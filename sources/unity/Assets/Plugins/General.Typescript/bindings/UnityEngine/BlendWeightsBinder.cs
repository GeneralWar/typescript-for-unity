using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineBlendWeights
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.BlendWeights> instance = space.DeclareEnum<UnityEngine.BlendWeights>();
			instance.SetValue("OneBone", (long)UnityEngine.BlendWeights.OneBone);
			instance.SetValue("TwoBones", (long)UnityEngine.BlendWeights.TwoBones);
			instance.SetValue("FourBones", (long)UnityEngine.BlendWeights.FourBones);
		}
	}
}
