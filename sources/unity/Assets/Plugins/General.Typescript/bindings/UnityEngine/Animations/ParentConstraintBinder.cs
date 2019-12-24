using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationsParentConstraint
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Animations.ParentConstraint> self = space.DeclareClass<UnityEngine.Animations.ParentConstraint, UnityEngine.Behaviour>();
			self.BindConstructor();
			self.BindInstanceFunction("AddSource", AddSource);
			self.BindInstanceFunction("GetRotationOffset", GetRotationOffset);
			self.BindInstanceFunction("GetSource", GetSource);
			self.BindInstanceFunction("GetTranslationOffset", GetTranslationOffset);
			self.BindInstanceFunction("RemoveSource", RemoveSource);
			self.BindInstanceFunction("SetRotationOffset", SetRotationOffset);
			self.BindInstanceFunction("SetSource", SetSource);
			self.BindInstanceFunction("SetTranslationOffset", SetTranslationOffset);
			self.BindInstanceProperty("weight", get_weight, set_weight);
			self.BindInstanceProperty("constraintActive", get_constraintActive, set_constraintActive);
			self.BindInstanceProperty("locked", get_locked, set_locked);
			self.BindInstanceProperty("sourceCount", get_sourceCount, null);
			self.BindInstanceProperty("translationAtRest", get_translationAtRest, set_translationAtRest);
			self.BindInstanceProperty("rotationAtRest", get_rotationAtRest, set_rotationAtRest);
			self.BindInstanceProperty("translationOffsets", get_translationOffsets, set_translationOffsets);
			self.BindInstanceProperty("rotationOffsets", get_rotationOffsets, set_rotationOffsets);
			self.BindInstanceProperty("translationAxis", get_translationAxis, set_translationAxis);
			self.BindInstanceProperty("rotationAxis", get_rotationAxis, set_rotationAxis);
		}

		static private System.Int32 AddSource(UnityEngine.Animations.ParentConstraint instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Animations.ConstraintSource>())
			{
				return instance.AddSource(parameters[0].ToObject<UnityEngine.Animations.ConstraintSource>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.ParentConstraint.AddSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.ParentConstraint.AddSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.Vector3 GetRotationOffset(UnityEngine.Animations.ParentConstraint instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetRotationOffset(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.ParentConstraint.GetRotationOffset has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.ParentConstraint.GetRotationOffset has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private UnityEngine.Animations.ConstraintSource GetSource(UnityEngine.Animations.ParentConstraint instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetSource(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.ParentConstraint.GetSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.ParentConstraint.GetSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Animations.ConstraintSource);
		}

		static private UnityEngine.Vector3 GetTranslationOffset(UnityEngine.Animations.ParentConstraint instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetTranslationOffset(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.ParentConstraint.GetTranslationOffset has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.ParentConstraint.GetTranslationOffset has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private void RemoveSource(UnityEngine.Animations.ParentConstraint instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.RemoveSource(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.ParentConstraint.RemoveSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.ParentConstraint.RemoveSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetRotationOffset(UnityEngine.Animations.ParentConstraint instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Vector3>())
			{
				instance.SetRotationOffset(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.ParentConstraint.SetRotationOffset has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.ParentConstraint.SetRotationOffset has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetSource(UnityEngine.Animations.ParentConstraint instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Animations.ConstraintSource>())
			{
				instance.SetSource(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Animations.ConstraintSource>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.ParentConstraint.SetSource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.ParentConstraint.SetSource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTranslationOffset(UnityEngine.Animations.ParentConstraint instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Vector3>())
			{
				instance.SetTranslationOffset(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.ParentConstraint.SetTranslationOffset has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.ParentConstraint.SetTranslationOffset has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Single get_weight(UnityEngine.Animations.ParentConstraint instance, string name)
		{
			return instance.weight;
		}

		static private void set_weight(UnityEngine.Animations.ParentConstraint instance, string name, System.Single value)
		{
			instance.weight = value;
		}

		static private System.Boolean get_constraintActive(UnityEngine.Animations.ParentConstraint instance, string name)
		{
			return instance.constraintActive;
		}

		static private void set_constraintActive(UnityEngine.Animations.ParentConstraint instance, string name, System.Boolean value)
		{
			instance.constraintActive = value;
		}

		static private System.Boolean get_locked(UnityEngine.Animations.ParentConstraint instance, string name)
		{
			return instance.locked;
		}

		static private void set_locked(UnityEngine.Animations.ParentConstraint instance, string name, System.Boolean value)
		{
			instance.locked = value;
		}

		static private System.Int32 get_sourceCount(UnityEngine.Animations.ParentConstraint instance, string name)
		{
			return instance.sourceCount;
		}

		static private UnityEngine.Vector3 get_translationAtRest(UnityEngine.Animations.ParentConstraint instance, string name)
		{
			return instance.translationAtRest;
		}

		static private void set_translationAtRest(UnityEngine.Animations.ParentConstraint instance, string name, UnityEngine.Vector3 value)
		{
			instance.translationAtRest = value;
		}

		static private UnityEngine.Vector3 get_rotationAtRest(UnityEngine.Animations.ParentConstraint instance, string name)
		{
			return instance.rotationAtRest;
		}

		static private void set_rotationAtRest(UnityEngine.Animations.ParentConstraint instance, string name, UnityEngine.Vector3 value)
		{
			instance.rotationAtRest = value;
		}

		static private UnityEngine.Vector3[] get_translationOffsets(UnityEngine.Animations.ParentConstraint instance, string name)
		{
			return instance.translationOffsets;
		}

		static private void set_translationOffsets(UnityEngine.Animations.ParentConstraint instance, string name, UnityEngine.Vector3[] value)
		{
			instance.translationOffsets = value;
		}

		static private UnityEngine.Vector3[] get_rotationOffsets(UnityEngine.Animations.ParentConstraint instance, string name)
		{
			return instance.rotationOffsets;
		}

		static private void set_rotationOffsets(UnityEngine.Animations.ParentConstraint instance, string name, UnityEngine.Vector3[] value)
		{
			instance.rotationOffsets = value;
		}

		static private UnityEngine.Animations.Axis get_translationAxis(UnityEngine.Animations.ParentConstraint instance, string name)
		{
			return instance.translationAxis;
		}

		static private void set_translationAxis(UnityEngine.Animations.ParentConstraint instance, string name, UnityEngine.Animations.Axis value)
		{
			instance.translationAxis = value;
		}

		static private UnityEngine.Animations.Axis get_rotationAxis(UnityEngine.Animations.ParentConstraint instance, string name)
		{
			return instance.rotationAxis;
		}

		static private void set_rotationAxis(UnityEngine.Animations.ParentConstraint instance, string name, UnityEngine.Animations.Axis value)
		{
			instance.rotationAxis = value;
		}

	}
}
