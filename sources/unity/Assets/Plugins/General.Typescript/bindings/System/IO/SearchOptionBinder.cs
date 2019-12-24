using UnityEngine;

namespace General.Typescript
{
	public class SystemIOSearchOption
	{
		static public void Bind(Namespace space)
		{
			Enum<System.IO.SearchOption> instance = space.DeclareEnum<System.IO.SearchOption>();
			instance.SetValue("TopDirectoryOnly", (long)System.IO.SearchOption.TopDirectoryOnly);
			instance.SetValue("AllDirectories", (long)System.IO.SearchOption.AllDirectories);
		}
	}
}
