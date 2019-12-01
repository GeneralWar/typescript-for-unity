using UnityEngine;

namespace General.Typescript
{
	public class SystemNetHttpWebRequest
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.HttpWebRequest> self = space.DeclareClass<System.Net.HttpWebRequest>();
			self.BindConstructor();
			self.BindInstanceFunction("Abort", Abort);
			self.BindInstanceFunction("AddRange", AddRange);
			self.BindInstanceFunction("EndGetRequestStream", EndGetRequestStream);
			self.BindInstanceFunction("EndGetResponse", EndGetResponse);
			self.BindInstanceFunction("GetRequestStream", GetRequestStream);
			self.BindInstanceFunction("GetResponse", GetResponse);
			self.BindStaticProperty("DefaultCachePolicy", get_DefaultCachePolicy, set_DefaultCachePolicy);
			self.BindStaticProperty("DefaultMaximumErrorResponseLength", get_DefaultMaximumErrorResponseLength, set_DefaultMaximumErrorResponseLength);
			self.BindStaticProperty("DefaultMaximumResponseHeadersLength", get_DefaultMaximumResponseHeadersLength, set_DefaultMaximumResponseHeadersLength);
			self.BindInstanceProperty("Accept", get_Accept, set_Accept);
			self.BindInstanceProperty("ReadWriteTimeout", get_ReadWriteTimeout, set_ReadWriteTimeout);
			self.BindInstanceProperty("ContinueTimeout", get_ContinueTimeout, set_ContinueTimeout);
			self.BindInstanceProperty("MediaType", get_MediaType, set_MediaType);
			self.BindInstanceProperty("Method", get_Method, set_Method);
			self.BindInstanceProperty("Pipelined", get_Pipelined, set_Pipelined);
			self.BindInstanceProperty("PreAuthenticate", get_PreAuthenticate, set_PreAuthenticate);
			self.BindInstanceProperty("ProtocolVersion", get_ProtocolVersion, set_ProtocolVersion);
			self.BindInstanceProperty("Proxy", get_Proxy, set_Proxy);
			self.BindInstanceProperty("Referer", get_Referer, set_Referer);
			self.BindInstanceProperty("RequestUri", get_RequestUri, null);
			self.BindInstanceProperty("SendChunked", get_SendChunked, set_SendChunked);
			self.BindInstanceProperty("ServicePoint", get_ServicePoint, null);
			self.BindInstanceProperty("SupportsCookieContainer", get_SupportsCookieContainer, null);
			self.BindInstanceProperty("Timeout", get_Timeout, set_Timeout);
			self.BindInstanceProperty("TransferEncoding", get_TransferEncoding, set_TransferEncoding);
			self.BindInstanceProperty("UseDefaultCredentials", get_UseDefaultCredentials, set_UseDefaultCredentials);
			self.BindInstanceProperty("UserAgent", get_UserAgent, set_UserAgent);
			self.BindInstanceProperty("MaximumResponseHeadersLength", get_MaximumResponseHeadersLength, set_MaximumResponseHeadersLength);
			self.BindInstanceProperty("MaximumAutomaticRedirections", get_MaximumAutomaticRedirections, set_MaximumAutomaticRedirections);
			self.BindInstanceProperty("KeepAlive", get_KeepAlive, set_KeepAlive);
			self.BindInstanceProperty("IfModifiedSince", get_IfModifiedSince, set_IfModifiedSince);
			self.BindInstanceProperty("Address", get_Address, null);
			self.BindInstanceProperty("AllowAutoRedirect", get_AllowAutoRedirect, set_AllowAutoRedirect);
			self.BindInstanceProperty("AllowWriteStreamBuffering", get_AllowWriteStreamBuffering, set_AllowWriteStreamBuffering);
			self.BindInstanceProperty("AllowReadStreamBuffering", get_AllowReadStreamBuffering, set_AllowReadStreamBuffering);
			self.BindInstanceProperty("AutomaticDecompression", get_AutomaticDecompression, set_AutomaticDecompression);
			self.BindInstanceProperty("ClientCertificates", get_ClientCertificates, set_ClientCertificates);
			self.BindInstanceProperty("Connection", get_Connection, set_Connection);
			self.BindInstanceProperty("ConnectionGroupName", get_ConnectionGroupName, set_ConnectionGroupName);
			self.BindInstanceProperty("UnsafeAuthenticatedConnectionSharing", get_UnsafeAuthenticatedConnectionSharing, set_UnsafeAuthenticatedConnectionSharing);
			self.BindInstanceProperty("ContentLength", get_ContentLength, set_ContentLength);
			self.BindInstanceProperty("ContinueDelegate", get_ContinueDelegate, set_ContinueDelegate);
			self.BindInstanceProperty("CookieContainer", get_CookieContainer, set_CookieContainer);
			self.BindInstanceProperty("Credentials", get_Credentials, set_Credentials);
			self.BindInstanceProperty("Date", get_Date, set_Date);
			self.BindInstanceProperty("Expect", get_Expect, set_Expect);
			self.BindInstanceProperty("HaveResponse", get_HaveResponse, null);
			self.BindInstanceProperty("Headers", get_Headers, set_Headers);
			self.BindInstanceProperty("Host", get_Host, set_Host);
			self.BindInstanceProperty("ContentType", get_ContentType, set_ContentType);
			self.BindInstanceProperty("ServerCertificateValidationCallback", get_ServerCertificateValidationCallback, set_ServerCertificateValidationCallback);
		}

		static private void Abort(System.Net.HttpWebRequest instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.HttpWebRequest.Abort has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void AddRange(System.Net.HttpWebRequest instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.AddRange(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int64>())
			{
				instance.AddRange(parameters[0].ToObject<System.Int64>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				instance.AddRange(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Int32>())
			{
				instance.AddRange(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int64, System.Int64>())
			{
				instance.AddRange(parameters[0].ToObject<System.Int64>(), parameters[1].ToObject<System.Int64>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Int64>())
			{
				instance.AddRange(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int64>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Int32, System.Int32>())
			{
				instance.AddRange(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Int64, System.Int64>())
			{
				instance.AddRange(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int64>(), parameters[2].ToObject<System.Int64>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.HttpWebRequest.AddRange has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.HttpWebRequest.AddRange has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.IO.Stream EndGetRequestStream(System.Net.HttpWebRequest instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndGetRequestStream(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.HttpWebRequest.EndGetRequestStream has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.HttpWebRequest.EndGetRequestStream has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Net.WebResponse EndGetResponse(System.Net.HttpWebRequest instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndGetResponse(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.HttpWebRequest.EndGetResponse has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.HttpWebRequest.EndGetResponse has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.IO.Stream GetRequestStream(System.Net.HttpWebRequest instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.HttpWebRequest.GetRequestStream has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Net.WebResponse GetResponse(System.Net.HttpWebRequest instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.HttpWebRequest.GetResponse has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Net.Cache.RequestCachePolicy get_DefaultCachePolicy()
		{
			return System.Net.HttpWebRequest.DefaultCachePolicy;
		}

		static private void set_DefaultCachePolicy(System.Net.Cache.RequestCachePolicy value)
		{
			System.Net.HttpWebRequest.DefaultCachePolicy = value;
		}

		static private System.Int32 get_DefaultMaximumErrorResponseLength()
		{
			return System.Net.HttpWebRequest.DefaultMaximumErrorResponseLength;
		}

		static private void set_DefaultMaximumErrorResponseLength(System.Int32 value)
		{
			System.Net.HttpWebRequest.DefaultMaximumErrorResponseLength = value;
		}

		static private System.Int32 get_DefaultMaximumResponseHeadersLength()
		{
			return System.Net.HttpWebRequest.DefaultMaximumResponseHeadersLength;
		}

		static private void set_DefaultMaximumResponseHeadersLength(System.Int32 value)
		{
			System.Net.HttpWebRequest.DefaultMaximumResponseHeadersLength = value;
		}

		static private System.String get_Accept(System.Net.HttpWebRequest instance)
		{
			return instance.Accept;
		}

		static private void set_Accept(System.Net.HttpWebRequest instance, System.String value)
		{
			instance.Accept = value;
		}

		static private System.Int32 get_ReadWriteTimeout(System.Net.HttpWebRequest instance)
		{
			return instance.ReadWriteTimeout;
		}

		static private void set_ReadWriteTimeout(System.Net.HttpWebRequest instance, System.Int32 value)
		{
			instance.ReadWriteTimeout = value;
		}

		static private System.Int32 get_ContinueTimeout(System.Net.HttpWebRequest instance)
		{
			return instance.ContinueTimeout;
		}

		static private void set_ContinueTimeout(System.Net.HttpWebRequest instance, System.Int32 value)
		{
			instance.ContinueTimeout = value;
		}

		static private System.String get_MediaType(System.Net.HttpWebRequest instance)
		{
			return instance.MediaType;
		}

		static private void set_MediaType(System.Net.HttpWebRequest instance, System.String value)
		{
			instance.MediaType = value;
		}

		static private System.String get_Method(System.Net.HttpWebRequest instance)
		{
			return instance.Method;
		}

		static private void set_Method(System.Net.HttpWebRequest instance, System.String value)
		{
			instance.Method = value;
		}

		static private System.Boolean get_Pipelined(System.Net.HttpWebRequest instance)
		{
			return instance.Pipelined;
		}

		static private void set_Pipelined(System.Net.HttpWebRequest instance, System.Boolean value)
		{
			instance.Pipelined = value;
		}

		static private System.Boolean get_PreAuthenticate(System.Net.HttpWebRequest instance)
		{
			return instance.PreAuthenticate;
		}

		static private void set_PreAuthenticate(System.Net.HttpWebRequest instance, System.Boolean value)
		{
			instance.PreAuthenticate = value;
		}

		static private System.Version get_ProtocolVersion(System.Net.HttpWebRequest instance)
		{
			return instance.ProtocolVersion;
		}

		static private void set_ProtocolVersion(System.Net.HttpWebRequest instance, System.Version value)
		{
			instance.ProtocolVersion = value;
		}

		static private System.Net.IWebProxy get_Proxy(System.Net.HttpWebRequest instance)
		{
			return instance.Proxy;
		}

		static private void set_Proxy(System.Net.HttpWebRequest instance, System.Net.IWebProxy value)
		{
			instance.Proxy = value;
		}

		static private System.String get_Referer(System.Net.HttpWebRequest instance)
		{
			return instance.Referer;
		}

		static private void set_Referer(System.Net.HttpWebRequest instance, System.String value)
		{
			instance.Referer = value;
		}

		static private System.Uri get_RequestUri(System.Net.HttpWebRequest instance)
		{
			return instance.RequestUri;
		}

		static private System.Boolean get_SendChunked(System.Net.HttpWebRequest instance)
		{
			return instance.SendChunked;
		}

		static private void set_SendChunked(System.Net.HttpWebRequest instance, System.Boolean value)
		{
			instance.SendChunked = value;
		}

		static private System.Net.ServicePoint get_ServicePoint(System.Net.HttpWebRequest instance)
		{
			return instance.ServicePoint;
		}

		static private System.Boolean get_SupportsCookieContainer(System.Net.HttpWebRequest instance)
		{
			return instance.SupportsCookieContainer;
		}

		static private System.Int32 get_Timeout(System.Net.HttpWebRequest instance)
		{
			return instance.Timeout;
		}

		static private void set_Timeout(System.Net.HttpWebRequest instance, System.Int32 value)
		{
			instance.Timeout = value;
		}

		static private System.String get_TransferEncoding(System.Net.HttpWebRequest instance)
		{
			return instance.TransferEncoding;
		}

		static private void set_TransferEncoding(System.Net.HttpWebRequest instance, System.String value)
		{
			instance.TransferEncoding = value;
		}

		static private System.Boolean get_UseDefaultCredentials(System.Net.HttpWebRequest instance)
		{
			return instance.UseDefaultCredentials;
		}

		static private void set_UseDefaultCredentials(System.Net.HttpWebRequest instance, System.Boolean value)
		{
			instance.UseDefaultCredentials = value;
		}

		static private System.String get_UserAgent(System.Net.HttpWebRequest instance)
		{
			return instance.UserAgent;
		}

		static private void set_UserAgent(System.Net.HttpWebRequest instance, System.String value)
		{
			instance.UserAgent = value;
		}

		static private System.Int32 get_MaximumResponseHeadersLength(System.Net.HttpWebRequest instance)
		{
			return instance.MaximumResponseHeadersLength;
		}

		static private void set_MaximumResponseHeadersLength(System.Net.HttpWebRequest instance, System.Int32 value)
		{
			instance.MaximumResponseHeadersLength = value;
		}

		static private System.Int32 get_MaximumAutomaticRedirections(System.Net.HttpWebRequest instance)
		{
			return instance.MaximumAutomaticRedirections;
		}

		static private void set_MaximumAutomaticRedirections(System.Net.HttpWebRequest instance, System.Int32 value)
		{
			instance.MaximumAutomaticRedirections = value;
		}

		static private System.Boolean get_KeepAlive(System.Net.HttpWebRequest instance)
		{
			return instance.KeepAlive;
		}

		static private void set_KeepAlive(System.Net.HttpWebRequest instance, System.Boolean value)
		{
			instance.KeepAlive = value;
		}

		static private System.DateTime get_IfModifiedSince(System.Net.HttpWebRequest instance)
		{
			return instance.IfModifiedSince;
		}

		static private void set_IfModifiedSince(System.Net.HttpWebRequest instance, System.DateTime value)
		{
			instance.IfModifiedSince = value;
		}

		static private System.Uri get_Address(System.Net.HttpWebRequest instance)
		{
			return instance.Address;
		}

		static private System.Boolean get_AllowAutoRedirect(System.Net.HttpWebRequest instance)
		{
			return instance.AllowAutoRedirect;
		}

		static private void set_AllowAutoRedirect(System.Net.HttpWebRequest instance, System.Boolean value)
		{
			instance.AllowAutoRedirect = value;
		}

		static private System.Boolean get_AllowWriteStreamBuffering(System.Net.HttpWebRequest instance)
		{
			return instance.AllowWriteStreamBuffering;
		}

		static private void set_AllowWriteStreamBuffering(System.Net.HttpWebRequest instance, System.Boolean value)
		{
			instance.AllowWriteStreamBuffering = value;
		}

		static private System.Boolean get_AllowReadStreamBuffering(System.Net.HttpWebRequest instance)
		{
			return instance.AllowReadStreamBuffering;
		}

		static private void set_AllowReadStreamBuffering(System.Net.HttpWebRequest instance, System.Boolean value)
		{
			instance.AllowReadStreamBuffering = value;
		}

		static private System.Net.DecompressionMethods get_AutomaticDecompression(System.Net.HttpWebRequest instance)
		{
			return instance.AutomaticDecompression;
		}

		static private void set_AutomaticDecompression(System.Net.HttpWebRequest instance, System.Net.DecompressionMethods value)
		{
			instance.AutomaticDecompression = value;
		}

		static private System.Security.Cryptography.X509Certificates.X509CertificateCollection get_ClientCertificates(System.Net.HttpWebRequest instance)
		{
			return instance.ClientCertificates;
		}

		static private void set_ClientCertificates(System.Net.HttpWebRequest instance, System.Security.Cryptography.X509Certificates.X509CertificateCollection value)
		{
			instance.ClientCertificates = value;
		}

		static private System.String get_Connection(System.Net.HttpWebRequest instance)
		{
			return instance.Connection;
		}

		static private void set_Connection(System.Net.HttpWebRequest instance, System.String value)
		{
			instance.Connection = value;
		}

		static private System.String get_ConnectionGroupName(System.Net.HttpWebRequest instance)
		{
			return instance.ConnectionGroupName;
		}

		static private void set_ConnectionGroupName(System.Net.HttpWebRequest instance, System.String value)
		{
			instance.ConnectionGroupName = value;
		}

		static private System.Boolean get_UnsafeAuthenticatedConnectionSharing(System.Net.HttpWebRequest instance)
		{
			return instance.UnsafeAuthenticatedConnectionSharing;
		}

		static private void set_UnsafeAuthenticatedConnectionSharing(System.Net.HttpWebRequest instance, System.Boolean value)
		{
			instance.UnsafeAuthenticatedConnectionSharing = value;
		}

		static private System.Int64 get_ContentLength(System.Net.HttpWebRequest instance)
		{
			return instance.ContentLength;
		}

		static private void set_ContentLength(System.Net.HttpWebRequest instance, System.Int64 value)
		{
			instance.ContentLength = value;
		}

		static private System.Net.HttpContinueDelegate get_ContinueDelegate(System.Net.HttpWebRequest instance)
		{
			return instance.ContinueDelegate;
		}

		static private void set_ContinueDelegate(System.Net.HttpWebRequest instance, System.Net.HttpContinueDelegate value)
		{
			instance.ContinueDelegate = value;
		}

		static private System.Net.CookieContainer get_CookieContainer(System.Net.HttpWebRequest instance)
		{
			return instance.CookieContainer;
		}

		static private void set_CookieContainer(System.Net.HttpWebRequest instance, System.Net.CookieContainer value)
		{
			instance.CookieContainer = value;
		}

		static private System.Net.ICredentials get_Credentials(System.Net.HttpWebRequest instance)
		{
			return instance.Credentials;
		}

		static private void set_Credentials(System.Net.HttpWebRequest instance, System.Net.ICredentials value)
		{
			instance.Credentials = value;
		}

		static private System.DateTime get_Date(System.Net.HttpWebRequest instance)
		{
			return instance.Date;
		}

		static private void set_Date(System.Net.HttpWebRequest instance, System.DateTime value)
		{
			instance.Date = value;
		}

		static private System.String get_Expect(System.Net.HttpWebRequest instance)
		{
			return instance.Expect;
		}

		static private void set_Expect(System.Net.HttpWebRequest instance, System.String value)
		{
			instance.Expect = value;
		}

		static private System.Boolean get_HaveResponse(System.Net.HttpWebRequest instance)
		{
			return instance.HaveResponse;
		}

		static private System.Net.WebHeaderCollection get_Headers(System.Net.HttpWebRequest instance)
		{
			return instance.Headers;
		}

		static private void set_Headers(System.Net.HttpWebRequest instance, System.Net.WebHeaderCollection value)
		{
			instance.Headers = value;
		}

		static private System.String get_Host(System.Net.HttpWebRequest instance)
		{
			return instance.Host;
		}

		static private void set_Host(System.Net.HttpWebRequest instance, System.String value)
		{
			instance.Host = value;
		}

		static private System.String get_ContentType(System.Net.HttpWebRequest instance)
		{
			return instance.ContentType;
		}

		static private void set_ContentType(System.Net.HttpWebRequest instance, System.String value)
		{
			instance.ContentType = value;
		}

		static private System.Net.Security.RemoteCertificateValidationCallback get_ServerCertificateValidationCallback(System.Net.HttpWebRequest instance)
		{
			return instance.ServerCertificateValidationCallback;
		}

		static private void set_ServerCertificateValidationCallback(System.Net.HttpWebRequest instance, System.Net.Security.RemoteCertificateValidationCallback value)
		{
			instance.ServerCertificateValidationCallback = value;
		}

	}
}
