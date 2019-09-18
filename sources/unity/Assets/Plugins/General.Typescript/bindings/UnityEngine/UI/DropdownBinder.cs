using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIDropdown
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.Dropdown> self = space.DeclareClass<UnityEngine.UI.Dropdown, UnityEngine.UI.Selectable>();
			self.BindConstructor();
			self.BindInstanceFunction("ClearOptions", ClearOptions);
			self.BindInstanceFunction("Hide", Hide);
			self.BindInstanceFunction("OnCancel", OnCancel);
			self.BindInstanceFunction("OnPointerClick", OnPointerClick);
			self.BindInstanceFunction("OnSubmit", OnSubmit);
			self.BindInstanceFunction("RefreshShownValue", RefreshShownValue);
			self.BindInstanceFunction("Show", Show);
			self.BindInstanceProperty("template", get_template, set_template);
			self.BindInstanceProperty("captionText", get_captionText, set_captionText);
			self.BindInstanceProperty("captionImage", get_captionImage, set_captionImage);
			self.BindInstanceProperty("itemText", get_itemText, set_itemText);
			self.BindInstanceProperty("itemImage", get_itemImage, set_itemImage);
			self.BindInstanceProperty("value", get_value, set_value);
		}

		static private void ClearOptions(UnityEngine.UI.Dropdown instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ClearOptions();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Dropdown.ClearOptions has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Hide(UnityEngine.UI.Dropdown instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Hide();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Dropdown.Hide has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void OnCancel(UnityEngine.UI.Dropdown instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.BaseEventData>())
			{
				instance.OnCancel(parameters[0].ToObject<UnityEngine.EventSystems.BaseEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Dropdown.OnCancel has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Dropdown.OnCancel has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnPointerClick(UnityEngine.UI.Dropdown instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnPointerClick(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Dropdown.OnPointerClick has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Dropdown.OnPointerClick has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnSubmit(UnityEngine.UI.Dropdown instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.BaseEventData>())
			{
				instance.OnSubmit(parameters[0].ToObject<UnityEngine.EventSystems.BaseEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Dropdown.OnSubmit has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Dropdown.OnSubmit has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void RefreshShownValue(UnityEngine.UI.Dropdown instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.RefreshShownValue();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Dropdown.RefreshShownValue has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Show(UnityEngine.UI.Dropdown instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Show();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Dropdown.Show has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.RectTransform get_template(UnityEngine.UI.Dropdown instance)
		{
			return instance.template;
		}

		static private void set_template(UnityEngine.UI.Dropdown instance, UnityEngine.RectTransform value)
		{
			instance.template = value;
		}

		static private UnityEngine.UI.Text get_captionText(UnityEngine.UI.Dropdown instance)
		{
			return instance.captionText;
		}

		static private void set_captionText(UnityEngine.UI.Dropdown instance, UnityEngine.UI.Text value)
		{
			instance.captionText = value;
		}

		static private UnityEngine.UI.Image get_captionImage(UnityEngine.UI.Dropdown instance)
		{
			return instance.captionImage;
		}

		static private void set_captionImage(UnityEngine.UI.Dropdown instance, UnityEngine.UI.Image value)
		{
			instance.captionImage = value;
		}

		static private UnityEngine.UI.Text get_itemText(UnityEngine.UI.Dropdown instance)
		{
			return instance.itemText;
		}

		static private void set_itemText(UnityEngine.UI.Dropdown instance, UnityEngine.UI.Text value)
		{
			instance.itemText = value;
		}

		static private UnityEngine.UI.Image get_itemImage(UnityEngine.UI.Dropdown instance)
		{
			return instance.itemImage;
		}

		static private void set_itemImage(UnityEngine.UI.Dropdown instance, UnityEngine.UI.Image value)
		{
			instance.itemImage = value;
		}

		static private System.Int32 get_value(UnityEngine.UI.Dropdown instance)
		{
			return instance.value;
		}

		static private void set_value(UnityEngine.UI.Dropdown instance, System.Int32 value)
		{
			instance.value = value;
		}

	}
}
