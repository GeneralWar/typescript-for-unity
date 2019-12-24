using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineResolution
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Resolution> self = space.DeclareClass<UnityEngine.Resolution>();
			self.BindConstructor();
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("width", get_width, set_width);
			self.BindInstanceProperty("height", get_height, set_height);
			self.BindInstanceProperty("refreshRate", get_refreshRate, set_refreshRate);
		}

		static private System.String ToString(UnityEngine.Resolution instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Resolution.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Int32 get_width(UnityEngine.Resolution instance, string name)
		{
			return instance.width;
		}

		static private void set_width(UnityEngine.Resolution instance, string name, System.Int32 value)
		{
			instance.width = value;
		}

		static private System.Int32 get_height(UnityEngine.Resolution instance, string name)
		{
			return instance.height;
		}

		static private void set_height(UnityEngine.Resolution instance, string name, System.Int32 value)
		{
			instance.height = value;
		}

		static private System.Int32 get_refreshRate(UnityEngine.Resolution instance, string name)
		{
			return instance.refreshRate;
		}

		static private void set_refreshRate(UnityEngine.Resolution instance, string name, System.Int32 value)
		{
			instance.refreshRate = value;
		}

	}
}
