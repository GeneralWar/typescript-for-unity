using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace General.Typescript
{
    static public class Utils
    {
        static public bool ArrayEqual(Array array1, Array array2)
        {
            if (array1.Length != array2.Length)
            {
                return false;
            }
            for (int i = array1.Length - 1; i > 0; --i)
            {
                if (array1.GetValue(i) != array2.GetValue(i))
                {
                    return false;
                }
            }
            return true;
        }

        static public bool IsSupported(MemberInfo info)
        {
            if (null == info)
            {
                return false;
            }
            if (null != info.GetCustomAttribute<ObsoleteAttribute>())
            {
                return false;
            }
            if (info is Type)
            {
                return isSupported(info as Type);
            }
            if (info is MethodInfo)
            {
                return isSupported(info as MethodInfo);
            }
            if (info is PropertyInfo)
            {
                return isSupported(info as PropertyInfo);
            }
            if (info is FieldInfo)
            {
                return isSupported(info as FieldInfo);
            }
            return true;
        }

        static private bool isSupported(Type type)
        {
            string fullname = type.GetSafeFullName();
            if (fullname.Contains("<") || fullname.Contains(">"))
            {
                return false;
            }
            return (type.IsPublic || (type.IsNestedPublic && type.ReflectedType.IsPublic)) && !type.IsGenericType && (!type.IsNested || Utils.IsSupported(type.ReflectedType)) && !type.Name.Contains("PlayerConnection");
        }

        static private bool isSupported(MethodInfo info)
        {
            if (info.Name.StartsWith("get_") || info.Name.StartsWith("set_") || info.Name.StartsWith("add_") || info.Name.StartsWith("remove_") // skip as property and event
                || info.Name.StartsWith("op_"))
            {
                return false;
            }
            ParameterInfo[] parameters = info.GetParameters();
            if (parameters.Any(p => null != p.ParameterType.GetSafeFullName() && p.ParameterType.GetSafeFullName().Contains("&") || p.ParameterType.GetSafeFullName().Contains("System.Nullable")))
            {
                return false;
            }
            if (info.Name == "SetNoBackupFlag"
                || info.Name == "ResetNoBackupFlag"
                || info.Name == "StopRecordingUndo"
                || info.Name == "StartRecordingUndo"
                || info.Name == "IsJoystickPreconfigured"
                || info.Name == "IsJoystickPreconfigured"
                || info.Name == "GetEditorName"
                || info.Name == "OnRebuildRequested")
            {
                return false;
            }
            return true;
        }

        static private bool isSupported(PropertyInfo info)
        {
            if (!Utils.IsSupported(info.PropertyType))
            {
                return false;
            }
            if (info.PropertyType.IsGenericType)
            {
                return false;
            }
            if ("Item" == info.Name
                || "areaSize" == info.Name
                || "lightmapBakeType" == info.Name
                || "shadowRadius" == info.Name
                || "shadowAngle" == info.Name
                || "streamingMipmapsRenderersPerFrame" == info.Name
                || "runInEditMode" == info.Name
                || "alphaIsTransparency" == info.Name
                || "imageContentsHash" == info.Name
                || "alphaIsTransparency" == info.Name)
            {
                return false;
            }
            return (info.CanWrite && info.SetMethod.IsPublic) || (info.CanRead && info.GetMethod.IsPublic);
        }

        static private bool isSupported(FieldInfo info)
        {
            if (!Utils.IsSupported(info.FieldType))
            {
                return false;
            }
            if (info.FieldType.IsGenericType)
            {
                return false;
            }
            if (info.Name.Contains("Crunched"))
            {
                return false;
            }
            return true;
        }

        static public bool IsSupported(ParameterInfo info)
        {
            if (null == info)
            {
                return false;
            }

            string typename = info.ParameterType.GetSafeFullName();
            if (typename.StartsWith("System.Span"))
            {
                // System.Span<T> seems to be a hiden symbol.
                return false;
            }
            if (typename.StartsWith("System.ReadOnlySpan"))
            {
                // System.ReadOnlySpan<T> seems to be a hiden symbol.
                return false;
            }
            if (typename.StartsWith("System.Memory"))
            {
                // System.Memory<T> seems to be a hiden symbol.
                return false;
            }
            if (typename.StartsWith("System.ReadOnlyMemory"))
            {
                // System.ReadOnlyMemory<T> seems to be a hiden symbol.
                return false;
            }
            return true;
        }

        static public List<Type> FilterTypeTable(IEnumerable<Type> types)
        {
            List<Type> filteredTypes = new List<Type>();
            foreach (Type type in types)
            {
                string typename = type.GetSafeFullName();
                if (typename.Contains("Android")
                || typename.StartsWith("UnityEngine.WSA") || typename.StartsWith("UnityEngine.Windows")
                || "UnityEngine.UI.GraphicRebuildTracker" == typename || "Unity.Collections.LowLevel.Unsafe.DisposeSentinel" == typename || "UnityEngine.TextureCompressionQuality" == typename
                || "UnityEngine.EventProvider" == typename || "Unity.Collections.LowLevel.Unsafe.AtomicSafetyHandle" == typename || "Unity.Collections.LowLevel.Unsafe.EnforceJobResult" == typename)
                {
                    continue;
                }
                filteredTypes.Add(type);
            }
            return filteredTypes;
        }
    }
}
