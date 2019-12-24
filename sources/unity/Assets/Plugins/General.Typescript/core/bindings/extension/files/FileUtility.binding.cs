using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace General.Typescript
{
	static public partial class FileUtility
	{
		[DllImport(Entry.LIBRARY_NAME)]
		static private extern void General_Typescript_Extension_BindReadStringFromFileCallback(OnReadStringFromFile callback);
	}
}
