using System;

namespace General.Typescript
{
    public class WindowsBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Windows");

			SpeechBinder.Bind(self);
        }
    }
}