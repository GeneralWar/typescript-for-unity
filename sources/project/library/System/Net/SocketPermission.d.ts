declare namespace System
{
	declare namespace Net
	{
		export class SocketPermission extends System.Security.CodeAccessPermission
		{
			public constructor(state: number);
			public constructor(access: number, transport: number, hostName: string, portNumber: number);
			public AddPermission(access: number, transport: number, hostName: string, portNumber: number): void;
			public Copy(): any;
			public FromXml(securityElement: System.Security.SecurityElement): void;
			public Intersect(target: any): any;
			public IsSubsetOf(target: any): number;
			public IsUnrestricted(): number;
			public ToXml(): System.Security.SecurityElement;
			public Union(target: any): any;
			public get AcceptList(): any;
			public get ConnectList(): any;
		}
	}
}
