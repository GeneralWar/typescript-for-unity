using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIInputFieldCharacterValidation
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.InputField.CharacterValidation> instance = space.DeclareEnum<UnityEngine.UI.InputField.CharacterValidation>();
			instance.SetValue("None", (long)UnityEngine.UI.InputField.CharacterValidation.None);
			instance.SetValue("Integer", (long)UnityEngine.UI.InputField.CharacterValidation.Integer);
			instance.SetValue("Decimal", (long)UnityEngine.UI.InputField.CharacterValidation.Decimal);
			instance.SetValue("Alphanumeric", (long)UnityEngine.UI.InputField.CharacterValidation.Alphanumeric);
			instance.SetValue("Name", (long)UnityEngine.UI.InputField.CharacterValidation.Name);
			instance.SetValue("EmailAddress", (long)UnityEngine.UI.InputField.CharacterValidation.EmailAddress);
		}
	}
}
