using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIGraphicRaycasterBlockingObjects
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.GraphicRaycaster.BlockingObjects> instance = space.DeclareEnum<UnityEngine.UI.GraphicRaycaster.BlockingObjects>();
			instance.SetValue("None", (long)UnityEngine.UI.GraphicRaycaster.BlockingObjects.None);
			instance.SetValue("TwoD", (long)UnityEngine.UI.GraphicRaycaster.BlockingObjects.TwoD);
			instance.SetValue("ThreeD", (long)UnityEngine.UI.GraphicRaycaster.BlockingObjects.ThreeD);
			instance.SetValue("All", (long)UnityEngine.UI.GraphicRaycaster.BlockingObjects.All);
		}
	}
}
