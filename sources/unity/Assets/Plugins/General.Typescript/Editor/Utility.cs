using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using UnityEditor;
using UnityEngine;
#if UNITY_STANDALONE_OSX
using System.Text.RegularExpressions;
#endif

namespace General.Typescript
{
	static public class Utility
	{
		public const string ROOT_PATH = "Assets/Plugins/General.Typescript/";
		public const string ASSETS_PATH = "Assets/Plugins/General.Typescript/assets.gzp";
		public static readonly string[] ASSETS_DIRECTORIES = { "Assets/Plugins/General.Typescript/core", "Assets/Plugins/General.Typescript/libs", "Assets/Plugins/General.Typescript/entries", "Assets/StreamingAssets/typescript", };
		public const string CONFIGURATION_PATH = "Assets/Plugins/General.Typescript/configs.asset";

		static public Rect GetScreenSize()
		{
#if UNITY_STANDALONE_OSX
            string result = Command("system_profiler SPDisplaysDataType | grep Resolution");
            Regex expression = new Regex(@"[0-9]+");
            MatchCollection matches = expression.Matches(result);
            if (2 == matches.Count)
            {
                int width = int.Parse(matches[0].Value);
                int height = int.Parse(matches[1].Value);
                return new Rect(0, 0, width, height);
            }
#endif
			return new Rect();
		}

		static public string Command(string command)
		{
			//UnityEngine.Debug.Log(command);
			ProcessStartInfo info = new ProcessStartInfo();
#if UNITY_STANDALONE_OSX
            info.FileName = "/bin/bash";
#endif
			//info.Arguments = command;
			info.UseShellExecute = false;
			info.RedirectStandardOutput = true;
			info.RedirectStandardInput = true;
			info.RedirectStandardError = true;
			info.CreateNoWindow = true;
			info.ErrorDialog = true;

			Process process = Process.Start(info);
			process.Start();

			process.StandardInput.WriteLine(command);
			process.StandardInput.WriteLine("exit");
			process.StandardInput.Flush();

			string result = process.StandardOutput.ReadToEnd();
			string error = process.StandardError.ReadToEnd();
			if (!string.IsNullOrWhiteSpace(error))
			{
				UnityEngine.Debug.LogError(error);
			}
			process.WaitForExit();
			return result;
		}

		static public string RelativePath(string from, string to)
		{
			int same = 0;
			string[] fromParts = from.Split('/', '\\');
			string[] toParts = to.Split('/', '\\');
			foreach (int i in Enumerable.Range(0, Math.Min(fromParts.Length, toParts.Length)))
			{
				if (fromParts[i] != toParts[i])
				{
					same = i;
					break;
				}
			}
			return Path.Combine(string.Join("/", Enumerable.Repeat<string>("..", fromParts.Length - same)), string.Join("/", toParts.Skip(same)));
		}

		static public bool Compile(string sourceDirectory, string compiledDirectory)
		{
			Directory.CreateDirectory("Assets/Resources/Scripts");
			foreach (string filename in Directory.GetFiles(compiledDirectory))
			{
				File.WriteAllBytes(Path.Combine("Assets/Resources/Scripts", Path.GetFileName(filename)), File.ReadAllBytes(Path.Combine(compiledDirectory, filename)));
			}
			//            UnityEngine.Debug.Log(sourceDirectory);
			//            UnityEngine.Debug.Log(compiledDirectory);
			//            string result = Command(string.Format("tsc {0} --outDir {1}", Path.Combine(sourceDirectory, "main.ts"), compiledDirectory));
			//            //string result = Command("./test.sh");
			//            //UnityEngine.Debug.Log(result);

			//            ProcessStartInfo info = new ProcessStartInfo();
			//#if UNITY_STANDALONE_OSX
			//            info.FileName = "/usr/local/lib/node_modules/typescript/bin/tsc";
			//#endif
			//info.Arguments = string.Format("{0} --outDir {1}", Path.Combine(System.Environment.CurrentDirectory, sourceDirectory, "main.ts"), Path.Combine(Environment.CurrentDirectory, compiledDirectory));
			//UnityEngine.Debug.Log(info.Arguments);
			//info.UseShellExecute = false;
			//info.WorkingDirectory = "/";
			//info.RedirectStandardOutput = true;
			////info.RedirectStandardInput = true;
			//info.RedirectStandardError = true;
			//info.CreateNoWindow = true;
			//info.ErrorDialog = true;

			//Process process = Process.Start(info);
			//process.ErrorDataReceived += Process_ErrorDataReceived;
			//process.Start();

			////process.StandardInput.WriteLine(command);
			////process.StandardInput.WriteLine("exit");
			////process.StandardInput.Flush();

			////string result = process.StandardOutput.ReadToEnd();
			//string error = process.StandardError.ReadToEnd();
			//if (!string.IsNullOrWhiteSpace(error))
			//{
			//    UnityEngine.Debug.LogError(error);
			//}
			//process.WaitForExit();
			//return result;

			return true;
		}

		static void Process_ErrorDataReceived(object sender, DataReceivedEventArgs e)
		{
			UnityEngine.Debug.LogError(e.Data);
		}

		static public string CheckPath(string path)
		{
			if (!Path.IsPathRooted(path))
			{
				path = Path.Combine(Environment.CurrentDirectory, path);
			}
			path = path.Replace("\\", "/");
			List<string> parts = new List<string>(path.Split('/'));
			parts.RemoveAll(p => p == ".");
			while (parts.Contains(".."))
			{
				int index = parts.IndexOf("..", 1);
				if (-1 == index)
				{
					break;
				}
				parts.RemoveRange(index - 1, 2);
			}
			return string.Join("/", parts);
		}

		static public void CreateDirectory(string directory)
		{
			directory = CheckPath(directory);
			if (!Directory.Exists(directory))
			{
				CreateDirectory(directory.Substring(0, directory.LastIndexOf("/")));
				Directory.CreateDirectory(directory);
			}
		}

		static public void DeleteDirectory(string directory, bool recursive = false)
		{
			if (Directory.Exists(directory))
			{
				Directory.Delete(directory, recursive);
			}
		}

		static public bool DirectoryContainsFiles(string directory)
		{
			if (!Directory.Exists(directory))
			{
				return false;
			}
			return Directory.EnumerateFiles(directory).Count() > 0;
		}

		static public void CreateConfigurationIfNotExists()
		{
			Configuration configuration = AssetDatabase.LoadAssetAtPath<Configuration>(Utility.CONFIGURATION_PATH);
			if (null == configuration)
			{
				configuration = ScriptableObject.CreateInstance<Configuration>();
				AssetDatabase.CreateAsset(configuration, Utility.CONFIGURATION_PATH);
			}
		}

		static public Configuration GetConfiguration()
		{
			return AssetDatabase.LoadAssetAtPath<Configuration>(Utility.CONFIGURATION_PATH);
		}
	}
}
