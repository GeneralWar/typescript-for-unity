﻿using AOT;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Typescript
{
	static public partial class FileUtility
	{
		delegate string OnReadStringFromFile(string filename);

		static private List<string> sSearchPaths = new List<string>();

		static FileUtility()
		{

		}

		static internal void Initialize()
		{
			FileUtility.General_Typescript_Extension_BindReadStringFromFileCallback(FileUtility.ReadStringFromFile);
		}

		static public void AddSearchPath(string path, bool front = false)
		{
			int index = sSearchPaths.IndexOf(path);
			if (index > -1 && !front) return;

			if (front)
			{
				if (-1 != index)
				{
					sSearchPaths.RemoveAt(index);
				}
				sSearchPaths.Insert(0, path);
			}
			else
			{
				sSearchPaths.Add(path);
			}
		}

		static public void SetSearchPaths(IEnumerable<string> paths)
		{
			sSearchPaths = new List<string>(paths);
		}

		static public List<string> GetSearchPaths()
		{
			return new List<string>(sSearchPaths);
		}

		[MonoPInvokeCallback(typeof(OnReadStringFromFile))]
		static public string ReadStringFromFile(string filename)
		{
			try
			{
				return File.ReadAllText(FindFile(filename));
			}
			catch 
			{
				UnityEngine.Debug.LogError(string.Format("Cannot read string from file [{0}]!", filename));
			}
			return string.Empty;
		}

		[MonoPInvokeCallback(typeof(OnReadStringFromFile))]
		static public string FindFile(string filename)
		{
			if (Path.IsPathRooted(filename))
			{
				return filename;
			}
			foreach (string path in sSearchPaths)
			{
				string fullPath = Path.Combine(path, filename);
				if (File.Exists(fullPath))
				{
					return fullPath;
				}
			}
			return string.Empty;
		}
	}
}