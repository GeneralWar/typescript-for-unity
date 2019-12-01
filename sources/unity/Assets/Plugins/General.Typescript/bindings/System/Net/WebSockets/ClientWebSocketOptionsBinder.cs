using UnityEngine;

namespace General.Typescript
{
	public class SystemNetWebSocketsClientWebSocketOptions
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.WebSockets.ClientWebSocketOptions> self = space.DeclareClass<System.Net.WebSockets.ClientWebSocketOptions>();
			self.BindConstructor();
			self.BindInstanceFunction("AddSubProtocol", AddSubProtocol);
			self.BindInstanceFunction("SetBuffer", SetBuffer);
			self.BindInstanceFunction("SetRequestHeader", SetRequestHeader);
			self.BindInstanceProperty("UseDefaultCredentials", get_UseDefaultCredentials, set_UseDefaultCredentials);
			self.BindInstanceProperty("Credentials", get_Credentials, set_Credentials);
			self.BindInstanceProperty("Proxy", get_Proxy, set_Proxy);
			self.BindInstanceProperty("ClientCertificates", get_ClientCertificates, set_ClientCertificates);
			self.BindInstanceProperty("Cookies", get_Cookies, set_Cookies);
			self.BindInstanceProperty("KeepAliveInterval", get_KeepAliveInterval, set_KeepAliveInterval);
		}

		static private void AddSubProtocol(System.Net.WebSockets.ClientWebSocketOptions instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.AddSubProtocol(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebSockets.ClientWebSocketOptions.AddSubProtocol has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebSockets.ClientWebSocketOptions.AddSubProtocol has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetBuffer(System.Net.WebSockets.ClientWebSocketOptions instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				instance.SetBuffer(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebSockets.ClientWebSocketOptions.SetBuffer has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebSockets.ClientWebSocketOptions.SetBuffer has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetRequestHeader(System.Net.WebSockets.ClientWebSocketOptions instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.String>())
			{
				instance.SetRequestHeader(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebSockets.ClientWebSocketOptions.SetRequestHeader has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebSockets.ClientWebSocketOptions.SetRequestHeader has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean get_UseDefaultCredentials(System.Net.WebSockets.ClientWebSocketOptions instance)
		{
			return instance.UseDefaultCredentials;
		}

		static private void set_UseDefaultCredentials(System.Net.WebSockets.ClientWebSocketOptions instance, System.Boolean value)
		{
			instance.UseDefaultCredentials = value;
		}

		static private System.Net.ICredentials get_Credentials(System.Net.WebSockets.ClientWebSocketOptions instance)
		{
			return instance.Credentials;
		}

		static private void set_Credentials(System.Net.WebSockets.ClientWebSocketOptions instance, System.Net.ICredentials value)
		{
			instance.Credentials = value;
		}

		static private System.Net.IWebProxy get_Proxy(System.Net.WebSockets.ClientWebSocketOptions instance)
		{
			return instance.Proxy;
		}

		static private void set_Proxy(System.Net.WebSockets.ClientWebSocketOptions instance, System.Net.IWebProxy value)
		{
			instance.Proxy = value;
		}

		static private System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates(System.Net.WebSockets.ClientWebSocketOptions instance)
		{
			return instance.ClientCertificates;
		}

		static private void set_ClientCertificates(System.Net.WebSockets.ClientWebSocketOptions instance, System.Security.Cryptography.X509Certificates.X509CertificateCollection value)
		{
			instance.ClientCertificates = value;
		}

		static private System.Net.CookieContainer get_Cookies(System.Net.WebSockets.ClientWebSocketOptions instance)
		{
			return instance.Cookies;
		}

		static private void set_Cookies(System.Net.WebSockets.ClientWebSocketOptions instance, System.Net.CookieContainer value)
		{
			instance.Cookies = value;
		}

		static private System.TimeSpan get_KeepAliveInterval(System.Net.WebSockets.ClientWebSocketOptions instance)
		{
			return instance.KeepAliveInterval;
		}

		static private void set_KeepAliveInterval(System.Net.WebSockets.ClientWebSocketOptions instance, System.TimeSpan value)
		{
			instance.KeepAliveInterval = value;
		}

	}
}
