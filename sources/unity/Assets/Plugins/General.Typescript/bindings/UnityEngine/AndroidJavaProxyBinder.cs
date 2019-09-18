#if UNITY_ANDROID
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAndroidJavaProxy
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AndroidJavaProxy> self = space.DeclareClass<UnityEngine.AndroidJavaProxy>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("equals", equals);
			self.BindInstanceFunction("hashCode", hashCode);
			self.BindInstanceFunction("Invoke", Invoke);
			self.BindInstanceFunction("toString", toString);
		}

		static private UnityEngine.AndroidJavaProxy Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return new UnityEngine.AndroidJavaProxy(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<UnityEngine.AndroidJavaClass>())
			{
				return new UnityEngine.AndroidJavaProxy(parameters[0].ToObject<UnityEngine.AndroidJavaClass>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJavaProxy.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJavaProxy.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.AndroidJavaProxy);
		}

		static private System.Boolean equals(UnityEngine.AndroidJavaProxy instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AndroidJavaObject>())
			{
				return instance.equals(parameters[0].ToObject<UnityEngine.AndroidJavaObject>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJavaProxy.equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJavaProxy.equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 hashCode(UnityEngine.AndroidJavaProxy instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.hashCode();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJavaProxy.hashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private UnityEngine.AndroidJavaObject Invoke(UnityEngine.AndroidJavaProxy instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Object[]>())
			{
				return instance.Invoke(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object[]>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.AndroidJavaObject[]>())
			{
				return instance.Invoke(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.AndroidJavaObject[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJavaProxy.Invoke has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJavaProxy.Invoke has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.String toString(UnityEngine.AndroidJavaProxy instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.toString();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJavaProxy.toString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

	}
}
#endif
