using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineOcclusionPortal
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.OcclusionPortal> self = space.DeclareClass<UnityEngine.OcclusionPortal, UnityEngine.Component>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("open", get_open, set_open);
		}

		static private UnityEngine.OcclusionPortal Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.OcclusionPortal();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.OcclusionPortal.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.OcclusionPortal);
		}

		static private System.Boolean get_open(UnityEngine.OcclusionPortal instance, string name)
		{
			return instance.open;
		}

		static private void set_open(UnityEngine.OcclusionPortal instance, string name, System.Boolean value)
		{
			instance.open = value;
		}

	}
}
