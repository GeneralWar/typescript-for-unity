declare namespace System
{
	declare namespace Web
	{
		export class AspNetHostingPermission extends System.Security.CodeAccessPermission
		{
			public constructor(level: System.Web.AspNetHostingPermissionLevel);
			public constructor(state: System.Security.Permissions.PermissionState);
			public Copy(): any;
			public FromXml(securityElement: System.Security.SecurityElement): void;
			public Intersect(target: any): any;
			public IsSubsetOf(target: any): boolean;
			public IsUnrestricted(): boolean;
			public ToXml(): System.Security.SecurityElement;
			public Union(target: any): any;
			public get Level(): System.Web.AspNetHostingPermissionLevel;
			public set Level(): System.Web.AspNetHostingPermissionLevel;
		}
	}
}
