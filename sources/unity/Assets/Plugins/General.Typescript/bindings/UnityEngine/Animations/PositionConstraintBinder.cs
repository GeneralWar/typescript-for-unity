using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationsPositionConstraint
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Animations.PositionConstraint> self = space.DeclareClass<UnityEngine.Animations.PositionConstraint, UnityEngine.Behaviour>();
			self.BindConstructor();
			self.BindInstanceFunction("AddSource", AddSource);
			self.BindInstanceFunction("GetSource", GetSource);
			self.BindInstanceFunction("RemoveSource", RemoveSource);
			self.BindInstanceFunction("SetSource", SetSource);
			self.BindInstanceProperty("weight", get_weight, set_weight);
			self.BindInstanceProperty("translationAtRest", get_translationAtRest, set_translationAtRest);
			self.BindInstanceProperty("translationOffset", get_translationOffset, set_translationOffset);
			self.BindInstanceProperty("translationAxis", get_translationAxis, set_translationAxis);
			self.BindInstanceProperty("constraintActive", get_constraintActive, set_constraintActive);
			self.BindInstanceProperty("locked", get_locked, set_locked);
			self.BindInstanceProperty("sourceCount", get_sourceCount, null);
		}

		static private System.Int32 AddSource(UnityEngine.Animations.PositionConstraint instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Animations.ConstraintSource>())
			{
				return instance.AddSource(parameters[0].ToObject<UnityEngine.Animations.ConstraintSource>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.PositionConstraint.AddSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.PositionConstraint.AddSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.Animations.ConstraintSource GetSource(UnityEngine.Animations.PositionConstraint instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetSource(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.PositionConstraint.GetSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.PositionConstraint.GetSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Animations.ConstraintSource);
		}

		static private void RemoveSource(UnityEngine.Animations.PositionConstraint instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.RemoveSource(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.PositionConstraint.RemoveSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.PositionConstraint.RemoveSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetSource(UnityEngine.Animations.PositionConstraint instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Animations.ConstraintSource>())
			{
				instance.SetSource(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Animations.ConstraintSource>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.PositionConstraint.SetSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.PositionConstraint.SetSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Single get_weight(UnityEngine.Animations.PositionConstraint instance, string name)
		{
			return instance.weight;
		}

		static private void set_weight(UnityEngine.Animations.PositionConstraint instance, string name, System.Single value)
		{
			instance.weight = value;
		}

		static private UnityEngine.Vector3 get_translationAtRest(UnityEngine.Animations.PositionConstraint instance, string name)
		{
			return instance.translationAtRest;
		}

		static private void set_translationAtRest(UnityEngine.Animations.PositionConstraint instance, string name, UnityEngine.Vector3 value)
		{
			instance.translationAtRest = value;
		}

		static private UnityEngine.Vector3 get_translationOffset(UnityEngine.Animations.PositionConstraint instance, string name)
		{
			return instance.translationOffset;
		}

		static private void set_translationOffset(UnityEngine.Animations.PositionConstraint instance, string name, UnityEngine.Vector3 value)
		{
			instance.translationOffset = value;
		}

		static private UnityEngine.Animations.Axis get_translationAxis(UnityEngine.Animations.PositionConstraint instance, string name)
		{
			return instance.translationAxis;
		}

		static private void set_translationAxis(UnityEngine.Animations.PositionConstraint instance, string name, UnityEngine.Animations.Axis value)
		{
			instance.translationAxis = value;
		}

		static private System.Boolean get_constraintActive(UnityEngine.Animations.PositionConstraint instance, string name)
		{
			return instance.constraintActive;
		}

		static private void set_constraintActive(UnityEngine.Animations.PositionConstraint instance, string name, System.Boolean value)
		{
			instance.constraintActive = value;
		}

		static private System.Boolean get_locked(UnityEngine.Animations.PositionConstraint instance, string name)
		{
			return instance.locked;
		}

		static private void set_locked(UnityEngine.Animations.PositionConstraint instance, string name, System.Boolean value)
		{
			instance.locked = value;
		}

		static private System.Int32 get_sourceCount(UnityEngine.Animations.PositionConstraint instance, string name)
		{
			return instance.sourceCount;
		}

	}
}
