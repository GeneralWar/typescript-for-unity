using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCollisionFlags
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.CollisionFlags> instance = space.DeclareEnum<UnityEngine.CollisionFlags>();
			instance.SetValue("None", (long)UnityEngine.CollisionFlags.None);
			instance.SetValue("Sides", (long)UnityEngine.CollisionFlags.Sides);
			instance.SetValue("CollidedSides", (long)UnityEngine.CollisionFlags.CollidedSides);
			instance.SetValue("Above", (long)UnityEngine.CollisionFlags.Above);
			instance.SetValue("CollidedAbove", (long)UnityEngine.CollisionFlags.CollidedAbove);
			instance.SetValue("Below", (long)UnityEngine.CollisionFlags.Below);
			instance.SetValue("CollidedBelow", (long)UnityEngine.CollisionFlags.CollidedBelow);
		}
	}
}
