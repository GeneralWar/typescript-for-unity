using UnityEngine;

namespace General.Typescript
{
	public class SystemNetWebExceptionStatus
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.WebExceptionStatus> instance = space.DeclareEnum<System.Net.WebExceptionStatus>();
			instance.SetValue("Success", (long)System.Net.WebExceptionStatus.Success);
			instance.SetValue("NameResolutionFailure", (long)System.Net.WebExceptionStatus.NameResolutionFailure);
			instance.SetValue("ConnectFailure", (long)System.Net.WebExceptionStatus.ConnectFailure);
			instance.SetValue("ReceiveFailure", (long)System.Net.WebExceptionStatus.ReceiveFailure);
			instance.SetValue("SendFailure", (long)System.Net.WebExceptionStatus.SendFailure);
			instance.SetValue("PipelineFailure", (long)System.Net.WebExceptionStatus.PipelineFailure);
			instance.SetValue("RequestCanceled", (long)System.Net.WebExceptionStatus.RequestCanceled);
			instance.SetValue("ProtocolError", (long)System.Net.WebExceptionStatus.ProtocolError);
			instance.SetValue("ConnectionClosed", (long)System.Net.WebExceptionStatus.ConnectionClosed);
			instance.SetValue("TrustFailure", (long)System.Net.WebExceptionStatus.TrustFailure);
			instance.SetValue("SecureChannelFailure", (long)System.Net.WebExceptionStatus.SecureChannelFailure);
			instance.SetValue("ServerProtocolViolation", (long)System.Net.WebExceptionStatus.ServerProtocolViolation);
			instance.SetValue("KeepAliveFailure", (long)System.Net.WebExceptionStatus.KeepAliveFailure);
			instance.SetValue("Pending", (long)System.Net.WebExceptionStatus.Pending);
			instance.SetValue("Timeout", (long)System.Net.WebExceptionStatus.Timeout);
			instance.SetValue("ProxyNameResolutionFailure", (long)System.Net.WebExceptionStatus.ProxyNameResolutionFailure);
			instance.SetValue("UnknownError", (long)System.Net.WebExceptionStatus.UnknownError);
			instance.SetValue("MessageLengthLimitExceeded", (long)System.Net.WebExceptionStatus.MessageLengthLimitExceeded);
			instance.SetValue("CacheEntryNotFound", (long)System.Net.WebExceptionStatus.CacheEntryNotFound);
			instance.SetValue("RequestProhibitedByCachePolicy", (long)System.Net.WebExceptionStatus.RequestProhibitedByCachePolicy);
			instance.SetValue("RequestProhibitedByProxy", (long)System.Net.WebExceptionStatus.RequestProhibitedByProxy);
		}
	}
}
