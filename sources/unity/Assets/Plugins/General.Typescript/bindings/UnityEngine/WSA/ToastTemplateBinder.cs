#if UNITY_WSA
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWSAToastTemplate
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.WSA.ToastTemplate> instance = space.DeclareEnum<UnityEngine.WSA.ToastTemplate>();
			instance.SetValue("ToastImageAndText01", (long)UnityEngine.WSA.ToastTemplate.ToastImageAndText01);
			instance.SetValue("ToastImageAndText02", (long)UnityEngine.WSA.ToastTemplate.ToastImageAndText02);
			instance.SetValue("ToastImageAndText03", (long)UnityEngine.WSA.ToastTemplate.ToastImageAndText03);
			instance.SetValue("ToastImageAndText04", (long)UnityEngine.WSA.ToastTemplate.ToastImageAndText04);
			instance.SetValue("ToastText01", (long)UnityEngine.WSA.ToastTemplate.ToastText01);
			instance.SetValue("ToastText02", (long)UnityEngine.WSA.ToastTemplate.ToastText02);
			instance.SetValue("ToastText03", (long)UnityEngine.WSA.ToastTemplate.ToastText03);
			instance.SetValue("ToastText04", (long)UnityEngine.WSA.ToastTemplate.ToastText04);
		}
	}
}
#endif
