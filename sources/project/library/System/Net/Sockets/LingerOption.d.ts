declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export class LingerOption
			{
				public constructor(enable: number, seconds: number);
				public get Enabled(): number;
				public set Enabled(): number;
				public get LingerTime(): number;
				public set LingerTime(): number;
			}
		}
	}
}
