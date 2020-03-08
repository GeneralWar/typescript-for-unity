using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace General.Typescript
{
    public partial class Parameters
    {
        public interface IParameterDelegateConverter
        {
            void InitializeDelegates();
            Delegate ToDelegate(IntPtr parameter, Type type);
        }

        static private IParameterDelegateConverter sDelegateConverter = null;

        static public void SetDelegateConverter<T>() where T : IParameterDelegateConverter, new()
        {
            if (null == sDelegateConverter || !(sDelegateConverter is T))
            {
                sDelegateConverter = new T();
                sDelegateConverter.InitializeDelegates();
            }
        }

        static public void SetDelegateConverter(Type type)
        {
            if (null == sDelegateConverter || sDelegateConverter.GetType() != type)
            {
                sDelegateConverter = System.Activator.CreateInstance(type) as IParameterDelegateConverter;
                sDelegateConverter.InitializeDelegates();
            }
        }

        static internal Delegate ConvertDelegate(Parameter parameter, Type type)
        {
            if (null != sDelegateConverter)
            {
                IntPtr handle = Entry.Parameters.ToFunction(parameter.Handle, parameter.Index);
                Delegate @delegate = sDelegateConverter.ToDelegate(handle, type);
                if (null == @delegate)
                {
                    Entry.Object.MakeWeak(handle);
                }
                else
                {
                    Entry.Object.MakePersistent(handle);
                }
                return @delegate;
            }
            return null;
        }
    }
}