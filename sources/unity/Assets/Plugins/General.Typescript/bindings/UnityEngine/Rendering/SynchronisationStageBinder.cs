using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingSynchronisationStage
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.SynchronisationStage> instance = space.DeclareEnum<UnityEngine.Rendering.SynchronisationStage>();
			instance.SetValue("VertexProcessing", (long)UnityEngine.Rendering.SynchronisationStage.VertexProcessing);
			instance.SetValue("PixelProcessing", (long)UnityEngine.Rendering.SynchronisationStage.PixelProcessing);
		}
	}
}
