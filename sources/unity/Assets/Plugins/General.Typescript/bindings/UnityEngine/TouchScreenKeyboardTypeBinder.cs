#if !UNITY_STANDALONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTouchScreenKeyboardType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.TouchScreenKeyboardType> instance = space.DeclareEnum<UnityEngine.TouchScreenKeyboardType>();
			instance.SetValue("Default", (long)UnityEngine.TouchScreenKeyboardType.Default);
			instance.SetValue("ASCIICapable", (long)UnityEngine.TouchScreenKeyboardType.ASCIICapable);
			instance.SetValue("NumbersAndPunctuation", (long)UnityEngine.TouchScreenKeyboardType.NumbersAndPunctuation);
			instance.SetValue("URL", (long)UnityEngine.TouchScreenKeyboardType.URL);
			instance.SetValue("NumberPad", (long)UnityEngine.TouchScreenKeyboardType.NumberPad);
			instance.SetValue("PhonePad", (long)UnityEngine.TouchScreenKeyboardType.PhonePad);
			instance.SetValue("NamePhonePad", (long)UnityEngine.TouchScreenKeyboardType.NamePhonePad);
			instance.SetValue("EmailAddress", (long)UnityEngine.TouchScreenKeyboardType.EmailAddress);
			instance.SetValue("Social", (long)UnityEngine.TouchScreenKeyboardType.Social);
			instance.SetValue("Search", (long)UnityEngine.TouchScreenKeyboardType.Search);
			instance.SetValue("DecimalPad", (long)UnityEngine.TouchScreenKeyboardType.DecimalPad);
		}
	}
}
#endif
