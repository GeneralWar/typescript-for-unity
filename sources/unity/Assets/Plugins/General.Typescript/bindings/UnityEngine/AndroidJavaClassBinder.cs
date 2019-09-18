#if UNITY_ANDROID
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAndroidJavaClass
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AndroidJavaClass> self = space.DeclareClass<UnityEngine.AndroidJavaClass>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.AndroidJavaClass Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return new UnityEngine.AndroidJavaClass(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJavaClass.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJavaClass.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.AndroidJavaClass);
		}

	}
}
#endif
