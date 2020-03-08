using System;

namespace General.Typescript
{
    public abstract partial class Entry
    {
        protected IntPtr mContext = IntPtr.Zero;

        public IntPtr Context { get { return mContext; } }

        abstract public bool initialize();

        private bool toObject(Type type, IntPtr handle, out object instance)
        {
            Entry.LogError("No implemention!");
            instance = null;
            bool result = false;
            //if (null == type.BaseType)
            //{
            //	JSValueType jsType = this.getType(handle);
            //	switch (jsType)
            //	{
            //		case JSValueType.Array:
            //			instance = this.fromJSObject<object[]>(handle);
            //			result = true;
            //			break;
            //		case JSValueType.Boolean:
            //			instance = Entry.General_Typescript_JSValue_ToBoolean(mContext, handle);
            //			result = true;
            //			break;
            //		case JSValueType.Object:
            //			instance = this.fromJSObject<UnityEngine.Object>(handle);
            //			result = true;
            //			break;
            //		case JSValueType.Number:
            //			instance = Entry.General_Typescript_JSValue_ToNumber(mContext, handle);
            //			result = true;
            //			break;
            //		case JSValueType.String:
            //			instance = Entry.ToString(handle);
            //			result = true;
            //			break;
            //		case JSValueType.Unknown:
            //			Entry.LogWarning("Try to convert unknown type from js to csharp!");
            //			result = false;
            //			break;
            //		default:
            //			//Entry.LogWarning("Try to convert null|undefined from js to csharp!");
            //			result = true;
            //			break;
            //	}
            //}
            //else
            //{
            //	string typeFullName = type.FullName;
            //	if (Type_String == typeFullName)
            //	{
            //		instance = Entry.ToString(handle);
            //		result = true;
            //	}
            //	if (Type_Type == typeFullName)
            //	{
            //		string name = Entry.GetTypeFullName(handle);
            //		instance = Class.FindType(name);
            //		return true;
            //	}
            //	if (this.convertToNumber(type, handle, out instance))
            //	{
            //		result = true;
            //	}

            //	if (type.Assembly.FullName.Contains("UnityEngine"))
            //	{
            //		Entry.LogError("No implemention!");
            //		//instance = Entry.FindInstance(handle);
            //		//if (null == instance)
            //		//{
            //		//	Entry.LogError("Trying to convert a nonexistent instance to {0}!", type.FullName);
            //		//}
            //		//else
            //		//{
            //		//	Type instanceType = instance.GetType();
            //		//	if (instanceType != type && !instanceType.IsSubclassOf(type))
            //		//	{
            //		//		instance = null;
            //		//		Entry.LogError("Trying to convert instance from {0} to {1}!", instanceType.FullName, type.FullName);
            //		//	}
            //		//}
            //		//result = true;
            //	}
            //}
            return result;
        }

        private bool convertToNumber(Type type, IntPtr handle, out object result)
        {
            Entry.LogError("No implemention!");
            //if (Type_Byte == type.FullName)
            //{
            //	result = (Entry.General_Typescript_JSValue_ToNumber(mContext, handle) as IConvertible).ToByte(null);
            //	return true;
            //}
            //if (Type_SByte == type.FullName)
            //{
            //	result = (Entry.General_Typescript_JSValue_ToNumber(mContext, handle) as IConvertible).ToSByte(null);
            //	return true;
            //}
            //if (Type_Short == type.FullName)
            //{
            //	result = (Entry.General_Typescript_JSValue_ToNumber(mContext, handle) as IConvertible).ToInt16(null);
            //	return true;
            //}
            //if (Type_UShort == type.FullName)
            //{
            //	result = (Entry.General_Typescript_JSValue_ToNumber(mContext, handle) as IConvertible).ToUInt16(null);
            //	return true;
            //}
            //if (Type_Int == type.FullName)
            //{
            //	result = (Entry.General_Typescript_JSValue_ToNumber(mContext, handle) as IConvertible).ToInt32(null);
            //	return true;
            //}
            //if (Type_UInt == type.FullName)
            //{
            //	result = (Entry.General_Typescript_JSValue_ToNumber(mContext, handle) as IConvertible).ToUInt32(null);
            //	return true;
            //}
            //if (Type_Long == type.FullName)
            //{
            //	result = (Entry.General_Typescript_JSValue_ToNumber(mContext, handle) as IConvertible).ToInt64(null);
            //	return true;
            //}
            //if (Type_ULong == type.FullName)
            //{
            //	result = (Entry.General_Typescript_JSValue_ToNumber(mContext, handle) as IConvertible).ToUInt64(null);
            //	return true;
            //}
            //if (Type_Float == type.FullName)
            //{
            //	result = (Entry.General_Typescript_JSValue_ToNumber(mContext, handle) as IConvertible).ToSingle(null);
            //	return true;
            //}
            //if (Type_Double == type.FullName)
            //{
            //	result = (Entry.General_Typescript_JSValue_ToNumber(mContext, handle) as IConvertible).ToDouble(null);
            //	return true;
            //}
            result = null;
            return false;
        }

        private Array convertToArray(Type subType, int length, IntPtr handle)
        {
            Entry.LogError("No implemention!");
            Array array = Array.CreateInstance(subType, length);
            //for (int i = length - 1; i >= 0; --i)
            //{
            //	object element = null;
            //	IntPtr elementHandle = Entry.General_Typescript_JSValue_GetArrayElement(mContext, handle, i);
            //	if (this.toObject(subType, elementHandle, out element))
            //	{
            //		array.SetValue(element, i);
            //	}
            //}
            return array;
        }

        public T fromJSObject<T>(IntPtr handle)
        {
            return (T)(this.fromJSObject(handle, typeof(T)) ?? default(T));
        }

        public object fromJSObject(IntPtr handle, Type type)
        {
            Entry.LogError("No implemention!");
            //if (this.toObject(type, handle, out basicValue))
            //{
            //	return (T)basicValue;
            //}

            //if (Type_Type == type.FullName)
            //{
            //	string name = Entry.GetTypeFullName(handle);
            //	return Class.FindType(name);
            //}

            //JSValueType jsType = Entry.General_Typescript_JSValue_GetType(mContext, handle);
            //if (type.IsArray)
            //{
            //	Type subType = type.GetElementType();
            //	if (JSValueType.Array == jsType)
            //	{
            //		int length = Entry.General_Typescript_JSValue_GetArrayLength(mContext, handle);
            //		if (null == subType.BaseType)
            //		{
            //			return this.convertToArray(subType, length, handle);
            //		}
            //		else
            //		{
            //			JSValueType jsSubType = Entry.General_Typescript_JSValue_GetArrayType(mContext, handle);
            //			if (subType.FullName == Entry.Type_String)
            //			{
            //				if (JSValueType.String == jsSubType)
            //				{
            //					string[] array = new string[length];
            //					for (int i = length - 1; i >= 0; --i)
            //					{
            //						IntPtr elementHandle = Entry.General_Typescript_JSValue_GetArrayElement(mContext, handle, i);
            //						array[i] = Entry.ToString(elementHandle);
            //					}
            //					return array;
            //				}
            //				else
            //				{
            //					Entry.LogError("Trying to convert JSValueType.{0}[] to {1}[]!", jsSubType.ToString(), subType.FullName);
            //				}
            //			}
            //			if (subType.IsValueType && !subType.FullName.Contains("UnityEngine"))
            //			{
            //				if (JSValueType.Number == jsSubType)
            //				{
            //					return this.convertToArray(subType, length, handle);
            //				}
            //				else
            //				{
            //					Entry.LogError("Trying to convert JSValueType.{0}[] to {1}[]!", jsSubType.ToString(), subType.FullName);
            //				}
            //			}
            //			if (subType.Assembly.FullName.Contains("UnityEngine"))
            //			{
            //				if (JSValueType.Object == jsSubType)
            //				{
            //					return this.convertToArray(subType, length, handle);
            //				}
            //				else
            //				{
            //					Entry.LogError("Trying to convert JSValueType.{0}[] to {1}[]!", jsSubType.ToString(), subType.FullName);
            //				}
            //			}
            //			if (JSValueType.Array == jsSubType)
            //			{
            //				Entry.LogWarning("General.Typescript does not support multi-dimensional array, please wait for upgrade...");
            //			}
            //		}
            //	}
            //	else
            //	{
            //		Entry.LogError("Trying to convert JSValueType.{0} to an array!", jsType.ToString());
            //	}
            //	return Array.CreateInstance(subType, 0);
            //}
            //switch (jsType)
            //{
            //	case JSValueType.Boolean:
            //		return Entry.General_Typescript_JSValue_ToBoolean(mContext, handle);
            //	case JSValueType.Number:
            //		object numberValue = null;
            //		this.convertToNumber(type, handle, out numberValue);
            //		return numberValue;
            //	case JSValueType.String:
            //                 return Entry.ToString(handle);
            //	case JSValueType.Null:
            //	case JSValueType.Undefined:
            //		return null;
            //	case JSValueType.Object:
            //		//return Entry.FromJSObject(handle);
            //	default:
            //		Entry.LogWarning("Unexpected jstype {0} without handler!", jsType.ToString());
            //		break;
            //}
            //Entry.LogWarning("Unexpected type {0} without handler, please contact author...", type.FullName);
            return null;
        }

        protected JSValueType getType(IntPtr handle)
        {
            Entry.LogError("No implemention!");
            //return Entry.General_Typescript_JSValue_GetType(mContext, handle);
            return JSValueType.Unknown;
        }

        protected void finalize()
        {
            IntPtr context = mContext;
            mContext = IntPtr.Zero;
            Entry.General_Typescript_Finalize(context);
        }
    }
}