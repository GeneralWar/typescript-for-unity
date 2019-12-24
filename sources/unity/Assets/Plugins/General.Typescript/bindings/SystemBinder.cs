using System;

namespace General.Typescript
{
    public class SystemBinder : Binder
    {
        static public void Initialize()
        {
            Namespace self = Entry.DeclareNamespace("System");

			IOBinder.Bind(self);
			NetBinder.Bind(self);
			SystemGuid.Bind(self);
        }
    }
}