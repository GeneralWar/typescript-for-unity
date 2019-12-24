using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimatorClipInfo
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AnimatorClipInfo> self = space.DeclareClass<UnityEngine.AnimatorClipInfo>();
			self.BindConstructor();
			self.BindInstanceProperty("clip", get_clip, null);
			self.BindInstanceProperty("weight", get_weight, null);
		}

		static private UnityEngine.AnimationClip get_clip(UnityEngine.AnimatorClipInfo instance, string name)
		{
			return instance.clip;
		}

		static private System.Single get_weight(UnityEngine.AnimatorClipInfo instance, string name)
		{
			return instance.weight;
		}

	}
}
