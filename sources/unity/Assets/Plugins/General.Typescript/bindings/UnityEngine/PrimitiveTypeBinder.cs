using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePrimitiveType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.PrimitiveType> instance = space.DeclareEnum<UnityEngine.PrimitiveType>();
			instance.SetValue("Sphere", (long)UnityEngine.PrimitiveType.Sphere);
			instance.SetValue("Capsule", (long)UnityEngine.PrimitiveType.Capsule);
			instance.SetValue("Cylinder", (long)UnityEngine.PrimitiveType.Cylinder);
			instance.SetValue("Cube", (long)UnityEngine.PrimitiveType.Cube);
			instance.SetValue("Plane", (long)UnityEngine.PrimitiveType.Plane);
			instance.SetValue("Quad", (long)UnityEngine.PrimitiveType.Quad);
		}
	}
}
