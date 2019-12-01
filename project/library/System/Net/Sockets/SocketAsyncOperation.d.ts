declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export enum SocketAsyncOperation
			{
				None = 0,
				Accept = 1,
				Connect = 2,
				Disconnect = 3,
				Receive = 4,
				ReceiveFrom = 5,
				ReceiveMessageFrom = 6,
				Send = 7,
				SendPackets = 8,
				SendTo = 9,
			}
		}
	}
}
