using AOT;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace General.Typescript
{
    public partial class Entry
    {
        static public class Object
        {
            [DllImport(LIBRARY_NAME)]
            extern static private IntPtr General_Typescript_Object_CreateBoolean(IntPtr context, bool value);
            static internal IntPtr Create(bool value)
            {
                return General_Typescript_Object_CreateBoolean(sInstance.Context, value);
            }

            [DllImport(LIBRARY_NAME)]
            extern static private IntPtr General_Typescript_Object_CreateString(IntPtr context, string value);
            static internal IntPtr Create(string value)
            {
                return General_Typescript_Object_CreateString(sInstance.Context, value);
            }

            [DllImport(LIBRARY_NAME)]
            extern static private IntPtr General_Typescript_Object_CreateInt32(IntPtr context, int value);
            static internal IntPtr Create(int value)
            {
                return General_Typescript_Object_CreateInt32(sInstance.Context, value);
            }

            [DllImport(LIBRARY_NAME)]
            extern static private IntPtr General_Typescript_Object_CreateUint32(IntPtr context, uint value);
            static internal IntPtr Create(uint value)
            {
                return General_Typescript_Object_CreateUint32(sInstance.Context, value);
            }

            [DllImport(LIBRARY_NAME)]
            extern static private IntPtr General_Typescript_Object_CreateInt64(IntPtr context, long value);
            static internal IntPtr Create(long value)
            {
                return General_Typescript_Object_CreateInt64(sInstance.Context, value);
            }

            [DllImport(LIBRARY_NAME)]
            extern static private IntPtr General_Typescript_Object_CreateUint64(IntPtr context, ulong value);
            static internal IntPtr Create(ulong value)
            {
                return General_Typescript_Object_CreateUint64(sInstance.Context, value);
            }

            [DllImport(LIBRARY_NAME)]
            extern static private IntPtr General_Typescript_Object_CreateFloat(IntPtr context, float value);
            static internal IntPtr Create(float value)
            {
                return General_Typescript_Object_CreateFloat(sInstance.Context, value);
            }

            [DllImport(LIBRARY_NAME)]
            extern static private IntPtr General_Typescript_Object_CreateDouble(IntPtr context, double value);
            static internal IntPtr Create(double value)
            {
                return General_Typescript_Object_CreateDouble(sInstance.Context, value);
            }

            [DllImport(LIBRARY_NAME)]
            extern static private IntPtr General_Typescript_Object_CreateInstanceHandle(IntPtr context, string type);
            static internal IntPtr CreateInstance(string type)
            {
                return General_Typescript_Object_CreateInstanceHandle(sInstance.Context, type);
            }

            [DllImport(LIBRARY_NAME)]
            extern static private IntPtr General_Typescript_Object_CreateWithField(IntPtr context, string type, int size);
            static internal IntPtr Create(string type, int size)
            {
                return General_Typescript_Object_CreateWithField(sInstance.Context, type, size);
            }

            [DllImport(LIBRARY_NAME)]
            extern static private IntPtr General_Typescript_Object_CreateArrayWithLength(IntPtr context, int length);

            [DllImport(LIBRARY_NAME)]
            extern static private IntPtr General_Typescript_Object_CreateArrayWithElements(IntPtr context, IntPtr[] elements, int length);

            static private Dictionary<object, IntPtr> sCSharpToNativeHandles = new Dictionary<object, IntPtr>();
            static private Dictionary<IntPtr, object> sNativeToCSharpHandles = new Dictionary<IntPtr, object>();

            static internal IntPtr Create(object instance)
            {
                if (null == instance)
                {
                    return IntPtr.Zero;
                }

                Type type = instance.GetType();
                if (type.IsValueType)
                {
                    if (type.IsPrimitive)
                    {
                        if (instance is bool)
                        {
                            return Create((bool)instance);
                        }
                        if (instance is sbyte)
                        {
                            return Create((sbyte)instance);
                        }
                        if (instance is byte)
                        {
                            return Create((byte)instance);
                        }
                        if (instance is short)
                        {
                            return Create((short)instance);
                        }
                        if (instance is ushort)
                        {
                            return Create((ushort)instance);
                        }
                        if (instance is int)
                        {
                            return Create((int)instance);
                        }
                        if (instance is uint)
                        {
                            return Create((uint)instance);
                        }
                        if (instance is long)
                        {
                            return Create((long)instance);
                        }
                        if (instance is ulong)
                        {
                            return Create((ulong)instance);
                        }
                        if (instance is float)
                        {
                            return Create((float)instance);
                        }
                        if (instance is double)
                        {
                            return Create((double)instance);
                        }
                    }
                    int size = Marshal.SizeOf(type);
                    IntPtr handle = Entry.Object.Create(type.GetSafeFullName(), size);
                    Marshal.StructureToPtr(instance, Entry.Object.GetField(handle), true);
                    return handle;
                }
                else
                {
                    if (instance is string)
                    {
                        return Create(instance as string);
                    }
                    else if (instance is Array)
                    {
                        Array array = instance as Array;
                        if (0 == array.Length)
                        {
                            return General_Typescript_Object_CreateArrayWithLength(sInstance.Context, 0);
                        }

                        IntPtr[] elements = new IntPtr[array.Length];
                        for (int i = 0; i < array.Length; ++i)
                        {
                            elements[i] = Create(array.GetValue(i));
                        }
                        return General_Typescript_Object_CreateArrayWithElements(sInstance.Context, elements, array.Length);
                    }

                    IntPtr handle = IntPtr.Zero;
                    if (!sCSharpToNativeHandles.TryGetValue(instance, out handle))
                    {
                        if (instance is ICustomSuperClass)
                        {
                            ICustomSuperClass super = instance as ICustomSuperClass;
                            handle = Entry.Object.CreateInstance(super.TypeFullName);
                            super.SetJsHandle(handle);
                        }
                        else
                        {
                            handle = Entry.Object.CreateInstance(type.GetSafeFullName());
                        }
                        sCSharpToNativeHandles.Add(instance, handle);
                        sNativeToCSharpHandles.Add(handle, instance);
                    }
                    return handle;
                }
            }

            [DllImport(LIBRARY_NAME)]
            static private extern void General_Typescript_SetGarbageCollectionCallback(OnGarbageCollection callback);
            static public void SetGarbageCollectionCallback()
            {
                General_Typescript_SetGarbageCollectionCallback(onGarbageCollection);
            }

            public delegate void OnGarbageCollection(IntPtr handle);
            [MonoPInvokeCallback(typeof(OnGarbageCollection))]
            static private void onGarbageCollection(IntPtr handle)
            {
                object instance = null;
                if (sNativeToCSharpHandles.TryGetValue(handle, out instance))
                {
                    sCSharpToNativeHandles.Remove(instance);
                    sNativeToCSharpHandles.Remove(handle);
                }
            }

            [DllImport(LIBRARY_NAME)]
            static private extern void General_Typescript_Object_MakePersistent(IntPtr context, IntPtr handle);
            static public void MakePersistent(IntPtr handle)
            {
                General_Typescript_Object_MakePersistent(sInstance.Context, handle);
            }

            [DllImport(LIBRARY_NAME)]
            static private extern void General_Typescript_Object_MakeWeak(IntPtr context, IntPtr handle);
            static public void MakeWeak(IntPtr handle)
            {
                General_Typescript_Object_MakeWeak(sInstance.Context, handle);
            }

            [DllImport(LIBRARY_NAME)]
            static private extern bool General_Typescript_Object_HasProperty(IntPtr context, IntPtr handle, string name);
            static public bool HasProperty(IntPtr handle, string name)
            {
                return sInstance ? General_Typescript_Object_HasProperty(sInstance.Context, handle, name) : false;
            }

            [DllImport(LIBRARY_NAME)]
            static private extern bool General_Typescript_Object_HasFunction(IntPtr context, IntPtr handle, string name);
            static public bool HasFunction(IntPtr handle, string name)
            {
                return sInstance ? General_Typescript_Object_HasFunction(sInstance.Context, handle, name) : false;
            }

            [DllImport(LIBRARY_NAME)]
            static private extern IntPtr General_Typescript_Object_CallFunction(IntPtr context, IntPtr handle, string name, IntPtr arguments);
            [DllImport(LIBRARY_NAME)]
            static private extern void General_Typescript_Object_CallFunctionWithoutResult(IntPtr context, IntPtr handle, string name, IntPtr arguments);

            static private byte[] serializeArguments(params object[] arguments)
            {
                if (arguments.Length > 0)
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        stream.Write(BitConverter.GetBytes(arguments.Length), 0, sizeof(int));
                        foreach (object argument in arguments)
                        {
                            byte[] buffer = Argument.Serialize(argument);
                            stream.Write(buffer, 0, buffer.Length);
                        }
                        return stream.ToArray();
                    }
                }
                return null;
            }

            /// <summary>
            /// Call specified function [name] of object [handle], and need return value.
            /// </summary>
            /// <param name="handle">Object witch to call the function.</param>
            /// <param name="name">Function of the object witch to call.</param>
            /// <param name="arguments">Arguments for this call, it only support primitive types in current version.</param>
            /// <returns></returns>
            static public General.Typescript.JsObject CallFunctionWithResult(IntPtr handle, string name, params object[] arguments)
            {
                return sInstance ? new General.Typescript.JsObject(General_Typescript_Object_CallFunction(sInstance.Context, handle, name, Create(arguments))) : new General.Typescript.JsObject(IntPtr.Zero);
            }

            /// <summary>
            /// Call specified function [name] of object [handle], and there is no return value for the purpose of being faster.
            /// </summary>
            /// <param name="handle">Object witch to call the function.</param>
            /// <param name="name">Function of the object witch to call.</param>
            /// <param name="arguments">Arguments for this call, it only support primitive types in current version.</param>
            /// <returns></returns>
            static public void CallFunction(IntPtr handle, string name, params object[] arguments)
            {
                if (sInstance)
                {
                    General_Typescript_Object_CallFunctionWithoutResult(sInstance.Context, handle, name, Create(arguments));
                }
            }

            [DllImport(LIBRARY_NAME)]
            static private extern IntPtr General_Typescript_Object_CallAsFunction(IntPtr context, IntPtr handle, IntPtr arguments);
            static public object CallAsFunction(IntPtr handle, params object[] arguments)
            {
                if (sInstance)
                {
                    General_Typescript_Object_CallAsFunction(sInstance.Context, handle, Create(arguments));
                }
                return null;
            }

            [DllImport(LIBRARY_NAME)]
            extern static private int General_Typescript_Object_GetJsType(IntPtr context, IntPtr result);
            static internal JSValueType GetJsType(IntPtr result)
            {
                return (JSValueType)General_Typescript_Object_GetJsType(sInstance.Context, result);
            }
            [DllImport(LIBRARY_NAME)]
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
			extern static private IntPtr General_Typescript_Object_GetTypeName(IntPtr context, IntPtr caller);
#else
            extern static private string General_Typescript_Object_GetTypeName(IntPtr context, IntPtr caller);
#endif
            static internal string GetType(IntPtr caller)
            {
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
				return Marshal.PtrToStringAnsi(General_Typescript_Object_GetTypeName(sInstance.Context, caller));
#else
                return General_Typescript_Object_GetTypeName(sInstance.Context, caller);
#endif
            }

            [DllImport(LIBRARY_NAME)]
            extern static private IntPtr General_Typescript_Object_GetField(IntPtr context, IntPtr caller);
            static internal IntPtr GetField(IntPtr caller)
            {
                return General_Typescript_Object_GetField(sInstance.Context, caller);
            }

            static internal object GetInstance(IntPtr caller)
            {
                if (IntPtr.Zero == caller)
                {
                    return null;
                }

                object instance = null;
                if (sNativeToCSharpHandles.TryGetValue(caller, out instance))
                {
                    return instance;
                }

                string name = Entry.Object.GetType(caller);
                Type type = Entry.FindCustomSuperClass(name);
                if (null == type)
                {
                    type = General.Typescript.Class.FindType(name);
                }
                if (null != type && type.IsValueType)
                {
                    return Marshal.PtrToStructure(Entry.Object.GetField(caller), type);
                }
                else
                {
                    Entry.LogError("There is no registered type for caller {0}, got type : {1}", caller.ToString(), name);
                }
                return null;
            }

            [DllImport(LIBRARY_NAME)]
            extern static private bool General_Typescript_Object_ToBoolean(IntPtr context, IntPtr result);
            static internal bool ToBoolean(IntPtr result)
            {
                return General_Typescript_Object_ToBoolean(sInstance.Context, result);
            }

            [DllImport(LIBRARY_NAME)]
            extern static private int General_Typescript_Object_ToInt32(IntPtr context, IntPtr result);
            static internal int ToInt32(IntPtr result)
            {
                return General_Typescript_Object_ToInt32(sInstance.Context, result);
            }

            [DllImport(LIBRARY_NAME)]
            extern static private uint General_Typescript_Object_ToUint32(IntPtr context, IntPtr result);
            static internal uint ToUint32(IntPtr result)
            {
                return General_Typescript_Object_ToUint32(sInstance.Context, result);
            }

            [DllImport(LIBRARY_NAME)]
            extern static private long General_Typescript_Object_ToInt64(IntPtr context, IntPtr result);
            static internal long ToInt64(IntPtr result)
            {
                return General_Typescript_Object_ToInt64(sInstance.Context, result);
            }

            [DllImport(LIBRARY_NAME)]
            extern static private ulong General_Typescript_Object_ToUint64(IntPtr context, IntPtr result);
            static internal ulong ToUint64(IntPtr result)
            {
                return General_Typescript_Object_ToUint64(sInstance.Context, result);
            }

            [DllImport(LIBRARY_NAME)]
            extern static private float General_Typescript_Object_ToFloat(IntPtr context, IntPtr result);
            static internal float ToSingle(IntPtr result)
            {
                return General_Typescript_Object_ToFloat(sInstance.Context, result);
            }

            [DllImport(LIBRARY_NAME)]
            extern static private double General_Typescript_Object_ToDouble(IntPtr context, IntPtr result);
            static internal double ToDouble(IntPtr result)
            {
                return General_Typescript_Object_ToDouble(sInstance.Context, result);
            }

            [DllImport(LIBRARY_NAME)]
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
			extern static private IntPtr General_Typescript_Object_ToString(IntPtr context, IntPtr result);
#else
            extern static private string General_Typescript_Object_ToString(IntPtr context, IntPtr result);
#endif
            static internal string ToString(IntPtr result)
            {
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
				return Marshal.PtrToStringAnsi(General_Typescript_Object_ToString(sInstance.Context, result));
#else
                return General_Typescript_Object_ToString(sInstance.Context, result);
#endif
            }
        }
    }
}
