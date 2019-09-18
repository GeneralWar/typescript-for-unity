using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIScrollRectMovementType
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.ScrollRect.MovementType> instance = space.DeclareEnum<UnityEngine.UI.ScrollRect.MovementType>();
			instance.SetValue("Unrestricted", (long)UnityEngine.UI.ScrollRect.MovementType.Unrestricted);
			instance.SetValue("Elastic", (long)UnityEngine.UI.ScrollRect.MovementType.Elastic);
			instance.SetValue("Clamped", (long)UnityEngine.UI.ScrollRect.MovementType.Clamped);
		}
	}
}
