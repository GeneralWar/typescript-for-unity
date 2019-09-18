declare namespace UnityEngine
{
	export class Ping
	{
		public constructor(address: string);
		public DestroyPing(): void;
		public get isDone(): number;
		public get time(): number;
		public get ip(): string;
	}
}
