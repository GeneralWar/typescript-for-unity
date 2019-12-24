using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineBoneWeight
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.BoneWeight> self = space.DeclareClass<UnityEngine.BoneWeight>();
			self.BindConstructor();
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceProperty("weight0", get_weight0, set_weight0);
			self.BindInstanceProperty("weight1", get_weight1, set_weight1);
			self.BindInstanceProperty("weight2", get_weight2, set_weight2);
			self.BindInstanceProperty("weight3", get_weight3, set_weight3);
			self.BindInstanceProperty("boneIndex0", get_boneIndex0, set_boneIndex0);
			self.BindInstanceProperty("boneIndex1", get_boneIndex1, set_boneIndex1);
			self.BindInstanceProperty("boneIndex2", get_boneIndex2, set_boneIndex2);
			self.BindInstanceProperty("boneIndex3", get_boneIndex3, set_boneIndex3);
		}

		static private System.Boolean Equals(UnityEngine.BoneWeight instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.BoneWeight>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.BoneWeight>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.BoneWeight.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.BoneWeight.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.BoneWeight instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetHashCode();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.BoneWeight.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Single get_weight0(UnityEngine.BoneWeight instance, string name)
		{
			return instance.weight0;
		}

		static private void set_weight0(UnityEngine.BoneWeight instance, string name, System.Single value)
		{
			instance.weight0 = value;
		}

		static private System.Single get_weight1(UnityEngine.BoneWeight instance, string name)
		{
			return instance.weight1;
		}

		static private void set_weight1(UnityEngine.BoneWeight instance, string name, System.Single value)
		{
			instance.weight1 = value;
		}

		static private System.Single get_weight2(UnityEngine.BoneWeight instance, string name)
		{
			return instance.weight2;
		}

		static private void set_weight2(UnityEngine.BoneWeight instance, string name, System.Single value)
		{
			instance.weight2 = value;
		}

		static private System.Single get_weight3(UnityEngine.BoneWeight instance, string name)
		{
			return instance.weight3;
		}

		static private void set_weight3(UnityEngine.BoneWeight instance, string name, System.Single value)
		{
			instance.weight3 = value;
		}

		static private System.Int32 get_boneIndex0(UnityEngine.BoneWeight instance, string name)
		{
			return instance.boneIndex0;
		}

		static private void set_boneIndex0(UnityEngine.BoneWeight instance, string name, System.Int32 value)
		{
			instance.boneIndex0 = value;
		}

		static private System.Int32 get_boneIndex1(UnityEngine.BoneWeight instance, string name)
		{
			return instance.boneIndex1;
		}

		static private void set_boneIndex1(UnityEngine.BoneWeight instance, string name, System.Int32 value)
		{
			instance.boneIndex1 = value;
		}

		static private System.Int32 get_boneIndex2(UnityEngine.BoneWeight instance, string name)
		{
			return instance.boneIndex2;
		}

		static private void set_boneIndex2(UnityEngine.BoneWeight instance, string name, System.Int32 value)
		{
			instance.boneIndex2 = value;
		}

		static private System.Int32 get_boneIndex3(UnityEngine.BoneWeight instance, string name)
		{
			return instance.boneIndex3;
		}

		static private void set_boneIndex3(UnityEngine.BoneWeight instance, string name, System.Int32 value)
		{
			instance.boneIndex3 = value;
		}

	}
}
