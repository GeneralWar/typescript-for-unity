using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIInputFieldInputType
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.InputField.InputType> instance = space.DeclareEnum<UnityEngine.UI.InputField.InputType>();
			instance.SetValue("Standard", (long)UnityEngine.UI.InputField.InputType.Standard);
			instance.SetValue("AutoCorrect", (long)UnityEngine.UI.InputField.InputType.AutoCorrect);
			instance.SetValue("Password", (long)UnityEngine.UI.InputField.InputType.Password);
		}
	}
}
