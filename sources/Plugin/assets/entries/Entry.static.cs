using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using UnityEngine;

namespace General.Typescript
{
	public abstract partial class Entry
	{
		static internal readonly string Type_Type = typeof(Type).FullName;
		static internal readonly string Type_String = typeof(string).FullName;
		static internal readonly string Type_Byte = typeof(byte).FullName;
		static internal readonly string Type_SByte = typeof(sbyte).FullName;
		static internal readonly string Type_Short = typeof(short).FullName;
		static internal readonly string Type_UShort = typeof(ushort).FullName;
		static internal readonly string Type_Int = typeof(int).FullName;
		static internal readonly string Type_UInt = typeof(uint).FullName;
		static internal readonly string Type_Long = typeof(long).FullName;
		static internal readonly string Type_ULong = typeof(ulong).FullName;
		static internal readonly string Type_Float = typeof(float).FullName;
		static internal readonly string Type_Double = typeof(double).FullName;

		static public event Action onBind = null;

		static public IntPtr ContextHandle { get { return sInstance?.Context ?? IntPtr.Zero; } }

		static private Entry sInstance = null;
		static public Entry Instance { get { return sInstance; } }

		static Entry()
		{
			Entry.onBind += delegate ()
			{
				{
					Type type = typeof(Entry).Assembly.GetType("General.Typescript.UnityEngineBinder");
					if (null == type)
					{
						UnityEngine.Debug.LogError("Cannot find class [UnityEngineBinder], please generate binders first!\nMenu -> General -> Typescript -> Generate Binders");
						return;
					}
					MethodInfo method = type.GetMethod("Initialize", BindingFlags.Static | BindingFlags.Public);
					method.Invoke(null, null);
				}

				CoreBinder.Initialize();
			};
		}

		static private void checkInstance()
		{
			if (null == sInstance)
			{
				throw new Exception(string.Format("There is no instance for Entry, check if you call Entry.Initialize first, or GeneralTypescript does not support this platform [{0}].", Application.platform));
			}
		}

		static public bool Initialize()
		{
			if (IntPtr.Zero == Entry.ContextHandle)
			{
#if UNITY_IPHONE || UNITY_STANDALONE_OSX
                sInstance = new IOSEntry();
//#elif UNITY_ANDROID
//				sInstance = new AndroidEntry();
//#elif UNITY_STANDALONE
//#if UNITY_STANDALONE_WIN
#else
				sInstance = new WindowsEntry();
//#endif
#endif

				ExtensionModule.Initialize();

				UnityEngine.SceneManagement.SceneManager.sceneUnloaded += (UnityEngine.SceneManagement.Scene scene) =>
				{
					//Entry.ReleaseMemrory();
				};

				UnityEngine.SceneManagement.SceneManager.sceneLoaded += (UnityEngine.SceneManagement.Scene scene, UnityEngine.SceneManagement.LoadSceneMode mode) =>
				{
					//Entry.ReleaseMemrory();
				};

				UnityEngine.Application.quitting += () =>
				{
					//sInstance?.finalize();
					Entry.Release();
				};

#if UNITY_EDITOR
				UnityEditor.EditorApplication.playModeStateChanged += (UnityEditor.PlayModeStateChange change) =>
				{
					if (UnityEditor.PlayModeStateChange.EnteredEditMode == change || UnityEditor.PlayModeStateChange.ExitingPlayMode == change)
					{
						Entry.Release();
					}
				};
#endif

				if (sInstance?.initialize() ?? false)
				{
					General_Typescript_BindLogCallback(Log, LogWarning, LogError);
					General_Typescript_Bind(sInstance.Context);
					return true;
				}
				return false;
			}
			return true;
		}

		static protected void Bind()
		{
			onBind?.Invoke();
		}

		//static public bool Run()
		//{
		//	checkInstance();
		//	return Instance?.run() ?? false;
		//}

		static public string ExecuteString(string content)
		{
			checkInstance();
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
			return Marshal.PtrToStringAnsi(General_Typescript_ExecuteString(sInstance.Context, content));
#else
			return General_Typescript_ExecuteString(sInstance.Context, content);
#endif
		}

		static public string ExecuteScript(string content, string filename)
		{
			checkInstance();
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
			return Marshal.PtrToStringAnsi(General_Typescript_ExecuteScript(sInstance.Context, content, filename));
#else
			return General_Typescript_ExecuteScript(sInstance.Context, content, filename);
#endif
		}

		static public IntPtr Require(string content, string filename)
		{
			checkInstance();
			return General_Typescript_Require(sInstance.Context, content, filename);
		}

		static public Namespace DeclareNamespace(string name)
		{
			checkInstance();
			return new Namespace(sInstance.Context, General_Typescript_DeclareNamespace(sInstance.Context, name));
		}

		static public Class<T> DeclareClass<T>(string name)
		{
			checkInstance();
			Type baseType = typeof(T).BaseType;
			return new Class<T>(sInstance.Context, Entry.General_Typescript_DeclareClass(sInstance.Context, name, null == baseType ? "" : baseType.FullName));
		}

		static public Class<T> DeclareClass<T>()
		{
			return Entry.DeclareClass<T>(typeof(T).Name);
		}

		static public Class<T> DeclareClass<T, TParent>()
		{
			Class<T> instance = Entry.DeclareClass<T>();
			instance.BindParentType<TParent>();
			return instance;
		}

		static public Function BindStaticFunction(string name, Action<General.Typescript.Parameters> function)
		{
			checkInstance();
			IntPtr handle = Entry.General_Typescript_BindStaticFunction(sInstance.Context, name);
			return new StaticFunction(sInstance.Context, handle, name, function);
		}

		static public Function BindStaticFunction<TValue>(string name, Func<General.Typescript.Parameters, TValue> function)
		{
			checkInstance();
			IntPtr handle = Entry.General_Typescript_BindStaticFunction(sInstance.Context, name);
			return new StaticFunction<TValue>(sInstance.Context, handle, name, function);
		}

		static internal int ReturnResultToJavascript(object instance)
		{
			if (null == instance) return -1;

			Type type = instance.GetType();
			if (instance is string)
			{
				return Entry.Return.Create(instance as string);
			}
			if (type.IsPrimitive)
			{
				return Entry.Return.Create((instance as IConvertible).ToDouble(null));
			}
			if (type.IsValueType)
			{
				int size = Marshal.SizeOf(type);
				IntPtr handle = Entry.General_Typescript_CreateBuffer(size);
				Marshal.StructureToPtr(instance, handle, false);
				return Entry.Return.Create(type.FullName, handle, size);
			}
			string name = type.FullName;
			Class c = Class.FindClass(name);
			if (null == c)
			{
				Debug.LogError(string.Format("Type {0} has not been registered into General.Typescript!", name));
				return -1;
			}
			return c.CreateInstanceAsReturn(instance);
		}

		//static internal T FromJSObject<T>(IntPtr handle)
		//{
		//	return (T)(Entry.FromJSObject(handle, typeof(T)) ?? default(T));
		//}

		//static internal object FromJSObject(IntPtr handle, Type type)
		//{
		//	checkInstance();
		//	if (type.IsEnum)
		//	{
		//		int value = sInstance.fromJSObject<int>(handle);
		//		return Enum.ToObject(type, value);
		//	}
		//	if (Entry.Type_Type == type.FullName)
		//	{
		//		return Entry.GetObjectType(handle);
		//	}
		//	return sInstance.fromJSObject(handle, type);
		//}

		static internal JSValueType GetType(IntPtr handle)
		{
			return null == sInstance ? JSValueType.Unknown : sInstance.getType(handle);
		}

		static internal Type GetObjectType(IntPtr handle)
		{
			checkInstance();
			UnityEngine.Debug.LogError("No implemention!");
			//#if UNITY_STANDALONE_WIN
			//			string name = Marshal.PtrToStringAnsi(Entry.General_Typescript_GetObjectType(sInstance.Context, handle));
			//#else
			//            string name = Entry.General_Typescript_GetObjectType(sInstance.Context, handle);
			//#endif
			//			if (Type_Type == name)
			//			{
			//				return typeof(Type);
			//			}
			//			if (CustomType.IsCustomType(name))
			//			{
			//				return new CustomType(name);
			//			}
			//			return Class.FindType(name);
			return null;
		}

		static public void ReleaseHandle(IntPtr handle)
		{
            if (!sInstance) return;
			Entry.General_Typescript_ReleaseHandle(sInstance.Context, handle);
		}

		static public void ReleaseMemrory()
		{
            if (!sInstance) return;

			List<IntPtr> handles = new List<IntPtr>();
			//foreach (var key in sRecorders.Keys.ToArray())
			//{
			//	InstanceHandleRecorder record = sRecorders[key];
			//	if ("null" == record.Instance.ToString())
			//	{
			//		handles.Add(record.OriginHandle);
			//		sRecorders.Remove(key);
			//	}
			//}
			IntPtr[] handlesToRelease = handles.Distinct().ToArray();
			Entry.General_Typescript_ReleaseMemory(sInstance.Context, handlesToRelease, handlesToRelease.Length);
		}

		static public void Release()
		{
			if (sInstance)
			{
				sInstance?.finalize();
				sInstance = null;
				Base.Release();
				Class.Release();
			}
		}

        static public implicit operator bool(Entry instance)
        {
            return null != instance;
        }
	}
}