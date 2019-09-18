using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingVertexAttribute
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.VertexAttribute> instance = space.DeclareEnum<UnityEngine.Rendering.VertexAttribute>();
			instance.SetValue("Position", (long)UnityEngine.Rendering.VertexAttribute.Position);
			instance.SetValue("Normal", (long)UnityEngine.Rendering.VertexAttribute.Normal);
			instance.SetValue("Tangent", (long)UnityEngine.Rendering.VertexAttribute.Tangent);
			instance.SetValue("Color", (long)UnityEngine.Rendering.VertexAttribute.Color);
			instance.SetValue("TexCoord0", (long)UnityEngine.Rendering.VertexAttribute.TexCoord0);
			instance.SetValue("TexCoord1", (long)UnityEngine.Rendering.VertexAttribute.TexCoord1);
			instance.SetValue("TexCoord2", (long)UnityEngine.Rendering.VertexAttribute.TexCoord2);
			instance.SetValue("TexCoord3", (long)UnityEngine.Rendering.VertexAttribute.TexCoord3);
			instance.SetValue("TexCoord4", (long)UnityEngine.Rendering.VertexAttribute.TexCoord4);
			instance.SetValue("TexCoord5", (long)UnityEngine.Rendering.VertexAttribute.TexCoord5);
			instance.SetValue("TexCoord6", (long)UnityEngine.Rendering.VertexAttribute.TexCoord6);
			instance.SetValue("TexCoord7", (long)UnityEngine.Rendering.VertexAttribute.TexCoord7);
			instance.SetValue("BlendWeight", (long)UnityEngine.Rendering.VertexAttribute.BlendWeight);
			instance.SetValue("BlendIndices", (long)UnityEngine.Rendering.VertexAttribute.BlendIndices);
		}
	}
}
