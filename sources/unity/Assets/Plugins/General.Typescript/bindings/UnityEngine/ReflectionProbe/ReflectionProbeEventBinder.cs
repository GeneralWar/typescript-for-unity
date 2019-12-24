using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineReflectionProbeReflectionProbeEvent
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.ReflectionProbe.ReflectionProbeEvent> instance = space.DeclareEnum<UnityEngine.ReflectionProbe.ReflectionProbeEvent>();
			instance.SetValue("ReflectionProbeAdded", (long)UnityEngine.ReflectionProbe.ReflectionProbeEvent.ReflectionProbeAdded);
			instance.SetValue("ReflectionProbeRemoved", (long)UnityEngine.ReflectionProbe.ReflectionProbeEvent.ReflectionProbeRemoved);
		}
	}
}
