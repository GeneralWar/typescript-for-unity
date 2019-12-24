using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTexture2DEXRFlags
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.Texture2D.EXRFlags> instance = space.DeclareEnum<UnityEngine.Texture2D.EXRFlags>();
			instance.SetValue("None", (long)UnityEngine.Texture2D.EXRFlags.None);
			instance.SetValue("OutputAsFloat", (long)UnityEngine.Texture2D.EXRFlags.OutputAsFloat);
			instance.SetValue("CompressZIP", (long)UnityEngine.Texture2D.EXRFlags.CompressZIP);
			instance.SetValue("CompressRLE", (long)UnityEngine.Texture2D.EXRFlags.CompressRLE);
			instance.SetValue("CompressPIZ", (long)UnityEngine.Texture2D.EXRFlags.CompressPIZ);
		}
	}
}
