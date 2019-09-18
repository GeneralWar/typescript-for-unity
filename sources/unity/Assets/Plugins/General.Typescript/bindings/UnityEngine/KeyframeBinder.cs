using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineKeyframe
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Keyframe> self = space.DeclareClass<UnityEngine.Keyframe>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("time", get_time, set_time);
			self.BindInstanceProperty("value", get_value, set_value);
			self.BindInstanceProperty("inTangent", get_inTangent, set_inTangent);
			self.BindInstanceProperty("outTangent", get_outTangent, set_outTangent);
			self.BindInstanceProperty("inWeight", get_inWeight, set_inWeight);
			self.BindInstanceProperty("outWeight", get_outWeight, set_outWeight);
			self.BindInstanceProperty("weightedMode", get_weightedMode, set_weightedMode);
		}

		static private UnityEngine.Keyframe Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return new UnityEngine.Keyframe(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single>())
			{
				return new UnityEngine.Keyframe(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single, System.Single, System.Single>())
			{
				return new UnityEngine.Keyframe(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Keyframe.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Keyframe.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Keyframe);
		}

		static private System.Single get_time(UnityEngine.Keyframe instance)
		{
			return instance.time;
		}

		static private void set_time(UnityEngine.Keyframe instance, System.Single value)
		{
			instance.time = value;
		}

		static private System.Single get_value(UnityEngine.Keyframe instance)
		{
			return instance.value;
		}

		static private void set_value(UnityEngine.Keyframe instance, System.Single value)
		{
			instance.value = value;
		}

		static private System.Single get_inTangent(UnityEngine.Keyframe instance)
		{
			return instance.inTangent;
		}

		static private void set_inTangent(UnityEngine.Keyframe instance, System.Single value)
		{
			instance.inTangent = value;
		}

		static private System.Single get_outTangent(UnityEngine.Keyframe instance)
		{
			return instance.outTangent;
		}

		static private void set_outTangent(UnityEngine.Keyframe instance, System.Single value)
		{
			instance.outTangent = value;
		}

		static private System.Single get_inWeight(UnityEngine.Keyframe instance)
		{
			return instance.inWeight;
		}

		static private void set_inWeight(UnityEngine.Keyframe instance, System.Single value)
		{
			instance.inWeight = value;
		}

		static private System.Single get_outWeight(UnityEngine.Keyframe instance)
		{
			return instance.outWeight;
		}

		static private void set_outWeight(UnityEngine.Keyframe instance, System.Single value)
		{
			instance.outWeight = value;
		}

		static private UnityEngine.WeightedMode get_weightedMode(UnityEngine.Keyframe instance)
		{
			return instance.weightedMode;
		}

		static private void set_weightedMode(UnityEngine.Keyframe instance, UnityEngine.WeightedMode value)
		{
			instance.weightedMode = value;
		}

	}
}
