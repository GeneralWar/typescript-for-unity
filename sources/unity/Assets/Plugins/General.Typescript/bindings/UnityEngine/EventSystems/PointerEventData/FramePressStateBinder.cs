using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineEventSystemsPointerEventDataFramePressState
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.EventSystems.PointerEventData.FramePressState> instance = space.DeclareEnum<UnityEngine.EventSystems.PointerEventData.FramePressState>();
			instance.SetValue("Pressed", (long)UnityEngine.EventSystems.PointerEventData.FramePressState.Pressed);
			instance.SetValue("Released", (long)UnityEngine.EventSystems.PointerEventData.FramePressState.Released);
			instance.SetValue("PressedAndReleased", (long)UnityEngine.EventSystems.PointerEventData.FramePressState.PressedAndReleased);
			instance.SetValue("NotChanged", (long)UnityEngine.EventSystems.PointerEventData.FramePressState.NotChanged);
		}
	}
}
