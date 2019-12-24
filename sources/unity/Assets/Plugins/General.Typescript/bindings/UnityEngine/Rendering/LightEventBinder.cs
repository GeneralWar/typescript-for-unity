using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingLightEvent
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.LightEvent> instance = space.DeclareEnum<UnityEngine.Rendering.LightEvent>();
			instance.SetValue("BeforeShadowMap", (long)UnityEngine.Rendering.LightEvent.BeforeShadowMap);
			instance.SetValue("AfterShadowMap", (long)UnityEngine.Rendering.LightEvent.AfterShadowMap);
			instance.SetValue("BeforeScreenspaceMask", (long)UnityEngine.Rendering.LightEvent.BeforeScreenspaceMask);
			instance.SetValue("AfterScreenspaceMask", (long)UnityEngine.Rendering.LightEvent.AfterScreenspaceMask);
			instance.SetValue("BeforeShadowMapPass", (long)UnityEngine.Rendering.LightEvent.BeforeShadowMapPass);
			instance.SetValue("AfterShadowMapPass", (long)UnityEngine.Rendering.LightEvent.AfterShadowMapPass);
		}
	}
}
