using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineEventSystemsBaseInput
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.EventSystems.BaseInput> self = space.DeclareClass<UnityEngine.EventSystems.BaseInput, UnityEngine.EventSystems.UIBehaviour>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("GetAxisRaw", GetAxisRaw);
			self.BindInstanceFunction("GetButtonDown", GetButtonDown);
			self.BindInstanceFunction("GetMouseButton", GetMouseButton);
			self.BindInstanceFunction("GetMouseButtonDown", GetMouseButtonDown);
			self.BindInstanceFunction("GetMouseButtonUp", GetMouseButtonUp);
			self.BindInstanceFunction("GetTouch", GetTouch);
			self.BindInstanceProperty("compositionString", get_compositionString, null);
			self.BindInstanceProperty("imeCompositionMode", get_imeCompositionMode, set_imeCompositionMode);
			self.BindInstanceProperty("compositionCursorPos", get_compositionCursorPos, set_compositionCursorPos);
			self.BindInstanceProperty("mousePresent", get_mousePresent, null);
			self.BindInstanceProperty("mousePosition", get_mousePosition, null);
			self.BindInstanceProperty("mouseScrollDelta", get_mouseScrollDelta, null);
			self.BindInstanceProperty("touchSupported", get_touchSupported, null);
			self.BindInstanceProperty("touchCount", get_touchCount, null);
		}

		static private UnityEngine.EventSystems.BaseInput Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.EventSystems.BaseInput();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.BaseInput.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.EventSystems.BaseInput);
		}

		static private System.Single GetAxisRaw(UnityEngine.EventSystems.BaseInput instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetAxisRaw(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.BaseInput.GetAxisRaw has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.BaseInput.GetAxisRaw has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Boolean GetButtonDown(UnityEngine.EventSystems.BaseInput instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetButtonDown(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.BaseInput.GetButtonDown has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.BaseInput.GetButtonDown has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean GetMouseButton(UnityEngine.EventSystems.BaseInput instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetMouseButton(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.BaseInput.GetMouseButton has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.BaseInput.GetMouseButton has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean GetMouseButtonDown(UnityEngine.EventSystems.BaseInput instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetMouseButtonDown(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.BaseInput.GetMouseButtonDown has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.BaseInput.GetMouseButtonDown has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean GetMouseButtonUp(UnityEngine.EventSystems.BaseInput instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetMouseButtonUp(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.BaseInput.GetMouseButtonUp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.BaseInput.GetMouseButtonUp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.Touch GetTouch(UnityEngine.EventSystems.BaseInput instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetTouch(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.BaseInput.GetTouch has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.BaseInput.GetTouch has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Touch);
		}

		static private System.String get_compositionString(UnityEngine.EventSystems.BaseInput instance)
		{
			return instance.compositionString;
		}

		static private UnityEngine.IMECompositionMode get_imeCompositionMode(UnityEngine.EventSystems.BaseInput instance)
		{
			return instance.imeCompositionMode;
		}

		static private void set_imeCompositionMode(UnityEngine.EventSystems.BaseInput instance, UnityEngine.IMECompositionMode value)
		{
			instance.imeCompositionMode = value;
		}

		static private UnityEngine.Vector2 get_compositionCursorPos(UnityEngine.EventSystems.BaseInput instance)
		{
			return instance.compositionCursorPos;
		}

		static private void set_compositionCursorPos(UnityEngine.EventSystems.BaseInput instance, UnityEngine.Vector2 value)
		{
			instance.compositionCursorPos = value;
		}

		static private System.Boolean get_mousePresent(UnityEngine.EventSystems.BaseInput instance)
		{
			return instance.mousePresent;
		}

		static private UnityEngine.Vector2 get_mousePosition(UnityEngine.EventSystems.BaseInput instance)
		{
			return instance.mousePosition;
		}

		static private UnityEngine.Vector2 get_mouseScrollDelta(UnityEngine.EventSystems.BaseInput instance)
		{
			return instance.mouseScrollDelta;
		}

		static private System.Boolean get_touchSupported(UnityEngine.EventSystems.BaseInput instance)
		{
			return instance.touchSupported;
		}

		static private System.Int32 get_touchCount(UnityEngine.EventSystems.BaseInput instance)
		{
			return instance.touchCount;
		}

	}
}
