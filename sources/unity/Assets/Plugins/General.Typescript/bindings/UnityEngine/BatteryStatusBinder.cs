using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineBatteryStatus
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.BatteryStatus> instance = space.DeclareEnum<UnityEngine.BatteryStatus>();
			instance.SetValue("Unknown", (long)UnityEngine.BatteryStatus.Unknown);
			instance.SetValue("Charging", (long)UnityEngine.BatteryStatus.Charging);
			instance.SetValue("Discharging", (long)UnityEngine.BatteryStatus.Discharging);
			instance.SetValue("NotCharging", (long)UnityEngine.BatteryStatus.NotCharging);
			instance.SetValue("Full", (long)UnityEngine.BatteryStatus.Full);
		}
	}
}
