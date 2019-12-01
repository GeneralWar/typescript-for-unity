using UnityEngine;

namespace General.Typescript
{
	public class SystemNetHttpListenerContext
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.HttpListenerContext> self = space.DeclareClass<System.Net.HttpListenerContext>();
			self.BindConstructor();
			self.BindInstanceProperty("Request", get_Request, null);
			self.BindInstanceProperty("Response", get_Response, null);
			self.BindInstanceProperty("User", get_User, null);
		}

		static private System.Net.HttpListenerRequest get_Request(System.Net.HttpListenerContext instance)
		{
			return instance.Request;
		}

		static private System.Net.HttpListenerResponse get_Response(System.Net.HttpListenerContext instance)
		{
			return instance.Response;
		}

		static private System.Security.Principal.IPrincipal get_User(System.Net.HttpListenerContext instance)
		{
			return instance.User;
		}

	}
}
