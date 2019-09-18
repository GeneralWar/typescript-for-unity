using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSceneManagementUnloadSceneOptions
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.SceneManagement.UnloadSceneOptions> instance = space.DeclareEnum<UnityEngine.SceneManagement.UnloadSceneOptions>();
			instance.SetValue("None", (long)UnityEngine.SceneManagement.UnloadSceneOptions.None);
			instance.SetValue("UnloadAllEmbeddedSceneObjects", (long)UnityEngine.SceneManagement.UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
		}
	}
}
