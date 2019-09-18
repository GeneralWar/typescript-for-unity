using General.Typescript;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using UnityEditor;
using UnityEngine;

public class PackTool
{
	[MenuItem("General/Typescript/Pack")]
	static private void Pack()
	{
		List<string> files = new List<string>();
		using (MemoryStream memory = new MemoryStream())
		{
			foreach (string directory in Utility.ASSETS_DIRECTORIES)
			{
				foreach (string filename in Directory.EnumerateFiles(directory, "*.*", SearchOption.AllDirectories))
				{
					if (filename.EndsWith(".meta"))
					{
						continue;
					}
					files.Add(filename);
					addFileToStream(memory, filename);
				}
			}

			using (FileStream file = File.OpenWrite(Utility.ASSETS_PATH))
			{
				using (GZipStream stream = new GZipStream(file, CompressionMode.Compress, false))
				{
					memory.Position = 0;
					memory.CopyTo(stream);
					stream.Flush();
					stream.Close();
				}
				file.Close();
			}

			memory.Close();
		}
	}

	static private void addFileToStream(Stream stream, string filename)
	{
		if (!filename.StartsWith("Assets"))
		{
			filename = filename.Substring(filename.IndexOf("Assets"));

		}
		using (FileStream fileStream = File.OpenRead(filename))
		{
			byte[] buffer = Encoding.UTF8.GetBytes(filename);
			stream.Write(BitConverter.GetBytes((ushort)buffer.Length), 0, sizeof(ushort));
			stream.Write(buffer, 0, buffer.Length);
			buffer = new byte[fileStream.Length];
			fileStream.Read(buffer, 0, buffer.Length);
			stream.Write(BitConverter.GetBytes(buffer.Length), 0, sizeof(int));
			stream.Write(buffer, 0, buffer.Length);
			fileStream.Close();
		}
	}

	[MenuItem("General/Typescript/Bind Custom Classes")]
	static private void bindCustomClasses()
	{
		List<Type> types = BinderGenerator.GetBindedTypes(false);
		types.AddRange(bindCustomClasses(typeof(Socket).Assembly, new string[] { "Socket", "IP" }));
		types.AddRange(bindCustomClasses(typeof(WebRequest).Assembly, new string[] { "Http", "Web", "Request", "Response" }, new string[] { "WebRequestModuleElementCollection", "HttpListenerTimeoutManager", "WebProxy" }));

		Debug.Log("Generate custom binders successfully!");
	}

	static private IEnumerable<Type> bindCustomClasses(Assembly assembly, string key)
	{
		Type[] types = Array.FindAll(assembly.GetTypes(), t => t.FullName.Contains(key));
		BinderGenerator.GenerateBinders(types);
		BinderGenerator.GenerateSnippets(types);
		return types;
	}

	static private IEnumerable<Type> bindCustomClasses(Assembly assembly, string[] keys, string[] excludes = null)
	{
		Type[] types = Array.FindAll(assembly.GetTypes(), t => (null == excludes ? true : !excludes.Any(e => t.FullName.Contains(e))) && keys.Any(key => t.FullName.Contains(key)));
		BinderGenerator.GenerateBinders(types);
		BinderGenerator.GenerateSnippets(types);
		return types;
	}

	[MenuItem("General/Typescript/Check Marshal")]
	static private void checkMarshal()
	{
		Debug.Log(typeof(UnityEngine.PrimitiveType).IsMarshalByRef);
		Debug.Log(typeof(int).IsMarshalByRef);
		Debug.Log(Marshal.SizeOf(typeof(int)));
	}
}
