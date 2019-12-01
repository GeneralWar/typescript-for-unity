﻿declare namespace System
{
	declare namespace Net
	{
		declare namespace WebSockets
		{
			export enum WebSocketState
			{
				None = 0,
				Connecting = 1,
				Open = 2,
				CloseSent = 3,
				CloseReceived = 4,
				Closed = 5,
				Aborted = 6,
			}
		}
	}
}
