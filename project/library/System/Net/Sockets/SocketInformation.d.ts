declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export class SocketInformation extends System.ValueType
			{
				public get ProtocolInformation(): number[];
				public set ProtocolInformation(): number[];
				public get Options(): System.Net.Sockets.SocketInformationOptions;
				public set Options(): System.Net.Sockets.SocketInformationOptions;
			}
		}
	}
}
