using System;
using System.IO;
using System.Linq;
using System.Reflection;

namespace General.Typescript
{
    static public partial class Extension
    {
        static public string GetSafeFullName(this Type type)
        {
            string result = (type.FullName ?? type.Name).Replace("+", ".");
            if (type.IsGenericType)
            {
                try
                {
                    result = string.Format("{0}<{1}>", result.Substring(0, result.IndexOf('`')), string.Join(", ", Array.ConvertAll(type.GetGenericArguments(), a => a.IsGenericParameter ? a.Name : a.GetSafeFullName())));
                }
                catch (Exception e)
                {
                    Entry.LogError(e);
                    Entry.LogWarning(type);
                    Type[] types = type.GetGenericArguments();
                    Entry.LogWarning(type.GetGenericArguments()[0].GetType());
                }
            }
            return result;
        }
    }
}
