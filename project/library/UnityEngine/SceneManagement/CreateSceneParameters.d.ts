declare namespace UnityEngine
{
	declare namespace SceneManagement
	{
		export class CreateSceneParameters extends System.ValueType
		{
			public constructor(physicsMode: UnityEngine.SceneManagement.LocalPhysicsMode);
			public get localPhysicsMode(): UnityEngine.SceneManagement.LocalPhysicsMode;
			public set localPhysicsMode(): UnityEngine.SceneManagement.LocalPhysicsMode;
		}
	}
}
