using System;

namespace General.Typescript
{
    public class WebBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Web");

			SystemWebAspNetHostingPermission.Bind(self);
			SystemWebAspNetHostingPermissionLevel.Bind(self);
        }
    }
}