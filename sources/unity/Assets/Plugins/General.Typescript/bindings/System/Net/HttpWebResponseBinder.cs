using UnityEngine;

namespace General.Typescript
{
	public class SystemNetHttpWebResponse
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.HttpWebResponse> self = space.DeclareClass<System.Net.HttpWebResponse>();
			self.BindConstructor();
			self.BindInstanceFunction("Close", Close);
			self.BindInstanceFunction("GetResponseHeader", GetResponseHeader);
			self.BindInstanceFunction("GetResponseStream", GetResponseStream);
			self.BindInstanceProperty("CharacterSet", get_CharacterSet, null);
			self.BindInstanceProperty("ContentEncoding", get_ContentEncoding, null);
			self.BindInstanceProperty("ContentLength", get_ContentLength, null);
			self.BindInstanceProperty("ContentType", get_ContentType, null);
			self.BindInstanceProperty("Cookies", get_Cookies, set_Cookies);
			self.BindInstanceProperty("Headers", get_Headers, null);
			self.BindInstanceProperty("IsMutuallyAuthenticated", get_IsMutuallyAuthenticated, null);
			self.BindInstanceProperty("LastModified", get_LastModified, null);
			self.BindInstanceProperty("Method", get_Method, null);
			self.BindInstanceProperty("ProtocolVersion", get_ProtocolVersion, null);
			self.BindInstanceProperty("ResponseUri", get_ResponseUri, null);
			self.BindInstanceProperty("Server", get_Server, null);
			self.BindInstanceProperty("StatusCode", get_StatusCode, null);
			self.BindInstanceProperty("StatusDescription", get_StatusDescription, null);
			self.BindInstanceProperty("SupportsHeaders", get_SupportsHeaders, null);
		}

		static private void Close(System.Net.HttpWebResponse instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Close();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.HttpWebResponse.Close has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.String GetResponseHeader(System.Net.HttpWebResponse instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetResponseHeader(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.HttpWebResponse.GetResponseHeader has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.HttpWebResponse.GetResponseHeader has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.IO.Stream GetResponseStream(System.Net.HttpWebResponse instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetResponseStream();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.HttpWebResponse.GetResponseStream has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.String get_CharacterSet(System.Net.HttpWebResponse instance)
		{
			return instance.CharacterSet;
		}

		static private System.String get_ContentEncoding(System.Net.HttpWebResponse instance)
		{
			return instance.ContentEncoding;
		}

		static private System.Int64 get_ContentLength(System.Net.HttpWebResponse instance)
		{
			return instance.ContentLength;
		}

		static private System.String get_ContentType(System.Net.HttpWebResponse instance)
		{
			return instance.ContentType;
		}

		static private System.Net.CookieCollection get_Cookies(System.Net.HttpWebResponse instance)
		{
			return instance.Cookies;
		}

		static private void set_Cookies(System.Net.HttpWebResponse instance, System.Net.CookieCollection value)
		{
			instance.Cookies = value;
		}

		static private System.Net.WebHeaderCollection get_Headers(System.Net.HttpWebResponse instance)
		{
			return instance.Headers;
		}

		static private System.Boolean get_IsMutuallyAuthenticated(System.Net.HttpWebResponse instance)
		{
			return instance.IsMutuallyAuthenticated;
		}

		static private System.DateTime get_LastModified(System.Net.HttpWebResponse instance)
		{
			return instance.LastModified;
		}

		static private System.String get_Method(System.Net.HttpWebResponse instance)
		{
			return instance.Method;
		}

		static private System.Version get_ProtocolVersion(System.Net.HttpWebResponse instance)
		{
			return instance.ProtocolVersion;
		}

		static private System.Uri get_ResponseUri(System.Net.HttpWebResponse instance)
		{
			return instance.ResponseUri;
		}

		static private System.String get_Server(System.Net.HttpWebResponse instance)
		{
			return instance.Server;
		}

		static private System.Net.HttpStatusCode get_StatusCode(System.Net.HttpWebResponse instance)
		{
			return instance.StatusCode;
		}

		static private System.String get_StatusDescription(System.Net.HttpWebResponse instance)
		{
			return instance.StatusDescription;
		}

		static private System.Boolean get_SupportsHeaders(System.Net.HttpWebResponse instance)
		{
			return instance.SupportsHeaders;
		}

	}
}
