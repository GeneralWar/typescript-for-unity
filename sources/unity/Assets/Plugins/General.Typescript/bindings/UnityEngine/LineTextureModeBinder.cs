using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLineTextureMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.LineTextureMode> instance = space.DeclareEnum<UnityEngine.LineTextureMode>();
			instance.SetValue("Stretch", (long)UnityEngine.LineTextureMode.Stretch);
			instance.SetValue("Tile", (long)UnityEngine.LineTextureMode.Tile);
			instance.SetValue("DistributePerSegment", (long)UnityEngine.LineTextureMode.DistributePerSegment);
			instance.SetValue("RepeatPerSegment", (long)UnityEngine.LineTextureMode.RepeatPerSegment);
		}
	}
}
