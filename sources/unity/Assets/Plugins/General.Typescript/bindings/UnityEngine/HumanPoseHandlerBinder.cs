using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineHumanPoseHandler
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.HumanPoseHandler> self = space.DeclareClass<UnityEngine.HumanPoseHandler>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Dispose", Dispose);
		}

		static private UnityEngine.HumanPoseHandler Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Avatar, UnityEngine.Transform>())
			{
				return new UnityEngine.HumanPoseHandler(parameters[0].ToObject<UnityEngine.Avatar>(), parameters[1].ToObject<UnityEngine.Transform>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.HumanPoseHandler.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.HumanPoseHandler.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.HumanPoseHandler);
		}

		static private void Dispose(UnityEngine.HumanPoseHandler instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Dispose();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.HumanPoseHandler.Dispose has no implemention with arguments ({0})!", string.Join(", ", types));
		}

	}
}
