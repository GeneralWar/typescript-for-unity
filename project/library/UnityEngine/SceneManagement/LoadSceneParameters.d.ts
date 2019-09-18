declare namespace UnityEngine
{
	declare namespace SceneManagement
	{
		export class LoadSceneParameters extends System.ValueType
		{
			public constructor(mode: UnityEngine.SceneManagement.LoadSceneMode);
			public constructor(mode: UnityEngine.SceneManagement.LoadSceneMode, physicsMode: UnityEngine.SceneManagement.LocalPhysicsMode);
			public get loadSceneMode(): UnityEngine.SceneManagement.LoadSceneMode;
			public set loadSceneMode(): UnityEngine.SceneManagement.LoadSceneMode;
			public get localPhysicsMode(): UnityEngine.SceneManagement.LocalPhysicsMode;
			public set localPhysicsMode(): UnityEngine.SceneManagement.LocalPhysicsMode;
		}
	}
}
