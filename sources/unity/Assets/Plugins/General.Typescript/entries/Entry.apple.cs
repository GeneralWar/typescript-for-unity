using System;
using UnityEngine;

namespace General.Typescript
{
    public class AppleEntry : Entry
    {
        override public bool initialize()
        {
            mContext = Entry.InitializeContext();
            if (IntPtr.Zero == mContext)
            {
                Entry.LogError("Initialize typescript failed!");
                return false;
            }
            return true;
        }

        //public override IntPtr toJSObject<T>(T value)
        //{
        //    if (value is string)
        //    {
        //        return Entry.General_Typescript_CreateString(mContext, value as string);
        //    }
        //    else if (value is ValueType)
        //    {
        //        return Entry.General_Typescript_CreateNumber(mContext, (value as IConvertible).ToDouble(null));
        //    }
        //    else
        //    {
        //        if (null == value)
        //        {
        //            return IntPtr.Zero;
        //        }
        //        else
        //        {
        //            Type type = value.GetType();
        //            string name = type.FullName;
        //            TypescriptClass c = Class.FindClass(name);
        //            if (null == c)
        //            {
        //                Entry.Log(name);
        //                Entry.LogWarning(string.Format("Type {0} has not been registered into General.Typescript!", name));
        //                return IntPtr.Zero;
        //            }
        //            return c.CreateInstance(value);
        //        }
        //    }
        //    //return IntPtr.Zero;
        //}
    }
}