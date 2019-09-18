using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationsAnimatorControllerPlayable
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Animations.AnimatorControllerPlayable> self = space.DeclareClass<UnityEngine.Animations.AnimatorControllerPlayable>();
			self.BindConstructor();
			self.BindStaticFunction("Create", Create);
			self.BindInstanceFunction("CrossFade", CrossFade);
			self.BindInstanceFunction("CrossFadeInFixedTime", CrossFadeInFixedTime);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetAnimatorTransitionInfo", GetAnimatorTransitionInfo);
			self.BindInstanceFunction("GetBool", GetBool);
			self.BindInstanceFunction("GetCurrentAnimatorClipInfo", GetCurrentAnimatorClipInfo);
			self.BindInstanceFunction("GetCurrentAnimatorClipInfoCount", GetCurrentAnimatorClipInfoCount);
			self.BindInstanceFunction("GetCurrentAnimatorStateInfo", GetCurrentAnimatorStateInfo);
			self.BindInstanceFunction("GetFloat", GetFloat);
			self.BindInstanceFunction("GetHandle", GetHandle);
			self.BindInstanceFunction("GetInteger", GetInteger);
			self.BindInstanceFunction("GetLayerCount", GetLayerCount);
			self.BindInstanceFunction("GetLayerIndex", GetLayerIndex);
			self.BindInstanceFunction("GetLayerName", GetLayerName);
			self.BindInstanceFunction("GetLayerWeight", GetLayerWeight);
			self.BindInstanceFunction("GetNextAnimatorClipInfo", GetNextAnimatorClipInfo);
			self.BindInstanceFunction("GetNextAnimatorClipInfoCount", GetNextAnimatorClipInfoCount);
			self.BindInstanceFunction("GetNextAnimatorStateInfo", GetNextAnimatorStateInfo);
			self.BindInstanceFunction("GetParameter", GetParameter);
			self.BindInstanceFunction("GetParameterCount", GetParameterCount);
			self.BindInstanceFunction("HasState", HasState);
			self.BindInstanceFunction("IsInTransition", IsInTransition);
			self.BindInstanceFunction("IsParameterControlledByCurve", IsParameterControlledByCurve);
			self.BindInstanceFunction("Play", Play);
			self.BindInstanceFunction("PlayInFixedTime", PlayInFixedTime);
			self.BindInstanceFunction("ResetTrigger", ResetTrigger);
			self.BindInstanceFunction("SetBool", SetBool);
			self.BindInstanceFunction("SetFloat", SetFloat);
			self.BindInstanceFunction("SetHandle", SetHandle);
			self.BindInstanceFunction("SetInteger", SetInteger);
			self.BindInstanceFunction("SetLayerWeight", SetLayerWeight);
			self.BindInstanceFunction("SetTrigger", SetTrigger);
			self.BindStaticProperty("Null", get_Null, null);
		}

		static private UnityEngine.Animations.AnimatorControllerPlayable Create(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Playables.PlayableGraph, UnityEngine.RuntimeAnimatorController>())
			{
				return UnityEngine.Animations.AnimatorControllerPlayable.Create(parameters[0].ToObject<UnityEngine.Playables.PlayableGraph>(), parameters[1].ToObject<UnityEngine.RuntimeAnimatorController>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.Create has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.Create has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Animations.AnimatorControllerPlayable);
		}

		static private void CrossFade(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Single>())
			{
				instance.CrossFade(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Single>())
			{
				instance.CrossFade(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Single, System.Int32>())
			{
				instance.CrossFade(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Single, System.Int32>())
			{
				instance.CrossFade(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Single, System.Int32, System.Single>())
			{
				instance.CrossFade(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Single, System.Int32, System.Single>())
			{
				instance.CrossFade(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.CrossFade has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.CrossFade has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void CrossFadeInFixedTime(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Single>())
			{
				instance.CrossFadeInFixedTime(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Single>())
			{
				instance.CrossFadeInFixedTime(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Single, System.Int32>())
			{
				instance.CrossFadeInFixedTime(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Single, System.Int32>())
			{
				instance.CrossFadeInFixedTime(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Single, System.Int32, System.Single>())
			{
				instance.CrossFadeInFixedTime(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Single, System.Int32, System.Single>())
			{
				instance.CrossFadeInFixedTime(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.CrossFadeInFixedTime has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.CrossFadeInFixedTime has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean Equals(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Animations.AnimatorControllerPlayable>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Animations.AnimatorControllerPlayable>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfo(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetAnimatorTransitionInfo(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.GetAnimatorTransitionInfo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.GetAnimatorTransitionInfo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.AnimatorTransitionInfo);
		}

		static private System.Boolean GetBool(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetBool(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetBool(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.GetBool has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.GetBool has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetCurrentAnimatorClipInfo(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.GetCurrentAnimatorClipInfo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.GetCurrentAnimatorClipInfo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 GetCurrentAnimatorClipInfoCount(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetCurrentAnimatorClipInfoCount(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.GetCurrentAnimatorClipInfoCount has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.GetCurrentAnimatorClipInfoCount has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetCurrentAnimatorStateInfo(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.GetCurrentAnimatorStateInfo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.GetCurrentAnimatorStateInfo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.AnimatorStateInfo);
		}

		static private System.Single GetFloat(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetFloat(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetFloat(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.GetFloat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.GetFloat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private UnityEngine.Playables.PlayableHandle GetHandle(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.GetHandle has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Playables.PlayableHandle);
		}

		static private System.Int32 GetInteger(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetInteger(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetInteger(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.GetInteger has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.GetInteger has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Int32 GetLayerCount(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetLayerCount();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.GetLayerCount has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Int32 GetLayerIndex(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetLayerIndex(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.GetLayerIndex has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.GetLayerIndex has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.String GetLayerName(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetLayerName(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.GetLayerName has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.GetLayerName has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Single GetLayerWeight(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetLayerWeight(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.GetLayerWeight has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.GetLayerWeight has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetNextAnimatorClipInfo(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.GetNextAnimatorClipInfo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.GetNextAnimatorClipInfo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 GetNextAnimatorClipInfoCount(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetNextAnimatorClipInfoCount(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.GetNextAnimatorClipInfoCount has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.GetNextAnimatorClipInfoCount has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetNextAnimatorStateInfo(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.GetNextAnimatorStateInfo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.GetNextAnimatorStateInfo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.AnimatorStateInfo);
		}

		static private UnityEngine.AnimatorControllerParameter GetParameter(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetParameter(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.GetParameter has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.GetParameter has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 GetParameterCount(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetParameterCount();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.GetParameterCount has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Boolean HasState(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return instance.HasState(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.HasState has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.HasState has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean IsInTransition(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.IsInTransition(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.IsInTransition has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.IsInTransition has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean IsParameterControlledByCurve(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.IsParameterControlledByCurve(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.IsParameterControlledByCurve(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.IsParameterControlledByCurve has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.IsParameterControlledByCurve has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void Play(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.Play(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.Play(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Int32>())
			{
				instance.Play(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				instance.Play(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Int32, System.Single>())
			{
				instance.Play(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Single>())
			{
				instance.Play(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.Play has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.Play has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void PlayInFixedTime(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.PlayInFixedTime(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.PlayInFixedTime(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Int32>())
			{
				instance.PlayInFixedTime(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				instance.PlayInFixedTime(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Int32, System.Single>())
			{
				instance.PlayInFixedTime(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Single>())
			{
				instance.PlayInFixedTime(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.PlayInFixedTime has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.PlayInFixedTime has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void ResetTrigger(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.ResetTrigger(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.ResetTrigger(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.ResetTrigger has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.ResetTrigger has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetBool(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Boolean>())
			{
				instance.SetBool(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Boolean>())
			{
				instance.SetBool(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.SetBool has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.SetBool has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetFloat(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Single>())
			{
				instance.SetFloat(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Single>())
			{
				instance.SetFloat(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.SetFloat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.SetFloat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetHandle(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Playables.PlayableHandle>())
			{
				instance.SetHandle(parameters[0].ToObject<UnityEngine.Playables.PlayableHandle>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.SetHandle has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.SetHandle has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetInteger(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Int32>())
			{
				instance.SetInteger(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				instance.SetInteger(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.SetInteger has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.SetInteger has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetLayerWeight(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Single>())
			{
				instance.SetLayerWeight(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.SetLayerWeight has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.SetLayerWeight has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTrigger(UnityEngine.Animations.AnimatorControllerPlayable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.SetTrigger(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.SetTrigger(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animations.AnimatorControllerPlayable.SetTrigger has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animations.AnimatorControllerPlayable.SetTrigger has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Animations.AnimatorControllerPlayable get_Null()
		{
			return UnityEngine.Animations.AnimatorControllerPlayable.Null;
		}

	}
}
