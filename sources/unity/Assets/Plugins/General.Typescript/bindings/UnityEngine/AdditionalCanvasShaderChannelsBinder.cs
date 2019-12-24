using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAdditionalCanvasShaderChannels
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.AdditionalCanvasShaderChannels> instance = space.DeclareEnum<UnityEngine.AdditionalCanvasShaderChannels>();
			instance.SetValue("None", (long)UnityEngine.AdditionalCanvasShaderChannels.None);
			instance.SetValue("TexCoord1", (long)UnityEngine.AdditionalCanvasShaderChannels.TexCoord1);
			instance.SetValue("TexCoord2", (long)UnityEngine.AdditionalCanvasShaderChannels.TexCoord2);
			instance.SetValue("TexCoord3", (long)UnityEngine.AdditionalCanvasShaderChannels.TexCoord3);
			instance.SetValue("Normal", (long)UnityEngine.AdditionalCanvasShaderChannels.Normal);
			instance.SetValue("Tangent", (long)UnityEngine.AdditionalCanvasShaderChannels.Tangent);
		}
	}
}
