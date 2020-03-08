using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace General.Typescript
{
    public abstract partial class Entry
    {
        static public class Parameters
        {
            #region Parameter
            [DllImport(LIBRARY_NAME)]
            static private extern int General_Typescript_Parameter_GetType(IntPtr context, IntPtr handle, int index);
            static internal JSValueType GetJsType(IntPtr handle, int index)
            {
                return (JSValueType)General_Typescript_Parameter_GetType(sInstance.Context, handle, index);
            }

            [DllImport(LIBRARY_NAME)]
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
			static private extern IntPtr General_Typescript_Parameter_GetTypeName(IntPtr context, IntPtr handle, int index);
#else
            static private extern string General_Typescript_Parameter_GetTypeName(IntPtr context, IntPtr handle, int index);
#endif
            static internal string GetTypeName(IntPtr handle, int index)
            {
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
				return Marshal.PtrToStringAnsi(General_Typescript_Parameter_GetTypeName(sInstance.Context, handle, index));
#else
                return General_Typescript_Parameter_GetTypeName(sInstance.Context, handle, index);
#endif
            }

            [DllImport(LIBRARY_NAME)]
            static private extern IntPtr General_Typescript_Parameter_GetHandle(IntPtr context, IntPtr handle, int index);
            static internal IntPtr GetHandle(IntPtr handle, int index)
            {
                return General_Typescript_Parameter_GetHandle(sInstance.Context, handle, index);
            }

            [DllImport(LIBRARY_NAME)]
            static private extern IntPtr General_Typescript_Parameter_GetField(IntPtr context, IntPtr handle, int index);
            static internal IntPtr GetField(IntPtr handle, int index)
            {
                return General_Typescript_Parameter_GetField(sInstance.Context, handle, index);
            }

            static internal Type GetType(IntPtr handle, int index)
            {
                string name = Entry.Parameters.GetTypeName(handle, index);
                //if (Type_Type == name)
                //{
                //	return typeof(Type);
                //}
                Type custom = Entry.FindCustomSuperClass(name);
                if (null != custom)
                {
                    return custom;
                }
                return General.Typescript.Class.FindType(name);
            }

            [DllImport(LIBRARY_NAME)]
            static private extern bool General_Typescript_Parameter_ToBoolean(IntPtr context, IntPtr handle, int index);
            static internal bool ToBoolean(IntPtr handle, int index)
            {
                return General_Typescript_Parameter_ToBoolean(sInstance.Context, handle, index);
            }

            [DllImport(LIBRARY_NAME)]
            static private extern double General_Typescript_Parameter_ToNumber(IntPtr context, IntPtr handle, int index);
            static internal double ToNumber(IntPtr handle, int index)
            {
                return General_Typescript_Parameter_ToNumber(sInstance.Context, handle, index);
            }

            [DllImport(LIBRARY_NAME)]
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
			static private extern IntPtr General_Typescript_Parameter_ToString(IntPtr context, IntPtr handle, int index);
#else
            static private extern string General_Typescript_Parameter_ToString(IntPtr context, IntPtr handle, int index);
#endif
            static internal string ToString(IntPtr handle, int index)
            {
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
				return Marshal.PtrToStringAnsi(General_Typescript_Parameter_ToString(sInstance.Context, handle, index));
#else
                return General_Typescript_Parameter_ToString(sInstance.Context, handle, index);
#endif
            }
            #endregion

            [DllImport(LIBRARY_NAME)]
            static private extern int General_Typescript_Parameter_GetArrayLength(IntPtr context, IntPtr pointer, int index);
            [DllImport(LIBRARY_NAME)]
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
			static private extern IntPtr General_Typescript_Parameter_GetArrayString(IntPtr context, IntPtr pointer, int index, int elementIndex);
#else
            static private extern string General_Typescript_Parameter_GetArrayString(IntPtr context, IntPtr pointer, int index, int elementIndex);
#endif

            [DllImport(LIBRARY_NAME)]
            static private extern IntPtr General_Typescript_Parameter_ToArray(IntPtr context, IntPtr pointer, int index, int type, int subType);
            static internal Array ToArray(IntPtr handle, int index, JSValueType type, JSNumberType subType)
            {
                if (JSValueType.String == type)
                {
                    int count = General_Typescript_Parameter_GetArrayLength(sInstance.Context, handle, index);
                    string[] array = new string[count];
                    foreach (int i in Enumerable.Range(0, count))
                    {
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
						array[i] = Marshal.PtrToStringAnsi(General_Typescript_Parameter_GetArrayString(sInstance.Context, handle, index, i));
#else
                        array[i] = General_Typescript_Parameter_GetArrayString(sInstance.Context, handle, index, i);
#endif
                    }
                    return array;
                }
                else
                {
                    IntPtr result = General_Typescript_Parameter_ToArray(sInstance.Context, handle, index, (int)type, (int)subType);
                    int count = Marshal.ReadInt32(result);
                    result += sizeof(int);
                    if (JSValueType.Boolean == type)
                    {
                        bool[] array = new bool[count];
                        foreach (int i in Enumerable.Range(0, count))
                        {
                            array[i] = 0 != Marshal.ReadByte(result);
                            result += sizeof(byte);
                        }
                        return array;
                    }
                    else if (JSValueType.Number == type)
                    {
                        Array array = null;
                        switch (subType)
                        {
                            case JSNumberType.SByte:
                                sbyte[] arraySByte = new sbyte[count];
                                foreach (int i in Enumerable.Range(0, count))
                                {
                                    arraySByte[i] = (sbyte)Marshal.ReadByte(result);
                                    result += sizeof(byte);
                                }
                                array = arraySByte;
                                break;
                            case JSNumberType.Byte:
                                byte[] arrayByte = new byte[count];
                                foreach (int i in Enumerable.Range(0, count))
                                {
                                    arrayByte[i] = Marshal.ReadByte(result);
                                    result += sizeof(byte);
                                }
                                array = arrayByte;
                                break;
                            case JSNumberType.Int16:
                                short[] arrayInt16 = new short[count];
                                foreach (int i in Enumerable.Range(0, count))
                                {
                                    arrayInt16[i] = (short)Marshal.ReadInt16(result);
                                    result += sizeof(short);
                                }
                                array = arrayInt16;
                                break;
                            case JSNumberType.UInt16:
                                ushort[] arrayUInt16 = new ushort[count];
                                foreach (int i in Enumerable.Range(0, count))
                                {
                                    arrayUInt16[i] = (ushort)Marshal.ReadInt16(result);
                                    result += sizeof(ushort);
                                }
                                array = arrayUInt16;
                                break;
                            case JSNumberType.Int32:
                                int[] arrayInt32 = new int[count];
                                foreach (int i in Enumerable.Range(0, count))
                                {
                                    arrayInt32[i] = (int)Marshal.ReadInt32(result);
                                    result += sizeof(int);
                                }
                                array = arrayInt32;
                                break;
                            case JSNumberType.UInt32:
                                uint[] arrayUInt32 = new uint[count];
                                foreach (int i in Enumerable.Range(0, count))
                                {
                                    arrayUInt32[i] = (uint)Marshal.ReadInt32(result);
                                    result += sizeof(uint);
                                }
                                array = arrayUInt32;
                                break;
                            case JSNumberType.Int64:
                                long[] arrayInt64 = new long[count];
                                foreach (int i in Enumerable.Range(0, count))
                                {
                                    arrayInt64[i] = (long)Marshal.ReadInt64(result);
                                    result += sizeof(long);
                                }
                                array = arrayInt64;
                                break;
                            case JSNumberType.UInt64:
                                ulong[] arrayUInt64 = new ulong[count];
                                foreach (int i in Enumerable.Range(0, count))
                                {
                                    arrayUInt64[i] = (ulong)Marshal.ReadInt64(result);
                                    result += sizeof(ulong);
                                }
                                array = arrayUInt64;
                                break;
                            case JSNumberType.Single:
                                float[] arraySingle = new float[count];
                                foreach (int i in Enumerable.Range(0, count))
                                {
                                    arraySingle[i] = (float)Marshal.PtrToStructure<System.Single>(result);
                                    result += sizeof(float);
                                }
                                array = arraySingle;
                                break;
                            case JSNumberType.Double:
                                double[] arrayDouble = new double[count];
                                foreach (int i in Enumerable.Range(0, count))
                                {
                                    arrayDouble[i] = (double)Marshal.PtrToStructure<System.Double>(result);
                                    result += sizeof(double);
                                }
                                array = arrayDouble;
                                break;
                        }
                        return array;
                    }
                }
                return null;
            }

            [DllImport(LIBRARY_NAME)]
            static private extern IntPtr General_Typescript_Parameter_ToFunction(IntPtr context, IntPtr handle, int index);
            static public IntPtr ToFunction(IntPtr handle, int index)
            {
                return General_Typescript_Parameter_ToFunction(sInstance.Context, handle, index);
            }
        }
    }
}