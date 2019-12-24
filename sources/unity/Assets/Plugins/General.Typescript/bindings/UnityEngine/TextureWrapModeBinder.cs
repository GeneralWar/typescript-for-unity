using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTextureWrapMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.TextureWrapMode> instance = space.DeclareEnum<UnityEngine.TextureWrapMode>();
			instance.SetValue("Repeat", (long)UnityEngine.TextureWrapMode.Repeat);
			instance.SetValue("Clamp", (long)UnityEngine.TextureWrapMode.Clamp);
			instance.SetValue("Mirror", (long)UnityEngine.TextureWrapMode.Mirror);
			instance.SetValue("MirrorOnce", (long)UnityEngine.TextureWrapMode.MirrorOnce);
		}
	}
}
