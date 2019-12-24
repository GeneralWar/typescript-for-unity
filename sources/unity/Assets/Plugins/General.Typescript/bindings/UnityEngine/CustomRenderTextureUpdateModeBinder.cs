using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCustomRenderTextureUpdateMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.CustomRenderTextureUpdateMode> instance = space.DeclareEnum<UnityEngine.CustomRenderTextureUpdateMode>();
			instance.SetValue("OnLoad", (long)UnityEngine.CustomRenderTextureUpdateMode.OnLoad);
			instance.SetValue("Realtime", (long)UnityEngine.CustomRenderTextureUpdateMode.Realtime);
			instance.SetValue("OnDemand", (long)UnityEngine.CustomRenderTextureUpdateMode.OnDemand);
		}
	}
}
