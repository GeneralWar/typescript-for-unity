using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace General.Typescript
{
	static public class ExtensionModule
	{
		static private bool sInitialized = false;

		static public void Initialize()
		{
			if (!sInitialized)
			{
				FileUtility.Initialize();
				sInitialized = true;
			}
		}
	}
}
