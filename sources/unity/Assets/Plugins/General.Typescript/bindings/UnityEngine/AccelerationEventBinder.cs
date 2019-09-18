using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAccelerationEvent
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AccelerationEvent> self = space.DeclareClass<UnityEngine.AccelerationEvent>();
			self.BindConstructor();
			self.BindInstanceProperty("acceleration", get_acceleration, null);
			self.BindInstanceProperty("deltaTime", get_deltaTime, null);
		}

		static private UnityEngine.Vector3 get_acceleration(UnityEngine.AccelerationEvent instance)
		{
			return instance.acceleration;
		}

		static private System.Single get_deltaTime(UnityEngine.AccelerationEvent instance)
		{
			return instance.deltaTime;
		}

	}
}
