using System;
using System.IO;
using UnityEngine;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

namespace General.Typescript
{
    internal abstract partial class BinderBase
    {
        static private string sBinderOutputPath = Utility.CheckPath(Path.Combine(Environment.CurrentDirectory, "Assets/Scripts/General.Typescript/bindings/"));

        static internal void SetBinderOutputPath(string path)
        {
			if (string.IsNullOrWhiteSpace(path))
			{
				return;
			}
            sBinderOutputPath = Utility.CheckPath(Path.IsPathRooted(path) ? path : Path.Combine(Environment.CurrentDirectory, path));
        }

        static private string sLibraryOutputPath = Utility.CheckPath(Path.Combine(Environment.CurrentDirectory, "../../project/library/"));

        static internal void SetLibraryOutputPath(string path)
		{
			if (string.IsNullOrWhiteSpace(path))
			{
				return;
			}
			sLibraryOutputPath = Utility.CheckPath(Path.IsPathRooted(path) ? path : Path.Combine(Environment.CurrentDirectory, path));
        }
    }
}
