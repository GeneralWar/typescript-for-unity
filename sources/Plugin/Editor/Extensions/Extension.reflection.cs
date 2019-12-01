using System;
using System.Reflection;

namespace General.Typescript
{
    static public partial class Extension
    {
        static public bool IsObsolete(this Type info)
        {
            return null != info.GetCustomAttribute<ObsoleteAttribute>();
        }

        static public bool IsObsolete(this MemberInfo info)
        {
            return null != info.GetCustomAttribute<ObsoleteAttribute>();
        }

        static public bool IsStillInUse(this Type info)
        {
            return null == info.GetCustomAttribute<ObsoleteAttribute>();
        }

        static public bool IsStillInUse(this MemberInfo info)
        {
            return null == info.GetCustomAttribute<ObsoleteAttribute>();
        }
    }
}
