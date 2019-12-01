declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export enum SocketFlags
			{
				None = 0,
				OutOfBand = 1,
				Peek = 2,
				DontRoute = 4,
				MaxIOVectorLength = 16,
				Truncated = 256,
				ControlDataTruncated = 512,
				Broadcast = 1024,
				Multicast = 2048,
				Partial = 32768,
			}
		}
	}
}
