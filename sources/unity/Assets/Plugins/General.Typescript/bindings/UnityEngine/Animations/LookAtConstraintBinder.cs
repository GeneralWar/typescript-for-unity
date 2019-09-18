using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationsLookAtConstraint
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Animations.LookAtConstraint> self = space.DeclareClass<UnityEngine.Animations.LookAtConstraint, UnityEngine.Behaviour>();
			self.BindConstructor();
			self.BindInstanceFunction("AddSource", AddSource);
			self.BindInstanceFunction("GetSource", GetSource);
			self.BindInstanceFunction("RemoveSource", RemoveSource);
			self.BindInstanceFunction("SetSource", SetSource);
			self.BindInstanceProperty("weight", get_weight, set_weight);
			self.BindInstanceProperty("roll", get_roll, set_roll);
			self.BindInstanceProperty("constraintActive", get_constraintActive, set_constraintActive);
			self.BindInstanceProperty("locked", get_locked, set_locked);
			self.BindInstanceProperty("rotationAtRest", get_rotationAtRest, set_rotationAtRest);
			self.BindInstanceProperty("rotationOffset", get_rotationOffset, set_rotationOffset);
			self.BindInstanceProperty("worldUpObject", get_worldUpObject, set_worldUpObject);
			self.BindInstanceProperty("useUpObject", get_useUpObject, set_useUpObject);
			self.BindInstanceProperty("sourceCount", get_sourceCount, null);
		}

		static private System.Int32 AddSource(UnityEngine.Animations.LookAtConstraint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Animations.ConstraintSource>())
			{
				return instance.AddSource(parameters[0].ToObject<UnityEngine.Animations.ConstraintSource>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.LookAtConstraint.AddSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.LookAtConstraint.AddSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.Animations.ConstraintSource GetSource(UnityEngine.Animations.LookAtConstraint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetSource(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.LookAtConstraint.GetSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.LookAtConstraint.GetSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Animations.ConstraintSource);
		}

		static private void RemoveSource(UnityEngine.Animations.LookAtConstraint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.RemoveSource(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.LookAtConstraint.RemoveSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.LookAtConstraint.RemoveSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetSource(UnityEngine.Animations.LookAtConstraint instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Animations.ConstraintSource>())
			{
				instance.SetSource(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Animations.ConstraintSource>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.LookAtConstraint.SetSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.LookAtConstraint.SetSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Single get_weight(UnityEngine.Animations.LookAtConstraint instance)
		{
			return instance.weight;
		}

		static private void set_weight(UnityEngine.Animations.LookAtConstraint instance, System.Single value)
		{
			instance.weight = value;
		}

		static private System.Single get_roll(UnityEngine.Animations.LookAtConstraint instance)
		{
			return instance.roll;
		}

		static private void set_roll(UnityEngine.Animations.LookAtConstraint instance, System.Single value)
		{
			instance.roll = value;
		}

		static private System.Boolean get_constraintActive(UnityEngine.Animations.LookAtConstraint instance)
		{
			return instance.constraintActive;
		}

		static private void set_constraintActive(UnityEngine.Animations.LookAtConstraint instance, System.Boolean value)
		{
			instance.constraintActive = value;
		}

		static private System.Boolean get_locked(UnityEngine.Animations.LookAtConstraint instance)
		{
			return instance.locked;
		}

		static private void set_locked(UnityEngine.Animations.LookAtConstraint instance, System.Boolean value)
		{
			instance.locked = value;
		}

		static private UnityEngine.Vector3 get_rotationAtRest(UnityEngine.Animations.LookAtConstraint instance)
		{
			return instance.rotationAtRest;
		}

		static private void set_rotationAtRest(UnityEngine.Animations.LookAtConstraint instance, UnityEngine.Vector3 value)
		{
			instance.rotationAtRest = value;
		}

		static private UnityEngine.Vector3 get_rotationOffset(UnityEngine.Animations.LookAtConstraint instance)
		{
			return instance.rotationOffset;
		}

		static private void set_rotationOffset(UnityEngine.Animations.LookAtConstraint instance, UnityEngine.Vector3 value)
		{
			instance.rotationOffset = value;
		}

		static private UnityEngine.Transform get_worldUpObject(UnityEngine.Animations.LookAtConstraint instance)
		{
			return instance.worldUpObject;
		}

		static private void set_worldUpObject(UnityEngine.Animations.LookAtConstraint instance, UnityEngine.Transform value)
		{
			instance.worldUpObject = value;
		}

		static private System.Boolean get_useUpObject(UnityEngine.Animations.LookAtConstraint instance)
		{
			return instance.useUpObject;
		}

		static private void set_useUpObject(UnityEngine.Animations.LookAtConstraint instance, System.Boolean value)
		{
			instance.useUpObject = value;
		}

		static private System.Int32 get_sourceCount(UnityEngine.Animations.LookAtConstraint instance)
		{
			return instance.sourceCount;
		}

	}
}
