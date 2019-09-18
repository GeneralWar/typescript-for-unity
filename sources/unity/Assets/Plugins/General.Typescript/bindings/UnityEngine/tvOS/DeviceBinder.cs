#if UNITY_TVOS
using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginetvOSDevice
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.tvOS.Device> self = space.DeclareClass<UnityEngine.tvOS.Device>();
			self.BindConstructor(Constructor);
			self.BindStaticProperty("systemVersion", get_systemVersion, null);
			self.BindStaticProperty("generation", get_generation, null);
			self.BindStaticProperty("vendorIdentifier", get_vendorIdentifier, null);
			self.BindStaticProperty("advertisingIdentifier", get_advertisingIdentifier, null);
			self.BindStaticProperty("advertisingTrackingEnabled", get_advertisingTrackingEnabled, null);
		}

		static private UnityEngine.tvOS.Device Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.tvOS.Device();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.tvOS.Device.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.tvOS.Device);
		}

		static private System.String get_systemVersion()
		{
			return UnityEngine.tvOS.Device.systemVersion;
		}

		static private UnityEngine.tvOS.DeviceGeneration get_generation()
		{
			return UnityEngine.tvOS.Device.generation;
		}

		static private System.String get_vendorIdentifier()
		{
			return UnityEngine.tvOS.Device.vendorIdentifier;
		}

		static private System.String get_advertisingIdentifier()
		{
			return UnityEngine.tvOS.Device.advertisingIdentifier;
		}

		static private System.Boolean get_advertisingTrackingEnabled()
		{
			return UnityEngine.tvOS.Device.advertisingTrackingEnabled;
		}

	}
}
#endif
