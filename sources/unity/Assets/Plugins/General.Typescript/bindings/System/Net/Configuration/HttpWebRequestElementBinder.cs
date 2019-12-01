using UnityEngine;

namespace General.Typescript
{
	public class SystemNetConfigurationHttpWebRequestElement
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Configuration.HttpWebRequestElement> self = space.DeclareClass<System.Net.Configuration.HttpWebRequestElement>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("MaximumErrorResponseLength", get_MaximumErrorResponseLength, set_MaximumErrorResponseLength);
			self.BindInstanceProperty("MaximumResponseHeadersLength", get_MaximumResponseHeadersLength, set_MaximumResponseHeadersLength);
			self.BindInstanceProperty("MaximumUnauthorizedUploadLength", get_MaximumUnauthorizedUploadLength, set_MaximumUnauthorizedUploadLength);
			self.BindInstanceProperty("UseUnsafeHeaderParsing", get_UseUnsafeHeaderParsing, set_UseUnsafeHeaderParsing);
		}

		static private System.Net.Configuration.HttpWebRequestElement Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.Configuration.HttpWebRequestElement();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Configuration.HttpWebRequestElement.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.Configuration.HttpWebRequestElement);
		}

		static private System.Int32 get_MaximumErrorResponseLength(System.Net.Configuration.HttpWebRequestElement instance)
		{
			return instance.MaximumErrorResponseLength;
		}

		static private void set_MaximumErrorResponseLength(System.Net.Configuration.HttpWebRequestElement instance, System.Int32 value)
		{
			instance.MaximumErrorResponseLength = value;
		}

		static private System.Int32 get_MaximumResponseHeadersLength(System.Net.Configuration.HttpWebRequestElement instance)
		{
			return instance.MaximumResponseHeadersLength;
		}

		static private void set_MaximumResponseHeadersLength(System.Net.Configuration.HttpWebRequestElement instance, System.Int32 value)
		{
			instance.MaximumResponseHeadersLength = value;
		}

		static private System.Int32 get_MaximumUnauthorizedUploadLength(System.Net.Configuration.HttpWebRequestElement instance)
		{
			return instance.MaximumUnauthorizedUploadLength;
		}

		static private void set_MaximumUnauthorizedUploadLength(System.Net.Configuration.HttpWebRequestElement instance, System.Int32 value)
		{
			instance.MaximumUnauthorizedUploadLength = value;
		}

		static private System.Boolean get_UseUnsafeHeaderParsing(System.Net.Configuration.HttpWebRequestElement instance)
		{
			return instance.UseUnsafeHeaderParsing;
		}

		static private void set_UseUnsafeHeaderParsing(System.Net.Configuration.HttpWebRequestElement instance, System.Boolean value)
		{
			instance.UseUnsafeHeaderParsing = value;
		}

	}
}
