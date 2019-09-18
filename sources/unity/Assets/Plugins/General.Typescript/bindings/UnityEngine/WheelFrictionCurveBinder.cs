using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWheelFrictionCurve
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.WheelFrictionCurve> self = space.DeclareClass<UnityEngine.WheelFrictionCurve>();
			self.BindConstructor();
			self.BindInstanceProperty("extremumSlip", get_extremumSlip, set_extremumSlip);
			self.BindInstanceProperty("extremumValue", get_extremumValue, set_extremumValue);
			self.BindInstanceProperty("asymptoteSlip", get_asymptoteSlip, set_asymptoteSlip);
			self.BindInstanceProperty("asymptoteValue", get_asymptoteValue, set_asymptoteValue);
			self.BindInstanceProperty("stiffness", get_stiffness, set_stiffness);
		}

		static private System.Single get_extremumSlip(UnityEngine.WheelFrictionCurve instance)
		{
			return instance.extremumSlip;
		}

		static private void set_extremumSlip(UnityEngine.WheelFrictionCurve instance, System.Single value)
		{
			instance.extremumSlip = value;
		}

		static private System.Single get_extremumValue(UnityEngine.WheelFrictionCurve instance)
		{
			return instance.extremumValue;
		}

		static private void set_extremumValue(UnityEngine.WheelFrictionCurve instance, System.Single value)
		{
			instance.extremumValue = value;
		}

		static private System.Single get_asymptoteSlip(UnityEngine.WheelFrictionCurve instance)
		{
			return instance.asymptoteSlip;
		}

		static private void set_asymptoteSlip(UnityEngine.WheelFrictionCurve instance, System.Single value)
		{
			instance.asymptoteSlip = value;
		}

		static private System.Single get_asymptoteValue(UnityEngine.WheelFrictionCurve instance)
		{
			return instance.asymptoteValue;
		}

		static private void set_asymptoteValue(UnityEngine.WheelFrictionCurve instance, System.Single value)
		{
			instance.asymptoteValue = value;
		}

		static private System.Single get_stiffness(UnityEngine.WheelFrictionCurve instance)
		{
			return instance.stiffness;
		}

		static private void set_stiffness(UnityEngine.WheelFrictionCurve instance, System.Single value)
		{
			instance.stiffness = value;
		}

	}
}
