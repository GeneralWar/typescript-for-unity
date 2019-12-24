using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCollisionDetectionMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.CollisionDetectionMode> instance = space.DeclareEnum<UnityEngine.CollisionDetectionMode>();
			instance.SetValue("Discrete", (long)UnityEngine.CollisionDetectionMode.Discrete);
			instance.SetValue("Continuous", (long)UnityEngine.CollisionDetectionMode.Continuous);
			instance.SetValue("ContinuousDynamic", (long)UnityEngine.CollisionDetectionMode.ContinuousDynamic);
			instance.SetValue("ContinuousSpeculative", (long)UnityEngine.CollisionDetectionMode.ContinuousSpeculative);
		}
	}
}
