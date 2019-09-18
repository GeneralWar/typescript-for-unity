using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCubemapFace
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.CubemapFace> instance = space.DeclareEnum<UnityEngine.CubemapFace>();
			instance.SetValue("PositiveX", (long)UnityEngine.CubemapFace.PositiveX);
			instance.SetValue("NegativeX", (long)UnityEngine.CubemapFace.NegativeX);
			instance.SetValue("PositiveY", (long)UnityEngine.CubemapFace.PositiveY);
			instance.SetValue("NegativeY", (long)UnityEngine.CubemapFace.NegativeY);
			instance.SetValue("PositiveZ", (long)UnityEngine.CubemapFace.PositiveZ);
			instance.SetValue("NegativeZ", (long)UnityEngine.CubemapFace.NegativeZ);
			instance.SetValue("Unknown", (long)UnityEngine.CubemapFace.Unknown);
		}
	}
}
