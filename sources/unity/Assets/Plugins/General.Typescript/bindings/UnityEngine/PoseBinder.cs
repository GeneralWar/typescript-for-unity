using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePose
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Pose> self = space.DeclareClass<UnityEngine.Pose>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("GetTransformedBy", GetTransformedBy);
			self.BindInstanceFunction("ToString", ToString);
			self.BindStaticProperty("identity", get_identity, null);
			self.BindInstanceProperty("forward", get_forward, null);
			self.BindInstanceProperty("right", get_right, null);
			self.BindInstanceProperty("up", get_up, null);
		}

		static private UnityEngine.Pose Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Quaternion>())
			{
				return new UnityEngine.Pose(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Quaternion>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Pose.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Pose.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Pose);
		}

		static private System.Boolean Equals(UnityEngine.Pose instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.Pose>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Pose>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Pose.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Pose.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.Pose instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Pose.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private UnityEngine.Pose GetTransformedBy(UnityEngine.Pose instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Pose>())
			{
				return instance.GetTransformedBy(parameters[0].ToObject<UnityEngine.Pose>());
			}
			if (parameters.CheckTypes<UnityEngine.Transform>())
			{
				return instance.GetTransformedBy(parameters[0].ToObject<UnityEngine.Transform>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Pose.GetTransformedBy has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Pose.GetTransformedBy has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Pose);
		}

		static private System.String ToString(UnityEngine.Pose instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return instance.ToString(parameters[0].ToObject<System.String>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Pose.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Pose get_identity(Type type, string name)
		{
			return UnityEngine.Pose.identity;
		}

		static private UnityEngine.Vector3 get_forward(UnityEngine.Pose instance, string name)
		{
			return instance.forward;
		}

		static private UnityEngine.Vector3 get_right(UnityEngine.Pose instance, string name)
		{
			return instance.right;
		}

		static private UnityEngine.Vector3 get_up(UnityEngine.Pose instance, string name)
		{
			return instance.up;
		}

	}
}
