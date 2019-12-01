using UnityEngine;

namespace General.Typescript
{
	public class SystemNetConfigurationWebUtilityElement
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Configuration.WebUtilityElement> self = space.DeclareClass<System.Net.Configuration.WebUtilityElement>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("UnicodeDecodingConformance", get_UnicodeDecodingConformance, set_UnicodeDecodingConformance);
			self.BindInstanceProperty("UnicodeEncodingConformance", get_UnicodeEncodingConformance, set_UnicodeEncodingConformance);
		}

		static private System.Net.Configuration.WebUtilityElement Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.Configuration.WebUtilityElement();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Configuration.WebUtilityElement.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.Configuration.WebUtilityElement);
		}

		static private System.Net.Configuration.UnicodeDecodingConformance get_UnicodeDecodingConformance(System.Net.Configuration.WebUtilityElement instance)
		{
			return instance.UnicodeDecodingConformance;
		}

		static private void set_UnicodeDecodingConformance(System.Net.Configuration.WebUtilityElement instance, System.Net.Configuration.UnicodeDecodingConformance value)
		{
			instance.UnicodeDecodingConformance = value;
		}

		static private System.Net.Configuration.UnicodeEncodingConformance get_UnicodeEncodingConformance(System.Net.Configuration.WebUtilityElement instance)
		{
			return instance.UnicodeEncodingConformance;
		}

		static private void set_UnicodeEncodingConformance(System.Net.Configuration.WebUtilityElement instance, System.Net.Configuration.UnicodeEncodingConformance value)
		{
			instance.UnicodeEncodingConformance = value;
		}

	}
}
