using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLogType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.LogType> instance = space.DeclareEnum<UnityEngine.LogType>();
			instance.SetValue("Error", (long)UnityEngine.LogType.Error);
			instance.SetValue("Assert", (long)UnityEngine.LogType.Assert);
			instance.SetValue("Warning", (long)UnityEngine.LogType.Warning);
			instance.SetValue("Log", (long)UnityEngine.LogType.Log);
			instance.SetValue("Exception", (long)UnityEngine.LogType.Exception);
		}
	}
}
