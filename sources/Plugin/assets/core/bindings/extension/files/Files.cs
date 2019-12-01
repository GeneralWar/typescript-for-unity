using AOT;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Typescript
{
	static public partial class Files
	{
		delegate string OnReadStringFromFile(string filename);

		static private List<string> sSearchPaths = new List<string>();

		static Files()
		{

		}

		static internal void Initialize()
		{
			Files.General_Typescript_Extension_BindReadStringFromFileCallback(Files.ReadStringFromFile);
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
		static private string ReadStringFromFile(string filename)
		{
			if (!Path.IsPathRooted(filename))
			{
				string absolutePath = string.Empty;
				foreach (string path in sSearchPaths)
				{
					string fullPath = Path.Combine(path, filename);
					if (File.Exists(fullPath))
					{
						absolutePath = fullPath;
						break;
					}
				}
				if (string.IsNullOrWhiteSpace(absolutePath))
				{
					return string.Empty;
				}
				filename = absolutePath;
			}
			try
			{
				return File.ReadAllText(filename);
			}
			catch (Exception e)
			{
				UnityEngine.Debug.LogException(e);
			}
			return string.Empty;
		}
	}
}
