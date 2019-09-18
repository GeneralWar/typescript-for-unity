using System;

namespace General.Typescript
{
    public class NetworkingBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Networking");

			PlayerConnectionBinder.Bind(self);
        }
    }
}