using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationsAnimationLayerMixerPlayable
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Animations.AnimationLayerMixerPlayable> self = space.DeclareClass<UnityEngine.Animations.AnimationLayerMixerPlayable>();
			self.BindConstructor();
			self.BindStaticFunction("Create", Create);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHandle", GetHandle);
			self.BindInstanceFunction("IsLayerAdditive", IsLayerAdditive);
			self.BindInstanceFunction("SetLayerAdditive", SetLayerAdditive);
			self.BindInstanceFunction("SetLayerMaskFromAvatarMask", SetLayerMaskFromAvatarMask);
			self.BindStaticProperty("Null", get_Null, null);
		}

		static private UnityEngine.Animations.AnimationLayerMixerPlayable Create(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Playables.PlayableGraph, System.Int32>())
			{
				return UnityEngine.Animations.AnimationLayerMixerPlayable.Create(parameters[0].ToObject<UnityEngine.Playables.PlayableGraph>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimationLayerMixerPlayable.Create has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationLayerMixerPlayable.Create has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Animations.AnimationLayerMixerPlayable);
		}

		static private System.Boolean Equals(UnityEngine.Animations.AnimationLayerMixerPlayable instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Animations.AnimationLayerMixerPlayable>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Animations.AnimationLayerMixerPlayable>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimationLayerMixerPlayable.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationLayerMixerPlayable.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.Playables.PlayableHandle GetHandle(UnityEngine.Animations.AnimationLayerMixerPlayable instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationLayerMixerPlayable.GetHandle has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Playables.PlayableHandle);
		}

		static private System.Boolean IsLayerAdditive(UnityEngine.Animations.AnimationLayerMixerPlayable instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.UInt32>())
			{
				return instance.IsLayerAdditive(parameters[0].ToObject<System.UInt32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimationLayerMixerPlayable.IsLayerAdditive has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationLayerMixerPlayable.IsLayerAdditive has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void SetLayerAdditive(UnityEngine.Animations.AnimationLayerMixerPlayable instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.UInt32, System.Boolean>())
			{
				instance.SetLayerAdditive(parameters[0].ToObject<System.UInt32>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimationLayerMixerPlayable.SetLayerAdditive has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationLayerMixerPlayable.SetLayerAdditive has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetLayerMaskFromAvatarMask(UnityEngine.Animations.AnimationLayerMixerPlayable instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.UInt32, UnityEngine.AvatarMask>())
			{
				instance.SetLayerMaskFromAvatarMask(parameters[0].ToObject<System.UInt32>(), parameters[1].ToObject<UnityEngine.AvatarMask>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimationLayerMixerPlayable.SetLayerMaskFromAvatarMask has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationLayerMixerPlayable.SetLayerMaskFromAvatarMask has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Animations.AnimationLayerMixerPlayable get_Null(Type type, string name)
		{
			return UnityEngine.Animations.AnimationLayerMixerPlayable.Null;
		}

	}
}
