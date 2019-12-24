using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingPassType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.PassType> instance = space.DeclareEnum<UnityEngine.Rendering.PassType>();
			instance.SetValue("Normal", (long)UnityEngine.Rendering.PassType.Normal);
			instance.SetValue("Vertex", (long)UnityEngine.Rendering.PassType.Vertex);
			instance.SetValue("VertexLM", (long)UnityEngine.Rendering.PassType.VertexLM);
			instance.SetValue("ForwardBase", (long)UnityEngine.Rendering.PassType.ForwardBase);
			instance.SetValue("ForwardAdd", (long)UnityEngine.Rendering.PassType.ForwardAdd);
			instance.SetValue("LightPrePassBase", (long)UnityEngine.Rendering.PassType.LightPrePassBase);
			instance.SetValue("LightPrePassFinal", (long)UnityEngine.Rendering.PassType.LightPrePassFinal);
			instance.SetValue("ShadowCaster", (long)UnityEngine.Rendering.PassType.ShadowCaster);
			instance.SetValue("Deferred", (long)UnityEngine.Rendering.PassType.Deferred);
			instance.SetValue("Meta", (long)UnityEngine.Rendering.PassType.Meta);
			instance.SetValue("MotionVectors", (long)UnityEngine.Rendering.PassType.MotionVectors);
			instance.SetValue("ScriptableRenderPipeline", (long)UnityEngine.Rendering.PassType.ScriptableRenderPipeline);
			instance.SetValue("ScriptableRenderPipelineDefaultUnlit", (long)UnityEngine.Rendering.PassType.ScriptableRenderPipelineDefaultUnlit);
		}
	}
}
