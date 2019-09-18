using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationsAnimationClipPlayable
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Animations.AnimationClipPlayable> self = space.DeclareClass<UnityEngine.Animations.AnimationClipPlayable>();
			self.BindConstructor();
			self.BindStaticFunction("Create", Create);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetAnimationClip", GetAnimationClip);
			self.BindInstanceFunction("GetApplyFootIK", GetApplyFootIK);
			self.BindInstanceFunction("GetApplyPlayableIK", GetApplyPlayableIK);
			self.BindInstanceFunction("GetHandle", GetHandle);
			self.BindInstanceFunction("SetApplyFootIK", SetApplyFootIK);
			self.BindInstanceFunction("SetApplyPlayableIK", SetApplyPlayableIK);
		}

		static private UnityEngine.Animations.AnimationClipPlayable Create(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Playables.PlayableGraph, UnityEngine.AnimationClip>())
			{
				return UnityEngine.Animations.AnimationClipPlayable.Create(parameters[0].ToObject<UnityEngine.Playables.PlayableGraph>(), parameters[1].ToObject<UnityEngine.AnimationClip>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimationClipPlayable.Create has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationClipPlayable.Create has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Animations.AnimationClipPlayable);
		}

		static private System.Boolean Equals(UnityEngine.Animations.AnimationClipPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Animations.AnimationClipPlayable>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Animations.AnimationClipPlayable>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimationClipPlayable.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationClipPlayable.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.AnimationClip GetAnimationClip(UnityEngine.Animations.AnimationClipPlayable instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetAnimationClip();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationClipPlayable.GetAnimationClip has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Boolean GetApplyFootIK(UnityEngine.Animations.AnimationClipPlayable instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetApplyFootIK();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationClipPlayable.GetApplyFootIK has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.Boolean GetApplyPlayableIK(UnityEngine.Animations.AnimationClipPlayable instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetApplyPlayableIK();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationClipPlayable.GetApplyPlayableIK has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private UnityEngine.Playables.PlayableHandle GetHandle(UnityEngine.Animations.AnimationClipPlayable instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetHandle();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationClipPlayable.GetHandle has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Playables.PlayableHandle);
		}

		static private void SetApplyFootIK(UnityEngine.Animations.AnimationClipPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean>())
			{
				instance.SetApplyFootIK(parameters[0].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimationClipPlayable.SetApplyFootIK has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationClipPlayable.SetApplyFootIK has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetApplyPlayableIK(UnityEngine.Animations.AnimationClipPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean>())
			{
				instance.SetApplyPlayableIK(parameters[0].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimationClipPlayable.SetApplyPlayableIK has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationClipPlayable.SetApplyPlayableIK has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

	}
}
