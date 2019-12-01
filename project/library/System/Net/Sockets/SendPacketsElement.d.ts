declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export class SendPacketsElement
			{
				public constructor(filepath: string);
				public constructor(buffer: number[]);
				public constructor(filepath: string, offset: number, count: number);
				public constructor(buffer: number[], offset: number, count: number);
				public constructor(filepath: string, offset: number, count: number, endOfPacket: boolean);
				public constructor(buffer: number[], offset: number, count: number, endOfPacket: boolean);
				public get FilePath(): string;
				public get Buffer(): number[];
				public get Count(): number;
				public get Offset(): number;
				public get EndOfPacket(): boolean;
			}
		}
	}
}
