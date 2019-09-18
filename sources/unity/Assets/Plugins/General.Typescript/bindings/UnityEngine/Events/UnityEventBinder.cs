using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineEventsUnityEvent
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Events.UnityEvent> self = space.DeclareClass<UnityEngine.Events.UnityEvent>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Invoke", Invoke);
		}

		static private UnityEngine.Events.UnityEvent Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Events.UnityEvent();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Events.UnityEvent.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Events.UnityEvent);
		}

		static private void Invoke(UnityEngine.Events.UnityEvent instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Invoke();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Events.UnityEvent.Invoke has no implemention with arguments ({0})!", string.Join(", ", types));
		}

	}
}
