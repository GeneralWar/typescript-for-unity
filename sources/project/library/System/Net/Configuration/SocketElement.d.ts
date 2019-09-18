declare namespace System
{
	declare namespace Net
	{
		declare namespace Configuration
		{
			export class SocketElement extends System.Configuration.ConfigurationElement
			{
				public constructor();
				public get AlwaysUseCompletionPortsForAccept(): number;
				public set AlwaysUseCompletionPortsForAccept(): number;
				public get AlwaysUseCompletionPortsForConnect(): number;
				public set AlwaysUseCompletionPortsForConnect(): number;
				public get IPProtectionLevel(): number;
				public set IPProtectionLevel(): number;
			}
		}
	}
}
