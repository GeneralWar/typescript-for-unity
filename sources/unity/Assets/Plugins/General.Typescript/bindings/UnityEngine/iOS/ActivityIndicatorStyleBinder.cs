#if UNITY_IPHONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineiOSActivityIndicatorStyle
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.iOS.ActivityIndicatorStyle> instance = space.DeclareEnum<UnityEngine.iOS.ActivityIndicatorStyle>();
			instance.SetValue("WhiteLarge", (long)UnityEngine.iOS.ActivityIndicatorStyle.WhiteLarge);
			instance.SetValue("White", (long)UnityEngine.iOS.ActivityIndicatorStyle.White);
			instance.SetValue("Gray", (long)UnityEngine.iOS.ActivityIndicatorStyle.Gray);
			instance.SetValue("DontShow", (long)UnityEngine.iOS.ActivityIndicatorStyle.DontShow);
		}
	}
}
#endif
