using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingRealtimeGICPUUsage
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.RealtimeGICPUUsage> instance = space.DeclareEnum<UnityEngine.Rendering.RealtimeGICPUUsage>();
			instance.SetValue("Low", (long)UnityEngine.Rendering.RealtimeGICPUUsage.Low);
			instance.SetValue("Medium", (long)UnityEngine.Rendering.RealtimeGICPUUsage.Medium);
			instance.SetValue("High", (long)UnityEngine.Rendering.RealtimeGICPUUsage.High);
			instance.SetValue("Unlimited", (long)UnityEngine.Rendering.RealtimeGICPUUsage.Unlimited);
		}
	}
}
