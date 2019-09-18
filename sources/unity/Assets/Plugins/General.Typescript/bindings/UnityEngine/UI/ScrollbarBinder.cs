using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIScrollbar
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.Scrollbar> self = space.DeclareClass<UnityEngine.UI.Scrollbar, UnityEngine.UI.Selectable>();
			UnityEngineUIScrollbarDirection.Bind(self);
			self.BindConstructor();
			self.BindInstanceFunction("FindSelectableOnDown", FindSelectableOnDown);
			self.BindInstanceFunction("FindSelectableOnLeft", FindSelectableOnLeft);
			self.BindInstanceFunction("FindSelectableOnRight", FindSelectableOnRight);
			self.BindInstanceFunction("FindSelectableOnUp", FindSelectableOnUp);
			self.BindInstanceFunction("GraphicUpdateComplete", GraphicUpdateComplete);
			self.BindInstanceFunction("LayoutComplete", LayoutComplete);
			self.BindInstanceFunction("OnBeginDrag", OnBeginDrag);
			self.BindInstanceFunction("OnDrag", OnDrag);
			self.BindInstanceFunction("OnInitializePotentialDrag", OnInitializePotentialDrag);
			self.BindInstanceFunction("OnMove", OnMove);
			self.BindInstanceFunction("OnPointerDown", OnPointerDown);
			self.BindInstanceFunction("OnPointerUp", OnPointerUp);
			self.BindInstanceFunction("Rebuild", Rebuild);
			self.BindInstanceFunction("SetDirection", SetDirection);
			self.BindInstanceProperty("handleRect", get_handleRect, set_handleRect);
			self.BindInstanceProperty("value", get_value, set_value);
			self.BindInstanceProperty("size", get_size, set_size);
			self.BindInstanceProperty("numberOfSteps", get_numberOfSteps, set_numberOfSteps);
		}

		static private UnityEngine.UI.Selectable FindSelectableOnDown(UnityEngine.UI.Scrollbar instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Scrollbar.FindSelectableOnDown has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.UI.Selectable FindSelectableOnLeft(UnityEngine.UI.Scrollbar instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Scrollbar.FindSelectableOnLeft has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.UI.Selectable FindSelectableOnRight(UnityEngine.UI.Scrollbar instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Scrollbar.FindSelectableOnRight has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.UI.Selectable FindSelectableOnUp(UnityEngine.UI.Scrollbar instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Scrollbar.FindSelectableOnUp has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void GraphicUpdateComplete(UnityEngine.UI.Scrollbar instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Scrollbar.GraphicUpdateComplete has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void LayoutComplete(UnityEngine.UI.Scrollbar instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Scrollbar.LayoutComplete has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void OnBeginDrag(UnityEngine.UI.Scrollbar instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnBeginDrag(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Scrollbar.OnBeginDrag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Scrollbar.OnBeginDrag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnDrag(UnityEngine.UI.Scrollbar instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnDrag(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Scrollbar.OnDrag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Scrollbar.OnDrag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnInitializePotentialDrag(UnityEngine.UI.Scrollbar instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnInitializePotentialDrag(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Scrollbar.OnInitializePotentialDrag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Scrollbar.OnInitializePotentialDrag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnMove(UnityEngine.UI.Scrollbar instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.AxisEventData>())
			{
				instance.OnMove(parameters[0].ToObject<UnityEngine.EventSystems.AxisEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Scrollbar.OnMove has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Scrollbar.OnMove has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnPointerDown(UnityEngine.UI.Scrollbar instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnPointerDown(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Scrollbar.OnPointerDown has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Scrollbar.OnPointerDown has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnPointerUp(UnityEngine.UI.Scrollbar instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnPointerUp(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Scrollbar.OnPointerUp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Scrollbar.OnPointerUp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Rebuild(UnityEngine.UI.Scrollbar instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.CanvasUpdate>())
			{
				instance.Rebuild(parameters[0].ToObject<UnityEngine.UI.CanvasUpdate>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Scrollbar.Rebuild has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Scrollbar.Rebuild has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetDirection(UnityEngine.UI.Scrollbar instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.Scrollbar.Direction, System.Boolean>())
			{
				instance.SetDirection(parameters[0].ToObject<UnityEngine.UI.Scrollbar.Direction>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Scrollbar.SetDirection has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Scrollbar.SetDirection has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.RectTransform get_handleRect(UnityEngine.UI.Scrollbar instance)
		{
			return instance.handleRect;
		}

		static private void set_handleRect(UnityEngine.UI.Scrollbar instance, UnityEngine.RectTransform value)
		{
			instance.handleRect = value;
		}

		static private System.Single get_value(UnityEngine.UI.Scrollbar instance)
		{
			return instance.value;
		}

		static private void set_value(UnityEngine.UI.Scrollbar instance, System.Single value)
		{
			instance.value = value;
		}

		static private System.Single get_size(UnityEngine.UI.Scrollbar instance)
		{
			return instance.size;
		}

		static private void set_size(UnityEngine.UI.Scrollbar instance, System.Single value)
		{
			instance.size = value;
		}

		static private System.Int32 get_numberOfSteps(UnityEngine.UI.Scrollbar instance)
		{
			return instance.numberOfSteps;
		}

		static private void set_numberOfSteps(UnityEngine.UI.Scrollbar instance, System.Int32 value)
		{
			instance.numberOfSteps = value;
		}

	}
}
