using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSpriteSortPoint
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.SpriteSortPoint> instance = space.DeclareEnum<UnityEngine.SpriteSortPoint>();
			instance.SetValue("Center", (long)UnityEngine.SpriteSortPoint.Center);
			instance.SetValue("Pivot", (long)UnityEngine.SpriteSortPoint.Pivot);
		}
	}
}
