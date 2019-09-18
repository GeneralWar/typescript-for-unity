using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationPlayMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.AnimationPlayMode> instance = space.DeclareEnum<UnityEngine.AnimationPlayMode>();
			instance.SetValue("Stop", (long)UnityEngine.AnimationPlayMode.Stop);
			instance.SetValue("Queue", (long)UnityEngine.AnimationPlayMode.Queue);
			instance.SetValue("Mix", (long)UnityEngine.AnimationPlayMode.Mix);
		}
	}
}
