declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export enum IPProtectionLevel
			{
				Unrestricted = 10,
				EdgeRestricted = 20,
				Restricted = 30,
				Unspecified = -1,
			}
		}
	}
}
