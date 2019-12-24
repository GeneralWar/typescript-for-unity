using System;

namespace General.Typescript
{
    public class U2DBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("U2D");

			UnityEngineU2DSpriteAtlas.Bind(self);
			UnityEngineU2DSpriteAtlasManager.Bind(self);
        }
    }
}