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
        static private string sBinderOutputPath = Utility.CheckPath(Path.Combine(Environment.CurrentDirectory, "Assets/Plugins/General.Typescript/bindings/"));

        static internal void SetBinderOutputPath(string output)
        {
            sBinderOutputPath = Utility.CheckPath(Path.IsPathRooted(output) ? output : Path.Combine(Environment.CurrentDirectory, output));
        }

        static private string sLibraryOutputPath = Utility.CheckPath(Path.Combine(Environment.CurrentDirectory, "../../project/library/"));

        static internal void SetLibraryOutputPath(string output)
        {
            sLibraryOutputPath = Utility.CheckPath(Path.IsPathRooted(output) ? output : Path.Combine(Environment.CurrentDirectory, output));
        }
    }
}
