using System;

namespace General.Typescript
{
    public class SerializationBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Serialization");

			UnityEngineSerializationUnitySurrogateSelector.Bind(self);
        }
    }
}