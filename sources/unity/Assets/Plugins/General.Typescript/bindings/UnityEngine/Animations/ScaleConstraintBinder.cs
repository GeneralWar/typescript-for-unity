using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationsScaleConstraint
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Animations.ScaleConstraint> self = space.DeclareClass<UnityEngine.Animations.ScaleConstraint, UnityEngine.Behaviour>();
			self.BindConstructor();
			self.BindInstanceFunction("AddSource", AddSource);
			self.BindInstanceFunction("GetSource", GetSource);
			self.BindInstanceFunction("RemoveSource", RemoveSource);
			self.BindInstanceFunction("SetSource", SetSource);
			self.BindInstanceProperty("weight", get_weight, set_weight);
			self.BindInstanceProperty("scaleAtRest", get_scaleAtRest, set_scaleAtRest);
			self.BindInstanceProperty("scaleOffset", get_scaleOffset, set_scaleOffset);
			self.BindInstanceProperty("scalingAxis", get_scalingAxis, set_scalingAxis);
			self.BindInstanceProperty("constraintActive", get_constraintActive, set_constraintActive);
			self.BindInstanceProperty("locked", get_locked, set_locked);
			self.BindInstanceProperty("sourceCount", get_sourceCount, null);
		}

		static private System.Int32 AddSource(UnityEngine.Animations.ScaleConstraint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Animations.ConstraintSource>())
			{
				return instance.AddSource(parameters[0].ToObject<UnityEngine.Animations.ConstraintSource>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.ScaleConstraint.AddSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.ScaleConstraint.AddSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.Animations.ConstraintSource GetSource(UnityEngine.Animations.ScaleConstraint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetSource(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.ScaleConstraint.GetSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.ScaleConstraint.GetSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Animations.ConstraintSource);
		}

		static private void RemoveSource(UnityEngine.Animations.ScaleConstraint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.RemoveSource(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.ScaleConstraint.RemoveSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.ScaleConstraint.RemoveSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetSource(UnityEngine.Animations.ScaleConstraint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Animations.ConstraintSource>())
			{
				instance.SetSource(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Animations.ConstraintSource>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.ScaleConstraint.SetSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.ScaleConstraint.SetSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Single get_weight(UnityEngine.Animations.ScaleConstraint instance)
		{
			return instance.weight;
		}

		static private void set_weight(UnityEngine.Animations.ScaleConstraint instance, System.Single value)
		{
			instance.weight = value;
		}

		static private UnityEngine.Vector3 get_scaleAtRest(UnityEngine.Animations.ScaleConstraint instance)
		{
			return instance.scaleAtRest;
		}

		static private void set_scaleAtRest(UnityEngine.Animations.ScaleConstraint instance, UnityEngine.Vector3 value)
		{
			instance.scaleAtRest = value;
		}

		static private UnityEngine.Vector3 get_scaleOffset(UnityEngine.Animations.ScaleConstraint instance)
		{
			return instance.scaleOffset;
		}

		static private void set_scaleOffset(UnityEngine.Animations.ScaleConstraint instance, UnityEngine.Vector3 value)
		{
			instance.scaleOffset = value;
		}

		static private UnityEngine.Animations.Axis get_scalingAxis(UnityEngine.Animations.ScaleConstraint instance)
		{
			return instance.scalingAxis;
		}

		static private void set_scalingAxis(UnityEngine.Animations.ScaleConstraint instance, UnityEngine.Animations.Axis value)
		{
			instance.scalingAxis = value;
		}

		static private System.Boolean get_constraintActive(UnityEngine.Animations.ScaleConstraint instance)
		{
			return instance.constraintActive;
		}

		static private void set_constraintActive(UnityEngine.Animations.ScaleConstraint instance, System.Boolean value)
		{
			instance.constraintActive = value;
		}

		static private System.Boolean get_locked(UnityEngine.Animations.ScaleConstraint instance)
		{
			return instance.locked;
		}

		static private void set_locked(UnityEngine.Animations.ScaleConstraint instance, System.Boolean value)
		{
			instance.locked = value;
		}

		static private System.Int32 get_sourceCount(UnityEngine.Animations.ScaleConstraint instance)
		{
			return instance.sourceCount;
		}

	}
}
