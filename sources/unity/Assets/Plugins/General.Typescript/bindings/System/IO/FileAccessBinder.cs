using UnityEngine;

namespace General.Typescript
{
	public class SystemIOFileAccess
	{
		static public void Bind(Namespace space)
		{
			Enum<System.IO.FileAccess> instance = space.DeclareEnum<System.IO.FileAccess>();
			instance.SetValue("Read", (long)System.IO.FileAccess.Read);
			instance.SetValue("Write", (long)System.IO.FileAccess.Write);
			instance.SetValue("ReadWrite", (long)System.IO.FileAccess.ReadWrite);
		}
	}
}
