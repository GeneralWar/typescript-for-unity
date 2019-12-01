using UnityEngine;

namespace General.Typescript
{
	public class SystemNetFileWebRequest
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.FileWebRequest> self = space.DeclareClass<System.Net.FileWebRequest>();
			self.BindConstructor();
			self.BindInstanceFunction("Abort", Abort);
			self.BindInstanceFunction("EndGetRequestStream", EndGetRequestStream);
			self.BindInstanceFunction("EndGetResponse", EndGetResponse);
			self.BindInstanceFunction("GetRequestStream", GetRequestStream);
			self.BindInstanceFunction("GetResponse", GetResponse);
			self.BindInstanceProperty("ConnectionGroupName", get_ConnectionGroupName, set_ConnectionGroupName);
			self.BindInstanceProperty("ContentLength", get_ContentLength, set_ContentLength);
			self.BindInstanceProperty("ContentType", get_ContentType, set_ContentType);
			self.BindInstanceProperty("Credentials", get_Credentials, set_Credentials);
			self.BindInstanceProperty("Headers", get_Headers, null);
			self.BindInstanceProperty("Method", get_Method, set_Method);
			self.BindInstanceProperty("PreAuthenticate", get_PreAuthenticate, set_PreAuthenticate);
			self.BindInstanceProperty("Proxy", get_Proxy, set_Proxy);
			self.BindInstanceProperty("Timeout", get_Timeout, set_Timeout);
			self.BindInstanceProperty("RequestUri", get_RequestUri, null);
			self.BindInstanceProperty("UseDefaultCredentials", get_UseDefaultCredentials, set_UseDefaultCredentials);
		}

		static private void Abort(System.Net.FileWebRequest instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.FileWebRequest.Abort has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.IO.Stream EndGetRequestStream(System.Net.FileWebRequest instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndGetRequestStream(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.FileWebRequest.EndGetRequestStream has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.FileWebRequest.EndGetRequestStream has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Net.WebResponse EndGetResponse(System.Net.FileWebRequest instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndGetResponse(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.FileWebRequest.EndGetResponse has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.FileWebRequest.EndGetResponse has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.IO.Stream GetRequestStream(System.Net.FileWebRequest instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.FileWebRequest.GetRequestStream has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Net.WebResponse GetResponse(System.Net.FileWebRequest instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.FileWebRequest.GetResponse has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.String get_ConnectionGroupName(System.Net.FileWebRequest instance)
		{
			return instance.ConnectionGroupName;
		}

		static private void set_ConnectionGroupName(System.Net.FileWebRequest instance, System.String value)
		{
			instance.ConnectionGroupName = value;
		}

		static private System.Int64 get_ContentLength(System.Net.FileWebRequest instance)
		{
			return instance.ContentLength;
		}

		static private void set_ContentLength(System.Net.FileWebRequest instance, System.Int64 value)
		{
			instance.ContentLength = value;
		}

		static private System.String get_ContentType(System.Net.FileWebRequest instance)
		{
			return instance.ContentType;
		}

		static private void set_ContentType(System.Net.FileWebRequest instance, System.String value)
		{
			instance.ContentType = value;
		}

		static private System.Net.ICredentials get_Credentials(System.Net.FileWebRequest instance)
		{
			return instance.Credentials;
		}

		static private void set_Credentials(System.Net.FileWebRequest instance, System.Net.ICredentials value)
		{
			instance.Credentials = value;
		}

		static private System.Net.WebHeaderCollection get_Headers(System.Net.FileWebRequest instance)
		{
			return instance.Headers;
		}

		static private System.String get_Method(System.Net.FileWebRequest instance)
		{
			return instance.Method;
		}

		static private void set_Method(System.Net.FileWebRequest instance, System.String value)
		{
			instance.Method = value;
		}

		static private System.Boolean get_PreAuthenticate(System.Net.FileWebRequest instance)
		{
			return instance.PreAuthenticate;
		}

		static private void set_PreAuthenticate(System.Net.FileWebRequest instance, System.Boolean value)
		{
			instance.PreAuthenticate = value;
		}

		static private System.Net.IWebProxy get_Proxy(System.Net.FileWebRequest instance)
		{
			return instance.Proxy;
		}

		static private void set_Proxy(System.Net.FileWebRequest instance, System.Net.IWebProxy value)
		{
			instance.Proxy = value;
		}

		static private System.Int32 get_Timeout(System.Net.FileWebRequest instance)
		{
			return instance.Timeout;
		}

		static private void set_Timeout(System.Net.FileWebRequest instance, System.Int32 value)
		{
			instance.Timeout = value;
		}

		static private System.Uri get_RequestUri(System.Net.FileWebRequest instance)
		{
			return instance.RequestUri;
		}

		static private System.Boolean get_UseDefaultCredentials(System.Net.FileWebRequest instance)
		{
			return instance.UseDefaultCredentials;
		}

		static private void set_UseDefaultCredentials(System.Net.FileWebRequest instance, System.Boolean value)
		{
			instance.UseDefaultCredentials = value;
		}

	}
}
