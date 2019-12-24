using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineHash128
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Hash128> self = space.DeclareClass<UnityEngine.Hash128>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("Compute", Compute);
			self.BindStaticFunction("Parse", Parse);
			self.BindInstanceFunction("CompareTo", CompareTo);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("isValid", get_isValid, null);
		}

		static private UnityEngine.Hash128 Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.UInt64, System.UInt64>())
			{
				return new UnityEngine.Hash128(parameters[0].ToObject<System.UInt64>(), parameters[1].ToObject<System.UInt64>());
			}
			if (parameters.CheckTypes<System.UInt32, System.UInt32, System.UInt32, System.UInt32>())
			{
				return new UnityEngine.Hash128(parameters[0].ToObject<System.UInt32>(), parameters[1].ToObject<System.UInt32>(), parameters[2].ToObject<System.UInt32>(), parameters[3].ToObject<System.UInt32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Hash128.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Hash128.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Hash128);
		}

		static private UnityEngine.Hash128 Compute(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Hash128.Compute(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Hash128.Compute has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Hash128.Compute has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Hash128);
		}

		static private UnityEngine.Hash128 Parse(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Hash128.Parse(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Hash128.Parse has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Hash128.Parse has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Hash128);
		}

		static private System.Int32 CompareTo(UnityEngine.Hash128 instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Hash128>())
			{
				return instance.CompareTo(parameters[0].ToObject<UnityEngine.Hash128>());
			}
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.CompareTo(parameters[0].ToObject<System.Object>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Hash128.CompareTo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Hash128.CompareTo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Boolean Equals(UnityEngine.Hash128 instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.Hash128>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Hash128>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Hash128.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Hash128.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.Hash128 instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Hash128.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.String ToString(UnityEngine.Hash128 instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Hash128.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Boolean get_isValid(UnityEngine.Hash128 instance, string name)
		{
			return instance.isValid;
		}

	}
}
