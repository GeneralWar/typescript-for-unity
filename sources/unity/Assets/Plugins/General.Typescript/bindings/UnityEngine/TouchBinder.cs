#if !UNITY_STANDALONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTouch
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Touch> self = space.DeclareClass<UnityEngine.Touch>();
			self.BindConstructor();
			self.BindInstanceProperty("fingerId", get_fingerId, set_fingerId);
			self.BindInstanceProperty("position", get_position, set_position);
			self.BindInstanceProperty("rawPosition", get_rawPosition, set_rawPosition);
			self.BindInstanceProperty("deltaPosition", get_deltaPosition, set_deltaPosition);
			self.BindInstanceProperty("deltaTime", get_deltaTime, set_deltaTime);
			self.BindInstanceProperty("tapCount", get_tapCount, set_tapCount);
			self.BindInstanceProperty("phase", get_phase, set_phase);
			self.BindInstanceProperty("pressure", get_pressure, set_pressure);
			self.BindInstanceProperty("maximumPossiblePressure", get_maximumPossiblePressure, set_maximumPossiblePressure);
			self.BindInstanceProperty("type", get_type, set_type);
			self.BindInstanceProperty("altitudeAngle", get_altitudeAngle, set_altitudeAngle);
			self.BindInstanceProperty("azimuthAngle", get_azimuthAngle, set_azimuthAngle);
			self.BindInstanceProperty("radius", get_radius, set_radius);
			self.BindInstanceProperty("radiusVariance", get_radiusVariance, set_radiusVariance);
		}

		static private System.Int32 get_fingerId(UnityEngine.Touch instance)
		{
			return instance.fingerId;
		}

		static private void set_fingerId(UnityEngine.Touch instance, System.Int32 value)
		{
			instance.fingerId = value;
		}

		static private UnityEngine.Vector2 get_position(UnityEngine.Touch instance)
		{
			return instance.position;
		}

		static private void set_position(UnityEngine.Touch instance, UnityEngine.Vector2 value)
		{
			instance.position = value;
		}

		static private UnityEngine.Vector2 get_rawPosition(UnityEngine.Touch instance)
		{
			return instance.rawPosition;
		}

		static private void set_rawPosition(UnityEngine.Touch instance, UnityEngine.Vector2 value)
		{
			instance.rawPosition = value;
		}

		static private UnityEngine.Vector2 get_deltaPosition(UnityEngine.Touch instance)
		{
			return instance.deltaPosition;
		}

		static private void set_deltaPosition(UnityEngine.Touch instance, UnityEngine.Vector2 value)
		{
			instance.deltaPosition = value;
		}

		static private System.Single get_deltaTime(UnityEngine.Touch instance)
		{
			return instance.deltaTime;
		}

		static private void set_deltaTime(UnityEngine.Touch instance, System.Single value)
		{
			instance.deltaTime = value;
		}

		static private System.Int32 get_tapCount(UnityEngine.Touch instance)
		{
			return instance.tapCount;
		}

		static private void set_tapCount(UnityEngine.Touch instance, System.Int32 value)
		{
			instance.tapCount = value;
		}

		static private UnityEngine.TouchPhase get_phase(UnityEngine.Touch instance)
		{
			return instance.phase;
		}

		static private void set_phase(UnityEngine.Touch instance, UnityEngine.TouchPhase value)
		{
			instance.phase = value;
		}

		static private System.Single get_pressure(UnityEngine.Touch instance)
		{
			return instance.pressure;
		}

		static private void set_pressure(UnityEngine.Touch instance, System.Single value)
		{
			instance.pressure = value;
		}

		static private System.Single get_maximumPossiblePressure(UnityEngine.Touch instance)
		{
			return instance.maximumPossiblePressure;
		}

		static private void set_maximumPossiblePressure(UnityEngine.Touch instance, System.Single value)
		{
			instance.maximumPossiblePressure = value;
		}

		static private UnityEngine.TouchType get_type(UnityEngine.Touch instance)
		{
			return instance.type;
		}

		static private void set_type(UnityEngine.Touch instance, UnityEngine.TouchType value)
		{
			instance.type = value;
		}

		static private System.Single get_altitudeAngle(UnityEngine.Touch instance)
		{
			return instance.altitudeAngle;
		}

		static private void set_altitudeAngle(UnityEngine.Touch instance, System.Single value)
		{
			instance.altitudeAngle = value;
		}

		static private System.Single get_azimuthAngle(UnityEngine.Touch instance)
		{
			return instance.azimuthAngle;
		}

		static private void set_azimuthAngle(UnityEngine.Touch instance, System.Single value)
		{
			instance.azimuthAngle = value;
		}

		static private System.Single get_radius(UnityEngine.Touch instance)
		{
			return instance.radius;
		}

		static private void set_radius(UnityEngine.Touch instance, System.Single value)
		{
			instance.radius = value;
		}

		static private System.Single get_radiusVariance(UnityEngine.Touch instance)
		{
			return instance.radiusVariance;
		}

		static private void set_radiusVariance(UnityEngine.Touch instance, System.Single value)
		{
			instance.radiusVariance = value;
		}

	}
}
#endif
