using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineConfigurableJointMotion
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.ConfigurableJointMotion> instance = space.DeclareEnum<UnityEngine.ConfigurableJointMotion>();
			instance.SetValue("Locked", (long)UnityEngine.ConfigurableJointMotion.Locked);
			instance.SetValue("Limited", (long)UnityEngine.ConfigurableJointMotion.Limited);
			instance.SetValue("Free", (long)UnityEngine.ConfigurableJointMotion.Free);
		}
	}
}
