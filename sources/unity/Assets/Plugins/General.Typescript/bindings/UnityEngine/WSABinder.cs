using System;

namespace General.Typescript
{
    public class WSABinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("WSA");


#if UNITY_WSA
			UnityEngineWSAApplication.Bind(self);
			UnityEngineWSAFolder.Bind(self);
			UnityEngineWSALauncher.Bind(self);
			UnityEngineWSASecondaryTileData.Bind(self);
			UnityEngineWSATile.Bind(self);
			UnityEngineWSATileForegroundText.Bind(self);
			UnityEngineWSATileTemplate.Bind(self);
			UnityEngineWSAToast.Bind(self);
			UnityEngineWSAToastTemplate.Bind(self);
			UnityEngineWSAWindowActivationState.Bind(self);
#endif
        }
    }
}