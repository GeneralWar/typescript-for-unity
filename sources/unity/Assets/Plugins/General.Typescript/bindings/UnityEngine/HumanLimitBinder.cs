using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineHumanLimit
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.HumanLimit> self = space.DeclareClass<UnityEngine.HumanLimit>();
			self.BindConstructor();
			self.BindInstanceProperty("useDefaultValues", get_useDefaultValues, set_useDefaultValues);
			self.BindInstanceProperty("min", get_min, set_min);
			self.BindInstanceProperty("max", get_max, set_max);
			self.BindInstanceProperty("center", get_center, set_center);
			self.BindInstanceProperty("axisLength", get_axisLength, set_axisLength);
		}

		static private System.Boolean get_useDefaultValues(UnityEngine.HumanLimit instance)
		{
			return instance.useDefaultValues;
		}

		static private void set_useDefaultValues(UnityEngine.HumanLimit instance, System.Boolean value)
		{
			instance.useDefaultValues = value;
		}

		static private UnityEngine.Vector3 get_min(UnityEngine.HumanLimit instance)
		{
			return instance.min;
		}

		static private void set_min(UnityEngine.HumanLimit instance, UnityEngine.Vector3 value)
		{
			instance.min = value;
		}

		static private UnityEngine.Vector3 get_max(UnityEngine.HumanLimit instance)
		{
			return instance.max;
		}

		static private void set_max(UnityEngine.HumanLimit instance, UnityEngine.Vector3 value)
		{
			instance.max = value;
		}

		static private UnityEngine.Vector3 get_center(UnityEngine.HumanLimit instance)
		{
			return instance.center;
		}

		static private void set_center(UnityEngine.HumanLimit instance, UnityEngine.Vector3 value)
		{
			instance.center = value;
		}

		static private System.Single get_axisLength(UnityEngine.HumanLimit instance)
		{
			return instance.axisLength;
		}

		static private void set_axisLength(UnityEngine.HumanLimit instance, System.Single value)
		{
			instance.axisLength = value;
		}

	}
}
