declare namespace System
{
	declare namespace Net
	{
		export namespace WebHeaderCollection
		{
			export function IsRestricted(headerName: string): boolean;
			export function IsRestricted(headerName: string, response: boolean): boolean;
		}
		export class WebHeaderCollection extends System.Collections.Specialized.NameValueCollection
		{
			public constructor();
			public Add(header: string): void;
			public Add(header: System.Net.HttpRequestHeader, value: string): void;
			public Add(header: System.Net.HttpResponseHeader, value: string): void;
			public Add(name: string, value: string): void;
			public Clear(): void;
			public Get(name: string): string;
			public Get(index: number): string;
			public GetEnumerator(): any;
			public GetKey(index: number): string;
			public GetObjectData(serializationInfo: System.Runtime.Serialization.SerializationInfo, streamingContext: System.Runtime.Serialization.StreamingContext): void;
			public GetValues(header: string): string[];
			public GetValues(index: number): string[];
			public OnDeserialization(sender: any): void;
			public Remove(header: System.Net.HttpRequestHeader): void;
			public Remove(header: System.Net.HttpResponseHeader): void;
			public Remove(name: string): void;
			public Set(header: System.Net.HttpRequestHeader, value: string): void;
			public Set(header: System.Net.HttpResponseHeader, value: string): void;
			public Set(name: string, value: string): void;
			public ToByteArray(): number[];
			public ToString(): string;
			public get Count(): number;
			public get AllKeys(): string[];
		}
	}
}
