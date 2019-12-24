using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIInputFieldLineType
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.InputField.LineType> instance = space.DeclareEnum<UnityEngine.UI.InputField.LineType>();
			instance.SetValue("SingleLine", (long)UnityEngine.UI.InputField.LineType.SingleLine);
			instance.SetValue("MultiLineSubmit", (long)UnityEngine.UI.InputField.LineType.MultiLineSubmit);
			instance.SetValue("MultiLineNewline", (long)UnityEngine.UI.InputField.LineType.MultiLineNewline);
		}
	}
}
