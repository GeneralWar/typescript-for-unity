declare namespace System
{
	declare namespace Web
	{
		export class AspNetHostingPermission extends System.Security.CodeAccessPermission
		{
			public constructor(level: number);
			public constructor(state: number);
			public Copy(): any;
			public FromXml(securityElement: System.Security.SecurityElement): void;
			public Intersect(target: any): any;
			public IsSubsetOf(target: any): number;
			public IsUnrestricted(): number;
			public ToXml(): System.Security.SecurityElement;
			public Union(target: any): any;
			public get Level(): number;
			public set Level(): number;
		}
	}
}
