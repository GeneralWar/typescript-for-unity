declare namespace System
{
	declare namespace Net
	{
		export class HttpListenerPrefixCollection
		{
			public Add(uriPrefix: string): void;
			public Clear(): void;
			public Contains(uriPrefix: string): boolean;
			public CopyTo(array: string[], offset: number): void;
			public CopyTo(array: System.Array, offset: number): void;
			public Remove(uriPrefix: string): boolean;
			public get Count(): number;
			public get IsReadOnly(): boolean;
			public get IsSynchronized(): boolean;
		}
	}
}
