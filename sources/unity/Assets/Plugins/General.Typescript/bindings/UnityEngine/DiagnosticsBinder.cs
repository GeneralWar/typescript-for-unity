using System;

namespace General.Typescript
{
    public class DiagnosticsBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Diagnostics");

			UnityEngineDiagnosticsForcedCrashCategory.Bind(self);
        }
    }
}