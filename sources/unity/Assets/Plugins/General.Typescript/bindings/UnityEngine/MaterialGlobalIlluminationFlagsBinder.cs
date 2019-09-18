using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMaterialGlobalIlluminationFlags
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.MaterialGlobalIlluminationFlags> instance = space.DeclareEnum<UnityEngine.MaterialGlobalIlluminationFlags>();
			instance.SetValue("None", (long)UnityEngine.MaterialGlobalIlluminationFlags.None);
			instance.SetValue("RealtimeEmissive", (long)UnityEngine.MaterialGlobalIlluminationFlags.RealtimeEmissive);
			instance.SetValue("BakedEmissive", (long)UnityEngine.MaterialGlobalIlluminationFlags.BakedEmissive);
			instance.SetValue("AnyEmissive", (long)UnityEngine.MaterialGlobalIlluminationFlags.AnyEmissive);
			instance.SetValue("EmissiveIsBlack", (long)UnityEngine.MaterialGlobalIlluminationFlags.EmissiveIsBlack);
		}
	}
}
