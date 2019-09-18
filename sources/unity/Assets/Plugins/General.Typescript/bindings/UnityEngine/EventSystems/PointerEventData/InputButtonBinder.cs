using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineEventSystemsPointerEventDataInputButton
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.EventSystems.PointerEventData.InputButton> instance = space.DeclareEnum<UnityEngine.EventSystems.PointerEventData.InputButton>();
			instance.SetValue("Left", (long)UnityEngine.EventSystems.PointerEventData.InputButton.Left);
			instance.SetValue("Right", (long)UnityEngine.EventSystems.PointerEventData.InputButton.Right);
			instance.SetValue("Middle", (long)UnityEngine.EventSystems.PointerEventData.InputButton.Middle);
		}
	}
}
