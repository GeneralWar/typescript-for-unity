using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSystemLanguage
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.SystemLanguage> instance = space.DeclareEnum<UnityEngine.SystemLanguage>();
			instance.SetValue("Afrikaans", (long)UnityEngine.SystemLanguage.Afrikaans);
			instance.SetValue("Arabic", (long)UnityEngine.SystemLanguage.Arabic);
			instance.SetValue("Basque", (long)UnityEngine.SystemLanguage.Basque);
			instance.SetValue("Belarusian", (long)UnityEngine.SystemLanguage.Belarusian);
			instance.SetValue("Bulgarian", (long)UnityEngine.SystemLanguage.Bulgarian);
			instance.SetValue("Catalan", (long)UnityEngine.SystemLanguage.Catalan);
			instance.SetValue("Chinese", (long)UnityEngine.SystemLanguage.Chinese);
			instance.SetValue("Czech", (long)UnityEngine.SystemLanguage.Czech);
			instance.SetValue("Danish", (long)UnityEngine.SystemLanguage.Danish);
			instance.SetValue("Dutch", (long)UnityEngine.SystemLanguage.Dutch);
			instance.SetValue("English", (long)UnityEngine.SystemLanguage.English);
			instance.SetValue("Estonian", (long)UnityEngine.SystemLanguage.Estonian);
			instance.SetValue("Faroese", (long)UnityEngine.SystemLanguage.Faroese);
			instance.SetValue("Finnish", (long)UnityEngine.SystemLanguage.Finnish);
			instance.SetValue("French", (long)UnityEngine.SystemLanguage.French);
			instance.SetValue("German", (long)UnityEngine.SystemLanguage.German);
			instance.SetValue("Greek", (long)UnityEngine.SystemLanguage.Greek);
			instance.SetValue("Hebrew", (long)UnityEngine.SystemLanguage.Hebrew);
			instance.SetValue("Hungarian", (long)UnityEngine.SystemLanguage.Hungarian);
			instance.SetValue("Icelandic", (long)UnityEngine.SystemLanguage.Icelandic);
			instance.SetValue("Indonesian", (long)UnityEngine.SystemLanguage.Indonesian);
			instance.SetValue("Italian", (long)UnityEngine.SystemLanguage.Italian);
			instance.SetValue("Japanese", (long)UnityEngine.SystemLanguage.Japanese);
			instance.SetValue("Korean", (long)UnityEngine.SystemLanguage.Korean);
			instance.SetValue("Latvian", (long)UnityEngine.SystemLanguage.Latvian);
			instance.SetValue("Lithuanian", (long)UnityEngine.SystemLanguage.Lithuanian);
			instance.SetValue("Norwegian", (long)UnityEngine.SystemLanguage.Norwegian);
			instance.SetValue("Polish", (long)UnityEngine.SystemLanguage.Polish);
			instance.SetValue("Portuguese", (long)UnityEngine.SystemLanguage.Portuguese);
			instance.SetValue("Romanian", (long)UnityEngine.SystemLanguage.Romanian);
			instance.SetValue("Russian", (long)UnityEngine.SystemLanguage.Russian);
			instance.SetValue("SerboCroatian", (long)UnityEngine.SystemLanguage.SerboCroatian);
			instance.SetValue("Slovak", (long)UnityEngine.SystemLanguage.Slovak);
			instance.SetValue("Slovenian", (long)UnityEngine.SystemLanguage.Slovenian);
			instance.SetValue("Spanish", (long)UnityEngine.SystemLanguage.Spanish);
			instance.SetValue("Swedish", (long)UnityEngine.SystemLanguage.Swedish);
			instance.SetValue("Thai", (long)UnityEngine.SystemLanguage.Thai);
			instance.SetValue("Turkish", (long)UnityEngine.SystemLanguage.Turkish);
			instance.SetValue("Ukrainian", (long)UnityEngine.SystemLanguage.Ukrainian);
			instance.SetValue("Vietnamese", (long)UnityEngine.SystemLanguage.Vietnamese);
			instance.SetValue("ChineseSimplified", (long)UnityEngine.SystemLanguage.ChineseSimplified);
			instance.SetValue("ChineseTraditional", (long)UnityEngine.SystemLanguage.ChineseTraditional);
			instance.SetValue("Unknown", (long)UnityEngine.SystemLanguage.Unknown);
		}
	}
}
