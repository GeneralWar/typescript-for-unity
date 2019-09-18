using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUISlider
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.Slider> self = space.DeclareClass<UnityEngine.UI.Slider, UnityEngine.UI.Selectable>();
			UnityEngineUISliderDirection.Bind(self);
			self.BindConstructor();
			self.BindInstanceFunction("FindSelectableOnDown", FindSelectableOnDown);
			self.BindInstanceFunction("FindSelectableOnLeft", FindSelectableOnLeft);
			self.BindInstanceFunction("FindSelectableOnRight", FindSelectableOnRight);
			self.BindInstanceFunction("FindSelectableOnUp", FindSelectableOnUp);
			self.BindInstanceFunction("GraphicUpdateComplete", GraphicUpdateComplete);
			self.BindInstanceFunction("LayoutComplete", LayoutComplete);
			self.BindInstanceFunction("OnDrag", OnDrag);
			self.BindInstanceFunction("OnInitializePotentialDrag", OnInitializePotentialDrag);
			self.BindInstanceFunction("OnMove", OnMove);
			self.BindInstanceFunction("OnPointerDown", OnPointerDown);
			self.BindInstanceFunction("Rebuild", Rebuild);
			self.BindInstanceFunction("SetDirection", SetDirection);
			self.BindInstanceProperty("fillRect", get_fillRect, set_fillRect);
			self.BindInstanceProperty("handleRect", get_handleRect, set_handleRect);
			self.BindInstanceProperty("minValue", get_minValue, set_minValue);
			self.BindInstanceProperty("maxValue", get_maxValue, set_maxValue);
			self.BindInstanceProperty("wholeNumbers", get_wholeNumbers, set_wholeNumbers);
			self.BindInstanceProperty("value", get_value, set_value);
			self.BindInstanceProperty("normalizedValue", get_normalizedValue, set_normalizedValue);
		}

		static private UnityEngine.UI.Selectable FindSelectableOnDown(UnityEngine.UI.Slider instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.FindSelectableOnDown();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Slider.FindSelectableOnDown has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.UI.Selectable FindSelectableOnLeft(UnityEngine.UI.Slider instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.FindSelectableOnLeft();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Slider.FindSelectableOnLeft has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.UI.Selectable FindSelectableOnRight(UnityEngine.UI.Slider instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.FindSelectableOnRight();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Slider.FindSelectableOnRight has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.UI.Selectable FindSelectableOnUp(UnityEngine.UI.Slider instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.FindSelectableOnUp();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Slider.FindSelectableOnUp has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void GraphicUpdateComplete(UnityEngine.UI.Slider instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Slider.GraphicUpdateComplete has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void LayoutComplete(UnityEngine.UI.Slider instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Slider.LayoutComplete has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void OnDrag(UnityEngine.UI.Slider instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnDrag(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Slider.OnDrag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Slider.OnDrag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnInitializePotentialDrag(UnityEngine.UI.Slider instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnInitializePotentialDrag(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Slider.OnInitializePotentialDrag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Slider.OnInitializePotentialDrag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnMove(UnityEngine.UI.Slider instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.AxisEventData>())
			{
				instance.OnMove(parameters[0].ToObject<UnityEngine.EventSystems.AxisEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Slider.OnMove has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Slider.OnMove has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnPointerDown(UnityEngine.UI.Slider instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnPointerDown(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Slider.OnPointerDown has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Slider.OnPointerDown has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Rebuild(UnityEngine.UI.Slider instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.CanvasUpdate>())
			{
				instance.Rebuild(parameters[0].ToObject<UnityEngine.UI.CanvasUpdate>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Slider.Rebuild has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Slider.Rebuild has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetDirection(UnityEngine.UI.Slider instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.Slider.Direction, System.Boolean>())
			{
				instance.SetDirection(parameters[0].ToObject<UnityEngine.UI.Slider.Direction>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Slider.SetDirection has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Slider.SetDirection has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.RectTransform get_fillRect(UnityEngine.UI.Slider instance)
		{
			return instance.fillRect;
		}

		static private void set_fillRect(UnityEngine.UI.Slider instance, UnityEngine.RectTransform value)
		{
			instance.fillRect = value;
		}

		static private UnityEngine.RectTransform get_handleRect(UnityEngine.UI.Slider instance)
		{
			return instance.handleRect;
		}

		static private void set_handleRect(UnityEngine.UI.Slider instance, UnityEngine.RectTransform value)
		{
			instance.handleRect = value;
		}

		static private System.Single get_minValue(UnityEngine.UI.Slider instance)
		{
			return instance.minValue;
		}

		static private void set_minValue(UnityEngine.UI.Slider instance, System.Single value)
		{
			instance.minValue = value;
		}

		static private System.Single get_maxValue(UnityEngine.UI.Slider instance)
		{
			return instance.maxValue;
		}

		static private void set_maxValue(UnityEngine.UI.Slider instance, System.Single value)
		{
			instance.maxValue = value;
		}

		static private System.Boolean get_wholeNumbers(UnityEngine.UI.Slider instance)
		{
			return instance.wholeNumbers;
		}

		static private void set_wholeNumbers(UnityEngine.UI.Slider instance, System.Boolean value)
		{
			instance.wholeNumbers = value;
		}

		static private System.Single get_value(UnityEngine.UI.Slider instance)
		{
			return instance.value;
		}

		static private void set_value(UnityEngine.UI.Slider instance, System.Single value)
		{
			instance.value = value;
		}

		static private System.Single get_normalizedValue(UnityEngine.UI.Slider instance)
		{
			return instance.normalizedValue;
		}

		static private void set_normalizedValue(UnityEngine.UI.Slider instance, System.Single value)
		{
			instance.normalizedValue = value;
		}

	}
}
