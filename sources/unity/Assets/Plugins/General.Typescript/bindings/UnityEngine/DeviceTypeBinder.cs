using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineDeviceType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.DeviceType> instance = space.DeclareEnum<UnityEngine.DeviceType>();
			instance.SetValue("Unknown", (long)UnityEngine.DeviceType.Unknown);
			instance.SetValue("Handheld", (long)UnityEngine.DeviceType.Handheld);
			instance.SetValue("Console", (long)UnityEngine.DeviceType.Console);
			instance.SetValue("Desktop", (long)UnityEngine.DeviceType.Desktop);
		}
	}
}
