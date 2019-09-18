using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineVRTextureUsage
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.VRTextureUsage> instance = space.DeclareEnum<UnityEngine.VRTextureUsage>();
			instance.SetValue("None", (long)UnityEngine.VRTextureUsage.None);
			instance.SetValue("OneEye", (long)UnityEngine.VRTextureUsage.OneEye);
			instance.SetValue("TwoEyes", (long)UnityEngine.VRTextureUsage.TwoEyes);
		}
	}
}
