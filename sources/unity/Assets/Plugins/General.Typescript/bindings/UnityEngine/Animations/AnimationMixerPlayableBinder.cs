using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationsAnimationMixerPlayable
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Animations.AnimationMixerPlayable> self = space.DeclareClass<UnityEngine.Animations.AnimationMixerPlayable>();
			self.BindConstructor();
			self.BindStaticFunction("Create", Create);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHandle", GetHandle);
			self.BindStaticProperty("Null", get_Null, null);
		}

		static private UnityEngine.Animations.AnimationMixerPlayable Create(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Playables.PlayableGraph, System.Int32, System.Boolean>())
			{
				return UnityEngine.Animations.AnimationMixerPlayable.Create(parameters[0].ToObject<UnityEngine.Playables.PlayableGraph>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimationMixerPlayable.Create has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationMixerPlayable.Create has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Animations.AnimationMixerPlayable);
		}

		static private System.Boolean Equals(UnityEngine.Animations.AnimationMixerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Animations.AnimationMixerPlayable>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Animations.AnimationMixerPlayable>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimationMixerPlayable.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationMixerPlayable.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.Playables.PlayableHandle GetHandle(UnityEngine.Animations.AnimationMixerPlayable instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationMixerPlayable.GetHandle has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Playables.PlayableHandle);
		}

		static private UnityEngine.Animations.AnimationMixerPlayable get_Null()
		{
			return UnityEngine.Animations.AnimationMixerPlayable.Null;
		}

	}
}
