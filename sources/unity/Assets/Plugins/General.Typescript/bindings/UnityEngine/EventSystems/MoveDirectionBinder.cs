using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineEventSystemsMoveDirection
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.EventSystems.MoveDirection> instance = space.DeclareEnum<UnityEngine.EventSystems.MoveDirection>();
			instance.SetValue("Left", (long)UnityEngine.EventSystems.MoveDirection.Left);
			instance.SetValue("Up", (long)UnityEngine.EventSystems.MoveDirection.Up);
			instance.SetValue("Right", (long)UnityEngine.EventSystems.MoveDirection.Right);
			instance.SetValue("Down", (long)UnityEngine.EventSystems.MoveDirection.Down);
			instance.SetValue("None", (long)UnityEngine.EventSystems.MoveDirection.None);
		}
	}
}
