using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingPath
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.RenderingPath> instance = space.DeclareEnum<UnityEngine.RenderingPath>();
			instance.SetValue("VertexLit", (long)UnityEngine.RenderingPath.VertexLit);
			instance.SetValue("Forward", (long)UnityEngine.RenderingPath.Forward);
			instance.SetValue("DeferredLighting", (long)UnityEngine.RenderingPath.DeferredLighting);
			instance.SetValue("DeferredShading", (long)UnityEngine.RenderingPath.DeferredShading);
			instance.SetValue("UsePlayerSettings", (long)UnityEngine.RenderingPath.UsePlayerSettings);
		}
	}
}
