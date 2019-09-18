using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRigidbodyInterpolation
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.RigidbodyInterpolation> instance = space.DeclareEnum<UnityEngine.RigidbodyInterpolation>();
			instance.SetValue("None", (long)UnityEngine.RigidbodyInterpolation.None);
			instance.SetValue("Interpolate", (long)UnityEngine.RigidbodyInterpolation.Interpolate);
			instance.SetValue("Extrapolate", (long)UnityEngine.RigidbodyInterpolation.Extrapolate);
		}
	}
}
