using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderTextureReadWrite
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.RenderTextureReadWrite> instance = space.DeclareEnum<UnityEngine.RenderTextureReadWrite>();
			instance.SetValue("Default", (long)UnityEngine.RenderTextureReadWrite.Default);
			instance.SetValue("Linear", (long)UnityEngine.RenderTextureReadWrite.Linear);
			instance.SetValue("sRGB", (long)UnityEngine.RenderTextureReadWrite.sRGB);
		}
	}
}
