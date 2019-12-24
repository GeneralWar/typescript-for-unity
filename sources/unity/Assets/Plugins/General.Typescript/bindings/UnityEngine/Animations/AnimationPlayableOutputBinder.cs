using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationsAnimationPlayableOutput
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Animations.AnimationPlayableOutput> self = space.DeclareClass<UnityEngine.Animations.AnimationPlayableOutput>();
			self.BindConstructor();
			self.BindStaticFunction("Create", Create);
			self.BindInstanceFunction("GetHandle", GetHandle);
			self.BindInstanceFunction("GetTarget", GetTarget);
			self.BindInstanceFunction("SetTarget", SetTarget);
			self.BindStaticProperty("Null", get_Null, null);
		}

		static private UnityEngine.Animations.AnimationPlayableOutput Create(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Playables.PlayableGraph, System.String, UnityEngine.Animator>())
			{
				return UnityEngine.Animations.AnimationPlayableOutput.Create(parameters[0].ToObject<UnityEngine.Playables.PlayableGraph>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<UnityEngine.Animator>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimationPlayableOutput.Create has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationPlayableOutput.Create has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Animations.AnimationPlayableOutput);
		}

		static private UnityEngine.Playables.PlayableOutputHandle GetHandle(UnityEngine.Animations.AnimationPlayableOutput instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationPlayableOutput.GetHandle has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Playables.PlayableOutputHandle);
		}

		static private UnityEngine.Animator GetTarget(UnityEngine.Animations.AnimationPlayableOutput instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetTarget();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationPlayableOutput.GetTarget has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void SetTarget(UnityEngine.Animations.AnimationPlayableOutput instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Animator>())
			{
				instance.SetTarget(parameters[0].ToObject<UnityEngine.Animator>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimationPlayableOutput.SetTarget has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimationPlayableOutput.SetTarget has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Animations.AnimationPlayableOutput get_Null(Type type, string name)
		{
			return UnityEngine.Animations.AnimationPlayableOutput.Null;
		}

	}
}
