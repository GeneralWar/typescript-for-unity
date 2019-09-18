using System;

namespace General.Typescript
{
    public class PlayerConnectionBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("PlayerConnection");

			UnityEngineNetworkingPlayerConnectionMessageEventArgs.Bind(self);
        }
    }
}