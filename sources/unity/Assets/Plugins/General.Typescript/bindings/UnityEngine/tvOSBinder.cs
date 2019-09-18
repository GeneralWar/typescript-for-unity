using System;

namespace General.Typescript
{
    public class tvOSBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("tvOS");


#if UNITY_TVOS
			UnityEnginetvOSDevice.Bind(self);
			UnityEnginetvOSDeviceGeneration.Bind(self);
			UnityEnginetvOSRemote.Bind(self);
#endif
        }
    }
}