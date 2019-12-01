declare namespace System
{
	declare namespace Net
	{
		export class SocketPermission extends System.Security.CodeAccessPermission
		{
			public constructor(state: System.Security.Permissions.PermissionState);
			public constructor(access: System.Net.NetworkAccess, transport: System.Net.TransportType, hostName: string, portNumber: number);
			public AddPermission(access: System.Net.NetworkAccess, transport: System.Net.TransportType, hostName: string, portNumber: number): void;
			public Copy(): any;
			public FromXml(securityElement: System.Security.SecurityElement): void;
			public Intersect(target: any): any;
			public IsSubsetOf(target: any): boolean;
			public IsUnrestricted(): boolean;
			public ToXml(): System.Security.SecurityElement;
			public Union(target: any): any;
			public get AcceptList(): any;
			public get ConnectList(): any;
		}
	}
}
