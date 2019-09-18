using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineGradientAlphaKey
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.GradientAlphaKey> self = space.DeclareClass<UnityEngine.GradientAlphaKey>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.GradientAlphaKey Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return new UnityEngine.GradientAlphaKey(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GradientAlphaKey.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GradientAlphaKey.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.GradientAlphaKey);
		}

	}
}
