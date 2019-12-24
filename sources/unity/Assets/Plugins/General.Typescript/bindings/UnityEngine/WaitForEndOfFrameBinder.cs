using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWaitForEndOfFrame
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.WaitForEndOfFrame> self = space.DeclareClass<UnityEngine.WaitForEndOfFrame>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.WaitForEndOfFrame Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.WaitForEndOfFrame();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.WaitForEndOfFrame.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.WaitForEndOfFrame);
		}

	}
}
