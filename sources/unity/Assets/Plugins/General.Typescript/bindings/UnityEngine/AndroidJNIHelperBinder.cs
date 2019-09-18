#if UNITY_ANDROID
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAndroidJNIHelper
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AndroidJNIHelper> self = space.DeclareClass<UnityEngine.AndroidJNIHelper>();
			self.BindConstructor();
			self.BindStaticFunction("ConvertToJNIArray", ConvertToJNIArray);
			self.BindStaticFunction("CreateJavaProxy", CreateJavaProxy);
			self.BindStaticFunction("CreateJNIArgArray", CreateJNIArgArray);
			self.BindStaticFunction("DeleteJNIArgArray", DeleteJNIArgArray);
			self.BindStaticFunction("GetConstructorID", GetConstructorID);
			self.BindStaticFunction("GetFieldID", GetFieldID);
			self.BindStaticFunction("GetMethodID", GetMethodID);
			self.BindStaticFunction("GetSignature", GetSignature);
			self.BindStaticProperty("debug", get_debug, set_debug);
		}

		static private System.IntPtr ConvertToJNIArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Array>())
			{
				return UnityEngine.AndroidJNIHelper.ConvertToJNIArray(parameters[0].ToObject<System.Array>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNIHelper.ConvertToJNIArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNIHelper.ConvertToJNIArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr CreateJavaProxy(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AndroidJavaProxy>())
			{
				return UnityEngine.AndroidJNIHelper.CreateJavaProxy(parameters[0].ToObject<UnityEngine.AndroidJavaProxy>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNIHelper.CreateJavaProxy has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNIHelper.CreateJavaProxy has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private UnityEngine.jvalue[] CreateJNIArgArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object[]>())
			{
				return UnityEngine.AndroidJNIHelper.CreateJNIArgArray(parameters[0].ToObject<System.Object[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNIHelper.CreateJNIArgArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNIHelper.CreateJNIArgArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void DeleteJNIArgArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object[], UnityEngine.jvalue[]>())
			{
				UnityEngine.AndroidJNIHelper.DeleteJNIArgArray(parameters[0].ToObject<System.Object[]>(), parameters[1].ToObject<UnityEngine.jvalue[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNIHelper.DeleteJNIArgArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNIHelper.DeleteJNIArgArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.IntPtr GetConstructorID(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNIHelper.GetConstructorID(parameters[0].ToObject<System.IntPtr>());
			}
			if (parameters.CheckTypes<System.IntPtr, System.String>())
			{
				return UnityEngine.AndroidJNIHelper.GetConstructorID(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.IntPtr, System.Object[]>())
			{
				return UnityEngine.AndroidJNIHelper.GetConstructorID(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Object[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNIHelper.GetConstructorID has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNIHelper.GetConstructorID has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr GetFieldID(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.String>())
			{
				return UnityEngine.AndroidJNIHelper.GetFieldID(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.IntPtr, System.String, System.String>())
			{
				return UnityEngine.AndroidJNIHelper.GetFieldID(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.IntPtr, System.String, System.String, System.Boolean>())
			{
				return UnityEngine.AndroidJNIHelper.GetFieldID(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>(), parameters[3].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNIHelper.GetFieldID has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNIHelper.GetFieldID has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr GetMethodID(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.String>())
			{
				return UnityEngine.AndroidJNIHelper.GetMethodID(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.IntPtr, System.String, System.String>())
			{
				return UnityEngine.AndroidJNIHelper.GetMethodID(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.IntPtr, System.String, System.String, System.Boolean>())
			{
				return UnityEngine.AndroidJNIHelper.GetMethodID(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>(), parameters[3].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.IntPtr, System.String, System.Object[], System.Boolean>())
			{
				return UnityEngine.AndroidJNIHelper.GetMethodID(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Object[]>(), parameters[3].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNIHelper.GetMethodID has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNIHelper.GetMethodID has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.String GetSignature(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return UnityEngine.AndroidJNIHelper.GetSignature(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<System.Object[]>())
			{
				return UnityEngine.AndroidJNIHelper.GetSignature(parameters[0].ToObject<System.Object[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNIHelper.GetSignature has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNIHelper.GetSignature has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean get_debug()
		{
			return UnityEngine.AndroidJNIHelper.debug;
		}

		static private void set_debug(System.Boolean value)
		{
			UnityEngine.AndroidJNIHelper.debug = value;
		}

	}
}
#endif
