using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingCullMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.CullMode> instance = space.DeclareEnum<UnityEngine.Rendering.CullMode>();
			instance.SetValue("Off", (long)UnityEngine.Rendering.CullMode.Off);
			instance.SetValue("Front", (long)UnityEngine.Rendering.CullMode.Front);
			instance.SetValue("Back", (long)UnityEngine.Rendering.CullMode.Back);
		}
	}
}
