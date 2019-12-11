using UnityEngine;

namespace General.Typescript
{
	public class SystemNetNetworkAccess
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.NetworkAccess> instance = space.DeclareEnum<System.Net.NetworkAccess>();
			instance.SetValue("Connect", (long)System.Net.NetworkAccess.Connect);
			instance.SetValue("Accept", (long)System.Net.NetworkAccess.Accept);
		}
	}
}
