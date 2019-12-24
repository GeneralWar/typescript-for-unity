using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemNetFtpWebRequest
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.FtpWebRequest> self = space.DeclareClass<System.Net.FtpWebRequest>();
			self.BindConstructor();
			self.BindInstanceFunction("Abort", Abort);
			self.BindInstanceFunction("EndGetRequestStream", EndGetRequestStream);
			self.BindInstanceFunction("EndGetResponse", EndGetResponse);
			self.BindInstanceFunction("GetRequestStream", GetRequestStream);
			self.BindInstanceFunction("GetResponse", GetResponse);
			self.BindStaticProperty("DefaultCachePolicy", get_DefaultCachePolicy, set_DefaultCachePolicy);
			self.BindInstanceProperty("ClientCertificates", get_ClientCertificates, set_ClientCertificates);
			self.BindInstanceProperty("UseDefaultCredentials", get_UseDefaultCredentials, set_UseDefaultCredentials);
			self.BindInstanceProperty("UsePassive", get_UsePassive, set_UsePassive);
			self.BindInstanceProperty("ServicePoint", get_ServicePoint, null);
			self.BindInstanceProperty("RequestUri", get_RequestUri, null);
			self.BindInstanceProperty("RenameTo", get_RenameTo, set_RenameTo);
			self.BindInstanceProperty("ReadWriteTimeout", get_ReadWriteTimeout, set_ReadWriteTimeout);
			self.BindInstanceProperty("Proxy", get_Proxy, set_Proxy);
			self.BindInstanceProperty("PreAuthenticate", get_PreAuthenticate, set_PreAuthenticate);
			self.BindInstanceProperty("Method", get_Method, set_Method);
			self.BindInstanceProperty("KeepAlive", get_KeepAlive, set_KeepAlive);
			self.BindInstanceProperty("Headers", get_Headers, set_Headers);
			self.BindInstanceProperty("EnableSsl", get_EnableSsl, set_EnableSsl);
			self.BindInstanceProperty("Credentials", get_Credentials, set_Credentials);
			self.BindInstanceProperty("ContentOffset", get_ContentOffset, set_ContentOffset);
			self.BindInstanceProperty("ContentLength", get_ContentLength, set_ContentLength);
			self.BindInstanceProperty("ContentType", get_ContentType, set_ContentType);
			self.BindInstanceProperty("ConnectionGroupName", get_ConnectionGroupName, set_ConnectionGroupName);
			self.BindInstanceProperty("UseBinary", get_UseBinary, set_UseBinary);
			self.BindInstanceProperty("Timeout", get_Timeout, set_Timeout);
		}

		static private void Abort(System.Net.FtpWebRequest instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.FtpWebRequest.Abort has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.IO.Stream EndGetRequestStream(System.Net.FtpWebRequest instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndGetRequestStream(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.FtpWebRequest.EndGetRequestStream has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.FtpWebRequest.EndGetRequestStream has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Net.WebResponse EndGetResponse(System.Net.FtpWebRequest instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndGetResponse(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.FtpWebRequest.EndGetResponse has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.FtpWebRequest.EndGetResponse has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.IO.Stream GetRequestStream(System.Net.FtpWebRequest instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetRequestStream();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.FtpWebRequest.GetRequestStream has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Net.WebResponse GetResponse(System.Net.FtpWebRequest instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetResponse();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.FtpWebRequest.GetResponse has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Net.Cache.RequestCachePolicy get_DefaultCachePolicy(Type type, string name)
		{
			return System.Net.FtpWebRequest.DefaultCachePolicy;
		}

		static private void set_DefaultCachePolicy(Type type, string name, System.Net.Cache.RequestCachePolicy value)
		{
			System.Net.FtpWebRequest.DefaultCachePolicy = value;
		}

		static private System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates(System.Net.FtpWebRequest instance, string name)
		{
			return instance.ClientCertificates;
		}

		static private void set_ClientCertificates(System.Net.FtpWebRequest instance, string name, System.Security.Cryptography.X509Certificates.X509CertificateCollection value)
		{
			instance.ClientCertificates = value;
		}

		static private System.Boolean get_UseDefaultCredentials(System.Net.FtpWebRequest instance, string name)
		{
			return instance.UseDefaultCredentials;
		}

		static private void set_UseDefaultCredentials(System.Net.FtpWebRequest instance, string name, System.Boolean value)
		{
			instance.UseDefaultCredentials = value;
		}

		static private System.Boolean get_UsePassive(System.Net.FtpWebRequest instance, string name)
		{
			return instance.UsePassive;
		}

		static private void set_UsePassive(System.Net.FtpWebRequest instance, string name, System.Boolean value)
		{
			instance.UsePassive = value;
		}

		static private System.Net.ServicePoint get_ServicePoint(System.Net.FtpWebRequest instance, string name)
		{
			return instance.ServicePoint;
		}

		static private System.Uri get_RequestUri(System.Net.FtpWebRequest instance, string name)
		{
			return instance.RequestUri;
		}

		static private System.String get_RenameTo(System.Net.FtpWebRequest instance, string name)
		{
			return instance.RenameTo;
		}

		static private void set_RenameTo(System.Net.FtpWebRequest instance, string name, System.String value)
		{
			instance.RenameTo = value;
		}

		static private System.Int32 get_ReadWriteTimeout(System.Net.FtpWebRequest instance, string name)
		{
			return instance.ReadWriteTimeout;
		}

		static private void set_ReadWriteTimeout(System.Net.FtpWebRequest instance, string name, System.Int32 value)
		{
			instance.ReadWriteTimeout = value;
		}

		static private System.Net.IWebProxy get_Proxy(System.Net.FtpWebRequest instance, string name)
		{
			return instance.Proxy;
		}

		static private void set_Proxy(System.Net.FtpWebRequest instance, string name, System.Net.IWebProxy value)
		{
			instance.Proxy = value;
		}

		static private System.Boolean get_PreAuthenticate(System.Net.FtpWebRequest instance, string name)
		{
			return instance.PreAuthenticate;
		}

		static private void set_PreAuthenticate(System.Net.FtpWebRequest instance, string name, System.Boolean value)
		{
			instance.PreAuthenticate = value;
		}

		static private System.String get_Method(System.Net.FtpWebRequest instance, string name)
		{
			return instance.Method;
		}

		static private void set_Method(System.Net.FtpWebRequest instance, string name, System.String value)
		{
			instance.Method = value;
		}

		static private System.Boolean get_KeepAlive(System.Net.FtpWebRequest instance, string name)
		{
			return instance.KeepAlive;
		}

		static private void set_KeepAlive(System.Net.FtpWebRequest instance, string name, System.Boolean value)
		{
			instance.KeepAlive = value;
		}

		static private System.Net.WebHeaderCollection get_Headers(System.Net.FtpWebRequest instance, string name)
		{
			return instance.Headers;
		}

		static private void set_Headers(System.Net.FtpWebRequest instance, string name, System.Net.WebHeaderCollection value)
		{
			instance.Headers = value;
		}

		static private System.Boolean get_EnableSsl(System.Net.FtpWebRequest instance, string name)
		{
			return instance.EnableSsl;
		}

		static private void set_EnableSsl(System.Net.FtpWebRequest instance, string name, System.Boolean value)
		{
			instance.EnableSsl = value;
		}

		static private System.Net.ICredentials get_Credentials(System.Net.FtpWebRequest instance, string name)
		{
			return instance.Credentials;
		}

		static private void set_Credentials(System.Net.FtpWebRequest instance, string name, System.Net.ICredentials value)
		{
			instance.Credentials = value;
		}

		static private System.Int64 get_ContentOffset(System.Net.FtpWebRequest instance, string name)
		{
			return instance.ContentOffset;
		}

		static private void set_ContentOffset(System.Net.FtpWebRequest instance, string name, System.Int64 value)
		{
			instance.ContentOffset = value;
		}

		static private System.Int64 get_ContentLength(System.Net.FtpWebRequest instance, string name)
		{
			return instance.ContentLength;
		}

		static private void set_ContentLength(System.Net.FtpWebRequest instance, string name, System.Int64 value)
		{
			instance.ContentLength = value;
		}

		static private System.String get_ContentType(System.Net.FtpWebRequest instance, string name)
		{
			return instance.ContentType;
		}

		static private void set_ContentType(System.Net.FtpWebRequest instance, string name, System.String value)
		{
			instance.ContentType = value;
		}

		static private System.String get_ConnectionGroupName(System.Net.FtpWebRequest instance, string name)
		{
			return instance.ConnectionGroupName;
		}

		static private void set_ConnectionGroupName(System.Net.FtpWebRequest instance, string name, System.String value)
		{
			instance.ConnectionGroupName = value;
		}

		static private System.Boolean get_UseBinary(System.Net.FtpWebRequest instance, string name)
		{
			return instance.UseBinary;
		}

		static private void set_UseBinary(System.Net.FtpWebRequest instance, string name, System.Boolean value)
		{
			instance.UseBinary = value;
		}

		static private System.Int32 get_Timeout(System.Net.FtpWebRequest instance, string name)
		{
			return instance.Timeout;
		}

		static private void set_Timeout(System.Net.FtpWebRequest instance, string name, System.Int32 value)
		{
			instance.Timeout = value;
		}

	}
}
