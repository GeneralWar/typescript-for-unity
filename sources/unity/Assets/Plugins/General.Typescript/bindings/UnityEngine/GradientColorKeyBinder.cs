using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineGradientColorKey
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.GradientColorKey> self = space.DeclareClass<UnityEngine.GradientColorKey>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.GradientColorKey Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Color, System.Single>())
			{
				return new UnityEngine.GradientColorKey(parameters[0].ToObject<UnityEngine.Color>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GradientColorKey.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GradientColorKey.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.GradientColorKey);
		}

	}
}
