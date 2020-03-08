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
        static private List<Type> sCustomSuperClasses = new List<Type>();

        static private Stack<string> sCustomTypeStack = new Stack<string>();
        static public string LastCustomType { get { return sCustomTypeStack.Count > 0 ? sCustomTypeStack.Peek() : string.Empty; } }

        static private Stack<int> sCustomTypeCountStack = new Stack<int>();

        static public void AppendCustomSuperClass<T>()
        {
            AppendCustomSuperClass(typeof(T));
        }

        static public void AppendCustomSuperClass(Type type)
        {
            checkInstance();
            sCustomSuperClasses.Add(type);
        }

        static public bool IsCustomSuperClass(string typename)
        {
            return sCustomSuperClasses.Exists(t => t.GetSafeFullName() == typename);
        }

        static public bool IsCustomSuperClassInstance(object instance)
        {
            return sCustomSuperClasses.Exists(t => t.IsInstanceOfType(instance));
        }

        static public Type FindCustomSuperClass(string typename)
        {
            Type type = sCustomSuperClasses.Find(t => typename.StartsWith(t.GetSafeFullName()));
            if (null != type)
            {
                sCustomTypeStack.Push(typename);
            }
            return type;
        }

        static public void BeginCallFunction()
        {
            sCustomTypeCountStack.Push(sCustomTypeStack.Count);
        }

        static public void EndCallFunction()
        {
            if (sCustomTypeCountStack.Count < 1)
            {
                Entry.LogError("Try to EndCallFunction but there is CustomTypeCountStack is empty!");
                return;
            }
            int count = sCustomTypeCountStack.Pop();
            if (sCustomTypeStack.Count < count)
            {
                Entry.LogError("Try to EndCallFunction but there is CustomTypeStack.Count is less than cached count!");
                return;
            }
            while (sCustomTypeStack.Count > count)
            {
                sCustomTypeStack.Pop();
            }
        }
    }
}