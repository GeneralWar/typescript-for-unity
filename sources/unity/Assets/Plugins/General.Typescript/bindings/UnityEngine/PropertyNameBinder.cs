using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePropertyName
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.PropertyName> self = space.DeclareClass<UnityEngine.PropertyName>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("IsNullOrEmpty", IsNullOrEmpty);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("ToString", ToString);
		}

		static private UnityEngine.PropertyName Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return new UnityEngine.PropertyName(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<UnityEngine.PropertyName>())
			{
				return new UnityEngine.PropertyName(parameters[0].ToObject<UnityEngine.PropertyName>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return new UnityEngine.PropertyName(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.PropertyName.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.PropertyName.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.PropertyName);
		}

		static private System.Boolean IsNullOrEmpty(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.PropertyName>())
			{
				return UnityEngine.PropertyName.IsNullOrEmpty(parameters[0].ToObject<UnityEngine.PropertyName>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.PropertyName.IsNullOrEmpty has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.PropertyName.IsNullOrEmpty has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean Equals(UnityEngine.PropertyName instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.PropertyName>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.PropertyName>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.PropertyName.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.PropertyName.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.PropertyName instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.PropertyName.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.String ToString(UnityEngine.PropertyName instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.PropertyName.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

	}
}
