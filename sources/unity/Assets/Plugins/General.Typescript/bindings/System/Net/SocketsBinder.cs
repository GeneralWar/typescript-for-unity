using System;

namespace General.Typescript
{
    public class SocketsBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Sockets");

			SystemNetSocketsAddressFamily.Bind(self);
			SystemNetSocketsIOControlCode.Bind(self);
			SystemNetSocketsIPPacketInformation.Bind(self);
			SystemNetSocketsIPProtectionLevel.Bind(self);
			SystemNetSocketsIPv6MulticastOption.Bind(self);
			SystemNetSocketsLingerOption.Bind(self);
			SystemNetSocketsMulticastOption.Bind(self);
			SystemNetSocketsNetworkStream.Bind(self);
			SystemNetSocketsProtocolFamily.Bind(self);
			SystemNetSocketsProtocolType.Bind(self);
			SystemNetSocketsSelectMode.Bind(self);
			SystemNetSocketsSendPacketsElement.Bind(self);
			SystemNetSocketsSocket.Bind(self);
			SystemNetSocketsSocketAsyncEventArgs.Bind(self);
			SystemNetSocketsSocketAsyncOperation.Bind(self);
			SystemNetSocketsSocketError.Bind(self);
			SystemNetSocketsSocketException.Bind(self);
			SystemNetSocketsSocketFlags.Bind(self);
			SystemNetSocketsSocketInformation.Bind(self);
			SystemNetSocketsSocketInformationOptions.Bind(self);
			SystemNetSocketsSocketOptionLevel.Bind(self);
			SystemNetSocketsSocketOptionName.Bind(self);
			SystemNetSocketsSocketShutdown.Bind(self);
			SystemNetSocketsSocketType.Bind(self);
			SystemNetSocketsTcpClient.Bind(self);
			SystemNetSocketsTransmitFileOptions.Bind(self);
			SystemNetSocketsUdpClient.Bind(self);
			SystemNetSocketsUdpReceiveResult.Bind(self);
        }
    }
}