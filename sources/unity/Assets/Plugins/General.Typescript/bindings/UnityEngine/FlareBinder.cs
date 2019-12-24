using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineFlare
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Flare> self = space.DeclareClass<UnityEngine.Flare, UnityEngine.Object>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.Flare Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Flare();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Flare.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Flare);
		}

	}
}
