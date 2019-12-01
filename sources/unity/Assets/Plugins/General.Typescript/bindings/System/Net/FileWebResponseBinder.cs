using UnityEngine;

namespace General.Typescript
{
	public class SystemNetFileWebResponse
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.FileWebResponse> self = space.DeclareClass<System.Net.FileWebResponse>();
			self.BindConstructor();
			self.BindInstanceFunction("Close", Close);
			self.BindInstanceFunction("GetResponseStream", GetResponseStream);
			self.BindInstanceProperty("ContentLength", get_ContentLength, null);
			self.BindInstanceProperty("ContentType", get_ContentType, null);
			self.BindInstanceProperty("Headers", get_Headers, null);
			self.BindInstanceProperty("SupportsHeaders", get_SupportsHeaders, null);
			self.BindInstanceProperty("ResponseUri", get_ResponseUri, null);
		}

		static private void Close(System.Net.FileWebResponse instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.FileWebResponse.Close has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.IO.Stream GetResponseStream(System.Net.FileWebResponse instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.FileWebResponse.GetResponseStream has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Int64 get_ContentLength(System.Net.FileWebResponse instance)
		{
			return instance.ContentLength;
		}

		static private System.String get_ContentType(System.Net.FileWebResponse instance)
		{
			return instance.ContentType;
		}

		static private System.Net.WebHeaderCollection get_Headers(System.Net.FileWebResponse instance)
		{
			return instance.Headers;
		}

		static private System.Boolean get_SupportsHeaders(System.Net.FileWebResponse instance)
		{
			return instance.SupportsHeaders;
		}

		static private System.Uri get_ResponseUri(System.Net.FileWebResponse instance)
		{
			return instance.ResponseUri;
		}

	}
}
