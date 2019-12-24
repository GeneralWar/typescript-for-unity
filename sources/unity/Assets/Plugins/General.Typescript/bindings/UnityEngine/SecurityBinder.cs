using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSecurity
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Security> self = space.DeclareClass<UnityEngine.Security>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.Security Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Security();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Security.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Security);
		}

	}
}
