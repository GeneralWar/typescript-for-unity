#if UNITY_ANDROID
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAndroidActivityIndicatorStyle
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.AndroidActivityIndicatorStyle> instance = space.DeclareEnum<UnityEngine.AndroidActivityIndicatorStyle>();
			instance.SetValue("Large", (long)UnityEngine.AndroidActivityIndicatorStyle.Large);
			instance.SetValue("InversedLarge", (long)UnityEngine.AndroidActivityIndicatorStyle.InversedLarge);
			instance.SetValue("Small", (long)UnityEngine.AndroidActivityIndicatorStyle.Small);
			instance.SetValue("InversedSmall", (long)UnityEngine.AndroidActivityIndicatorStyle.InversedSmall);
			instance.SetValue("DontShow", (long)UnityEngine.AndroidActivityIndicatorStyle.DontShow);
		}
	}
}
#endif
