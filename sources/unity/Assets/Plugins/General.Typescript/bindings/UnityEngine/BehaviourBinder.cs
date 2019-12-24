using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineBehaviour
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Behaviour> self = space.DeclareClass<UnityEngine.Behaviour, UnityEngine.Component>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("enabled", get_enabled, set_enabled);
			self.BindInstanceProperty("isActiveAndEnabled", get_isActiveAndEnabled, null);
		}

		static private UnityEngine.Behaviour Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Behaviour();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Behaviour.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Behaviour);
		}

		static private System.Boolean get_enabled(UnityEngine.Behaviour instance, string name)
		{
			return instance.enabled;
		}

		static private void set_enabled(UnityEngine.Behaviour instance, string name, System.Boolean value)
		{
			instance.enabled = value;
		}

		static private System.Boolean get_isActiveAndEnabled(UnityEngine.Behaviour instance, string name)
		{
			return instance.isActiveAndEnabled;
		}

	}
}
