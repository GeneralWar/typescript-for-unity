using System;

namespace General.Typescript
{
    public class NetBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Net");

			CacheBinder.Bind(self);
			ConfigurationBinder.Bind(self);
			WebSocketsBinder.Bind(self);
			SystemNetFileWebRequest.Bind(self);
			SystemNetFileWebResponse.Bind(self);
			SystemNetFtpWebRequest.Bind(self);
			SystemNetFtpWebResponse.Bind(self);
			SystemNetHttpListener.Bind(self);
			SystemNetHttpListenerBasicIdentity.Bind(self);
			SystemNetHttpListenerContext.Bind(self);
			SystemNetHttpListenerException.Bind(self);
			SystemNetHttpListenerPrefixCollection.Bind(self);
			SystemNetHttpListenerRequest.Bind(self);
			SystemNetHttpListenerResponse.Bind(self);
			SystemNetHttpRequestHeader.Bind(self);
			SystemNetHttpResponseHeader.Bind(self);
			SystemNetHttpStatusCode.Bind(self);
			SystemNetHttpVersion.Bind(self);
			SystemNetHttpWebRequest.Bind(self);
			SystemNetHttpWebResponse.Bind(self);
			SystemNetWebClient.Bind(self);
			SystemNetWebException.Bind(self);
			SystemNetWebExceptionStatus.Bind(self);
			SystemNetWebHeaderCollection.Bind(self);
			SystemNetWebPermission.Bind(self);
        }
    }
}