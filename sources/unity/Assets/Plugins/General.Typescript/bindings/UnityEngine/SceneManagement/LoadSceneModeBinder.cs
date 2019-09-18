using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSceneManagementLoadSceneMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.SceneManagement.LoadSceneMode> instance = space.DeclareEnum<UnityEngine.SceneManagement.LoadSceneMode>();
			instance.SetValue("Single", (long)UnityEngine.SceneManagement.LoadSceneMode.Single);
			instance.SetValue("Additive", (long)UnityEngine.SceneManagement.LoadSceneMode.Additive);
		}
	}
}
