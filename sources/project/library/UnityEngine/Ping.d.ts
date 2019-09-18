declare namespace UnityEngine
{
	export class Ping
	{
		public constructor(address: string);
		public DestroyPing(): void;
		public get isDone(): boolean;
		public get time(): number;
		public get ip(): string;
	}
}
