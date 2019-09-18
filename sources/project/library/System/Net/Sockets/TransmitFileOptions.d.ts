declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export enum TransmitFileOptions
			{
				UseDefaultWorkerThread = 0,
				Disconnect = 1,
				ReuseSocket = 2,
				WriteBehind = 4,
				UseSystemThread = 16,
				UseKernelApc = 32,
			}
		}
	}
}
