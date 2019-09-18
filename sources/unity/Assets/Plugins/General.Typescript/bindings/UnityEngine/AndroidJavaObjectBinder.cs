#if UNITY_ANDROID
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAndroidJavaObject
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AndroidJavaObject> self = space.DeclareClass<UnityEngine.AndroidJavaObject>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Call", Call);
			self.BindInstanceFunction("CallStatic", CallStatic);
			self.BindInstanceFunction("Dispose", Dispose);
			self.BindInstanceFunction("GetRawClass", GetRawClass);
			self.BindInstanceFunction("GetRawObject", GetRawObject);
		}

		static private UnityEngine.AndroidJavaObject Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Object[]>())
			{
				return new UnityEngine.AndroidJavaObject(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJavaObject.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJavaObject.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.AndroidJavaObject);
		}

		static private System.Object Call(UnityEngine.AndroidJavaObject instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Object[]>())
			{
				instance.Call(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object[]>());
				return default(System.Object);
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJavaObject.Call has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJavaObject.Call has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Object CallStatic(UnityEngine.AndroidJavaObject instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Object[]>())
			{
				instance.CallStatic(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object[]>());
				return default(System.Object);
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJavaObject.CallStatic has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJavaObject.CallStatic has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void Dispose(UnityEngine.AndroidJavaObject instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Dispose();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJavaObject.Dispose has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.IntPtr GetRawClass(UnityEngine.AndroidJavaObject instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetRawClass();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJavaObject.GetRawClass has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.IntPtr);
		}

		static private System.IntPtr GetRawObject(UnityEngine.AndroidJavaObject instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetRawObject();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJavaObject.GetRawObject has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.IntPtr);
		}

	}
}
#endif
