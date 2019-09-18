using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationsAimConstraint
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Animations.AimConstraint> self = space.DeclareClass<UnityEngine.Animations.AimConstraint, UnityEngine.Behaviour>();
			UnityEngineAnimationsAimConstraintWorldUpType.Bind(self);
			self.BindConstructor();
			self.BindInstanceFunction("AddSource", AddSource);
			self.BindInstanceFunction("GetSource", GetSource);
			self.BindInstanceFunction("RemoveSource", RemoveSource);
			self.BindInstanceFunction("SetSource", SetSource);
			self.BindInstanceProperty("weight", get_weight, set_weight);
			self.BindInstanceProperty("constraintActive", get_constraintActive, set_constraintActive);
			self.BindInstanceProperty("locked", get_locked, set_locked);
			self.BindInstanceProperty("rotationAtRest", get_rotationAtRest, set_rotationAtRest);
			self.BindInstanceProperty("rotationOffset", get_rotationOffset, set_rotationOffset);
			self.BindInstanceProperty("rotationAxis", get_rotationAxis, set_rotationAxis);
			self.BindInstanceProperty("aimVector", get_aimVector, set_aimVector);
			self.BindInstanceProperty("upVector", get_upVector, set_upVector);
			self.BindInstanceProperty("worldUpVector", get_worldUpVector, set_worldUpVector);
			self.BindInstanceProperty("worldUpObject", get_worldUpObject, set_worldUpObject);
			self.BindInstanceProperty("sourceCount", get_sourceCount, null);
		}

		static private System.Int32 AddSource(UnityEngine.Animations.AimConstraint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Animations.ConstraintSource>())
			{
				return instance.AddSource(parameters[0].ToObject<UnityEngine.Animations.ConstraintSource>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AimConstraint.AddSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AimConstraint.AddSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.Animations.ConstraintSource GetSource(UnityEngine.Animations.AimConstraint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetSource(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AimConstraint.GetSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AimConstraint.GetSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Animations.ConstraintSource);
		}

		static private void RemoveSource(UnityEngine.Animations.AimConstraint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.RemoveSource(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AimConstraint.RemoveSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AimConstraint.RemoveSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetSource(UnityEngine.Animations.AimConstraint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Animations.ConstraintSource>())
			{
				instance.SetSource(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Animations.ConstraintSource>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AimConstraint.SetSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AimConstraint.SetSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Single get_weight(UnityEngine.Animations.AimConstraint instance)
		{
			return instance.weight;
		}

		static private void set_weight(UnityEngine.Animations.AimConstraint instance, System.Single value)
		{
			instance.weight = value;
		}

		static private System.Boolean get_constraintActive(UnityEngine.Animations.AimConstraint instance)
		{
			return instance.constraintActive;
		}

		static private void set_constraintActive(UnityEngine.Animations.AimConstraint instance, System.Boolean value)
		{
			instance.constraintActive = value;
		}

		static private System.Boolean get_locked(UnityEngine.Animations.AimConstraint instance)
		{
			return instance.locked;
		}

		static private void set_locked(UnityEngine.Animations.AimConstraint instance, System.Boolean value)
		{
			instance.locked = value;
		}

		static private UnityEngine.Vector3 get_rotationAtRest(UnityEngine.Animations.AimConstraint instance)
		{
			return instance.rotationAtRest;
		}

		static private void set_rotationAtRest(UnityEngine.Animations.AimConstraint instance, UnityEngine.Vector3 value)
		{
			instance.rotationAtRest = value;
		}

		static private UnityEngine.Vector3 get_rotationOffset(UnityEngine.Animations.AimConstraint instance)
		{
			return instance.rotationOffset;
		}

		static private void set_rotationOffset(UnityEngine.Animations.AimConstraint instance, UnityEngine.Vector3 value)
		{
			instance.rotationOffset = value;
		}

		static private UnityEngine.Animations.Axis get_rotationAxis(UnityEngine.Animations.AimConstraint instance)
		{
			return instance.rotationAxis;
		}

		static private void set_rotationAxis(UnityEngine.Animations.AimConstraint instance, UnityEngine.Animations.Axis value)
		{
			instance.rotationAxis = value;
		}

		static private UnityEngine.Vector3 get_aimVector(UnityEngine.Animations.AimConstraint instance)
		{
			return instance.aimVector;
		}

		static private void set_aimVector(UnityEngine.Animations.AimConstraint instance, UnityEngine.Vector3 value)
		{
			instance.aimVector = value;
		}

		static private UnityEngine.Vector3 get_upVector(UnityEngine.Animations.AimConstraint instance)
		{
			return instance.upVector;
		}

		static private void set_upVector(UnityEngine.Animations.AimConstraint instance, UnityEngine.Vector3 value)
		{
			instance.upVector = value;
		}

		static private UnityEngine.Vector3 get_worldUpVector(UnityEngine.Animations.AimConstraint instance)
		{
			return instance.worldUpVector;
		}

		static private void set_worldUpVector(UnityEngine.Animations.AimConstraint instance, UnityEngine.Vector3 value)
		{
			instance.worldUpVector = value;
		}

		static private UnityEngine.Transform get_worldUpObject(UnityEngine.Animations.AimConstraint instance)
		{
			return instance.worldUpObject;
		}

		static private void set_worldUpObject(UnityEngine.Animations.AimConstraint instance, UnityEngine.Transform value)
		{
			instance.worldUpObject = value;
		}

		static private System.Int32 get_sourceCount(UnityEngine.Animations.AimConstraint instance)
		{
			return instance.sourceCount;
		}

	}
}
