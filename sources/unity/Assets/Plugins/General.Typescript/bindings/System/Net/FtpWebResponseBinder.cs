using UnityEngine;

namespace General.Typescript
{
	public class SystemNetFtpWebResponse
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.FtpWebResponse> self = space.DeclareClass<System.Net.FtpWebResponse>();
			self.BindConstructor();
			self.BindInstanceFunction("Close", Close);
			self.BindInstanceFunction("GetResponseStream", GetResponseStream);
			self.BindInstanceProperty("ContentLength", get_ContentLength, null);
			self.BindInstanceProperty("Headers", get_Headers, null);
			self.BindInstanceProperty("ResponseUri", get_ResponseUri, null);
			self.BindInstanceProperty("LastModified", get_LastModified, null);
			self.BindInstanceProperty("BannerMessage", get_BannerMessage, null);
			self.BindInstanceProperty("WelcomeMessage", get_WelcomeMessage, null);
			self.BindInstanceProperty("ExitMessage", get_ExitMessage, null);
			self.BindInstanceProperty("StatusCode", get_StatusCode, null);
			self.BindInstanceProperty("SupportsHeaders", get_SupportsHeaders, null);
			self.BindInstanceProperty("StatusDescription", get_StatusDescription, null);
		}

		static private void Close(System.Net.FtpWebResponse instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.FtpWebResponse.Close has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.IO.Stream GetResponseStream(System.Net.FtpWebResponse instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.FtpWebResponse.GetResponseStream has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Int64 get_ContentLength(System.Net.FtpWebResponse instance)
		{
			return instance.ContentLength;
		}

		static private System.Net.WebHeaderCollection get_Headers(System.Net.FtpWebResponse instance)
		{
			return instance.Headers;
		}

		static private System.Uri get_ResponseUri(System.Net.FtpWebResponse instance)
		{
			return instance.ResponseUri;
		}

		static private System.DateTime get_LastModified(System.Net.FtpWebResponse instance)
		{
			return instance.LastModified;
		}

		static private System.String get_BannerMessage(System.Net.FtpWebResponse instance)
		{
			return instance.BannerMessage;
		}

		static private System.String get_WelcomeMessage(System.Net.FtpWebResponse instance)
		{
			return instance.WelcomeMessage;
		}

		static private System.String get_ExitMessage(System.Net.FtpWebResponse instance)
		{
			return instance.ExitMessage;
		}

		static private System.Net.FtpStatusCode get_StatusCode(System.Net.FtpWebResponse instance)
		{
			return instance.StatusCode;
		}

		static private System.Boolean get_SupportsHeaders(System.Net.FtpWebResponse instance)
		{
			return instance.SupportsHeaders;
		}

		static private System.String get_StatusDescription(System.Net.FtpWebResponse instance)
		{
			return instance.StatusDescription;
		}

	}
}
