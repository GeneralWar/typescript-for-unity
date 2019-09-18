#if UNITY_IPHONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineiOSDevice
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.iOS.Device> self = space.DeclareClass<UnityEngine.iOS.Device>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("RequestStoreReview", RequestStoreReview);
			self.BindStaticProperty("systemVersion", get_systemVersion, null);
			self.BindStaticProperty("generation", get_generation, null);
			self.BindStaticProperty("vendorIdentifier", get_vendorIdentifier, null);
			self.BindStaticProperty("advertisingIdentifier", get_advertisingIdentifier, null);
			self.BindStaticProperty("advertisingTrackingEnabled", get_advertisingTrackingEnabled, null);
			self.BindStaticProperty("hideHomeButton", get_hideHomeButton, set_hideHomeButton);
			self.BindStaticProperty("deferSystemGesturesMode", get_deferSystemGesturesMode, set_deferSystemGesturesMode);
		}

		static private UnityEngine.iOS.Device Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.iOS.Device();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.iOS.Device.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.iOS.Device);
		}

		static private System.Boolean RequestStoreReview(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.iOS.Device.RequestStoreReview();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.iOS.Device.RequestStoreReview has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.String get_systemVersion()
		{
			return UnityEngine.iOS.Device.systemVersion;
		}

		static private UnityEngine.iOS.DeviceGeneration get_generation()
		{
			return UnityEngine.iOS.Device.generation;
		}

		static private System.String get_vendorIdentifier()
		{
			return UnityEngine.iOS.Device.vendorIdentifier;
		}

		static private System.String get_advertisingIdentifier()
		{
			return UnityEngine.iOS.Device.advertisingIdentifier;
		}

		static private System.Boolean get_advertisingTrackingEnabled()
		{
			return UnityEngine.iOS.Device.advertisingTrackingEnabled;
		}

		static private System.Boolean get_hideHomeButton()
		{
			return UnityEngine.iOS.Device.hideHomeButton;
		}

		static private void set_hideHomeButton(System.Boolean value)
		{
			UnityEngine.iOS.Device.hideHomeButton = value;
		}

		static private UnityEngine.iOS.SystemGestureDeferMode get_deferSystemGesturesMode()
		{
			return UnityEngine.iOS.Device.deferSystemGesturesMode;
		}

		static private void set_deferSystemGesturesMode(UnityEngine.iOS.SystemGestureDeferMode value)
		{
			UnityEngine.iOS.Device.deferSystemGesturesMode = value;
		}

	}
}
#endif
