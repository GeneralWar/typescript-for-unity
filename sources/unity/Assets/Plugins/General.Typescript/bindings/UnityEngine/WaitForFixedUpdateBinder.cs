using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWaitForFixedUpdate
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.WaitForFixedUpdate> self = space.DeclareClass<UnityEngine.WaitForFixedUpdate>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.WaitForFixedUpdate Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.WaitForFixedUpdate();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.WaitForFixedUpdate.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.WaitForFixedUpdate);
		}

	}
}
