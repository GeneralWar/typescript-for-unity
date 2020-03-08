using AOT;
using System;
using System.Collections.Generic;
using System.IO;
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

        static public IntPtr ContextHandle { get { return sInstance?.Context ?? IntPtr.Zero; } }

        static private Entry sInstance = null;
        static public Entry Instance { get { return sInstance; } }

        static private List<Tuple<Delegate, object[]>> sBindDelegates = new List<Tuple<Delegate, object[]>>();

        static Entry()
        {
            Entry.AppendBindDelegate(new Action(Entry.bindNative));
#if DEBUG && !UNITY_EDITOR
            Application.logMessageReceived += onLogMessageReceived;
#endif
        }

        private static void onLogMessageReceived(string condition, string stackTrace, LogType type)
        {
            switch (type)
            {
                case LogType.Warning:
                    Entry.LogWarning(condition);
                    break;
                case LogType.Error:
                case LogType.Assert:
                case LogType.Exception:
                    Entry.LogError(condition);
                    break;
                default:
                    Entry.Log(condition);
                    break;
            }
        }

        static public void AppendBindDelegate(Delegate @delegate, params object[] arguments)
        {
            if (!existBindDelegate(@delegate, arguments))
            {
                sBindDelegates.Add(new Tuple<Delegate, object[]>(@delegate, arguments));
            }
        }

        static private bool existBindDelegate(Delegate @delegate, params object[] arguments)
        {
            foreach (Tuple<Delegate, object[]> record in sBindDelegates)
            {
                if (record.Item1.Method != @delegate.Method)
                {
                    continue;
                }
                if (record.Item2.Length != arguments.Length)
                {
                    continue;
                }
                if (!Utils.ArrayEqual(record.Item2, arguments))
                {
                    continue;
                }
                return true;
            }
            return false;
        }

        static private void bindNative()
        {
            List<Type> types = new List<Type>();
            types.AddRange(typeof(Entry).Assembly.GetTypes().Where(t => t.IsSubclassOf(typeof(Binder))));
            types.AddRange(Assembly.Load("Assembly-CSharp")?.GetTypes().Where(t => t.IsSubclassOf(typeof(Binder))));
            foreach (Type type in types)
            {
                MethodInfo method = type.GetMethod("Initialize", BindingFlags.Static | BindingFlags.Public);
                method.Invoke(null, null);
            }
        }

        static public void SetDelegateConverter<T>() where T : General.Typescript.Parameters.IParameterDelegateConverter, new()
        {
            General.Typescript.Parameters.SetDelegateConverter<T>();
        }

        static private void checkInstance()
        {
            if (null == sInstance)
            {
                throw new Exception(string.Format("There is no instance for Entry, check if you call Entry.Initialize first, or General.Typescript does not support this platform [{0}].", Application.platform));
            }
        }

        /// <summary>
        /// <para>初始化JS运行时。 Initialize javascript runtime.</para>
        /// <para>在初始化之前的准备工作： Preparation before initialize:</para>
        /// <para>1. 需要通过General.Typescript.Parameters.SetDelegateConverter设置一个委托转换器，否则来自JS层的function句柄将无法转换为CS层的委托。</para>
        /// <para>Need to set a delegate converter via General.Typescript.Parameters.SetDelegateConverter, otherwise, function handle from JS won't be converted to a delegate in CSharp.</para>
        /// <para>2. 通过General.Typescript.FileUtility.AddSearchPath添加额外的搜索路径，读取文件时将依次检查所有搜索路径。</para>
        /// <para>Append extra search path via General.Typescript.FileUtility.AddSearchPath, they will check in order when reading files. </para>
        /// <para>3. 如果需要动态绑定，需要再初始化之前通过General.Typescript.Entry.AppendBindDelegate设置相关配置。</para>
        /// <para>Call General.Typescript.Entry.AppendBindDelegate to set configs if you need dynamic binding.</para>
        /// </summary>
        /// <returns></returns>
        static public bool Initialize()
        {
            if (null != sInstance)
            {
                return true;
            }

            //if (Entry.General_Typescript_Is_Initialized())
            //{
            //	return true;
            //}

            Entry.Object.SetGarbageCollectionCallback();

            if (IntPtr.Zero == Entry.ContextHandle)
            {
                DateTime startTime = DateTime.Now;
#if UNITY_IPHONE || UNITY_STANDALONE_OSX
                sInstance = new AppleEntry();
#else
				sInstance = new V8Entry();
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

                if (!sInstance.initialize())
                {
                    return false;
                }
                General_Typescript_BindLogCallback(LogCallback, LogWarningCallback, LogErrorCallback);

                foreach (Tuple<Delegate, object[]> @delegate in sBindDelegates)
                {
                    @delegate.Item1.DynamicInvoke(@delegate.Item2);
                }
                General.Typescript.TypeInstance.BindTypes();

                Entry.Log("Initialize typescript takes {0}.", DateTime.Now - startTime);
            }
            return true;
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

        static public string ExecuteScript(string filename)
        {
            string content = FileUtility.ReadStringFromFile(filename);
            if (string.IsNullOrEmpty(content))
            {
                Entry.LogError("Cannot find {0}, or it is empty!", filename);
                return string.Empty;
            }
            return ExecuteScript(content, Path.GetFileName(filename));
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

        //static public IntPtr Require(string content, string filename)
        //{
        //	checkInstance();
        //	return General_Typescript_Require(sInstance.Context, content, filename);
        //}

        static public General.Typescript.Namespace DeclareNamespace(string name)
        {
            checkInstance();
            return new General.Typescript.Namespace(sInstance.Context, Entry.DeclareNamespace(sInstance.Context, name), name, null);
        }

        static public Class<T> DeclareClass<T>()
        {
            return General.Typescript.Class.Create<T>(sInstance.Context, Entry.DeclareClass(typeof(T)), null);
        }

        static public Function BindStaticFunction(string name, Action<Type, string, General.Typescript.Parameters> function)
        {
            checkInstance();
            IntPtr handle = Entry.General_Typescript_BindStaticFunction(sInstance.Context, name);
            return new StaticFunction(sInstance.Context, handle, name, null, function);
        }

        static public Function BindStaticFunction<TValue>(string name, Func<Type, string, General.Typescript.Parameters, TValue> function)
        {
            checkInstance();
            IntPtr handle = Entry.General_Typescript_BindStaticFunction(sInstance.Context, name);
            return new StaticFunction<TValue>(sInstance.Context, handle, name, null, function);
        }

        static internal IntPtr ReturnResultToJavascript(object instance)
        {
            if (null == instance)
            {
                return IntPtr.Zero;
            }

            Type type = instance.GetType();
            IntPtr handle = Entry.Object.Create(instance);
            if (!type.IsValueType && Entry.IsCustomSuperClassInstance(instance))
            {
                ICustomSuperClass super = instance as ICustomSuperClass;
                super.Initialize();
            }
            return handle;
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
            Entry.LogError("No implemention!");
            //#if UNITY_STANDALONE_WIN
            //          string name = Marshal.PtrToStringAnsi(Entry.General_Typescript_GetObjectType(sInstance.Context, handle));
            //#else
            //            string name = Entry.General_Typescript_GetObjectType(sInstance.Context, handle);
            //#endif
            //          if (Type_Type == name)
            //          {
            //              return typeof(Type);
            //          }
            //          if (CustomType.IsCustomType(name))
            //          {
            //              return new CustomType(name);
            //          }
            //          return Class.FindType(name);
            return null;
        }

        static public void RequestGarbageCollection()
        {
            checkInstance();
            Entry.General_Typescript_Request_GarbageCollection(sInstance.Context);
        }

        static public void Release()
        {
            General.Typescript.Base.Clear();
            General.Typescript.Class.Clear();
            if (sInstance)
            {
                sInstance?.finalize();
                sInstance = null;
                Base.Release();
                General.Typescript.Class.Release();
            }
        }

        static public implicit operator bool(Entry instance)
        {
            return null != instance;
        }
    }
}