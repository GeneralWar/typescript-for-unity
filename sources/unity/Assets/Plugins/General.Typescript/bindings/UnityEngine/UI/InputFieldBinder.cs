using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIInputField
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.InputField> self = space.DeclareClass<UnityEngine.UI.InputField, UnityEngine.UI.Selectable>();
			UnityEngineUIInputFieldCharacterValidation.Bind(self);
			UnityEngineUIInputFieldContentType.Bind(self);
			UnityEngineUIInputFieldInputType.Bind(self);
			UnityEngineUIInputFieldLineType.Bind(self);
			self.BindConstructor();
			self.BindInstanceFunction("ActivateInputField", ActivateInputField);
			self.BindInstanceFunction("CalculateLayoutInputHorizontal", CalculateLayoutInputHorizontal);
			self.BindInstanceFunction("CalculateLayoutInputVertical", CalculateLayoutInputVertical);
			self.BindInstanceFunction("DeactivateInputField", DeactivateInputField);
			self.BindInstanceFunction("ForceLabelUpdate", ForceLabelUpdate);
			self.BindInstanceFunction("GraphicUpdateComplete", GraphicUpdateComplete);
			self.BindInstanceFunction("LayoutComplete", LayoutComplete);
			self.BindInstanceFunction("MoveTextEnd", MoveTextEnd);
			self.BindInstanceFunction("MoveTextStart", MoveTextStart);
			self.BindInstanceFunction("OnBeginDrag", OnBeginDrag);
			self.BindInstanceFunction("OnDeselect", OnDeselect);
			self.BindInstanceFunction("OnDrag", OnDrag);
			self.BindInstanceFunction("OnEndDrag", OnEndDrag);
			self.BindInstanceFunction("OnPointerClick", OnPointerClick);
			self.BindInstanceFunction("OnPointerDown", OnPointerDown);
			self.BindInstanceFunction("OnSelect", OnSelect);
			self.BindInstanceFunction("OnSubmit", OnSubmit);
			self.BindInstanceFunction("OnUpdateSelected", OnUpdateSelected);
			self.BindInstanceFunction("ProcessEvent", ProcessEvent);
			self.BindInstanceFunction("Rebuild", Rebuild);
			self.BindInstanceProperty("shouldHideMobileInput", get_shouldHideMobileInput, set_shouldHideMobileInput);
			self.BindInstanceProperty("preferredHeight", get_preferredHeight, null);
			self.BindInstanceProperty("minHeight", get_minHeight, null);
			self.BindInstanceProperty("flexibleWidth", get_flexibleWidth, null);
			self.BindInstanceProperty("preferredWidth", get_preferredWidth, null);
			self.BindInstanceProperty("minWidth", get_minWidth, null);
			self.BindInstanceProperty("selectionFocusPosition", get_selectionFocusPosition, set_selectionFocusPosition);
			self.BindInstanceProperty("selectionAnchorPosition", get_selectionAnchorPosition, set_selectionAnchorPosition);
			self.BindInstanceProperty("caretPosition", get_caretPosition, set_caretPosition);
			self.BindInstanceProperty("wasCanceled", get_wasCanceled, null);
			self.BindInstanceProperty("asteriskChar", get_asteriskChar, set_asteriskChar);
			self.BindInstanceProperty("multiLine", get_multiLine, null);
			self.BindInstanceProperty("flexibleHeight", get_flexibleHeight, null);
			self.BindInstanceProperty("readOnly", get_readOnly, set_readOnly);
			self.BindInstanceProperty("touchScreenKeyboard", get_touchScreenKeyboard, null);
			self.BindInstanceProperty("characterLimit", get_characterLimit, set_characterLimit);
			self.BindInstanceProperty("selectionColor", get_selectionColor, set_selectionColor);
			self.BindInstanceProperty("customCaretColor", get_customCaretColor, set_customCaretColor);
			self.BindInstanceProperty("caretColor", get_caretColor, set_caretColor);
			self.BindInstanceProperty("placeholder", get_placeholder, set_placeholder);
			self.BindInstanceProperty("textComponent", get_textComponent, set_textComponent);
			self.BindInstanceProperty("caretWidth", get_caretWidth, set_caretWidth);
			self.BindInstanceProperty("caretBlinkRate", get_caretBlinkRate, set_caretBlinkRate);
			self.BindInstanceProperty("isFocused", get_isFocused, null);
			self.BindInstanceProperty("text", get_text, set_text);
			self.BindInstanceProperty("keyboardType", get_keyboardType, set_keyboardType);
			self.BindInstanceProperty("layoutPriority", get_layoutPriority, null);
		}

		static private void ActivateInputField(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ActivateInputField();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.ActivateInputField has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void CalculateLayoutInputHorizontal(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.CalculateLayoutInputHorizontal();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.CalculateLayoutInputHorizontal has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void CalculateLayoutInputVertical(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.CalculateLayoutInputVertical();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.CalculateLayoutInputVertical has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void DeactivateInputField(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.DeactivateInputField();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.DeactivateInputField has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ForceLabelUpdate(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ForceLabelUpdate();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.ForceLabelUpdate has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void GraphicUpdateComplete(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.GraphicUpdateComplete();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.GraphicUpdateComplete has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void LayoutComplete(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.LayoutComplete();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.LayoutComplete has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void MoveTextEnd(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean>())
			{
				instance.MoveTextEnd(parameters[0].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.InputField.MoveTextEnd has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.MoveTextEnd has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void MoveTextStart(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean>())
			{
				instance.MoveTextStart(parameters[0].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.InputField.MoveTextStart has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.MoveTextStart has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnBeginDrag(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnBeginDrag(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.InputField.OnBeginDrag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.OnBeginDrag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnDeselect(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.BaseEventData>())
			{
				instance.OnDeselect(parameters[0].ToObject<UnityEngine.EventSystems.BaseEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.InputField.OnDeselect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.OnDeselect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnDrag(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnDrag(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.InputField.OnDrag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.OnDrag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnEndDrag(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnEndDrag(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.InputField.OnEndDrag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.OnEndDrag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnPointerClick(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnPointerClick(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.InputField.OnPointerClick has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.OnPointerClick has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnPointerDown(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnPointerDown(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.InputField.OnPointerDown has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.OnPointerDown has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnSelect(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.BaseEventData>())
			{
				instance.OnSelect(parameters[0].ToObject<UnityEngine.EventSystems.BaseEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.InputField.OnSelect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.OnSelect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnSubmit(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.BaseEventData>())
			{
				instance.OnSubmit(parameters[0].ToObject<UnityEngine.EventSystems.BaseEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.InputField.OnSubmit has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.OnSubmit has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnUpdateSelected(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.BaseEventData>())
			{
				instance.OnUpdateSelected(parameters[0].ToObject<UnityEngine.EventSystems.BaseEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.InputField.OnUpdateSelected has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.OnUpdateSelected has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void ProcessEvent(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Event>())
			{
				instance.ProcessEvent(parameters[0].ToObject<UnityEngine.Event>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.InputField.ProcessEvent has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.ProcessEvent has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Rebuild(UnityEngine.UI.InputField instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.CanvasUpdate>())
			{
				instance.Rebuild(parameters[0].ToObject<UnityEngine.UI.CanvasUpdate>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.InputField.Rebuild has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.InputField.Rebuild has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean get_shouldHideMobileInput(UnityEngine.UI.InputField instance, string name)
		{
			return instance.shouldHideMobileInput;
		}

		static private void set_shouldHideMobileInput(UnityEngine.UI.InputField instance, string name, System.Boolean value)
		{
			instance.shouldHideMobileInput = value;
		}

		static private System.Single get_preferredHeight(UnityEngine.UI.InputField instance, string name)
		{
			return instance.preferredHeight;
		}

		static private System.Single get_minHeight(UnityEngine.UI.InputField instance, string name)
		{
			return instance.minHeight;
		}

		static private System.Single get_flexibleWidth(UnityEngine.UI.InputField instance, string name)
		{
			return instance.flexibleWidth;
		}

		static private System.Single get_preferredWidth(UnityEngine.UI.InputField instance, string name)
		{
			return instance.preferredWidth;
		}

		static private System.Single get_minWidth(UnityEngine.UI.InputField instance, string name)
		{
			return instance.minWidth;
		}

		static private System.Int32 get_selectionFocusPosition(UnityEngine.UI.InputField instance, string name)
		{
			return instance.selectionFocusPosition;
		}

		static private void set_selectionFocusPosition(UnityEngine.UI.InputField instance, string name, System.Int32 value)
		{
			instance.selectionFocusPosition = value;
		}

		static private System.Int32 get_selectionAnchorPosition(UnityEngine.UI.InputField instance, string name)
		{
			return instance.selectionAnchorPosition;
		}

		static private void set_selectionAnchorPosition(UnityEngine.UI.InputField instance, string name, System.Int32 value)
		{
			instance.selectionAnchorPosition = value;
		}

		static private System.Int32 get_caretPosition(UnityEngine.UI.InputField instance, string name)
		{
			return instance.caretPosition;
		}

		static private void set_caretPosition(UnityEngine.UI.InputField instance, string name, System.Int32 value)
		{
			instance.caretPosition = value;
		}

		static private System.Boolean get_wasCanceled(UnityEngine.UI.InputField instance, string name)
		{
			return instance.wasCanceled;
		}

		static private System.Char get_asteriskChar(UnityEngine.UI.InputField instance, string name)
		{
			return instance.asteriskChar;
		}

		static private void set_asteriskChar(UnityEngine.UI.InputField instance, string name, System.Char value)
		{
			instance.asteriskChar = value;
		}

		static private System.Boolean get_multiLine(UnityEngine.UI.InputField instance, string name)
		{
			return instance.multiLine;
		}

		static private System.Single get_flexibleHeight(UnityEngine.UI.InputField instance, string name)
		{
			return instance.flexibleHeight;
		}

		static private System.Boolean get_readOnly(UnityEngine.UI.InputField instance, string name)
		{
			return instance.readOnly;
		}

		static private void set_readOnly(UnityEngine.UI.InputField instance, string name, System.Boolean value)
		{
			instance.readOnly = value;
		}

		static private UnityEngine.TouchScreenKeyboard get_touchScreenKeyboard(UnityEngine.UI.InputField instance, string name)
		{
			return instance.touchScreenKeyboard;
		}

		static private System.Int32 get_characterLimit(UnityEngine.UI.InputField instance, string name)
		{
			return instance.characterLimit;
		}

		static private void set_characterLimit(UnityEngine.UI.InputField instance, string name, System.Int32 value)
		{
			instance.characterLimit = value;
		}

		static private UnityEngine.Color get_selectionColor(UnityEngine.UI.InputField instance, string name)
		{
			return instance.selectionColor;
		}

		static private void set_selectionColor(UnityEngine.UI.InputField instance, string name, UnityEngine.Color value)
		{
			instance.selectionColor = value;
		}

		static private System.Boolean get_customCaretColor(UnityEngine.UI.InputField instance, string name)
		{
			return instance.customCaretColor;
		}

		static private void set_customCaretColor(UnityEngine.UI.InputField instance, string name, System.Boolean value)
		{
			instance.customCaretColor = value;
		}

		static private UnityEngine.Color get_caretColor(UnityEngine.UI.InputField instance, string name)
		{
			return instance.caretColor;
		}

		static private void set_caretColor(UnityEngine.UI.InputField instance, string name, UnityEngine.Color value)
		{
			instance.caretColor = value;
		}

		static private UnityEngine.UI.Graphic get_placeholder(UnityEngine.UI.InputField instance, string name)
		{
			return instance.placeholder;
		}

		static private void set_placeholder(UnityEngine.UI.InputField instance, string name, UnityEngine.UI.Graphic value)
		{
			instance.placeholder = value;
		}

		static private UnityEngine.UI.Text get_textComponent(UnityEngine.UI.InputField instance, string name)
		{
			return instance.textComponent;
		}

		static private void set_textComponent(UnityEngine.UI.InputField instance, string name, UnityEngine.UI.Text value)
		{
			instance.textComponent = value;
		}

		static private System.Int32 get_caretWidth(UnityEngine.UI.InputField instance, string name)
		{
			return instance.caretWidth;
		}

		static private void set_caretWidth(UnityEngine.UI.InputField instance, string name, System.Int32 value)
		{
			instance.caretWidth = value;
		}

		static private System.Single get_caretBlinkRate(UnityEngine.UI.InputField instance, string name)
		{
			return instance.caretBlinkRate;
		}

		static private void set_caretBlinkRate(UnityEngine.UI.InputField instance, string name, System.Single value)
		{
			instance.caretBlinkRate = value;
		}

		static private System.Boolean get_isFocused(UnityEngine.UI.InputField instance, string name)
		{
			return instance.isFocused;
		}

		static private System.String get_text(UnityEngine.UI.InputField instance, string name)
		{
			return instance.text;
		}

		static private void set_text(UnityEngine.UI.InputField instance, string name, System.String value)
		{
			instance.text = value;
		}

		static private UnityEngine.TouchScreenKeyboardType get_keyboardType(UnityEngine.UI.InputField instance, string name)
		{
			return instance.keyboardType;
		}

		static private void set_keyboardType(UnityEngine.UI.InputField instance, string name, UnityEngine.TouchScreenKeyboardType value)
		{
			instance.keyboardType = value;
		}

		static private System.Int32 get_layoutPriority(UnityEngine.UI.InputField instance, string name)
		{
			return instance.layoutPriority;
		}

	}
}
