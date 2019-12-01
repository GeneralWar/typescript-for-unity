using System;
using System.Collections.Generic;

namespace General.Typescript
{
    internal partial class NamespaceBinder : BinderBase
    {
        static private SortedList<string, NamespaceBinder> sSpaces = new SortedList<string, NamespaceBinder>();

        static public IEnumerable<NamespaceBinder> Spaces { get { return sSpaces.Values; } }

		static internal void Clear()
		{
			sSpaces.Clear();
		}

        static internal NamespaceBinder GetNamespace(string name)
        {
            if (name.Contains("Experimental") || !name.Contains("UnityEngine"))
            {
                return null;
            }

            NamespaceBinder space = null;
            if (!sSpaces.TryGetValue(name, out space))
            {
                NamespaceBinder parent = null;
                if (name.Contains("."))
                {
                    parent = GetNamespace(name.Substring(0, name.LastIndexOf('.')));
                }
                space = new NamespaceBinder(name, parent);
            }
            return space;
        }
    }
}
