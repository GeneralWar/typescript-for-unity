declare namespace System
{
	declare namespace Net
	{
		export class HttpListener
		{
			public constructor();
			static public get IsSupported(): boolean;
			public Abort(): void;
			public Close(): void;
			public EndGetContext(asyncResult: any): System.Net.HttpListenerContext;
			public GetContext(): System.Net.HttpListenerContext;
			public Start(): void;
			public Stop(): void;
			public get AuthenticationSchemes(): System.Net.AuthenticationSchemes;
			public set AuthenticationSchemes(): System.Net.AuthenticationSchemes;
			public get AuthenticationSchemeSelectorDelegate(): System.Net.AuthenticationSchemeSelector;
			public set AuthenticationSchemeSelectorDelegate(): System.Net.AuthenticationSchemeSelector;
			public get IgnoreWriteExceptions(): boolean;
			public set IgnoreWriteExceptions(): boolean;
			public get IsListening(): boolean;
			public get Prefixes(): System.Net.HttpListenerPrefixCollection;
			public get TimeoutManager(): System.Net.HttpListenerTimeoutManager;
			public get ExtendedProtectionPolicy(): System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy;
			public set ExtendedProtectionPolicy(): System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy;
			public get DefaultServiceNames(): System.Security.Authentication.ExtendedProtection.ServiceNameCollection;
			public get Realm(): string;
			public set Realm(): string;
			public get UnsafeConnectionNtlmAuthentication(): boolean;
			public set UnsafeConnectionNtlmAuthentication(): boolean;
		}
	}
}
