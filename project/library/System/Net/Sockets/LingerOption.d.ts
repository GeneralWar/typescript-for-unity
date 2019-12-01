declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export class LingerOption
			{
				public constructor(enable: boolean, seconds: number);
				public get Enabled(): boolean;
				public set Enabled(): boolean;
				public get LingerTime(): number;
				public set LingerTime(): number;
			}
		}
	}
}
