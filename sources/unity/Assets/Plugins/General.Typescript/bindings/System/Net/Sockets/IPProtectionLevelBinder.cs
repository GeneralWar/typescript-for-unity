using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsIPProtectionLevel
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Sockets.IPProtectionLevel> instance = space.DeclareEnum<System.Net.Sockets.IPProtectionLevel>();
			instance.SetValue("Unrestricted", (long)System.Net.Sockets.IPProtectionLevel.Unrestricted);
			instance.SetValue("EdgeRestricted", (long)System.Net.Sockets.IPProtectionLevel.EdgeRestricted);
			instance.SetValue("Restricted", (long)System.Net.Sockets.IPProtectionLevel.Restricted);
			instance.SetValue("Unspecified", (long)System.Net.Sockets.IPProtectionLevel.Unspecified);
		}
	}
}
