using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineInput
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Input> self = space.DeclareClass<UnityEngine.Input>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("GetAccelerationEvent", GetAccelerationEvent);
			self.BindStaticFunction("GetAxis", GetAxis);
			self.BindStaticFunction("GetAxisRaw", GetAxisRaw);
			self.BindStaticFunction("GetButton", GetButton);
			self.BindStaticFunction("GetButtonDown", GetButtonDown);
			self.BindStaticFunction("GetButtonUp", GetButtonUp);
			self.BindStaticFunction("GetJoystickNames", GetJoystickNames);
			self.BindStaticFunction("GetKey", GetKey);
			self.BindStaticFunction("GetKeyDown", GetKeyDown);
			self.BindStaticFunction("GetKeyUp", GetKeyUp);
			self.BindStaticFunction("GetMouseButton", GetMouseButton);
			self.BindStaticFunction("GetMouseButtonDown", GetMouseButtonDown);
			self.BindStaticFunction("GetMouseButtonUp", GetMouseButtonUp);
			self.BindStaticFunction("GetTouch", GetTouch);
			self.BindStaticFunction("ResetInputAxes", ResetInputAxes);
			self.BindStaticProperty("simulateMouseWithTouches", get_simulateMouseWithTouches, set_simulateMouseWithTouches);
			self.BindStaticProperty("gyro", get_gyro, null);
			self.BindStaticProperty("compass", get_compass, null);
			self.BindStaticProperty("location", get_location, null);
			self.BindStaticProperty("backButtonLeavesApp", get_backButtonLeavesApp, set_backButtonLeavesApp);
			self.BindStaticProperty("accelerationEventCount", get_accelerationEventCount, null);
			self.BindStaticProperty("compensateSensors", get_compensateSensors, set_compensateSensors);
			self.BindStaticProperty("acceleration", get_acceleration, null);
			self.BindStaticProperty("deviceOrientation", get_deviceOrientation, null);
			self.BindStaticProperty("multiTouchEnabled", get_multiTouchEnabled, set_multiTouchEnabled);
			self.BindStaticProperty("touchSupported", get_touchSupported, null);
			self.BindStaticProperty("stylusTouchSupported", get_stylusTouchSupported, null);
			self.BindStaticProperty("touchPressureSupported", get_touchPressureSupported, null);
			self.BindStaticProperty("touchCount", get_touchCount, null);
			self.BindStaticProperty("mousePresent", get_mousePresent, null);
			self.BindStaticProperty("compositionCursorPos", get_compositionCursorPos, set_compositionCursorPos);
			self.BindStaticProperty("imeIsSelected", get_imeIsSelected, null);
			self.BindStaticProperty("compositionString", get_compositionString, null);
			self.BindStaticProperty("imeCompositionMode", get_imeCompositionMode, set_imeCompositionMode);
			self.BindStaticProperty("mouseScrollDelta", get_mouseScrollDelta, null);
			self.BindStaticProperty("mousePosition", get_mousePosition, null);
			self.BindStaticProperty("inputString", get_inputString, null);
			self.BindStaticProperty("anyKeyDown", get_anyKeyDown, null);
			self.BindStaticProperty("anyKey", get_anyKey, null);
			self.BindStaticProperty("touches", get_touches, null);
			self.BindStaticProperty("accelerationEvents", get_accelerationEvents, null);
		}

		static private UnityEngine.Input Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Input();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Input.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Input);
		}

		static private UnityEngine.AccelerationEvent GetAccelerationEvent(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Input.GetAccelerationEvent(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Input.GetAccelerationEvent has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Input.GetAccelerationEvent has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.AccelerationEvent);
		}

		static private System.Single GetAxis(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Input.GetAxis(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Input.GetAxis has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Input.GetAxis has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single GetAxisRaw(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Input.GetAxisRaw(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Input.GetAxisRaw has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Input.GetAxisRaw has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Boolean GetButton(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Input.GetButton(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Input.GetButton has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Input.GetButton has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean GetButtonDown(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Input.GetButtonDown(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Input.GetButtonDown has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Input.GetButtonDown has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean GetButtonUp(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Input.GetButtonUp(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Input.GetButtonUp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Input.GetButtonUp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.String[] GetJoystickNames(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.Input.GetJoystickNames();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Input.GetJoystickNames has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Boolean GetKey(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.KeyCode>())
			{
				return UnityEngine.Input.GetKey(parameters[0].ToObject<UnityEngine.KeyCode>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Input.GetKey(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Input.GetKey has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Input.GetKey has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean GetKeyDown(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.KeyCode>())
			{
				return UnityEngine.Input.GetKeyDown(parameters[0].ToObject<UnityEngine.KeyCode>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Input.GetKeyDown(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Input.GetKeyDown has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Input.GetKeyDown has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean GetKeyUp(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.KeyCode>())
			{
				return UnityEngine.Input.GetKeyUp(parameters[0].ToObject<UnityEngine.KeyCode>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Input.GetKeyUp(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Input.GetKeyUp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Input.GetKeyUp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean GetMouseButton(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Input.GetMouseButton(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Input.GetMouseButton has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Input.GetMouseButton has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean GetMouseButtonDown(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Input.GetMouseButtonDown(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Input.GetMouseButtonDown has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Input.GetMouseButtonDown has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean GetMouseButtonUp(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Input.GetMouseButtonUp(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Input.GetMouseButtonUp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Input.GetMouseButtonUp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.Touch GetTouch(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Input.GetTouch(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Input.GetTouch has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Input.GetTouch has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Touch);
		}

		static private void ResetInputAxes(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.Input.ResetInputAxes();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Input.ResetInputAxes has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean get_simulateMouseWithTouches()
		{
			return UnityEngine.Input.simulateMouseWithTouches;
		}

		static private void set_simulateMouseWithTouches(System.Boolean value)
		{
			UnityEngine.Input.simulateMouseWithTouches = value;
		}

		static private UnityEngine.Gyroscope get_gyro()
		{
			return UnityEngine.Input.gyro;
		}

		static private UnityEngine.Compass get_compass()
		{
			return UnityEngine.Input.compass;
		}

		static private UnityEngine.LocationService get_location()
		{
			return UnityEngine.Input.location;
		}

		static private System.Boolean get_backButtonLeavesApp()
		{
			return UnityEngine.Input.backButtonLeavesApp;
		}

		static private void set_backButtonLeavesApp(System.Boolean value)
		{
			UnityEngine.Input.backButtonLeavesApp = value;
		}

		static private System.Int32 get_accelerationEventCount()
		{
			return UnityEngine.Input.accelerationEventCount;
		}

		static private System.Boolean get_compensateSensors()
		{
			return UnityEngine.Input.compensateSensors;
		}

		static private void set_compensateSensors(System.Boolean value)
		{
			UnityEngine.Input.compensateSensors = value;
		}

		static private UnityEngine.Vector3 get_acceleration()
		{
			return UnityEngine.Input.acceleration;
		}

		static private UnityEngine.DeviceOrientation get_deviceOrientation()
		{
			return UnityEngine.Input.deviceOrientation;
		}

		static private System.Boolean get_multiTouchEnabled()
		{
			return UnityEngine.Input.multiTouchEnabled;
		}

		static private void set_multiTouchEnabled(System.Boolean value)
		{
			UnityEngine.Input.multiTouchEnabled = value;
		}

		static private System.Boolean get_touchSupported()
		{
			return UnityEngine.Input.touchSupported;
		}

		static private System.Boolean get_stylusTouchSupported()
		{
			return UnityEngine.Input.stylusTouchSupported;
		}

		static private System.Boolean get_touchPressureSupported()
		{
			return UnityEngine.Input.touchPressureSupported;
		}

		static private System.Int32 get_touchCount()
		{
			return UnityEngine.Input.touchCount;
		}

		static private System.Boolean get_mousePresent()
		{
			return UnityEngine.Input.mousePresent;
		}

		static private UnityEngine.Vector2 get_compositionCursorPos()
		{
			return UnityEngine.Input.compositionCursorPos;
		}

		static private void set_compositionCursorPos(UnityEngine.Vector2 value)
		{
			UnityEngine.Input.compositionCursorPos = value;
		}

		static private System.Boolean get_imeIsSelected()
		{
			return UnityEngine.Input.imeIsSelected;
		}

		static private System.String get_compositionString()
		{
			return UnityEngine.Input.compositionString;
		}

		static private UnityEngine.IMECompositionMode get_imeCompositionMode()
		{
			return UnityEngine.Input.imeCompositionMode;
		}

		static private void set_imeCompositionMode(UnityEngine.IMECompositionMode value)
		{
			UnityEngine.Input.imeCompositionMode = value;
		}

		static private UnityEngine.Vector2 get_mouseScrollDelta()
		{
			return UnityEngine.Input.mouseScrollDelta;
		}

		static private UnityEngine.Vector3 get_mousePosition()
		{
			return UnityEngine.Input.mousePosition;
		}

		static private System.String get_inputString()
		{
			return UnityEngine.Input.inputString;
		}

		static private System.Boolean get_anyKeyDown()
		{
			return UnityEngine.Input.anyKeyDown;
		}

		static private System.Boolean get_anyKey()
		{
			return UnityEngine.Input.anyKey;
		}

		static private UnityEngine.Touch[] get_touches()
		{
			return UnityEngine.Input.touches;
		}

		static private UnityEngine.AccelerationEvent[] get_accelerationEvents()
		{
			return UnityEngine.Input.accelerationEvents;
		}

	}
}
