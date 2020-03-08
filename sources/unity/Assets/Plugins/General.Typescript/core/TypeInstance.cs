
using System;
using System.Collections.Generic;

namespace General.Typescript
{
    public abstract class TypeInstance : Base
    {
        protected Type mType = null;
        public Type Type { get { return mType; } }

        private bool mIsBinded = false;
        public bool IsBinded { get { return mIsBinded; } }

        internal TypeInstance(IntPtr context, IntPtr handle, Type type, Base parent) : base(context, handle, type.Name, parent)
        {
            mType = type;
            sInstances.Add(type.GetSafeFullName(), this);
        }

        public void Bind()
        {
            Type type = mType;
            Type directBaseType = null;
            TypeInstance baseInstance = null;
            while (null != type?.DeclaringType)
            {
                if (sInstances.TryGetValue(type.DeclaringType.GetSafeFullName(), out baseInstance) && (baseInstance?.IsBinded ?? false))
                {
                    baseInstance.Bind();
                    break;
                }
                type = type.DeclaringType;
            }
            while (null != type?.BaseType)
            {
                if (sInstances.TryGetValue(type.BaseType.GetSafeFullName(), out baseInstance))
                {
                    directBaseType = baseInstance.Type;
                    if (!baseInstance.IsBinded)
                    {
                        baseInstance.Bind();
                    }
                    break;
                }
                type = type.BaseType;
            }
            this.bind(directBaseType?.GetSafeFullName());
            mIsBinded = true;
        }

        protected abstract void bind(string parentType);

        static private Dictionary<string, TypeInstance> sInstances = new Dictionary<string, TypeInstance>();

        static public void BindTypes()
        {
            foreach (KeyValuePair<string, TypeInstance> pair in sInstances)
            {
                pair.Value.Bind();
            }
            sInstances.Clear();
        }
    }
}