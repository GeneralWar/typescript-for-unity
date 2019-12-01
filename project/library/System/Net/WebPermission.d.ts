declare namespace System
{
	declare namespace Net
	{
		export class WebPermission extends System.Security.CodeAccessPermission
		{
			public constructor();
			public constructor(state: System.Security.Permissions.PermissionState);
			public constructor(access: System.Net.NetworkAccess, uriRegex: System.Text.RegularExpressions.Regex);
			public constructor(access: System.Net.NetworkAccess, uriString: string);
			public AddPermission(access: System.Net.NetworkAccess, uriString: string): void;
			public AddPermission(access: System.Net.NetworkAccess, uriRegex: System.Text.RegularExpressions.Regex): void;
			public Copy(): any;
			public FromXml(securityElement: System.Security.SecurityElement): void;
			public Intersect(target: any): any;
			public IsSubsetOf(target: any): boolean;
			public IsUnrestricted(): boolean;
			public ToXml(): System.Security.SecurityElement;
			public Union(target: any): any;
			public get ConnectList(): any;
			public get AcceptList(): any;
		}
	}
}
