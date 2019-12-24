using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAsyncOperation
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AsyncOperation> self = space.DeclareClass<UnityEngine.AsyncOperation>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("isDone", get_isDone, null);
			self.BindInstanceProperty("progress", get_progress, null);
			self.BindInstanceProperty("priority", get_priority, set_priority);
			self.BindInstanceProperty("allowSceneActivation", get_allowSceneActivation, set_allowSceneActivation);
		}

		static private UnityEngine.AsyncOperation Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.AsyncOperation();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AsyncOperation.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.AsyncOperation);
		}

		static private System.Boolean get_isDone(UnityEngine.AsyncOperation instance, string name)
		{
			return instance.isDone;
		}

		static private System.Single get_progress(UnityEngine.AsyncOperation instance, string name)
		{
			return instance.progress;
		}

		static private System.Int32 get_priority(UnityEngine.AsyncOperation instance, string name)
		{
			return instance.priority;
		}

		static private void set_priority(UnityEngine.AsyncOperation instance, string name, System.Int32 value)
		{
			instance.priority = value;
		}

		static private System.Boolean get_allowSceneActivation(UnityEngine.AsyncOperation instance, string name)
		{
			return instance.allowSceneActivation;
		}

		static private void set_allowSceneActivation(UnityEngine.AsyncOperation instance, string name, System.Boolean value)
		{
			instance.allowSceneActivation = value;
		}

	}
}
