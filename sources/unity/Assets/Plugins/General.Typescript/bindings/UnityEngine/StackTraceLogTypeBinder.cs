using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineStackTraceLogType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.StackTraceLogType> instance = space.DeclareEnum<UnityEngine.StackTraceLogType>();
			instance.SetValue("None", (long)UnityEngine.StackTraceLogType.None);
			instance.SetValue("ScriptOnly", (long)UnityEngine.StackTraceLogType.ScriptOnly);
			instance.SetValue("Full", (long)UnityEngine.StackTraceLogType.Full);
		}
	}
}
