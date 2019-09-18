#if !UNITY_STANDALONE_WIN && !UNITY_IPHONE && !UNITY_ANDROID
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTextureCompressionQuality
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.TextureCompressionQuality> instance = space.DeclareEnum<UnityEngine.TextureCompressionQuality>();
			instance.SetValue("Fast", (long)UnityEngine.TextureCompressionQuality.Fast);
			instance.SetValue("Normal", (long)UnityEngine.TextureCompressionQuality.Normal);
			instance.SetValue("Best", (long)UnityEngine.TextureCompressionQuality.Best);
		}
	}
}
#endif
