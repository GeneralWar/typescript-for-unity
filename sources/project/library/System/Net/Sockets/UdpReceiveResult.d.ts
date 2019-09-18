﻿declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export class UdpReceiveResult extends System.ValueType
			{
				public constructor(buffer: number[], remoteEndPoint: System.Net.IPEndPoint);
				public Equals(obj: any): number;
				public Equals(other: number): number;
				public GetHashCode(): number;
				public get Buffer(): number[];
				public get RemoteEndPoint(): System.Net.IPEndPoint;
			}
		}
	}
}
