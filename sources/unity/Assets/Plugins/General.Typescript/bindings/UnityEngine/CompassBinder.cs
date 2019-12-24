using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCompass
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Compass> self = space.DeclareClass<UnityEngine.Compass>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("magneticHeading", get_magneticHeading, null);
			self.BindInstanceProperty("trueHeading", get_trueHeading, null);
			self.BindInstanceProperty("headingAccuracy", get_headingAccuracy, null);
			self.BindInstanceProperty("rawVector", get_rawVector, null);
			self.BindInstanceProperty("timestamp", get_timestamp, null);
			self.BindInstanceProperty("enabled", get_enabled, set_enabled);
		}

		static private UnityEngine.Compass Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Compass();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Compass.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Compass);
		}

		static private System.Single get_magneticHeading(UnityEngine.Compass instance, string name)
		{
			return instance.magneticHeading;
		}

		static private System.Single get_trueHeading(UnityEngine.Compass instance, string name)
		{
			return instance.trueHeading;
		}

		static private System.Single get_headingAccuracy(UnityEngine.Compass instance, string name)
		{
			return instance.headingAccuracy;
		}

		static private UnityEngine.Vector3 get_rawVector(UnityEngine.Compass instance, string name)
		{
			return instance.rawVector;
		}

		static private System.Double get_timestamp(UnityEngine.Compass instance, string name)
		{
			return instance.timestamp;
		}

		static private System.Boolean get_enabled(UnityEngine.Compass instance, string name)
		{
			return instance.enabled;
		}

		static private void set_enabled(UnityEngine.Compass instance, string name, System.Boolean value)
		{
			instance.enabled = value;
		}

	}
}
