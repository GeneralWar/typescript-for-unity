declare namespace System
{
	declare namespace Net
	{
		export class HttpListener
		{
			public constructor();
			static public get IsSupported(): number;
			public Abort(): void;
			public Close(): void;
			public EndGetContext(asyncResult: any): System.Net.HttpListenerContext;
			public GetContext(): System.Net.HttpListenerContext;
			public Start(): void;
			public Stop(): void;
			public get AuthenticationSchemes(): number;
			public set AuthenticationSchemes(): number;
			public get AuthenticationSchemeSelectorDelegate(): System.Net.AuthenticationSchemeSelector;
			public set AuthenticationSchemeSelectorDelegate(): System.Net.AuthenticationSchemeSelector;
			public get IgnoreWriteExceptions(): number;
			public set IgnoreWriteExceptions(): number;
			public get IsListening(): number;
			public get Prefixes(): System.Net.HttpListenerPrefixCollection;
			public get TimeoutManager(): System.Net.HttpListenerTimeoutManager;
			public get ExtendedProtectionPolicy(): System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy;
			public set ExtendedProtectionPolicy(): System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy;
			public get DefaultServiceNames(): System.Security.Authentication.ExtendedProtection.ServiceNameCollection;
			public get Realm(): string;
			public set Realm(): string;
			public get UnsafeConnectionNtlmAuthentication(): number;
			public set UnsafeConnectionNtlmAuthentication(): number;
		}
	}
}
