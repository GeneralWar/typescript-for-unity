#if UNITY_TVOS
using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginetvOSDeviceGeneration
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.tvOS.DeviceGeneration> instance = space.DeclareEnum<UnityEngine.tvOS.DeviceGeneration>();
			instance.SetValue("Unknown", (long)UnityEngine.tvOS.DeviceGeneration.Unknown);
			instance.SetValue("AppleTV1Gen", (long)UnityEngine.tvOS.DeviceGeneration.AppleTV1Gen);
			instance.SetValue("AppleTV2Gen", (long)UnityEngine.tvOS.DeviceGeneration.AppleTV2Gen);
		}
	}
}
#endif
