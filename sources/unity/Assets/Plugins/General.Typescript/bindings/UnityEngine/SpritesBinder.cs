using System;

namespace General.Typescript
{
    public class SpritesBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Sprites");

			UnityEngineSpritesDataUtility.Bind(self);
        }
    }
}