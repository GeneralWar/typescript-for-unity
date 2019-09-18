using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingCopyTextureSupport
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.CopyTextureSupport> instance = space.DeclareEnum<UnityEngine.Rendering.CopyTextureSupport>();
			instance.SetValue("None", (long)UnityEngine.Rendering.CopyTextureSupport.None);
			instance.SetValue("Basic", (long)UnityEngine.Rendering.CopyTextureSupport.Basic);
			instance.SetValue("Copy3D", (long)UnityEngine.Rendering.CopyTextureSupport.Copy3D);
			instance.SetValue("DifferentTypes", (long)UnityEngine.Rendering.CopyTextureSupport.DifferentTypes);
			instance.SetValue("TextureToRT", (long)UnityEngine.Rendering.CopyTextureSupport.TextureToRT);
			instance.SetValue("RTToTexture", (long)UnityEngine.Rendering.CopyTextureSupport.RTToTexture);
		}
	}
}
