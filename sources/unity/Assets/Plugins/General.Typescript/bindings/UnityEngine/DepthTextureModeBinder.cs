using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineDepthTextureMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.DepthTextureMode> instance = space.DeclareEnum<UnityEngine.DepthTextureMode>();
			instance.SetValue("None", (long)UnityEngine.DepthTextureMode.None);
			instance.SetValue("Depth", (long)UnityEngine.DepthTextureMode.Depth);
			instance.SetValue("DepthNormals", (long)UnityEngine.DepthTextureMode.DepthNormals);
			instance.SetValue("MotionVectors", (long)UnityEngine.DepthTextureMode.MotionVectors);
		}
	}
}
