using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineYieldInstruction
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.YieldInstruction> self = space.DeclareClass<UnityEngine.YieldInstruction>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.YieldInstruction Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.YieldInstruction();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.YieldInstruction.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.YieldInstruction);
		}

	}
}
