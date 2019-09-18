declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export enum SocketInformationOptions
			{
				NonBlocking = 1,
				Connected = 2,
				Listening = 4,
				UseOnlyOverlappedIO = 8,
			}
		}
	}
}
