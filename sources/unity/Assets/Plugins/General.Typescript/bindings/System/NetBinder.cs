using System;

namespace General.Typescript
{
    public class NetBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Net");

			SocketsBinder.Bind(self);
			WebSocketsBinder.Bind(self);
			SystemNetEndpointPermission.Bind(self);
			SystemNetFileWebRequest.Bind(self);
			SystemNetFileWebResponse.Bind(self);
			SystemNetFtpStatusCode.Bind(self);
			SystemNetFtpWebRequest.Bind(self);
			SystemNetFtpWebResponse.Bind(self);
			SystemNetHttpWebRequest.Bind(self);
			SystemNetHttpWebResponse.Bind(self);
			SystemNetIPAddress.Bind(self);
			SystemNetIPEndPoint.Bind(self);
			SystemNetIPHostEntry.Bind(self);
			SystemNetNetworkAccess.Bind(self);
			SystemNetNetworkCredential.Bind(self);
			SystemNetTransportType.Bind(self);
			SystemNetUploadDataCompletedEventArgs.Bind(self);
			SystemNetUploadFileCompletedEventArgs.Bind(self);
			SystemNetUploadProgressChangedEventArgs.Bind(self);
			SystemNetUploadStringCompletedEventArgs.Bind(self);
			SystemNetUploadValuesCompletedEventArgs.Bind(self);
			SystemNetWebException.Bind(self);
			SystemNetWebExceptionStatus.Bind(self);
			SystemNetWebHeaderCollection.Bind(self);
			SystemNetWebPermission.Bind(self);
        }
    }
}