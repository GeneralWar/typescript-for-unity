#if UNITY_ANDROID
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAndroidJNI
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AndroidJNI> self = space.DeclareClass<UnityEngine.AndroidJNI>();
			self.BindConstructor();
			self.BindStaticFunction("AllocObject", AllocObject);
			self.BindStaticFunction("AttachCurrentThread", AttachCurrentThread);
			self.BindStaticFunction("CallBooleanMethod", CallBooleanMethod);
			self.BindStaticFunction("CallByteMethod", CallByteMethod);
			self.BindStaticFunction("CallCharMethod", CallCharMethod);
			self.BindStaticFunction("CallDoubleMethod", CallDoubleMethod);
			self.BindStaticFunction("CallFloatMethod", CallFloatMethod);
			self.BindStaticFunction("CallIntMethod", CallIntMethod);
			self.BindStaticFunction("CallLongMethod", CallLongMethod);
			self.BindStaticFunction("CallObjectMethod", CallObjectMethod);
			self.BindStaticFunction("CallShortMethod", CallShortMethod);
			self.BindStaticFunction("CallStaticBooleanMethod", CallStaticBooleanMethod);
			self.BindStaticFunction("CallStaticByteMethod", CallStaticByteMethod);
			self.BindStaticFunction("CallStaticCharMethod", CallStaticCharMethod);
			self.BindStaticFunction("CallStaticDoubleMethod", CallStaticDoubleMethod);
			self.BindStaticFunction("CallStaticFloatMethod", CallStaticFloatMethod);
			self.BindStaticFunction("CallStaticIntMethod", CallStaticIntMethod);
			self.BindStaticFunction("CallStaticLongMethod", CallStaticLongMethod);
			self.BindStaticFunction("CallStaticObjectMethod", CallStaticObjectMethod);
			self.BindStaticFunction("CallStaticShortMethod", CallStaticShortMethod);
			self.BindStaticFunction("CallStaticStringMethod", CallStaticStringMethod);
			self.BindStaticFunction("CallStaticVoidMethod", CallStaticVoidMethod);
			self.BindStaticFunction("CallStringMethod", CallStringMethod);
			self.BindStaticFunction("CallVoidMethod", CallVoidMethod);
			self.BindStaticFunction("DeleteGlobalRef", DeleteGlobalRef);
			self.BindStaticFunction("DeleteLocalRef", DeleteLocalRef);
			self.BindStaticFunction("DetachCurrentThread", DetachCurrentThread);
			self.BindStaticFunction("EnsureLocalCapacity", EnsureLocalCapacity);
			self.BindStaticFunction("ExceptionClear", ExceptionClear);
			self.BindStaticFunction("ExceptionDescribe", ExceptionDescribe);
			self.BindStaticFunction("ExceptionOccurred", ExceptionOccurred);
			self.BindStaticFunction("FatalError", FatalError);
			self.BindStaticFunction("FindClass", FindClass);
			self.BindStaticFunction("FromBooleanArray", FromBooleanArray);
			self.BindStaticFunction("FromByteArray", FromByteArray);
			self.BindStaticFunction("FromCharArray", FromCharArray);
			self.BindStaticFunction("FromDoubleArray", FromDoubleArray);
			self.BindStaticFunction("FromFloatArray", FromFloatArray);
			self.BindStaticFunction("FromIntArray", FromIntArray);
			self.BindStaticFunction("FromLongArray", FromLongArray);
			self.BindStaticFunction("FromObjectArray", FromObjectArray);
			self.BindStaticFunction("FromReflectedField", FromReflectedField);
			self.BindStaticFunction("FromReflectedMethod", FromReflectedMethod);
			self.BindStaticFunction("FromShortArray", FromShortArray);
			self.BindStaticFunction("GetArrayLength", GetArrayLength);
			self.BindStaticFunction("GetBooleanArrayElement", GetBooleanArrayElement);
			self.BindStaticFunction("GetBooleanField", GetBooleanField);
			self.BindStaticFunction("GetByteArrayElement", GetByteArrayElement);
			self.BindStaticFunction("GetByteField", GetByteField);
			self.BindStaticFunction("GetCharArrayElement", GetCharArrayElement);
			self.BindStaticFunction("GetCharField", GetCharField);
			self.BindStaticFunction("GetDoubleArrayElement", GetDoubleArrayElement);
			self.BindStaticFunction("GetDoubleField", GetDoubleField);
			self.BindStaticFunction("GetFieldID", GetFieldID);
			self.BindStaticFunction("GetFloatArrayElement", GetFloatArrayElement);
			self.BindStaticFunction("GetFloatField", GetFloatField);
			self.BindStaticFunction("GetIntArrayElement", GetIntArrayElement);
			self.BindStaticFunction("GetIntField", GetIntField);
			self.BindStaticFunction("GetLongArrayElement", GetLongArrayElement);
			self.BindStaticFunction("GetLongField", GetLongField);
			self.BindStaticFunction("GetMethodID", GetMethodID);
			self.BindStaticFunction("GetObjectArrayElement", GetObjectArrayElement);
			self.BindStaticFunction("GetObjectClass", GetObjectClass);
			self.BindStaticFunction("GetObjectField", GetObjectField);
			self.BindStaticFunction("GetShortArrayElement", GetShortArrayElement);
			self.BindStaticFunction("GetShortField", GetShortField);
			self.BindStaticFunction("GetStaticBooleanField", GetStaticBooleanField);
			self.BindStaticFunction("GetStaticByteField", GetStaticByteField);
			self.BindStaticFunction("GetStaticCharField", GetStaticCharField);
			self.BindStaticFunction("GetStaticDoubleField", GetStaticDoubleField);
			self.BindStaticFunction("GetStaticFieldID", GetStaticFieldID);
			self.BindStaticFunction("GetStaticFloatField", GetStaticFloatField);
			self.BindStaticFunction("GetStaticIntField", GetStaticIntField);
			self.BindStaticFunction("GetStaticLongField", GetStaticLongField);
			self.BindStaticFunction("GetStaticMethodID", GetStaticMethodID);
			self.BindStaticFunction("GetStaticObjectField", GetStaticObjectField);
			self.BindStaticFunction("GetStaticShortField", GetStaticShortField);
			self.BindStaticFunction("GetStaticStringField", GetStaticStringField);
			self.BindStaticFunction("GetStringField", GetStringField);
			self.BindStaticFunction("GetStringUTFChars", GetStringUTFChars);
			self.BindStaticFunction("GetStringUTFLength", GetStringUTFLength);
			self.BindStaticFunction("GetSuperclass", GetSuperclass);
			self.BindStaticFunction("GetVersion", GetVersion);
			self.BindStaticFunction("IsAssignableFrom", IsAssignableFrom);
			self.BindStaticFunction("IsInstanceOf", IsInstanceOf);
			self.BindStaticFunction("IsSameObject", IsSameObject);
			self.BindStaticFunction("NewBooleanArray", NewBooleanArray);
			self.BindStaticFunction("NewByteArray", NewByteArray);
			self.BindStaticFunction("NewCharArray", NewCharArray);
			self.BindStaticFunction("NewDoubleArray", NewDoubleArray);
			self.BindStaticFunction("NewFloatArray", NewFloatArray);
			self.BindStaticFunction("NewGlobalRef", NewGlobalRef);
			self.BindStaticFunction("NewIntArray", NewIntArray);
			self.BindStaticFunction("NewLocalRef", NewLocalRef);
			self.BindStaticFunction("NewLongArray", NewLongArray);
			self.BindStaticFunction("NewObject", NewObject);
			self.BindStaticFunction("NewObjectArray", NewObjectArray);
			self.BindStaticFunction("NewShortArray", NewShortArray);
			self.BindStaticFunction("NewStringUTF", NewStringUTF);
			self.BindStaticFunction("PopLocalFrame", PopLocalFrame);
			self.BindStaticFunction("PushLocalFrame", PushLocalFrame);
			self.BindStaticFunction("SetBooleanArrayElement", SetBooleanArrayElement);
			self.BindStaticFunction("SetBooleanField", SetBooleanField);
			self.BindStaticFunction("SetByteArrayElement", SetByteArrayElement);
			self.BindStaticFunction("SetByteField", SetByteField);
			self.BindStaticFunction("SetCharArrayElement", SetCharArrayElement);
			self.BindStaticFunction("SetCharField", SetCharField);
			self.BindStaticFunction("SetDoubleArrayElement", SetDoubleArrayElement);
			self.BindStaticFunction("SetDoubleField", SetDoubleField);
			self.BindStaticFunction("SetFloatArrayElement", SetFloatArrayElement);
			self.BindStaticFunction("SetFloatField", SetFloatField);
			self.BindStaticFunction("SetIntArrayElement", SetIntArrayElement);
			self.BindStaticFunction("SetIntField", SetIntField);
			self.BindStaticFunction("SetLongArrayElement", SetLongArrayElement);
			self.BindStaticFunction("SetLongField", SetLongField);
			self.BindStaticFunction("SetObjectArrayElement", SetObjectArrayElement);
			self.BindStaticFunction("SetObjectField", SetObjectField);
			self.BindStaticFunction("SetShortArrayElement", SetShortArrayElement);
			self.BindStaticFunction("SetShortField", SetShortField);
			self.BindStaticFunction("SetStaticBooleanField", SetStaticBooleanField);
			self.BindStaticFunction("SetStaticByteField", SetStaticByteField);
			self.BindStaticFunction("SetStaticCharField", SetStaticCharField);
			self.BindStaticFunction("SetStaticDoubleField", SetStaticDoubleField);
			self.BindStaticFunction("SetStaticFloatField", SetStaticFloatField);
			self.BindStaticFunction("SetStaticIntField", SetStaticIntField);
			self.BindStaticFunction("SetStaticLongField", SetStaticLongField);
			self.BindStaticFunction("SetStaticObjectField", SetStaticObjectField);
			self.BindStaticFunction("SetStaticShortField", SetStaticShortField);
			self.BindStaticFunction("SetStaticStringField", SetStaticStringField);
			self.BindStaticFunction("SetStringField", SetStringField);
			self.BindStaticFunction("Throw", Throw);
			self.BindStaticFunction("ThrowNew", ThrowNew);
			self.BindStaticFunction("ToBooleanArray", ToBooleanArray);
			self.BindStaticFunction("ToByteArray", ToByteArray);
			self.BindStaticFunction("ToCharArray", ToCharArray);
			self.BindStaticFunction("ToDoubleArray", ToDoubleArray);
			self.BindStaticFunction("ToFloatArray", ToFloatArray);
			self.BindStaticFunction("ToIntArray", ToIntArray);
			self.BindStaticFunction("ToLongArray", ToLongArray);
			self.BindStaticFunction("ToObjectArray", ToObjectArray);
			self.BindStaticFunction("ToReflectedField", ToReflectedField);
			self.BindStaticFunction("ToReflectedMethod", ToReflectedMethod);
			self.BindStaticFunction("ToShortArray", ToShortArray);
		}

		static private System.IntPtr AllocObject(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.AllocObject(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.AllocObject has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.AllocObject has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.Int32 AttachCurrentThread(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.AndroidJNI.AttachCurrentThread();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.AttachCurrentThread has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Boolean CallBooleanMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallBooleanMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallBooleanMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallBooleanMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Byte CallByteMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallByteMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallByteMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallByteMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Byte);
		}

		static private System.Char CallCharMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallCharMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallCharMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallCharMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Char);
		}

		static private System.Double CallDoubleMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallDoubleMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallDoubleMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallDoubleMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Double);
		}

		static private System.Single CallFloatMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallFloatMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallFloatMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallFloatMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Int32 CallIntMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallIntMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallIntMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallIntMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Int64 CallLongMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallLongMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallLongMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallLongMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int64);
		}

		static private System.IntPtr CallObjectMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallObjectMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallObjectMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallObjectMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.Int16 CallShortMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallShortMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallShortMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallShortMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int16);
		}

		static private System.Boolean CallStaticBooleanMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallStaticBooleanMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallStaticBooleanMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallStaticBooleanMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Byte CallStaticByteMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallStaticByteMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallStaticByteMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallStaticByteMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Byte);
		}

		static private System.Char CallStaticCharMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallStaticCharMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallStaticCharMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallStaticCharMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Char);
		}

		static private System.Double CallStaticDoubleMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallStaticDoubleMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallStaticDoubleMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallStaticDoubleMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Double);
		}

		static private System.Single CallStaticFloatMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallStaticFloatMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallStaticFloatMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallStaticFloatMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Int32 CallStaticIntMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallStaticIntMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallStaticIntMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallStaticIntMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Int64 CallStaticLongMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallStaticLongMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallStaticLongMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallStaticLongMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int64);
		}

		static private System.IntPtr CallStaticObjectMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallStaticObjectMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallStaticObjectMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallStaticObjectMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.Int16 CallStaticShortMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallStaticShortMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallStaticShortMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallStaticShortMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int16);
		}

		static private System.String CallStaticStringMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallStaticStringMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallStaticStringMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallStaticStringMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void CallStaticVoidMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				UnityEngine.AndroidJNI.CallStaticVoidMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallStaticVoidMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallStaticVoidMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.String CallStringMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.CallStringMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallStringMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallStringMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void CallVoidMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				UnityEngine.AndroidJNI.CallVoidMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.CallVoidMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.CallVoidMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DeleteGlobalRef(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				UnityEngine.AndroidJNI.DeleteGlobalRef(parameters[0].ToObject<System.IntPtr>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.DeleteGlobalRef has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.DeleteGlobalRef has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DeleteLocalRef(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				UnityEngine.AndroidJNI.DeleteLocalRef(parameters[0].ToObject<System.IntPtr>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.DeleteLocalRef has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.DeleteLocalRef has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 DetachCurrentThread(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.AndroidJNI.DetachCurrentThread();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.DetachCurrentThread has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Int32 EnsureLocalCapacity(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.AndroidJNI.EnsureLocalCapacity(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.EnsureLocalCapacity has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.EnsureLocalCapacity has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void ExceptionClear(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.AndroidJNI.ExceptionClear();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.ExceptionClear has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ExceptionDescribe(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.AndroidJNI.ExceptionDescribe();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.ExceptionDescribe has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.IntPtr ExceptionOccurred(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.AndroidJNI.ExceptionOccurred();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.ExceptionOccurred has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.IntPtr);
		}

		static private void FatalError(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				UnityEngine.AndroidJNI.FatalError(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.FatalError has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.FatalError has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.IntPtr FindClass(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.AndroidJNI.FindClass(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.FindClass has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.FindClass has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.Boolean[] FromBooleanArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.FromBooleanArray(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.FromBooleanArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.FromBooleanArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Byte[] FromByteArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.FromByteArray(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.FromByteArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.FromByteArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Char[] FromCharArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.FromCharArray(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.FromCharArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.FromCharArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Double[] FromDoubleArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.FromDoubleArray(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.FromDoubleArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.FromDoubleArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Single[] FromFloatArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.FromFloatArray(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.FromFloatArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.FromFloatArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32[] FromIntArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.FromIntArray(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.FromIntArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.FromIntArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int64[] FromLongArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.FromLongArray(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.FromLongArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.FromLongArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.IntPtr[] FromObjectArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.FromObjectArray(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.FromObjectArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.FromObjectArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.IntPtr FromReflectedField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.FromReflectedField(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.FromReflectedField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.FromReflectedField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr FromReflectedMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.FromReflectedMethod(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.FromReflectedMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.FromReflectedMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.Int16[] FromShortArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.FromShortArray(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.FromShortArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.FromShortArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 GetArrayLength(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetArrayLength(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetArrayLength has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetArrayLength has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Boolean GetBooleanArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32>())
			{
				return UnityEngine.AndroidJNI.GetBooleanArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetBooleanArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetBooleanArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean GetBooleanField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetBooleanField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetBooleanField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetBooleanField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Byte GetByteArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32>())
			{
				return UnityEngine.AndroidJNI.GetByteArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetByteArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetByteArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Byte);
		}

		static private System.Byte GetByteField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetByteField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetByteField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetByteField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Byte);
		}

		static private System.Char GetCharArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32>())
			{
				return UnityEngine.AndroidJNI.GetCharArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetCharArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetCharArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Char);
		}

		static private System.Char GetCharField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetCharField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetCharField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetCharField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Char);
		}

		static private System.Double GetDoubleArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32>())
			{
				return UnityEngine.AndroidJNI.GetDoubleArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetDoubleArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetDoubleArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Double);
		}

		static private System.Double GetDoubleField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetDoubleField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetDoubleField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetDoubleField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Double);
		}

		static private System.IntPtr GetFieldID(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.String, System.String>())
			{
				return UnityEngine.AndroidJNI.GetFieldID(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetFieldID has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetFieldID has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.Single GetFloatArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32>())
			{
				return UnityEngine.AndroidJNI.GetFloatArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetFloatArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetFloatArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single GetFloatField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetFloatField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetFloatField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetFloatField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Int32 GetIntArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32>())
			{
				return UnityEngine.AndroidJNI.GetIntArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetIntArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetIntArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Int32 GetIntField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetIntField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetIntField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetIntField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Int64 GetLongArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32>())
			{
				return UnityEngine.AndroidJNI.GetLongArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetLongArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetLongArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int64);
		}

		static private System.Int64 GetLongField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetLongField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetLongField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetLongField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int64);
		}

		static private System.IntPtr GetMethodID(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.String, System.String>())
			{
				return UnityEngine.AndroidJNI.GetMethodID(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetMethodID has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetMethodID has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr GetObjectArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32>())
			{
				return UnityEngine.AndroidJNI.GetObjectArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetObjectArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetObjectArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr GetObjectClass(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetObjectClass(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetObjectClass has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetObjectClass has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr GetObjectField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetObjectField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetObjectField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetObjectField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.Int16 GetShortArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32>())
			{
				return UnityEngine.AndroidJNI.GetShortArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetShortArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetShortArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int16);
		}

		static private System.Int16 GetShortField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetShortField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetShortField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetShortField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int16);
		}

		static private System.Boolean GetStaticBooleanField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetStaticBooleanField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetStaticBooleanField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetStaticBooleanField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Byte GetStaticByteField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetStaticByteField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetStaticByteField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetStaticByteField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Byte);
		}

		static private System.Char GetStaticCharField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetStaticCharField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetStaticCharField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetStaticCharField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Char);
		}

		static private System.Double GetStaticDoubleField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetStaticDoubleField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetStaticDoubleField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetStaticDoubleField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Double);
		}

		static private System.IntPtr GetStaticFieldID(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.String, System.String>())
			{
				return UnityEngine.AndroidJNI.GetStaticFieldID(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetStaticFieldID has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetStaticFieldID has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.Single GetStaticFloatField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetStaticFloatField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetStaticFloatField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetStaticFloatField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Int32 GetStaticIntField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetStaticIntField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetStaticIntField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetStaticIntField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Int64 GetStaticLongField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetStaticLongField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetStaticLongField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetStaticLongField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int64);
		}

		static private System.IntPtr GetStaticMethodID(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.String, System.String>())
			{
				return UnityEngine.AndroidJNI.GetStaticMethodID(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetStaticMethodID has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetStaticMethodID has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr GetStaticObjectField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetStaticObjectField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetStaticObjectField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetStaticObjectField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.Int16 GetStaticShortField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetStaticShortField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetStaticShortField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetStaticShortField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int16);
		}

		static private System.String GetStaticStringField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetStaticStringField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetStaticStringField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetStaticStringField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.String GetStringField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetStringField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetStringField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetStringField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.String GetStringUTFChars(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetStringUTFChars(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetStringUTFChars has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetStringUTFChars has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 GetStringUTFLength(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetStringUTFLength(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetStringUTFLength has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetStringUTFLength has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.IntPtr GetSuperclass(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.GetSuperclass(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.GetSuperclass has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetSuperclass has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.Int32 GetVersion(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.AndroidJNI.GetVersion();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.GetVersion has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Boolean IsAssignableFrom(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.IsAssignableFrom(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.IsAssignableFrom has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.IsAssignableFrom has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean IsInstanceOf(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.IsInstanceOf(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.IsInstanceOf has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.IsInstanceOf has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean IsSameObject(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.IsSameObject(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.IsSameObject has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.IsSameObject has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.IntPtr NewBooleanArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.AndroidJNI.NewBooleanArray(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.NewBooleanArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.NewBooleanArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr NewByteArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.AndroidJNI.NewByteArray(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.NewByteArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.NewByteArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr NewCharArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.AndroidJNI.NewCharArray(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.NewCharArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.NewCharArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr NewDoubleArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.AndroidJNI.NewDoubleArray(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.NewDoubleArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.NewDoubleArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr NewFloatArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.AndroidJNI.NewFloatArray(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.NewFloatArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.NewFloatArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr NewGlobalRef(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.NewGlobalRef(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.NewGlobalRef has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.NewGlobalRef has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr NewIntArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.AndroidJNI.NewIntArray(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.NewIntArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.NewIntArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr NewLocalRef(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.NewLocalRef(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.NewLocalRef has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.NewLocalRef has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr NewLongArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.AndroidJNI.NewLongArray(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.NewLongArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.NewLongArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr NewObject(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, UnityEngine.jvalue[]>())
			{
				return UnityEngine.AndroidJNI.NewObject(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<UnityEngine.jvalue[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.NewObject has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.NewObject has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr NewObjectArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.IntPtr, System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.NewObjectArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.NewObjectArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.NewObjectArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr NewShortArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.AndroidJNI.NewShortArray(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.NewShortArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.NewShortArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr NewStringUTF(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.AndroidJNI.NewStringUTF(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.NewStringUTF has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.NewStringUTF has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr PopLocalFrame(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.PopLocalFrame(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.PopLocalFrame has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.PopLocalFrame has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.Int32 PushLocalFrame(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.AndroidJNI.PushLocalFrame(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.PushLocalFrame has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.PushLocalFrame has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void SetBooleanArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32, System.Byte>())
			{
				UnityEngine.AndroidJNI.SetBooleanArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Byte>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetBooleanArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetBooleanArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetBooleanField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Boolean>())
			{
				UnityEngine.AndroidJNI.SetBooleanField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetBooleanField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetBooleanField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetByteArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32, System.SByte>())
			{
				UnityEngine.AndroidJNI.SetByteArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.SByte>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetByteArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetByteArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetByteField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Byte>())
			{
				UnityEngine.AndroidJNI.SetByteField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Byte>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetByteField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetByteField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetCharArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32, System.Char>())
			{
				UnityEngine.AndroidJNI.SetCharArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Char>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetCharArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetCharArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetCharField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Char>())
			{
				UnityEngine.AndroidJNI.SetCharField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Char>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetCharField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetCharField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetDoubleArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32, System.Double>())
			{
				UnityEngine.AndroidJNI.SetDoubleArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Double>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetDoubleArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetDoubleArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetDoubleField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Double>())
			{
				UnityEngine.AndroidJNI.SetDoubleField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Double>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetDoubleField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetDoubleField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetFloatArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32, System.Single>())
			{
				UnityEngine.AndroidJNI.SetFloatArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetFloatArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetFloatArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetFloatField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Single>())
			{
				UnityEngine.AndroidJNI.SetFloatField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetFloatField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetFloatField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetIntArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32, System.Int32>())
			{
				UnityEngine.AndroidJNI.SetIntArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetIntArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetIntArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetIntField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Int32>())
			{
				UnityEngine.AndroidJNI.SetIntField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetIntField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetIntField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetLongArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32, System.Int64>())
			{
				UnityEngine.AndroidJNI.SetLongArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int64>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetLongArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetLongArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetLongField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Int64>())
			{
				UnityEngine.AndroidJNI.SetLongField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Int64>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetLongField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetLongField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetObjectArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32, System.IntPtr>())
			{
				UnityEngine.AndroidJNI.SetObjectArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.IntPtr>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetObjectArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetObjectArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetObjectField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.IntPtr>())
			{
				UnityEngine.AndroidJNI.SetObjectField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.IntPtr>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetObjectField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetObjectField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetShortArrayElement(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32, System.Int16>())
			{
				UnityEngine.AndroidJNI.SetShortArrayElement(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int16>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetShortArrayElement has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetShortArrayElement has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetShortField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Int16>())
			{
				UnityEngine.AndroidJNI.SetShortField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Int16>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetShortField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetShortField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetStaticBooleanField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Boolean>())
			{
				UnityEngine.AndroidJNI.SetStaticBooleanField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetStaticBooleanField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetStaticBooleanField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetStaticByteField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Byte>())
			{
				UnityEngine.AndroidJNI.SetStaticByteField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Byte>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetStaticByteField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetStaticByteField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetStaticCharField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Char>())
			{
				UnityEngine.AndroidJNI.SetStaticCharField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Char>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetStaticCharField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetStaticCharField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetStaticDoubleField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Double>())
			{
				UnityEngine.AndroidJNI.SetStaticDoubleField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Double>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetStaticDoubleField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetStaticDoubleField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetStaticFloatField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Single>())
			{
				UnityEngine.AndroidJNI.SetStaticFloatField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetStaticFloatField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetStaticFloatField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetStaticIntField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Int32>())
			{
				UnityEngine.AndroidJNI.SetStaticIntField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetStaticIntField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetStaticIntField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetStaticLongField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Int64>())
			{
				UnityEngine.AndroidJNI.SetStaticLongField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Int64>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetStaticLongField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetStaticLongField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetStaticObjectField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.IntPtr>())
			{
				UnityEngine.AndroidJNI.SetStaticObjectField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.IntPtr>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetStaticObjectField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetStaticObjectField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetStaticShortField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Int16>())
			{
				UnityEngine.AndroidJNI.SetStaticShortField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Int16>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetStaticShortField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetStaticShortField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetStaticStringField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.String>())
			{
				UnityEngine.AndroidJNI.SetStaticStringField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetStaticStringField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetStaticStringField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetStringField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.String>())
			{
				UnityEngine.AndroidJNI.SetStringField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.SetStringField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.SetStringField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 Throw(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.Throw(parameters[0].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.Throw has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.Throw has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Int32 ThrowNew(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.String>())
			{
				return UnityEngine.AndroidJNI.ThrowNew(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.ThrowNew has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.ThrowNew has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.IntPtr ToBooleanArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean[]>())
			{
				return UnityEngine.AndroidJNI.ToBooleanArray(parameters[0].ToObject<System.Boolean[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.ToBooleanArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.ToBooleanArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr ToByteArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[]>())
			{
				return UnityEngine.AndroidJNI.ToByteArray(parameters[0].ToObject<System.Byte[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.ToByteArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.ToByteArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr ToCharArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Char[]>())
			{
				return UnityEngine.AndroidJNI.ToCharArray(parameters[0].ToObject<System.Char[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.ToCharArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.ToCharArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr ToDoubleArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Double[]>())
			{
				return UnityEngine.AndroidJNI.ToDoubleArray(parameters[0].ToObject<System.Double[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.ToDoubleArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.ToDoubleArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr ToFloatArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single[]>())
			{
				return UnityEngine.AndroidJNI.ToFloatArray(parameters[0].ToObject<System.Single[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.ToFloatArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.ToFloatArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr ToIntArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32[]>())
			{
				return UnityEngine.AndroidJNI.ToIntArray(parameters[0].ToObject<System.Int32[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.ToIntArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.ToIntArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr ToLongArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int64[]>())
			{
				return UnityEngine.AndroidJNI.ToLongArray(parameters[0].ToObject<System.Int64[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.ToLongArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.ToLongArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr ToObjectArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr[]>())
			{
				return UnityEngine.AndroidJNI.ToObjectArray(parameters[0].ToObject<System.IntPtr[]>());
			}
			if (parameters.CheckTypes<System.IntPtr[], System.IntPtr>())
			{
				return UnityEngine.AndroidJNI.ToObjectArray(parameters[0].ToObject<System.IntPtr[]>(), parameters[1].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.ToObjectArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.ToObjectArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr ToReflectedField(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Boolean>())
			{
				return UnityEngine.AndroidJNI.ToReflectedField(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.ToReflectedField has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.ToReflectedField has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr ToReflectedMethod(Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.IntPtr, System.Boolean>())
			{
				return UnityEngine.AndroidJNI.ToReflectedMethod(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.IntPtr>(), parameters[2].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.ToReflectedMethod has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.ToReflectedMethod has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private System.IntPtr ToShortArray(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int16[]>())
			{
				return UnityEngine.AndroidJNI.ToShortArray(parameters[0].ToObject<System.Int16[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidJNI.ToShortArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidJNI.ToShortArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

	}
}
#endif
