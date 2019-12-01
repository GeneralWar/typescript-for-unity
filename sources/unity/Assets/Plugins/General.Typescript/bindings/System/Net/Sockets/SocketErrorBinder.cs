using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsSocketError
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Sockets.SocketError> instance = space.DeclareEnum<System.Net.Sockets.SocketError>();
			instance.SetValue("Success", (long)System.Net.Sockets.SocketError.Success);
			instance.SetValue("OperationAborted", (long)System.Net.Sockets.SocketError.OperationAborted);
			instance.SetValue("IOPending", (long)System.Net.Sockets.SocketError.IOPending);
			instance.SetValue("Interrupted", (long)System.Net.Sockets.SocketError.Interrupted);
			instance.SetValue("AccessDenied", (long)System.Net.Sockets.SocketError.AccessDenied);
			instance.SetValue("Fault", (long)System.Net.Sockets.SocketError.Fault);
			instance.SetValue("InvalidArgument", (long)System.Net.Sockets.SocketError.InvalidArgument);
			instance.SetValue("TooManyOpenSockets", (long)System.Net.Sockets.SocketError.TooManyOpenSockets);
			instance.SetValue("WouldBlock", (long)System.Net.Sockets.SocketError.WouldBlock);
			instance.SetValue("InProgress", (long)System.Net.Sockets.SocketError.InProgress);
			instance.SetValue("AlreadyInProgress", (long)System.Net.Sockets.SocketError.AlreadyInProgress);
			instance.SetValue("NotSocket", (long)System.Net.Sockets.SocketError.NotSocket);
			instance.SetValue("DestinationAddressRequired", (long)System.Net.Sockets.SocketError.DestinationAddressRequired);
			instance.SetValue("MessageSize", (long)System.Net.Sockets.SocketError.MessageSize);
			instance.SetValue("ProtocolType", (long)System.Net.Sockets.SocketError.ProtocolType);
			instance.SetValue("ProtocolOption", (long)System.Net.Sockets.SocketError.ProtocolOption);
			instance.SetValue("ProtocolNotSupported", (long)System.Net.Sockets.SocketError.ProtocolNotSupported);
			instance.SetValue("SocketNotSupported", (long)System.Net.Sockets.SocketError.SocketNotSupported);
			instance.SetValue("OperationNotSupported", (long)System.Net.Sockets.SocketError.OperationNotSupported);
			instance.SetValue("ProtocolFamilyNotSupported", (long)System.Net.Sockets.SocketError.ProtocolFamilyNotSupported);
			instance.SetValue("AddressFamilyNotSupported", (long)System.Net.Sockets.SocketError.AddressFamilyNotSupported);
			instance.SetValue("AddressAlreadyInUse", (long)System.Net.Sockets.SocketError.AddressAlreadyInUse);
			instance.SetValue("AddressNotAvailable", (long)System.Net.Sockets.SocketError.AddressNotAvailable);
			instance.SetValue("NetworkDown", (long)System.Net.Sockets.SocketError.NetworkDown);
			instance.SetValue("NetworkUnreachable", (long)System.Net.Sockets.SocketError.NetworkUnreachable);
			instance.SetValue("NetworkReset", (long)System.Net.Sockets.SocketError.NetworkReset);
			instance.SetValue("ConnectionAborted", (long)System.Net.Sockets.SocketError.ConnectionAborted);
			instance.SetValue("ConnectionReset", (long)System.Net.Sockets.SocketError.ConnectionReset);
			instance.SetValue("NoBufferSpaceAvailable", (long)System.Net.Sockets.SocketError.NoBufferSpaceAvailable);
			instance.SetValue("IsConnected", (long)System.Net.Sockets.SocketError.IsConnected);
			instance.SetValue("NotConnected", (long)System.Net.Sockets.SocketError.NotConnected);
			instance.SetValue("Shutdown", (long)System.Net.Sockets.SocketError.Shutdown);
			instance.SetValue("TimedOut", (long)System.Net.Sockets.SocketError.TimedOut);
			instance.SetValue("ConnectionRefused", (long)System.Net.Sockets.SocketError.ConnectionRefused);
			instance.SetValue("HostDown", (long)System.Net.Sockets.SocketError.HostDown);
			instance.SetValue("HostUnreachable", (long)System.Net.Sockets.SocketError.HostUnreachable);
			instance.SetValue("ProcessLimit", (long)System.Net.Sockets.SocketError.ProcessLimit);
			instance.SetValue("SystemNotReady", (long)System.Net.Sockets.SocketError.SystemNotReady);
			instance.SetValue("VersionNotSupported", (long)System.Net.Sockets.SocketError.VersionNotSupported);
			instance.SetValue("NotInitialized", (long)System.Net.Sockets.SocketError.NotInitialized);
			instance.SetValue("Disconnecting", (long)System.Net.Sockets.SocketError.Disconnecting);
			instance.SetValue("TypeNotFound", (long)System.Net.Sockets.SocketError.TypeNotFound);
			instance.SetValue("HostNotFound", (long)System.Net.Sockets.SocketError.HostNotFound);
			instance.SetValue("TryAgain", (long)System.Net.Sockets.SocketError.TryAgain);
			instance.SetValue("NoRecovery", (long)System.Net.Sockets.SocketError.NoRecovery);
			instance.SetValue("NoData", (long)System.Net.Sockets.SocketError.NoData);
			instance.SetValue("SocketError", (long)System.Net.Sockets.SocketError.SocketError);
		}
	}
}
