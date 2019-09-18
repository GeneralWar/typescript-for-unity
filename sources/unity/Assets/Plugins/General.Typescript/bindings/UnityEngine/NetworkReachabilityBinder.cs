using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineNetworkReachability
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.NetworkReachability> instance = space.DeclareEnum<UnityEngine.NetworkReachability>();
			instance.SetValue("NotReachable", (long)UnityEngine.NetworkReachability.NotReachable);
			instance.SetValue("ReachableViaCarrierDataNetwork", (long)UnityEngine.NetworkReachability.ReachableViaCarrierDataNetwork);
			instance.SetValue("ReachableViaLocalAreaNetwork", (long)UnityEngine.NetworkReachability.ReachableViaLocalAreaNetwork);
		}
	}
}
