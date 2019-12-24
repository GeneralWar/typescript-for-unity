using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineFixedJoint
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.FixedJoint> self = space.DeclareClass<UnityEngine.FixedJoint, UnityEngine.Joint>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.FixedJoint Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.FixedJoint();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.FixedJoint.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.FixedJoint);
		}

	}
}
