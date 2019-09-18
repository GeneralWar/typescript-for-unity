using System;

namespace General.Typescript
{
    public class AssertionsBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Assertions");

			ComparersBinder.Bind(self);
			UnityEngineAssertionsAssertionException.Bind(self);
        }
    }
}