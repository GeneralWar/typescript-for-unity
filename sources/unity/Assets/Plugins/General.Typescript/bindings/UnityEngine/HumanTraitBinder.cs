using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineHumanTrait
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.HumanTrait> self = space.DeclareClass<UnityEngine.HumanTrait>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("BoneFromMuscle", BoneFromMuscle);
			self.BindStaticFunction("GetBoneDefaultHierarchyMass", GetBoneDefaultHierarchyMass);
			self.BindStaticFunction("GetMuscleDefaultMax", GetMuscleDefaultMax);
			self.BindStaticFunction("GetMuscleDefaultMin", GetMuscleDefaultMin);
			self.BindStaticFunction("GetParentBone", GetParentBone);
			self.BindStaticFunction("MuscleFromBone", MuscleFromBone);
			self.BindStaticFunction("RequiredBone", RequiredBone);
			self.BindStaticProperty("MuscleCount", get_MuscleCount, null);
			self.BindStaticProperty("MuscleName", get_MuscleName, null);
			self.BindStaticProperty("BoneCount", get_BoneCount, null);
			self.BindStaticProperty("BoneName", get_BoneName, null);
			self.BindStaticProperty("RequiredBoneCount", get_RequiredBoneCount, null);
		}

		static private UnityEngine.HumanTrait Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.HumanTrait();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.HumanTrait.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.HumanTrait);
		}

		static private System.Int32 BoneFromMuscle(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.HumanTrait.BoneFromMuscle(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.HumanTrait.BoneFromMuscle has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.HumanTrait.BoneFromMuscle has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Single GetBoneDefaultHierarchyMass(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.HumanTrait.GetBoneDefaultHierarchyMass(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.HumanTrait.GetBoneDefaultHierarchyMass has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.HumanTrait.GetBoneDefaultHierarchyMass has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single GetMuscleDefaultMax(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.HumanTrait.GetMuscleDefaultMax(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.HumanTrait.GetMuscleDefaultMax has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.HumanTrait.GetMuscleDefaultMax has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single GetMuscleDefaultMin(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.HumanTrait.GetMuscleDefaultMin(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.HumanTrait.GetMuscleDefaultMin has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.HumanTrait.GetMuscleDefaultMin has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Int32 GetParentBone(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.HumanTrait.GetParentBone(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.HumanTrait.GetParentBone has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.HumanTrait.GetParentBone has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Int32 MuscleFromBone(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return UnityEngine.HumanTrait.MuscleFromBone(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.HumanTrait.MuscleFromBone has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.HumanTrait.MuscleFromBone has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Boolean RequiredBone(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.HumanTrait.RequiredBone(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.HumanTrait.RequiredBone has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.HumanTrait.RequiredBone has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 get_MuscleCount()
		{
			return UnityEngine.HumanTrait.MuscleCount;
		}

		static private System.String[] get_MuscleName()
		{
			return UnityEngine.HumanTrait.MuscleName;
		}

		static private System.Int32 get_BoneCount()
		{
			return UnityEngine.HumanTrait.BoneCount;
		}

		static private System.String[] get_BoneName()
		{
			return UnityEngine.HumanTrait.BoneName;
		}

		static private System.Int32 get_RequiredBoneCount()
		{
			return UnityEngine.HumanTrait.RequiredBoneCount;
		}

	}
}
