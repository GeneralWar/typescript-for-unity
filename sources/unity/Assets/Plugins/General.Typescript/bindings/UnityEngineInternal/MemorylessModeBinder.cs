using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineInternalMemorylessMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngineInternal.MemorylessMode> instance = space.DeclareEnum<UnityEngineInternal.MemorylessMode>();
			instance.SetValue("Unused", (long)UnityEngineInternal.MemorylessMode.Unused);
			instance.SetValue("Forced", (long)UnityEngineInternal.MemorylessMode.Forced);
			instance.SetValue("Automatic", (long)UnityEngineInternal.MemorylessMode.Automatic);
		}
	}
}
