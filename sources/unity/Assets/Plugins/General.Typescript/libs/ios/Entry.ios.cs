using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System;
using AOT;
using System.Linq;
using System.IO;

namespace General.Typescript
{
    public class IOSEntry : Entry
    {
        override public bool initialize()
        {
            mContext = General_Typescript_Initialize();
            if (IntPtr.Zero == mContext)
            {
                Debug.LogError("Initialize typescript failed!");
                return false;
            }

			Entry.Bind();

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
        //                Debug.Log(name);
        //                Debug.LogWarning(string.Format("Type {0} has not been registered into General.Typescript!", name));
        //                return IntPtr.Zero;
        //            }
        //            return c.CreateInstance(value);
        //        }
        //    }
        //    //return IntPtr.Zero;
        //}
	}
}