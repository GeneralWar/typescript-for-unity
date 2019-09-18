using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlayerPrefsException
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.PlayerPrefsException> self = space.DeclareClass<UnityEngine.PlayerPrefsException>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.PlayerPrefsException Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return new UnityEngine.PlayerPrefsException(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.PlayerPrefsException.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.PlayerPrefsException.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.PlayerPrefsException);
		}

	}
}
