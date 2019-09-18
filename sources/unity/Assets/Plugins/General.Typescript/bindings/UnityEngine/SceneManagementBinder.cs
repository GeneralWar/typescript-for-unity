using System;

namespace General.Typescript
{
    public class SceneManagementBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("SceneManagement");

			UnityEngineSceneManagementCreateSceneParameters.Bind(self);
			UnityEngineSceneManagementLoadSceneMode.Bind(self);
			UnityEngineSceneManagementLoadSceneParameters.Bind(self);
			UnityEngineSceneManagementLocalPhysicsMode.Bind(self);
			UnityEngineSceneManagementScene.Bind(self);
			UnityEngineSceneManagementSceneManager.Bind(self);
			UnityEngineSceneManagementUnloadSceneOptions.Bind(self);
        }
    }
}