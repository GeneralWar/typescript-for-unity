using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineEventsUnityEventCallState
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Events.UnityEventCallState> instance = space.DeclareEnum<UnityEngine.Events.UnityEventCallState>();
			instance.SetValue("Off", (long)UnityEngine.Events.UnityEventCallState.Off);
			instance.SetValue("EditorAndRuntime", (long)UnityEngine.Events.UnityEventCallState.EditorAndRuntime);
			instance.SetValue("RuntimeOnly", (long)UnityEngine.Events.UnityEventCallState.RuntimeOnly);
		}
	}
}
