using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAssertionsComparersFloatComparer
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Assertions.Comparers.FloatComparer> self = space.DeclareClass<UnityEngine.Assertions.Comparers.FloatComparer>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("AreEqual", AreEqual);
			self.BindStaticFunction("AreEqualRelative", AreEqualRelative);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
		}

		static private UnityEngine.Assertions.Comparers.FloatComparer Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Assertions.Comparers.FloatComparer();
			}
			if (parameters.CheckTypes<System.Boolean>())
			{
				return new UnityEngine.Assertions.Comparers.FloatComparer(parameters[0].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.Single>())
			{
				return new UnityEngine.Assertions.Comparers.FloatComparer(parameters[0].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<System.Single, System.Boolean>())
			{
				return new UnityEngine.Assertions.Comparers.FloatComparer(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Boolean>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Assertions.Comparers.FloatComparer.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Assertions.Comparers.FloatComparer);
		}

		static private System.Boolean AreEqual(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Assertions.Comparers.FloatComparer.AreEqual(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Assertions.Comparers.FloatComparer.AreEqual has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Assertions.Comparers.FloatComparer.AreEqual has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean AreEqualRelative(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Assertions.Comparers.FloatComparer.AreEqualRelative(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Assertions.Comparers.FloatComparer.AreEqualRelative has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Assertions.Comparers.FloatComparer.AreEqualRelative has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean Equals(UnityEngine.Assertions.Comparers.FloatComparer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return instance.Equals(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Assertions.Comparers.FloatComparer.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Assertions.Comparers.FloatComparer.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.Assertions.Comparers.FloatComparer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return instance.GetHashCode(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Assertions.Comparers.FloatComparer.GetHashCode has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Assertions.Comparers.FloatComparer.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

	}
}
