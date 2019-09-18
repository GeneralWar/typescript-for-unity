using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMatchTargetWeightMask
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.MatchTargetWeightMask> self = space.DeclareClass<UnityEngine.MatchTargetWeightMask>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("positionXYZWeight", get_positionXYZWeight, set_positionXYZWeight);
			self.BindInstanceProperty("rotationWeight", get_rotationWeight, set_rotationWeight);
		}

		static private UnityEngine.MatchTargetWeightMask Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single>())
			{
				return new UnityEngine.MatchTargetWeightMask(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.MatchTargetWeightMask.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MatchTargetWeightMask.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.MatchTargetWeightMask);
		}

		static private UnityEngine.Vector3 get_positionXYZWeight(UnityEngine.MatchTargetWeightMask instance)
		{
			return instance.positionXYZWeight;
		}

		static private void set_positionXYZWeight(UnityEngine.MatchTargetWeightMask instance, UnityEngine.Vector3 value)
		{
			instance.positionXYZWeight = value;
		}

		static private System.Single get_rotationWeight(UnityEngine.MatchTargetWeightMask instance)
		{
			return instance.rotationWeight;
		}

		static private void set_rotationWeight(UnityEngine.MatchTargetWeightMask instance, System.Single value)
		{
			instance.rotationWeight = value;
		}

	}
}
