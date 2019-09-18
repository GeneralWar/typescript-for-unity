#if UNITY_ANDROID
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAndroidJavaException
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AndroidJavaException> self = space.DeclareClass<UnityEngine.AndroidJavaException>();
			self.BindConstructor();
			self.BindInstanceProperty("StackTrace", get_StackTrace, null);
		}

		static private System.String get_StackTrace(UnityEngine.AndroidJavaException instance)
		{
			return instance.StackTrace;
		}

	}
}
#endif
