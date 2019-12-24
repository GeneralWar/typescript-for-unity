using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRuntimeInitializeLoadType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.RuntimeInitializeLoadType> instance = space.DeclareEnum<UnityEngine.RuntimeInitializeLoadType>();
			instance.SetValue("AfterSceneLoad", (long)UnityEngine.RuntimeInitializeLoadType.AfterSceneLoad);
			instance.SetValue("BeforeSceneLoad", (long)UnityEngine.RuntimeInitializeLoadType.BeforeSceneLoad);
		}
	}
}
