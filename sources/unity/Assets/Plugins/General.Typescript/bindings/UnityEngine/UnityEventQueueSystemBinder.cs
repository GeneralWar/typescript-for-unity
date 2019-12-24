using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUnityEventQueueSystem
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UnityEventQueueSystem> self = space.DeclareClass<UnityEngine.UnityEventQueueSystem>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("GenerateEventIdForPayload", GenerateEventIdForPayload);
			self.BindStaticFunction("GetGlobalEventQueue", GetGlobalEventQueue);
		}

		static private UnityEngine.UnityEventQueueSystem Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.UnityEventQueueSystem();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UnityEventQueueSystem.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.UnityEventQueueSystem);
		}

		static private System.String GenerateEventIdForPayload(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.UnityEventQueueSystem.GenerateEventIdForPayload(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UnityEventQueueSystem.GenerateEventIdForPayload has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UnityEventQueueSystem.GenerateEventIdForPayload has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.IntPtr GetGlobalEventQueue(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.UnityEventQueueSystem.GetGlobalEventQueue();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UnityEventQueueSystem.GetGlobalEventQueue has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.IntPtr);
		}

	}
}
