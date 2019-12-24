using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSceneManagementLocalPhysicsMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.SceneManagement.LocalPhysicsMode> instance = space.DeclareEnum<UnityEngine.SceneManagement.LocalPhysicsMode>();
			instance.SetValue("None", (long)UnityEngine.SceneManagement.LocalPhysicsMode.None);
			instance.SetValue("Physics2D", (long)UnityEngine.SceneManagement.LocalPhysicsMode.Physics2D);
			instance.SetValue("Physics3D", (long)UnityEngine.SceneManagement.LocalPhysicsMode.Physics3D);
		}
	}
}
