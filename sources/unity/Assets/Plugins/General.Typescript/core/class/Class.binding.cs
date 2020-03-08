using System;
using System.Runtime.InteropServices;

namespace General.Typescript
{
    public abstract partial class Entry
    {
        static public class Class
        {
            #region Class
            [DllImport(LIBRARY_NAME)]
            static private extern void General_Typescript_Class_BindConstructorCallback(ConstructorCallback callback);
            static internal void BindConstructorCallback(ConstructorCallback callback)
            {
                General_Typescript_Class_BindConstructorCallback(callback);
            }

            [DllImport(LIBRARY_NAME)]
            static private extern IntPtr General_Typescript_Class_BindStaticFunction(IntPtr handle, string name);
            static public IntPtr BindStaticFunction(IntPtr handle, string name)
            {
                return General_Typescript_Class_BindStaticFunction(handle, name);
            }

            [DllImport(LIBRARY_NAME)]
            static private extern IntPtr General_Typescript_Class_BindInstanceFunction(IntPtr handle, string name);
            static public IntPtr BindInstanceFunction(IntPtr handle, string name)
            {
                return General_Typescript_Class_BindInstanceFunction(handle, name);
            }

            [DllImport(LIBRARY_NAME)]
            static private extern void General_Typescript_Class_BindFunctionCallback(StaticFunctionCallback staticCallback, InstanceFunctionCallback instanceCallback);
            static public void BindFunctionCallback(StaticFunctionCallback staticCallback, InstanceFunctionCallback instanceCallback)
            {
                General_Typescript_Class_BindFunctionCallback(staticCallback, instanceCallback);
            }

            [DllImport(LIBRARY_NAME)]
            static private extern IntPtr General_Typescript_Class_BindStaticProperty(IntPtr handle, string name, bool hasGetter, bool hasSetter);
            static public IntPtr BindStaticProperty(IntPtr handle, string name, bool hasGetter, bool hasSetter)
            {
                return General_Typescript_Class_BindStaticProperty(handle, name, hasGetter, hasSetter);
            }

            [DllImport(LIBRARY_NAME)]
            static private extern IntPtr General_Typescript_Class_BindInstanceProperty(IntPtr handle, string name, bool hasGetter, bool hasSetter);
            static public IntPtr BindInstanceProperty(IntPtr handle, string name, bool hasGetter, bool hasSetter)
            {
                return General_Typescript_Class_BindInstanceProperty(handle, name, hasGetter, hasSetter);
            }

            [DllImport(LIBRARY_NAME)]
            static private extern void General_Typescript_Class_BindPropertyCallback(StaticPropertyGetter staticGetter, StaticPropertySetter staticSetter, InstancePropertyGetter instanceGetter, InstancePropertySetter instanceSetter);
            static public void BindPropertyCallback(StaticPropertyGetter staticGetter, StaticPropertySetter staticSetter, InstancePropertyGetter instanceGetter, InstancePropertySetter instanceSetter)
            {
                General_Typescript_Class_BindPropertyCallback(staticGetter, staticSetter, instanceGetter, instanceSetter);
            }

            [DllImport(LIBRARY_NAME)]
            static private extern IntPtr General_Typescript_Class_DeclareClass(IntPtr parent, string name, string baseFullname, bool hasConstructor, bool isStatic);
            static public IntPtr DeclareClass(IntPtr parent, Type type)
            {
                return General_Typescript_Class_DeclareClass(parent, type.Name, type?.BaseType.GetSafeFullName() ?? string.Empty, General.Typescript.Class.HasValidConstructors(type), type.IsAbstract && type.IsSealed);
            }

            [DllImport(LIBRARY_NAME)]
            static private extern IntPtr General_Typescript_Class_DeclareEnum(IntPtr parent, string name);
            static public IntPtr DeclareEnum(IntPtr parent, string name)
            {
                return General_Typescript_Class_DeclareEnum(parent, name);
            }

            [DllImport(LIBRARY_NAME)]
            static private extern void General_Typescript_Class_Register(IntPtr handle, string parentType);
            static public void Register(IntPtr handle, string parentType)
            {
                General_Typescript_Class_Register(handle, parentType);
            }
            #endregion
        }
    }
}