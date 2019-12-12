declare namespace System
{
	declare namespace Net
	{
		export class EndpointPermission
		{
			public Equals(obj: any): boolean;
			public GetHashCode(): number;
			public ToString(): string;
			public get Hostname(): string;
			public get Port(): number;
			public get Transport(): System.Net.TransportType;
		}
	}
}
