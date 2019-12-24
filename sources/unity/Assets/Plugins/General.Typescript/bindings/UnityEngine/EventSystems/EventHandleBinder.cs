using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineEventSystemsEventHandle
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.EventSystems.EventHandle> instance = space.DeclareEnum<UnityEngine.EventSystems.EventHandle>();
			instance.SetValue("Unused", (long)UnityEngine.EventSystems.EventHandle.Unused);
			instance.SetValue("Used", (long)UnityEngine.EventSystems.EventHandle.Used);
		}
	}
}
