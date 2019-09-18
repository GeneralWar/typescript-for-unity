using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineColorGamut
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.ColorGamut> instance = space.DeclareEnum<UnityEngine.ColorGamut>();
			instance.SetValue("sRGB", (long)UnityEngine.ColorGamut.sRGB);
			instance.SetValue("Rec709", (long)UnityEngine.ColorGamut.Rec709);
			instance.SetValue("Rec2020", (long)UnityEngine.ColorGamut.Rec2020);
			instance.SetValue("DisplayP3", (long)UnityEngine.ColorGamut.DisplayP3);
			instance.SetValue("HDR10", (long)UnityEngine.ColorGamut.HDR10);
			instance.SetValue("DolbyHDR", (long)UnityEngine.ColorGamut.DolbyHDR);
		}
	}
}
