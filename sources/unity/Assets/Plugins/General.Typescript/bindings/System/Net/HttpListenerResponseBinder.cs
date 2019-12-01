using UnityEngine;

namespace General.Typescript
{
	public class SystemNetHttpListenerResponse
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.HttpListenerResponse> self = space.DeclareClass<System.Net.HttpListenerResponse>();
			self.BindConstructor();
			self.BindInstanceFunction("Abort", Abort);
			self.BindInstanceFunction("AddHeader", AddHeader);
			self.BindInstanceFunction("AppendCookie", AppendCookie);
			self.BindInstanceFunction("AppendHeader", AppendHeader);
			self.BindInstanceFunction("Close", Close);
			self.BindInstanceFunction("CopyFrom", CopyFrom);
			self.BindInstanceFunction("Redirect", Redirect);
			self.BindInstanceFunction("SetCookie", SetCookie);
			self.BindInstanceProperty("ContentEncoding", get_ContentEncoding, set_ContentEncoding);
			self.BindInstanceProperty("ContentLength64", get_ContentLength64, set_ContentLength64);
			self.BindInstanceProperty("ContentType", get_ContentType, set_ContentType);
			self.BindInstanceProperty("Cookies", get_Cookies, set_Cookies);
			self.BindInstanceProperty("Headers", get_Headers, set_Headers);
			self.BindInstanceProperty("KeepAlive", get_KeepAlive, set_KeepAlive);
			self.BindInstanceProperty("OutputStream", get_OutputStream, null);
			self.BindInstanceProperty("ProtocolVersion", get_ProtocolVersion, set_ProtocolVersion);
			self.BindInstanceProperty("RedirectLocation", get_RedirectLocation, set_RedirectLocation);
			self.BindInstanceProperty("SendChunked", get_SendChunked, set_SendChunked);
			self.BindInstanceProperty("StatusCode", get_StatusCode, set_StatusCode);
			self.BindInstanceProperty("StatusDescription", get_StatusDescription, set_StatusDescription);
		}

		static private void Abort(System.Net.HttpListenerResponse instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Abort();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.HttpListenerResponse.Abort has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void AddHeader(System.Net.HttpListenerResponse instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.String>())
			{
				instance.AddHeader(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.HttpListenerResponse.AddHeader has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.HttpListenerResponse.AddHeader has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void AppendCookie(System.Net.HttpListenerResponse instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Cookie>())
			{
				instance.AppendCookie(parameters[0].ToObject<System.Net.Cookie>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.HttpListenerResponse.AppendCookie has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.HttpListenerResponse.AppendCookie has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void AppendHeader(System.Net.HttpListenerResponse instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.String>())
			{
				instance.AppendHeader(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.HttpListenerResponse.AppendHeader has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.HttpListenerResponse.AppendHeader has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Close(System.Net.HttpListenerResponse instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Close();
			}
			if (parameters.CheckTypes<System.Byte[], System.Boolean>())
			{
				instance.Close(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.HttpListenerResponse.Close has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void CopyFrom(System.Net.HttpListenerResponse instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.HttpListenerResponse>())
			{
				instance.CopyFrom(parameters[0].ToObject<System.Net.HttpListenerResponse>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.HttpListenerResponse.CopyFrom has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.HttpListenerResponse.CopyFrom has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Redirect(System.Net.HttpListenerResponse instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.Redirect(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.HttpListenerResponse.Redirect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.HttpListenerResponse.Redirect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetCookie(System.Net.HttpListenerResponse instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.Cookie>())
			{
				instance.SetCookie(parameters[0].ToObject<System.Net.Cookie>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.HttpListenerResponse.SetCookie has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.HttpListenerResponse.SetCookie has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Text.Encoding get_ContentEncoding(System.Net.HttpListenerResponse instance)
		{
			return instance.ContentEncoding;
		}

		static private void set_ContentEncoding(System.Net.HttpListenerResponse instance, System.Text.Encoding value)
		{
			instance.ContentEncoding = value;
		}

		static private System.Int64 get_ContentLength64(System.Net.HttpListenerResponse instance)
		{
			return instance.ContentLength64;
		}

		static private void set_ContentLength64(System.Net.HttpListenerResponse instance, System.Int64 value)
		{
			instance.ContentLength64 = value;
		}

		static private System.String get_ContentType(System.Net.HttpListenerResponse instance)
		{
			return instance.ContentType;
		}

		static private void set_ContentType(System.Net.HttpListenerResponse instance, System.String value)
		{
			instance.ContentType = value;
		}

		static private System.Net.CookieCollection get_Cookies(System.Net.HttpListenerResponse instance)
		{
			return instance.Cookies;
		}

		static private void set_Cookies(System.Net.HttpListenerResponse instance, System.Net.CookieCollection value)
		{
			instance.Cookies = value;
		}

		static private System.Net.WebHeaderCollection get_Headers(System.Net.HttpListenerResponse instance)
		{
			return instance.Headers;
		}

		static private void set_Headers(System.Net.HttpListenerResponse instance, System.Net.WebHeaderCollection value)
		{
			instance.Headers = value;
		}

		static private System.Boolean get_KeepAlive(System.Net.HttpListenerResponse instance)
		{
			return instance.KeepAlive;
		}

		static private void set_KeepAlive(System.Net.HttpListenerResponse instance, System.Boolean value)
		{
			instance.KeepAlive = value;
		}

		static private System.IO.Stream get_OutputStream(System.Net.HttpListenerResponse instance)
		{
			return instance.OutputStream;
		}

		static private System.Version get_ProtocolVersion(System.Net.HttpListenerResponse instance)
		{
			return instance.ProtocolVersion;
		}

		static private void set_ProtocolVersion(System.Net.HttpListenerResponse instance, System.Version value)
		{
			instance.ProtocolVersion = value;
		}

		static private System.String get_RedirectLocation(System.Net.HttpListenerResponse instance)
		{
			return instance.RedirectLocation;
		}

		static private void set_RedirectLocation(System.Net.HttpListenerResponse instance, System.String value)
		{
			instance.RedirectLocation = value;
		}

		static private System.Boolean get_SendChunked(System.Net.HttpListenerResponse instance)
		{
			return instance.SendChunked;
		}

		static private void set_SendChunked(System.Net.HttpListenerResponse instance, System.Boolean value)
		{
			instance.SendChunked = value;
		}

		static private System.Int32 get_StatusCode(System.Net.HttpListenerResponse instance)
		{
			return instance.StatusCode;
		}

		static private void set_StatusCode(System.Net.HttpListenerResponse instance, System.Int32 value)
		{
			instance.StatusCode = value;
		}

		static private System.String get_StatusDescription(System.Net.HttpListenerResponse instance)
		{
			return instance.StatusDescription;
		}

		static private void set_StatusDescription(System.Net.HttpListenerResponse instance, System.String value)
		{
			instance.StatusDescription = value;
		}

	}
}
