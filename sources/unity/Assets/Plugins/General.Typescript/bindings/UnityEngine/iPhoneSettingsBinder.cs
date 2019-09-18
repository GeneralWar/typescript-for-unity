#if UNITY_IPHONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineiPhoneSettings
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.iPhoneSettings> self = space.DeclareClass<UnityEngine.iPhoneSettings>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.iPhoneSettings Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.iPhoneSettings();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.iPhoneSettings.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.iPhoneSettings);
		}

	}
}
#endif
