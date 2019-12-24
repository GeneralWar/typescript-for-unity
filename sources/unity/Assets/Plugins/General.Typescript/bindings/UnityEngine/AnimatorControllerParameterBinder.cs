using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimatorControllerParameter
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AnimatorControllerParameter> self = space.DeclareClass<UnityEngine.AnimatorControllerParameter>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceProperty("name", get_name, null);
			self.BindInstanceProperty("nameHash", get_nameHash, null);
			self.BindInstanceProperty("type", get_type, set_type);
			self.BindInstanceProperty("defaultFloat", get_defaultFloat, set_defaultFloat);
			self.BindInstanceProperty("defaultInt", get_defaultInt, set_defaultInt);
			self.BindInstanceProperty("defaultBool", get_defaultBool, set_defaultBool);
		}

		static private UnityEngine.AnimatorControllerParameter Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.AnimatorControllerParameter();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimatorControllerParameter.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.AnimatorControllerParameter);
		}

		static private System.Boolean Equals(UnityEngine.AnimatorControllerParameter instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimatorControllerParameter.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimatorControllerParameter.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.AnimatorControllerParameter instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimatorControllerParameter.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.String get_name(UnityEngine.AnimatorControllerParameter instance, string name)
		{
			return instance.name;
		}

		static private System.Int32 get_nameHash(UnityEngine.AnimatorControllerParameter instance, string name)
		{
			return instance.nameHash;
		}

		static private UnityEngine.AnimatorControllerParameterType get_type(UnityEngine.AnimatorControllerParameter instance, string name)
		{
			return instance.type;
		}

		static private void set_type(UnityEngine.AnimatorControllerParameter instance, string name, UnityEngine.AnimatorControllerParameterType value)
		{
			instance.type = value;
		}

		static private System.Single get_defaultFloat(UnityEngine.AnimatorControllerParameter instance, string name)
		{
			return instance.defaultFloat;
		}

		static private void set_defaultFloat(UnityEngine.AnimatorControllerParameter instance, string name, System.Single value)
		{
			instance.defaultFloat = value;
		}

		static private System.Int32 get_defaultInt(UnityEngine.AnimatorControllerParameter instance, string name)
		{
			return instance.defaultInt;
		}

		static private void set_defaultInt(UnityEngine.AnimatorControllerParameter instance, string name, System.Int32 value)
		{
			instance.defaultInt = value;
		}

		static private System.Boolean get_defaultBool(UnityEngine.AnimatorControllerParameter instance, string name)
		{
			return instance.defaultBool;
		}

		static private void set_defaultBool(UnityEngine.AnimatorControllerParameter instance, string name, System.Boolean value)
		{
			instance.defaultBool = value;
		}

	}
}
