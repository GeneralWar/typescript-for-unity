declare namespace System
{
	declare namespace Net
	{
		declare namespace Configuration
		{
			export class SocketElement extends System.Configuration.ConfigurationElement
			{
				public constructor();
				public get AlwaysUseCompletionPortsForAccept(): boolean;
				public set AlwaysUseCompletionPortsForAccept(): boolean;
				public get AlwaysUseCompletionPortsForConnect(): boolean;
				public set AlwaysUseCompletionPortsForConnect(): boolean;
				public get IPProtectionLevel(): System.Net.Sockets.IPProtectionLevel;
				public set IPProtectionLevel(): System.Net.Sockets.IPProtectionLevel;
			}
		}
	}
}
