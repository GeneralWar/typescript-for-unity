using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineThreadPriority
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.ThreadPriority> instance = space.DeclareEnum<UnityEngine.ThreadPriority>();
			instance.SetValue("Low", (long)UnityEngine.ThreadPriority.Low);
			instance.SetValue("BelowNormal", (long)UnityEngine.ThreadPriority.BelowNormal);
			instance.SetValue("Normal", (long)UnityEngine.ThreadPriority.Normal);
			instance.SetValue("High", (long)UnityEngine.ThreadPriority.High);
		}
	}
}
