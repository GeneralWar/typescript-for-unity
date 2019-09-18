using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIScrollRect
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.ScrollRect> self = space.DeclareClass<UnityEngine.UI.ScrollRect, UnityEngine.EventSystems.UIBehaviour>();
			UnityEngineUIScrollRectMovementType.Bind(self);
			UnityEngineUIScrollRectScrollbarVisibility.Bind(self);
			self.BindConstructor();
			self.BindInstanceFunction("CalculateLayoutInputHorizontal", CalculateLayoutInputHorizontal);
			self.BindInstanceFunction("CalculateLayoutInputVertical", CalculateLayoutInputVertical);
			self.BindInstanceFunction("GraphicUpdateComplete", GraphicUpdateComplete);
			self.BindInstanceFunction("IsActive", IsActive);
			self.BindInstanceFunction("LayoutComplete", LayoutComplete);
			self.BindInstanceFunction("OnBeginDrag", OnBeginDrag);
			self.BindInstanceFunction("OnDrag", OnDrag);
			self.BindInstanceFunction("OnEndDrag", OnEndDrag);
			self.BindInstanceFunction("OnInitializePotentialDrag", OnInitializePotentialDrag);
			self.BindInstanceFunction("OnScroll", OnScroll);
			self.BindInstanceFunction("Rebuild", Rebuild);
			self.BindInstanceFunction("SetLayoutHorizontal", SetLayoutHorizontal);
			self.BindInstanceFunction("SetLayoutVertical", SetLayoutVertical);
			self.BindInstanceFunction("StopMovement", StopMovement);
			self.BindInstanceProperty("content", get_content, set_content);
			self.BindInstanceProperty("preferredHeight", get_preferredHeight, null);
			self.BindInstanceProperty("minHeight", get_minHeight, null);
			self.BindInstanceProperty("flexibleWidth", get_flexibleWidth, null);
			self.BindInstanceProperty("preferredWidth", get_preferredWidth, null);
			self.BindInstanceProperty("minWidth", get_minWidth, null);
			self.BindInstanceProperty("verticalNormalizedPosition", get_verticalNormalizedPosition, set_verticalNormalizedPosition);
			self.BindInstanceProperty("horizontalNormalizedPosition", get_horizontalNormalizedPosition, set_horizontalNormalizedPosition);
			self.BindInstanceProperty("normalizedPosition", get_normalizedPosition, set_normalizedPosition);
			self.BindInstanceProperty("velocity", get_velocity, set_velocity);
			self.BindInstanceProperty("flexibleHeight", get_flexibleHeight, null);
			self.BindInstanceProperty("verticalScrollbarSpacing", get_verticalScrollbarSpacing, set_verticalScrollbarSpacing);
			self.BindInstanceProperty("verticalScrollbar", get_verticalScrollbar, set_verticalScrollbar);
			self.BindInstanceProperty("horizontalScrollbar", get_horizontalScrollbar, set_horizontalScrollbar);
			self.BindInstanceProperty("viewport", get_viewport, set_viewport);
			self.BindInstanceProperty("scrollSensitivity", get_scrollSensitivity, set_scrollSensitivity);
			self.BindInstanceProperty("decelerationRate", get_decelerationRate, set_decelerationRate);
			self.BindInstanceProperty("inertia", get_inertia, set_inertia);
			self.BindInstanceProperty("elasticity", get_elasticity, set_elasticity);
			self.BindInstanceProperty("vertical", get_vertical, set_vertical);
			self.BindInstanceProperty("horizontal", get_horizontal, set_horizontal);
			self.BindInstanceProperty("horizontalScrollbarSpacing", get_horizontalScrollbarSpacing, set_horizontalScrollbarSpacing);
			self.BindInstanceProperty("layoutPriority", get_layoutPriority, null);
		}

		static private void CalculateLayoutInputHorizontal(UnityEngine.UI.ScrollRect instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ScrollRect.CalculateLayoutInputHorizontal has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void CalculateLayoutInputVertical(UnityEngine.UI.ScrollRect instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ScrollRect.CalculateLayoutInputVertical has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void GraphicUpdateComplete(UnityEngine.UI.ScrollRect instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ScrollRect.GraphicUpdateComplete has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean IsActive(UnityEngine.UI.ScrollRect instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsActive();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ScrollRect.IsActive has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private void LayoutComplete(UnityEngine.UI.ScrollRect instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ScrollRect.LayoutComplete has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void OnBeginDrag(UnityEngine.UI.ScrollRect instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnBeginDrag(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.ScrollRect.OnBeginDrag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ScrollRect.OnBeginDrag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnDrag(UnityEngine.UI.ScrollRect instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnDrag(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.ScrollRect.OnDrag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ScrollRect.OnDrag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnEndDrag(UnityEngine.UI.ScrollRect instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnEndDrag(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.ScrollRect.OnEndDrag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ScrollRect.OnEndDrag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnInitializePotentialDrag(UnityEngine.UI.ScrollRect instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnInitializePotentialDrag(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.ScrollRect.OnInitializePotentialDrag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ScrollRect.OnInitializePotentialDrag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnScroll(UnityEngine.UI.ScrollRect instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnScroll(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.ScrollRect.OnScroll has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ScrollRect.OnScroll has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Rebuild(UnityEngine.UI.ScrollRect instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.CanvasUpdate>())
			{
				instance.Rebuild(parameters[0].ToObject<UnityEngine.UI.CanvasUpdate>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.ScrollRect.Rebuild has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ScrollRect.Rebuild has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetLayoutHorizontal(UnityEngine.UI.ScrollRect instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.SetLayoutHorizontal();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ScrollRect.SetLayoutHorizontal has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetLayoutVertical(UnityEngine.UI.ScrollRect instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.SetLayoutVertical();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ScrollRect.SetLayoutVertical has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void StopMovement(UnityEngine.UI.ScrollRect instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.StopMovement();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ScrollRect.StopMovement has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.RectTransform get_content(UnityEngine.UI.ScrollRect instance)
		{
			return instance.content;
		}

		static private void set_content(UnityEngine.UI.ScrollRect instance, UnityEngine.RectTransform value)
		{
			instance.content = value;
		}

		static private System.Single get_preferredHeight(UnityEngine.UI.ScrollRect instance)
		{
			return instance.preferredHeight;
		}

		static private System.Single get_minHeight(UnityEngine.UI.ScrollRect instance)
		{
			return instance.minHeight;
		}

		static private System.Single get_flexibleWidth(UnityEngine.UI.ScrollRect instance)
		{
			return instance.flexibleWidth;
		}

		static private System.Single get_preferredWidth(UnityEngine.UI.ScrollRect instance)
		{
			return instance.preferredWidth;
		}

		static private System.Single get_minWidth(UnityEngine.UI.ScrollRect instance)
		{
			return instance.minWidth;
		}

		static private System.Single get_verticalNormalizedPosition(UnityEngine.UI.ScrollRect instance)
		{
			return instance.verticalNormalizedPosition;
		}

		static private void set_verticalNormalizedPosition(UnityEngine.UI.ScrollRect instance, System.Single value)
		{
			instance.verticalNormalizedPosition = value;
		}

		static private System.Single get_horizontalNormalizedPosition(UnityEngine.UI.ScrollRect instance)
		{
			return instance.horizontalNormalizedPosition;
		}

		static private void set_horizontalNormalizedPosition(UnityEngine.UI.ScrollRect instance, System.Single value)
		{
			instance.horizontalNormalizedPosition = value;
		}

		static private UnityEngine.Vector2 get_normalizedPosition(UnityEngine.UI.ScrollRect instance)
		{
			return instance.normalizedPosition;
		}

		static private void set_normalizedPosition(UnityEngine.UI.ScrollRect instance, UnityEngine.Vector2 value)
		{
			instance.normalizedPosition = value;
		}

		static private UnityEngine.Vector2 get_velocity(UnityEngine.UI.ScrollRect instance)
		{
			return instance.velocity;
		}

		static private void set_velocity(UnityEngine.UI.ScrollRect instance, UnityEngine.Vector2 value)
		{
			instance.velocity = value;
		}

		static private System.Single get_flexibleHeight(UnityEngine.UI.ScrollRect instance)
		{
			return instance.flexibleHeight;
		}

		static private System.Single get_verticalScrollbarSpacing(UnityEngine.UI.ScrollRect instance)
		{
			return instance.verticalScrollbarSpacing;
		}

		static private void set_verticalScrollbarSpacing(UnityEngine.UI.ScrollRect instance, System.Single value)
		{
			instance.verticalScrollbarSpacing = value;
		}

		static private UnityEngine.UI.Scrollbar get_verticalScrollbar(UnityEngine.UI.ScrollRect instance)
		{
			return instance.verticalScrollbar;
		}

		static private void set_verticalScrollbar(UnityEngine.UI.ScrollRect instance, UnityEngine.UI.Scrollbar value)
		{
			instance.verticalScrollbar = value;
		}

		static private UnityEngine.UI.Scrollbar get_horizontalScrollbar(UnityEngine.UI.ScrollRect instance)
		{
			return instance.horizontalScrollbar;
		}

		static private void set_horizontalScrollbar(UnityEngine.UI.ScrollRect instance, UnityEngine.UI.Scrollbar value)
		{
			instance.horizontalScrollbar = value;
		}

		static private UnityEngine.RectTransform get_viewport(UnityEngine.UI.ScrollRect instance)
		{
			return instance.viewport;
		}

		static private void set_viewport(UnityEngine.UI.ScrollRect instance, UnityEngine.RectTransform value)
		{
			instance.viewport = value;
		}

		static private System.Single get_scrollSensitivity(UnityEngine.UI.ScrollRect instance)
		{
			return instance.scrollSensitivity;
		}

		static private void set_scrollSensitivity(UnityEngine.UI.ScrollRect instance, System.Single value)
		{
			instance.scrollSensitivity = value;
		}

		static private System.Single get_decelerationRate(UnityEngine.UI.ScrollRect instance)
		{
			return instance.decelerationRate;
		}

		static private void set_decelerationRate(UnityEngine.UI.ScrollRect instance, System.Single value)
		{
			instance.decelerationRate = value;
		}

		static private System.Boolean get_inertia(UnityEngine.UI.ScrollRect instance)
		{
			return instance.inertia;
		}

		static private void set_inertia(UnityEngine.UI.ScrollRect instance, System.Boolean value)
		{
			instance.inertia = value;
		}

		static private System.Single get_elasticity(UnityEngine.UI.ScrollRect instance)
		{
			return instance.elasticity;
		}

		static private void set_elasticity(UnityEngine.UI.ScrollRect instance, System.Single value)
		{
			instance.elasticity = value;
		}

		static private System.Boolean get_vertical(UnityEngine.UI.ScrollRect instance)
		{
			return instance.vertical;
		}

		static private void set_vertical(UnityEngine.UI.ScrollRect instance, System.Boolean value)
		{
			instance.vertical = value;
		}

		static private System.Boolean get_horizontal(UnityEngine.UI.ScrollRect instance)
		{
			return instance.horizontal;
		}

		static private void set_horizontal(UnityEngine.UI.ScrollRect instance, System.Boolean value)
		{
			instance.horizontal = value;
		}

		static private System.Single get_horizontalScrollbarSpacing(UnityEngine.UI.ScrollRect instance)
		{
			return instance.horizontalScrollbarSpacing;
		}

		static private void set_horizontalScrollbarSpacing(UnityEngine.UI.ScrollRect instance, System.Single value)
		{
			instance.horizontalScrollbarSpacing = value;
		}

		static private System.Int32 get_layoutPriority(UnityEngine.UI.ScrollRect instance)
		{
			return instance.layoutPriority;
		}

	}
}
