using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineGyroscope
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Gyroscope> self = space.DeclareClass<UnityEngine.Gyroscope>();
			self.BindConstructor();
			self.BindInstanceProperty("rotationRate", get_rotationRate, null);
			self.BindInstanceProperty("rotationRateUnbiased", get_rotationRateUnbiased, null);
			self.BindInstanceProperty("gravity", get_gravity, null);
			self.BindInstanceProperty("userAcceleration", get_userAcceleration, null);
			self.BindInstanceProperty("attitude", get_attitude, null);
			self.BindInstanceProperty("enabled", get_enabled, set_enabled);
			self.BindInstanceProperty("updateInterval", get_updateInterval, set_updateInterval);
		}

		static private UnityEngine.Vector3 get_rotationRate(UnityEngine.Gyroscope instance, string name)
		{
			return instance.rotationRate;
		}

		static private UnityEngine.Vector3 get_rotationRateUnbiased(UnityEngine.Gyroscope instance, string name)
		{
			return instance.rotationRateUnbiased;
		}

		static private UnityEngine.Vector3 get_gravity(UnityEngine.Gyroscope instance, string name)
		{
			return instance.gravity;
		}

		static private UnityEngine.Vector3 get_userAcceleration(UnityEngine.Gyroscope instance, string name)
		{
			return instance.userAcceleration;
		}

		static private UnityEngine.Quaternion get_attitude(UnityEngine.Gyroscope instance, string name)
		{
			return instance.attitude;
		}

		static private System.Boolean get_enabled(UnityEngine.Gyroscope instance, string name)
		{
			return instance.enabled;
		}

		static private void set_enabled(UnityEngine.Gyroscope instance, string name, System.Boolean value)
		{
			instance.enabled = value;
		}

		static private System.Single get_updateInterval(UnityEngine.Gyroscope instance, string name)
		{
			return instance.updateInterval;
		}

		static private void set_updateInterval(UnityEngine.Gyroscope instance, string name, System.Single value)
		{
			instance.updateInterval = value;
		}

	}
}
