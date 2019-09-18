using System;

namespace General.Typescript
{
    public class ComparersBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Comparers");

			UnityEngineAssertionsComparersFloatComparer.Bind(self);
        }
    }
}