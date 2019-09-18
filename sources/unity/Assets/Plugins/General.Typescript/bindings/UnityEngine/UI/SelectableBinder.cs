using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUISelectable
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.Selectable> self = space.DeclareClass<UnityEngine.UI.Selectable, UnityEngine.EventSystems.UIBehaviour>();
			UnityEngineUISelectableTransition.Bind(self);
			self.BindConstructor();
			self.BindInstanceFunction("FindSelectable", FindSelectable);
			self.BindInstanceFunction("FindSelectableOnDown", FindSelectableOnDown);
			self.BindInstanceFunction("FindSelectableOnLeft", FindSelectableOnLeft);
			self.BindInstanceFunction("FindSelectableOnRight", FindSelectableOnRight);
			self.BindInstanceFunction("FindSelectableOnUp", FindSelectableOnUp);
			self.BindInstanceFunction("IsInteractable", IsInteractable);
			self.BindInstanceFunction("OnDeselect", OnDeselect);
			self.BindInstanceFunction("OnMove", OnMove);
			self.BindInstanceFunction("OnPointerDown", OnPointerDown);
			self.BindInstanceFunction("OnPointerEnter", OnPointerEnter);
			self.BindInstanceFunction("OnPointerExit", OnPointerExit);
			self.BindInstanceFunction("OnPointerUp", OnPointerUp);
			self.BindInstanceFunction("OnSelect", OnSelect);
			self.BindInstanceFunction("Select", Select);
			self.BindInstanceProperty("navigation", get_navigation, set_navigation);
			self.BindInstanceProperty("colors", get_colors, set_colors);
			self.BindInstanceProperty("spriteState", get_spriteState, set_spriteState);
			self.BindInstanceProperty("animationTriggers", get_animationTriggers, set_animationTriggers);
			self.BindInstanceProperty("targetGraphic", get_targetGraphic, set_targetGraphic);
			self.BindInstanceProperty("interactable", get_interactable, set_interactable);
			self.BindInstanceProperty("image", get_image, set_image);
			self.BindInstanceProperty("animator", get_animator, null);
		}

		static private UnityEngine.UI.Selectable FindSelectable(UnityEngine.UI.Selectable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.FindSelectable(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Selectable.FindSelectable has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Selectable.FindSelectable has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.UI.Selectable FindSelectableOnDown(UnityEngine.UI.Selectable instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Selectable.FindSelectableOnDown has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.UI.Selectable FindSelectableOnLeft(UnityEngine.UI.Selectable instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Selectable.FindSelectableOnLeft has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.UI.Selectable FindSelectableOnRight(UnityEngine.UI.Selectable instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Selectable.FindSelectableOnRight has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.UI.Selectable FindSelectableOnUp(UnityEngine.UI.Selectable instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Selectable.FindSelectableOnUp has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Boolean IsInteractable(UnityEngine.UI.Selectable instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsInteractable();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Selectable.IsInteractable has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private void OnDeselect(UnityEngine.UI.Selectable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.BaseEventData>())
			{
				instance.OnDeselect(parameters[0].ToObject<UnityEngine.EventSystems.BaseEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Selectable.OnDeselect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Selectable.OnDeselect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnMove(UnityEngine.UI.Selectable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.AxisEventData>())
			{
				instance.OnMove(parameters[0].ToObject<UnityEngine.EventSystems.AxisEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Selectable.OnMove has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Selectable.OnMove has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnPointerDown(UnityEngine.UI.Selectable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnPointerDown(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Selectable.OnPointerDown has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Selectable.OnPointerDown has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnPointerEnter(UnityEngine.UI.Selectable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnPointerEnter(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Selectable.OnPointerEnter has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Selectable.OnPointerEnter has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnPointerExit(UnityEngine.UI.Selectable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnPointerExit(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Selectable.OnPointerExit has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Selectable.OnPointerExit has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnPointerUp(UnityEngine.UI.Selectable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnPointerUp(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Selectable.OnPointerUp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Selectable.OnPointerUp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnSelect(UnityEngine.UI.Selectable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.BaseEventData>())
			{
				instance.OnSelect(parameters[0].ToObject<UnityEngine.EventSystems.BaseEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Selectable.OnSelect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Selectable.OnSelect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Select(UnityEngine.UI.Selectable instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Select();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Selectable.Select has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.UI.Navigation get_navigation(UnityEngine.UI.Selectable instance)
		{
			return instance.navigation;
		}

		static private void set_navigation(UnityEngine.UI.Selectable instance, UnityEngine.UI.Navigation value)
		{
			instance.navigation = value;
		}

		static private UnityEngine.UI.ColorBlock get_colors(UnityEngine.UI.Selectable instance)
		{
			return instance.colors;
		}

		static private void set_colors(UnityEngine.UI.Selectable instance, UnityEngine.UI.ColorBlock value)
		{
			instance.colors = value;
		}

		static private UnityEngine.UI.SpriteState get_spriteState(UnityEngine.UI.Selectable instance)
		{
			return instance.spriteState;
		}

		static private void set_spriteState(UnityEngine.UI.Selectable instance, UnityEngine.UI.SpriteState value)
		{
			instance.spriteState = value;
		}

		static private UnityEngine.UI.AnimationTriggers get_animationTriggers(UnityEngine.UI.Selectable instance)
		{
			return instance.animationTriggers;
		}

		static private void set_animationTriggers(UnityEngine.UI.Selectable instance, UnityEngine.UI.AnimationTriggers value)
		{
			instance.animationTriggers = value;
		}

		static private UnityEngine.UI.Graphic get_targetGraphic(UnityEngine.UI.Selectable instance)
		{
			return instance.targetGraphic;
		}

		static private void set_targetGraphic(UnityEngine.UI.Selectable instance, UnityEngine.UI.Graphic value)
		{
			instance.targetGraphic = value;
		}

		static private System.Boolean get_interactable(UnityEngine.UI.Selectable instance)
		{
			return instance.interactable;
		}

		static private void set_interactable(UnityEngine.UI.Selectable instance, System.Boolean value)
		{
			instance.interactable = value;
		}

		static private UnityEngine.UI.Image get_image(UnityEngine.UI.Selectable instance)
		{
			return instance.image;
		}

		static private void set_image(UnityEngine.UI.Selectable instance, UnityEngine.UI.Image value)
		{
			instance.image = value;
		}

		static private UnityEngine.Animator get_animator(UnityEngine.UI.Selectable instance)
		{
			return instance.animator;
		}

	}
}
