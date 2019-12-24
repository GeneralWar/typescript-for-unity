using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRuntimeAnimatorController
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.RuntimeAnimatorController> self = space.DeclareClass<UnityEngine.RuntimeAnimatorController, UnityEngine.Object>();
			self.BindConstructor();
			self.BindInstanceProperty("animationClips", get_animationClips, null);
		}

		static private UnityEngine.AnimationClip[] get_animationClips(UnityEngine.RuntimeAnimatorController instance, string name)
		{
			return instance.animationClips;
		}

	}
}
