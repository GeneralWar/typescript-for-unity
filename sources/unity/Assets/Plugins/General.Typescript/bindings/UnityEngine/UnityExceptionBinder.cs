using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUnityException
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UnityException> self = space.DeclareClass<UnityEngine.UnityException>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.UnityException Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.UnityException();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return new UnityEngine.UnityException(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Exception>())
			{
				return new UnityEngine.UnityException(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Exception>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UnityException.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.UnityException);
		}

	}
}
