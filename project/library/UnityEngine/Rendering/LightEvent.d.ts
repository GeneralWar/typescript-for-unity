declare namespace UnityEngine
{
	declare namespace Rendering
	{
		export enum LightEvent
		{
			BeforeShadowMap = 0,
			AfterShadowMap = 1,
			BeforeScreenspaceMask = 2,
			AfterScreenspaceMask = 3,
			BeforeShadowMapPass = 4,
			AfterShadowMapPass = 5,
		}
	}
}
