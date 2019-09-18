using System;

namespace General.Typescript
{
    public class AndroidBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Android");


#if UNITY_ANDROID
			UnityEngineAndroidPermission.Bind(self);
#endif
        }
    }
}