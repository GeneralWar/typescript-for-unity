using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingReflectionCubemapCompression
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.ReflectionCubemapCompression> instance = space.DeclareEnum<UnityEngine.Rendering.ReflectionCubemapCompression>();
			instance.SetValue("Uncompressed", (long)UnityEngine.Rendering.ReflectionCubemapCompression.Uncompressed);
			instance.SetValue("Compressed", (long)UnityEngine.Rendering.ReflectionCubemapCompression.Compressed);
			instance.SetValue("Auto", (long)UnityEngine.Rendering.ReflectionCubemapCompression.Auto);
		}
	}
}
