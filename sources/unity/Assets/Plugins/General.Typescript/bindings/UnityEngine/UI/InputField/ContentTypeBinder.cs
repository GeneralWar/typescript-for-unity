using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIInputFieldContentType
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.UI.InputField.ContentType> instance = space.DeclareEnum<UnityEngine.UI.InputField.ContentType>();
			instance.SetValue("Standard", (long)UnityEngine.UI.InputField.ContentType.Standard);
			instance.SetValue("Autocorrected", (long)UnityEngine.UI.InputField.ContentType.Autocorrected);
			instance.SetValue("IntegerNumber", (long)UnityEngine.UI.InputField.ContentType.IntegerNumber);
			instance.SetValue("DecimalNumber", (long)UnityEngine.UI.InputField.ContentType.DecimalNumber);
			instance.SetValue("Alphanumeric", (long)UnityEngine.UI.InputField.ContentType.Alphanumeric);
			instance.SetValue("Name", (long)UnityEngine.UI.InputField.ContentType.Name);
			instance.SetValue("EmailAddress", (long)UnityEngine.UI.InputField.ContentType.EmailAddress);
			instance.SetValue("Password", (long)UnityEngine.UI.InputField.ContentType.Password);
			instance.SetValue("Pin", (long)UnityEngine.UI.InputField.ContentType.Pin);
			instance.SetValue("Custom", (long)UnityEngine.UI.InputField.ContentType.Custom);
		}
	}
}
