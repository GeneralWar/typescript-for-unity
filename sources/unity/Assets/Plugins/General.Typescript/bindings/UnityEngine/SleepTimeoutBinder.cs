using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSleepTimeout
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.SleepTimeout> self = space.DeclareClass<UnityEngine.SleepTimeout>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.SleepTimeout Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.SleepTimeout();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.SleepTimeout.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.SleepTimeout);
		}

	}
}
