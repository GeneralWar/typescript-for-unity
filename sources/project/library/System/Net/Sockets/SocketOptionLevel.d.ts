declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export enum SocketOptionLevel
			{
				IP = 0,
				Tcp = 6,
				Udp = 17,
				IPv6 = 41,
				Socket = 65535,
			}
		}
	}
}
