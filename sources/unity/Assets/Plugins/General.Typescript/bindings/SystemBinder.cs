using System;

namespace General.Typescript
{
    public class SystemBinder
    {
        static public void Initialize()
        {
            Namespace self = Entry.DeclareNamespace("System");

			NetBinder.Bind(self);
			WebBinder.Bind(self);
			SystemHttpStyleUriParser.Bind(self);
        }
    }
}