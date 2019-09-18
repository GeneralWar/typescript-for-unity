declare namespace System
{
	declare namespace Net
	{
		export class WebPermission extends System.Security.CodeAccessPermission
		{
			public constructor();
			public constructor(state: number);
			public constructor(access: number, uriRegex: System.Text.RegularExpressions.Regex);
			public constructor(access: number, uriString: string);
			public AddPermission(access: number, uriString: string): void;
			public AddPermission(access: number, uriRegex: System.Text.RegularExpressions.Regex): void;
			public Copy(): any;
			public FromXml(securityElement: System.Security.SecurityElement): void;
			public Intersect(target: any): any;
			public IsSubsetOf(target: any): number;
			public IsUnrestricted(): number;
			public ToXml(): System.Security.SecurityElement;
			public Union(target: any): any;
			public get ConnectList(): any;
			public get AcceptList(): any;
		}
	}
}
