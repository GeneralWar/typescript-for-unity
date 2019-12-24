using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderTextureMemoryless
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.RenderTextureMemoryless> instance = space.DeclareEnum<UnityEngine.RenderTextureMemoryless>();
			instance.SetValue("None", (long)UnityEngine.RenderTextureMemoryless.None);
			instance.SetValue("Color", (long)UnityEngine.RenderTextureMemoryless.Color);
			instance.SetValue("Depth", (long)UnityEngine.RenderTextureMemoryless.Depth);
			instance.SetValue("MSAA", (long)UnityEngine.RenderTextureMemoryless.MSAA);
		}
	}
}
