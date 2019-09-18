#if !UNITY_STANDALONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTouchScreenKeyboard
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.TouchScreenKeyboard> self = space.DeclareClass<UnityEngine.TouchScreenKeyboard>();
#if !UNITY_STANDALONE
			UnityEngineTouchScreenKeyboardStatus.Bind(self);
#endif
			self.BindConstructor(Constructor);
			self.BindStaticFunction("Open", Open);
			self.BindStaticProperty("isSupported", get_isSupported, null);
			self.BindStaticProperty("hideInput", get_hideInput, set_hideInput);
			self.BindStaticProperty("area", get_area, null);
			self.BindStaticProperty("visible", get_visible, null);
			self.BindInstanceProperty("text", get_text, set_text);
			self.BindInstanceProperty("active", get_active, set_active);
			self.BindInstanceProperty("characterLimit", get_characterLimit, set_characterLimit);
			self.BindInstanceProperty("canGetSelection", get_canGetSelection, null);
			self.BindInstanceProperty("canSetSelection", get_canSetSelection, null);
			self.BindInstanceProperty("selection", get_selection, set_selection);
			self.BindInstanceProperty("type", get_type, null);
			self.BindInstanceProperty("targetDisplay", get_targetDisplay, set_targetDisplay);
		}

		static private UnityEngine.TouchScreenKeyboard Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.TouchScreenKeyboardType, System.Boolean, System.Boolean, System.Boolean, System.Boolean, System.String, System.Int32>())
			{
				return new UnityEngine.TouchScreenKeyboard(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.TouchScreenKeyboardType>(), parameters[2].ToObject<System.Boolean>(), parameters[3].ToObject<System.Boolean>(), parameters[4].ToObject<System.Boolean>(), parameters[5].ToObject<System.Boolean>(), parameters[6].ToObject<System.String>(), parameters[7].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.TouchScreenKeyboard.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.TouchScreenKeyboard.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.TouchScreenKeyboard);
		}

		static private UnityEngine.TouchScreenKeyboard Open(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.TouchScreenKeyboard.Open(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.TouchScreenKeyboardType>())
			{
				return UnityEngine.TouchScreenKeyboard.Open(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.TouchScreenKeyboardType>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.TouchScreenKeyboardType, System.Boolean>())
			{
				return UnityEngine.TouchScreenKeyboard.Open(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.TouchScreenKeyboardType>(), parameters[2].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.TouchScreenKeyboardType, System.Boolean, System.Boolean>())
			{
				return UnityEngine.TouchScreenKeyboard.Open(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.TouchScreenKeyboardType>(), parameters[2].ToObject<System.Boolean>(), parameters[3].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.TouchScreenKeyboardType, System.Boolean, System.Boolean, System.Boolean>())
			{
				return UnityEngine.TouchScreenKeyboard.Open(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.TouchScreenKeyboardType>(), parameters[2].ToObject<System.Boolean>(), parameters[3].ToObject<System.Boolean>(), parameters[4].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.TouchScreenKeyboardType, System.Boolean, System.Boolean, System.Boolean, System.Boolean>())
			{
				return UnityEngine.TouchScreenKeyboard.Open(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.TouchScreenKeyboardType>(), parameters[2].ToObject<System.Boolean>(), parameters[3].ToObject<System.Boolean>(), parameters[4].ToObject<System.Boolean>(), parameters[5].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.TouchScreenKeyboardType, System.Boolean, System.Boolean, System.Boolean, System.Boolean, System.String>())
			{
				return UnityEngine.TouchScreenKeyboard.Open(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.TouchScreenKeyboardType>(), parameters[2].ToObject<System.Boolean>(), parameters[3].ToObject<System.Boolean>(), parameters[4].ToObject<System.Boolean>(), parameters[5].ToObject<System.Boolean>(), parameters[6].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.TouchScreenKeyboardType, System.Boolean, System.Boolean, System.Boolean, System.Boolean, System.String, System.Int32>())
			{
				return UnityEngine.TouchScreenKeyboard.Open(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.TouchScreenKeyboardType>(), parameters[2].ToObject<System.Boolean>(), parameters[3].ToObject<System.Boolean>(), parameters[4].ToObject<System.Boolean>(), parameters[5].ToObject<System.Boolean>(), parameters[6].ToObject<System.String>(), parameters[7].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.TouchScreenKeyboard.Open has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.TouchScreenKeyboard.Open has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean get_isSupported()
		{
			return UnityEngine.TouchScreenKeyboard.isSupported;
		}

		static private System.Boolean get_hideInput()
		{
			return UnityEngine.TouchScreenKeyboard.hideInput;
		}

		static private void set_hideInput(System.Boolean value)
		{
			UnityEngine.TouchScreenKeyboard.hideInput = value;
		}

		static private UnityEngine.Rect get_area()
		{
			return UnityEngine.TouchScreenKeyboard.area;
		}

		static private System.Boolean get_visible()
		{
			return UnityEngine.TouchScreenKeyboard.visible;
		}

		static private System.String get_text(UnityEngine.TouchScreenKeyboard instance)
		{
			return instance.text;
		}

		static private void set_text(UnityEngine.TouchScreenKeyboard instance, System.String value)
		{
			instance.text = value;
		}

		static private System.Boolean get_active(UnityEngine.TouchScreenKeyboard instance)
		{
			return instance.active;
		}

		static private void set_active(UnityEngine.TouchScreenKeyboard instance, System.Boolean value)
		{
			instance.active = value;
		}

		static private System.Int32 get_characterLimit(UnityEngine.TouchScreenKeyboard instance)
		{
			return instance.characterLimit;
		}

		static private void set_characterLimit(UnityEngine.TouchScreenKeyboard instance, System.Int32 value)
		{
			instance.characterLimit = value;
		}

		static private System.Boolean get_canGetSelection(UnityEngine.TouchScreenKeyboard instance)
		{
			return instance.canGetSelection;
		}

		static private System.Boolean get_canSetSelection(UnityEngine.TouchScreenKeyboard instance)
		{
			return instance.canSetSelection;
		}

		static private UnityEngine.RangeInt get_selection(UnityEngine.TouchScreenKeyboard instance)
		{
			return instance.selection;
		}

		static private void set_selection(UnityEngine.TouchScreenKeyboard instance, UnityEngine.RangeInt value)
		{
			instance.selection = value;
		}

		static private UnityEngine.TouchScreenKeyboardType get_type(UnityEngine.TouchScreenKeyboard instance)
		{
			return instance.type;
		}

		static private System.Int32 get_targetDisplay(UnityEngine.TouchScreenKeyboard instance)
		{
			return instance.targetDisplay;
		}

		static private void set_targetDisplay(UnityEngine.TouchScreenKeyboard instance, System.Int32 value)
		{
			instance.targetDisplay = value;
		}

	}
}
#endif
