declare namespace System
{
	declare namespace Net
	{
		export namespace WebHeaderCollection
		{
			export function IsRestricted(headerName: string): number;
			export function IsRestricted(headerName: string, response: number): number;
		}
		export class WebHeaderCollection extends System.Collections.Specialized.NameValueCollection
		{
			public constructor();
			public Add(header: string): void;
			public Add(header: number, value: string): void;
			public Add(header: number, value: string): void;
			public Add(name: string, value: string): void;
			public Clear(): void;
			public Get(name: string): string;
			public Get(index: number): string;
			public GetEnumerator(): any;
			public GetKey(index: number): string;
			public GetObjectData(serializationInfo: System.Runtime.Serialization.SerializationInfo, streamingContext: number): void;
			public GetValues(header: string): string[];
			public GetValues(index: number): string[];
			public OnDeserialization(sender: any): void;
			public Remove(header: number): void;
			public Remove(header: number): void;
			public Remove(name: string): void;
			public Set(header: number, value: string): void;
			public Set(header: number, value: string): void;
			public Set(name: string, value: string): void;
			public ToByteArray(): number[];
			public ToString(): string;
			public get Count(): number;
			public get AllKeys(): string[];
		}
	}
}
