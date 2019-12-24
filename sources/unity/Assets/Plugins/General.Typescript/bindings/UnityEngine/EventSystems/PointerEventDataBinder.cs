using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineEventSystemsPointerEventData
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.EventSystems.PointerEventData> self = space.DeclareClass<UnityEngine.EventSystems.PointerEventData>();
			UnityEngineEventSystemsPointerEventDataFramePressState.Bind(self);
			UnityEngineEventSystemsPointerEventDataInputButton.Bind(self);
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("IsPointerMoving", IsPointerMoving);
			self.BindInstanceFunction("IsScrolling", IsScrolling);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("pointerEnter", get_pointerEnter, set_pointerEnter);
			self.BindInstanceProperty("enterEventCamera", get_enterEventCamera, null);
			self.BindInstanceProperty("dragging", get_dragging, set_dragging);
			self.BindInstanceProperty("useDragThreshold", get_useDragThreshold, set_useDragThreshold);
			self.BindInstanceProperty("scrollDelta", get_scrollDelta, set_scrollDelta);
			self.BindInstanceProperty("clickCount", get_clickCount, set_clickCount);
			self.BindInstanceProperty("clickTime", get_clickTime, set_clickTime);
			self.BindInstanceProperty("pressPosition", get_pressPosition, set_pressPosition);
			self.BindInstanceProperty("pressEventCamera", get_pressEventCamera, null);
			self.BindInstanceProperty("delta", get_delta, set_delta);
			self.BindInstanceProperty("pointerId", get_pointerId, set_pointerId);
			self.BindInstanceProperty("eligibleForClick", get_eligibleForClick, set_eligibleForClick);
			self.BindInstanceProperty("pointerPressRaycast", get_pointerPressRaycast, set_pointerPressRaycast);
			self.BindInstanceProperty("pointerCurrentRaycast", get_pointerCurrentRaycast, set_pointerCurrentRaycast);
			self.BindInstanceProperty("pointerDrag", get_pointerDrag, set_pointerDrag);
			self.BindInstanceProperty("rawPointerPress", get_rawPointerPress, set_rawPointerPress);
			self.BindInstanceProperty("lastPress", get_lastPress, null);
			self.BindInstanceProperty("position", get_position, set_position);
			self.BindInstanceProperty("pointerPress", get_pointerPress, set_pointerPress);
		}

		static private UnityEngine.EventSystems.PointerEventData Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.EventSystem>())
			{
				return new UnityEngine.EventSystems.PointerEventData(parameters[0].ToObject<UnityEngine.EventSystems.EventSystem>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.PointerEventData.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.PointerEventData.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.EventSystems.PointerEventData);
		}

		static private System.Boolean IsPointerMoving(UnityEngine.EventSystems.PointerEventData instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsPointerMoving();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.PointerEventData.IsPointerMoving has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.Boolean IsScrolling(UnityEngine.EventSystems.PointerEventData instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsScrolling();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.PointerEventData.IsScrolling has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.String ToString(UnityEngine.EventSystems.PointerEventData instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.PointerEventData.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.GameObject get_pointerEnter(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.pointerEnter;
		}

		static private void set_pointerEnter(UnityEngine.EventSystems.PointerEventData instance, string name, UnityEngine.GameObject value)
		{
			instance.pointerEnter = value;
		}

		static private UnityEngine.Camera get_enterEventCamera(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.enterEventCamera;
		}

		static private System.Boolean get_dragging(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.dragging;
		}

		static private void set_dragging(UnityEngine.EventSystems.PointerEventData instance, string name, System.Boolean value)
		{
			instance.dragging = value;
		}

		static private System.Boolean get_useDragThreshold(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.useDragThreshold;
		}

		static private void set_useDragThreshold(UnityEngine.EventSystems.PointerEventData instance, string name, System.Boolean value)
		{
			instance.useDragThreshold = value;
		}

		static private UnityEngine.Vector2 get_scrollDelta(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.scrollDelta;
		}

		static private void set_scrollDelta(UnityEngine.EventSystems.PointerEventData instance, string name, UnityEngine.Vector2 value)
		{
			instance.scrollDelta = value;
		}

		static private System.Int32 get_clickCount(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.clickCount;
		}

		static private void set_clickCount(UnityEngine.EventSystems.PointerEventData instance, string name, System.Int32 value)
		{
			instance.clickCount = value;
		}

		static private System.Single get_clickTime(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.clickTime;
		}

		static private void set_clickTime(UnityEngine.EventSystems.PointerEventData instance, string name, System.Single value)
		{
			instance.clickTime = value;
		}

		static private UnityEngine.Vector2 get_pressPosition(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.pressPosition;
		}

		static private void set_pressPosition(UnityEngine.EventSystems.PointerEventData instance, string name, UnityEngine.Vector2 value)
		{
			instance.pressPosition = value;
		}

		static private UnityEngine.Camera get_pressEventCamera(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.pressEventCamera;
		}

		static private UnityEngine.Vector2 get_delta(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.delta;
		}

		static private void set_delta(UnityEngine.EventSystems.PointerEventData instance, string name, UnityEngine.Vector2 value)
		{
			instance.delta = value;
		}

		static private System.Int32 get_pointerId(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.pointerId;
		}

		static private void set_pointerId(UnityEngine.EventSystems.PointerEventData instance, string name, System.Int32 value)
		{
			instance.pointerId = value;
		}

		static private System.Boolean get_eligibleForClick(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.eligibleForClick;
		}

		static private void set_eligibleForClick(UnityEngine.EventSystems.PointerEventData instance, string name, System.Boolean value)
		{
			instance.eligibleForClick = value;
		}

		static private UnityEngine.EventSystems.RaycastResult get_pointerPressRaycast(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.pointerPressRaycast;
		}

		static private void set_pointerPressRaycast(UnityEngine.EventSystems.PointerEventData instance, string name, UnityEngine.EventSystems.RaycastResult value)
		{
			instance.pointerPressRaycast = value;
		}

		static private UnityEngine.EventSystems.RaycastResult get_pointerCurrentRaycast(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.pointerCurrentRaycast;
		}

		static private void set_pointerCurrentRaycast(UnityEngine.EventSystems.PointerEventData instance, string name, UnityEngine.EventSystems.RaycastResult value)
		{
			instance.pointerCurrentRaycast = value;
		}

		static private UnityEngine.GameObject get_pointerDrag(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.pointerDrag;
		}

		static private void set_pointerDrag(UnityEngine.EventSystems.PointerEventData instance, string name, UnityEngine.GameObject value)
		{
			instance.pointerDrag = value;
		}

		static private UnityEngine.GameObject get_rawPointerPress(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.rawPointerPress;
		}

		static private void set_rawPointerPress(UnityEngine.EventSystems.PointerEventData instance, string name, UnityEngine.GameObject value)
		{
			instance.rawPointerPress = value;
		}

		static private UnityEngine.GameObject get_lastPress(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.lastPress;
		}

		static private UnityEngine.Vector2 get_position(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.position;
		}

		static private void set_position(UnityEngine.EventSystems.PointerEventData instance, string name, UnityEngine.Vector2 value)
		{
			instance.position = value;
		}

		static private UnityEngine.GameObject get_pointerPress(UnityEngine.EventSystems.PointerEventData instance, string name)
		{
			return instance.pointerPress;
		}

		static private void set_pointerPress(UnityEngine.EventSystems.PointerEventData instance, string name, UnityEngine.GameObject value)
		{
			instance.pointerPress = value;
		}

	}
}
