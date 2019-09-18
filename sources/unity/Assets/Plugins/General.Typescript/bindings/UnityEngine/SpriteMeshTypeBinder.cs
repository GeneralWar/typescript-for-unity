using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSpriteMeshType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.SpriteMeshType> instance = space.DeclareEnum<UnityEngine.SpriteMeshType>();
			instance.SetValue("FullRect", (long)UnityEngine.SpriteMeshType.FullRect);
			instance.SetValue("Tight", (long)UnityEngine.SpriteMeshType.Tight);
		}
	}
}
