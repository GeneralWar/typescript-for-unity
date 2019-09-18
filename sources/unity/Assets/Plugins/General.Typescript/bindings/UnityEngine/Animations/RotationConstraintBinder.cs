using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationsRotationConstraint
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Animations.RotationConstraint> self = space.DeclareClass<UnityEngine.Animations.RotationConstraint, UnityEngine.Behaviour>();
			self.BindConstructor();
			self.BindInstanceFunction("AddSource", AddSource);
			self.BindInstanceFunction("GetSource", GetSource);
			self.BindInstanceFunction("RemoveSource", RemoveSource);
			self.BindInstanceFunction("SetSource", SetSource);
			self.BindInstanceProperty("weight", get_weight, set_weight);
			self.BindInstanceProperty("rotationAtRest", get_rotationAtRest, set_rotationAtRest);
			self.BindInstanceProperty("rotationOffset", get_rotationOffset, set_rotationOffset);
			self.BindInstanceProperty("rotationAxis", get_rotationAxis, set_rotationAxis);
			self.BindInstanceProperty("constraintActive", get_constraintActive, set_constraintActive);
			self.BindInstanceProperty("locked", get_locked, set_locked);
			self.BindInstanceProperty("sourceCount", get_sourceCount, null);
		}

		static private System.Int32 AddSource(UnityEngine.Animations.RotationConstraint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Animations.ConstraintSource>())
			{
				return instance.AddSource(parameters[0].ToObject<UnityEngine.Animations.ConstraintSource>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.RotationConstraint.AddSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.RotationConstraint.AddSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.Animations.ConstraintSource GetSource(UnityEngine.Animations.RotationConstraint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetSource(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.RotationConstraint.GetSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.RotationConstraint.GetSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Animations.ConstraintSource);
		}

		static private void RemoveSource(UnityEngine.Animations.RotationConstraint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.RemoveSource(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.RotationConstraint.RemoveSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.RotationConstraint.RemoveSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetSource(UnityEngine.Animations.RotationConstraint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Animations.ConstraintSource>())
			{
				instance.SetSource(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Animations.ConstraintSource>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.RotationConstraint.SetSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.RotationConstraint.SetSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Single get_weight(UnityEngine.Animations.RotationConstraint instance)
		{
			return instance.weight;
		}

		static private void set_weight(UnityEngine.Animations.RotationConstraint instance, System.Single value)
		{
			instance.weight = value;
		}

		static private UnityEngine.Vector3 get_rotationAtRest(UnityEngine.Animations.RotationConstraint instance)
		{
			return instance.rotationAtRest;
		}

		static private void set_rotationAtRest(UnityEngine.Animations.RotationConstraint instance, UnityEngine.Vector3 value)
		{
			instance.rotationAtRest = value;
		}

		static private UnityEngine.Vector3 get_rotationOffset(UnityEngine.Animations.RotationConstraint instance)
		{
			return instance.rotationOffset;
		}

		static private void set_rotationOffset(UnityEngine.Animations.RotationConstraint instance, UnityEngine.Vector3 value)
		{
			instance.rotationOffset = value;
		}

		static private UnityEngine.Animations.Axis get_rotationAxis(UnityEngine.Animations.RotationConstraint instance)
		{
			return instance.rotationAxis;
		}

		static private void set_rotationAxis(UnityEngine.Animations.RotationConstraint instance, UnityEngine.Animations.Axis value)
		{
			instance.rotationAxis = value;
		}

		static private System.Boolean get_constraintActive(UnityEngine.Animations.RotationConstraint instance)
		{
			return instance.constraintActive;
		}

		static private void set_constraintActive(UnityEngine.Animations.RotationConstraint instance, System.Boolean value)
		{
			instance.constraintActive = value;
		}

		static private System.Boolean get_locked(UnityEngine.Animations.RotationConstraint instance)
		{
			return instance.locked;
		}

		static private void set_locked(UnityEngine.Animations.RotationConstraint instance, System.Boolean value)
		{
			instance.locked = value;
		}

		static private System.Int32 get_sourceCount(UnityEngine.Animations.RotationConstraint instance)
		{
			return instance.sourceCount;
		}

	}
}
