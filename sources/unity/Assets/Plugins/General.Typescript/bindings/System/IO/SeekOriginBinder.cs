using UnityEngine;

namespace General.Typescript
{
	public class SystemIOSeekOrigin
	{
		static public void Bind(Namespace space)
		{
			Enum<System.IO.SeekOrigin> instance = space.DeclareEnum<System.IO.SeekOrigin>();
			instance.SetValue("Begin", (long)System.IO.SeekOrigin.Begin);
			instance.SetValue("Current", (long)System.IO.SeekOrigin.Current);
			instance.SetValue("End", (long)System.IO.SeekOrigin.End);
		}
	}
}
