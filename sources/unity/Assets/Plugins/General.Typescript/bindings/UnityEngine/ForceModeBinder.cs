using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineForceMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.ForceMode> instance = space.DeclareEnum<UnityEngine.ForceMode>();
			instance.SetValue("Force", (long)UnityEngine.ForceMode.Force);
			instance.SetValue("Impulse", (long)UnityEngine.ForceMode.Impulse);
			instance.SetValue("VelocityChange", (long)UnityEngine.ForceMode.VelocityChange);
			instance.SetValue("Acceleration", (long)UnityEngine.ForceMode.Acceleration);
		}
	}
}
