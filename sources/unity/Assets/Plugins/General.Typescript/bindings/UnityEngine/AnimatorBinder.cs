using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimator
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Animator> self = space.DeclareClass<UnityEngine.Animator, UnityEngine.Behaviour>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("StringToHash", StringToHash);
			self.BindInstanceFunction("ApplyBuiltinRootMotion", ApplyBuiltinRootMotion);
			self.BindInstanceFunction("CrossFade", CrossFade);
			self.BindInstanceFunction("CrossFadeInFixedTime", CrossFadeInFixedTime);
			self.BindInstanceFunction("GetAnimatorTransitionInfo", GetAnimatorTransitionInfo);
			self.BindInstanceFunction("GetBehaviours", GetBehaviours);
			self.BindInstanceFunction("GetBoneTransform", GetBoneTransform);
			self.BindInstanceFunction("GetBool", GetBool);
			self.BindInstanceFunction("GetCurrentAnimatorClipInfo", GetCurrentAnimatorClipInfo);
			self.BindInstanceFunction("GetCurrentAnimatorClipInfoCount", GetCurrentAnimatorClipInfoCount);
			self.BindInstanceFunction("GetCurrentAnimatorStateInfo", GetCurrentAnimatorStateInfo);
			self.BindInstanceFunction("GetFloat", GetFloat);
			self.BindInstanceFunction("GetIKHintPosition", GetIKHintPosition);
			self.BindInstanceFunction("GetIKHintPositionWeight", GetIKHintPositionWeight);
			self.BindInstanceFunction("GetIKPosition", GetIKPosition);
			self.BindInstanceFunction("GetIKPositionWeight", GetIKPositionWeight);
			self.BindInstanceFunction("GetIKRotation", GetIKRotation);
			self.BindInstanceFunction("GetIKRotationWeight", GetIKRotationWeight);
			self.BindInstanceFunction("GetInteger", GetInteger);
			self.BindInstanceFunction("GetLayerIndex", GetLayerIndex);
			self.BindInstanceFunction("GetLayerName", GetLayerName);
			self.BindInstanceFunction("GetLayerWeight", GetLayerWeight);
			self.BindInstanceFunction("GetNextAnimatorClipInfo", GetNextAnimatorClipInfo);
			self.BindInstanceFunction("GetNextAnimatorClipInfoCount", GetNextAnimatorClipInfoCount);
			self.BindInstanceFunction("GetNextAnimatorStateInfo", GetNextAnimatorStateInfo);
			self.BindInstanceFunction("GetParameter", GetParameter);
			self.BindInstanceFunction("HasState", HasState);
			self.BindInstanceFunction("InterruptMatchTarget", InterruptMatchTarget);
			self.BindInstanceFunction("IsInTransition", IsInTransition);
			self.BindInstanceFunction("IsParameterControlledByCurve", IsParameterControlledByCurve);
			self.BindInstanceFunction("MatchTarget", MatchTarget);
			self.BindInstanceFunction("Play", Play);
			self.BindInstanceFunction("PlayInFixedTime", PlayInFixedTime);
			self.BindInstanceFunction("Rebind", Rebind);
			self.BindInstanceFunction("ResetTrigger", ResetTrigger);
			self.BindInstanceFunction("SetBoneLocalRotation", SetBoneLocalRotation);
			self.BindInstanceFunction("SetBool", SetBool);
			self.BindInstanceFunction("SetFloat", SetFloat);
			self.BindInstanceFunction("SetIKHintPosition", SetIKHintPosition);
			self.BindInstanceFunction("SetIKHintPositionWeight", SetIKHintPositionWeight);
			self.BindInstanceFunction("SetIKPosition", SetIKPosition);
			self.BindInstanceFunction("SetIKPositionWeight", SetIKPositionWeight);
			self.BindInstanceFunction("SetIKRotation", SetIKRotation);
			self.BindInstanceFunction("SetIKRotationWeight", SetIKRotationWeight);
			self.BindInstanceFunction("SetInteger", SetInteger);
			self.BindInstanceFunction("SetLayerWeight", SetLayerWeight);
			self.BindInstanceFunction("SetLookAtPosition", SetLookAtPosition);
			self.BindInstanceFunction("SetLookAtWeight", SetLookAtWeight);
			self.BindInstanceFunction("SetTarget", SetTarget);
			self.BindInstanceFunction("SetTrigger", SetTrigger);
			self.BindInstanceFunction("StartPlayback", StartPlayback);
			self.BindInstanceFunction("StartRecording", StartRecording);
			self.BindInstanceFunction("StopPlayback", StopPlayback);
			self.BindInstanceFunction("StopRecording", StopRecording);
			self.BindInstanceFunction("Update", Update);
			self.BindInstanceFunction("WriteDefaultValues", WriteDefaultValues);
			self.BindInstanceProperty("isOptimizable", get_isOptimizable, null);
			self.BindInstanceProperty("pivotPosition", get_pivotPosition, null);
			self.BindInstanceProperty("isMatchingTarget", get_isMatchingTarget, null);
			self.BindInstanceProperty("speed", get_speed, set_speed);
			self.BindInstanceProperty("targetPosition", get_targetPosition, null);
			self.BindInstanceProperty("targetRotation", get_targetRotation, null);
			self.BindInstanceProperty("cullingMode", get_cullingMode, set_cullingMode);
			self.BindInstanceProperty("playbackTime", get_playbackTime, set_playbackTime);
			self.BindInstanceProperty("recorderStartTime", get_recorderStartTime, set_recorderStartTime);
			self.BindInstanceProperty("pivotWeight", get_pivotWeight, null);
			self.BindInstanceProperty("recorderStopTime", get_recorderStopTime, set_recorderStopTime);
			self.BindInstanceProperty("runtimeAnimatorController", get_runtimeAnimatorController, set_runtimeAnimatorController);
			self.BindInstanceProperty("hasBoundPlayables", get_hasBoundPlayables, null);
			self.BindInstanceProperty("avatar", get_avatar, set_avatar);
			self.BindInstanceProperty("playableGraph", get_playableGraph, null);
			self.BindInstanceProperty("layersAffectMassCenter", get_layersAffectMassCenter, set_layersAffectMassCenter);
			self.BindInstanceProperty("leftFeetBottomHeight", get_leftFeetBottomHeight, null);
			self.BindInstanceProperty("rightFeetBottomHeight", get_rightFeetBottomHeight, null);
			self.BindInstanceProperty("logWarnings", get_logWarnings, set_logWarnings);
			self.BindInstanceProperty("recorderMode", get_recorderMode, null);
			self.BindInstanceProperty("fireEvents", get_fireEvents, set_fireEvents);
			self.BindInstanceProperty("feetPivotActive", get_feetPivotActive, set_feetPivotActive);
			self.BindInstanceProperty("parameters", get_parameters, null);
			self.BindInstanceProperty("isHuman", get_isHuman, null);
			self.BindInstanceProperty("hasRootMotion", get_hasRootMotion, null);
			self.BindInstanceProperty("humanScale", get_humanScale, null);
			self.BindInstanceProperty("isInitialized", get_isInitialized, null);
			self.BindInstanceProperty("deltaPosition", get_deltaPosition, null);
			self.BindInstanceProperty("deltaRotation", get_deltaRotation, null);
			self.BindInstanceProperty("velocity", get_velocity, null);
			self.BindInstanceProperty("angularVelocity", get_angularVelocity, null);
			self.BindInstanceProperty("parameterCount", get_parameterCount, null);
			self.BindInstanceProperty("rootPosition", get_rootPosition, set_rootPosition);
			self.BindInstanceProperty("applyRootMotion", get_applyRootMotion, set_applyRootMotion);
			self.BindInstanceProperty("updateMode", get_updateMode, set_updateMode);
			self.BindInstanceProperty("hasTransformHierarchy", get_hasTransformHierarchy, null);
			self.BindInstanceProperty("gravityWeight", get_gravityWeight, null);
			self.BindInstanceProperty("bodyPosition", get_bodyPosition, set_bodyPosition);
			self.BindInstanceProperty("bodyRotation", get_bodyRotation, set_bodyRotation);
			self.BindInstanceProperty("stabilizeFeet", get_stabilizeFeet, set_stabilizeFeet);
			self.BindInstanceProperty("layerCount", get_layerCount, null);
			self.BindInstanceProperty("rootRotation", get_rootRotation, set_rootRotation);
			self.BindInstanceProperty("keepAnimatorControllerStateOnDisable", get_keepAnimatorControllerStateOnDisable, set_keepAnimatorControllerStateOnDisable);
		}

		static private UnityEngine.Animator Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Animator();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Animator);
		}

		static private System.Int32 StringToHash(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Animator.StringToHash(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.StringToHash has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.StringToHash has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void ApplyBuiltinRootMotion(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ApplyBuiltinRootMotion();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.ApplyBuiltinRootMotion has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void CrossFade(UnityEngine.Animator instance, string methodName, Parameters parameters)
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
			if (parameters.CheckTypes<System.String, System.Single, System.Int32, System.Single, System.Single>())
			{
				instance.CrossFade(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Single, System.Int32, System.Single, System.Single>())
			{
				instance.CrossFade(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.CrossFade has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.CrossFade has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void CrossFadeInFixedTime(UnityEngine.Animator instance, string methodName, Parameters parameters)
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
			if (parameters.CheckTypes<System.String, System.Single, System.Int32, System.Single, System.Single>())
			{
				instance.CrossFadeInFixedTime(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Single, System.Int32, System.Single, System.Single>())
			{
				instance.CrossFadeInFixedTime(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.CrossFadeInFixedTime has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.CrossFadeInFixedTime has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.AnimatorTransitionInfo GetAnimatorTransitionInfo(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetAnimatorTransitionInfo(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetAnimatorTransitionInfo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetAnimatorTransitionInfo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.AnimatorTransitionInfo);
		}

		static private System.Object GetBehaviours(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return instance.GetBehaviours(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetBehaviours has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetBehaviours has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.Transform GetBoneTransform(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.HumanBodyBones>())
			{
				return instance.GetBoneTransform(parameters[0].ToObject<UnityEngine.HumanBodyBones>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetBoneTransform has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetBoneTransform has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean GetBool(UnityEngine.Animator instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetBool has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetBool has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.AnimatorClipInfo[] GetCurrentAnimatorClipInfo(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetCurrentAnimatorClipInfo(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetCurrentAnimatorClipInfo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetCurrentAnimatorClipInfo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 GetCurrentAnimatorClipInfoCount(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetCurrentAnimatorClipInfoCount(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetCurrentAnimatorClipInfoCount has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetCurrentAnimatorClipInfoCount has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.AnimatorStateInfo GetCurrentAnimatorStateInfo(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetCurrentAnimatorStateInfo(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetCurrentAnimatorStateInfo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetCurrentAnimatorStateInfo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.AnimatorStateInfo);
		}

		static private System.Single GetFloat(UnityEngine.Animator instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetFloat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetFloat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private UnityEngine.Vector3 GetIKHintPosition(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AvatarIKHint>())
			{
				return instance.GetIKHintPosition(parameters[0].ToObject<UnityEngine.AvatarIKHint>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetIKHintPosition has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetIKHintPosition has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private System.Single GetIKHintPositionWeight(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AvatarIKHint>())
			{
				return instance.GetIKHintPositionWeight(parameters[0].ToObject<UnityEngine.AvatarIKHint>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetIKHintPositionWeight has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetIKHintPositionWeight has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private UnityEngine.Vector3 GetIKPosition(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AvatarIKGoal>())
			{
				return instance.GetIKPosition(parameters[0].ToObject<UnityEngine.AvatarIKGoal>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetIKPosition has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetIKPosition has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private System.Single GetIKPositionWeight(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AvatarIKGoal>())
			{
				return instance.GetIKPositionWeight(parameters[0].ToObject<UnityEngine.AvatarIKGoal>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetIKPositionWeight has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetIKPositionWeight has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private UnityEngine.Quaternion GetIKRotation(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AvatarIKGoal>())
			{
				return instance.GetIKRotation(parameters[0].ToObject<UnityEngine.AvatarIKGoal>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetIKRotation has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetIKRotation has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Quaternion);
		}

		static private System.Single GetIKRotationWeight(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AvatarIKGoal>())
			{
				return instance.GetIKRotationWeight(parameters[0].ToObject<UnityEngine.AvatarIKGoal>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetIKRotationWeight has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetIKRotationWeight has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Int32 GetInteger(UnityEngine.Animator instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetInteger has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetInteger has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Int32 GetLayerIndex(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetLayerIndex(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetLayerIndex has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetLayerIndex has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.String GetLayerName(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetLayerName(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetLayerName has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetLayerName has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Single GetLayerWeight(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetLayerWeight(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetLayerWeight has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetLayerWeight has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private UnityEngine.AnimatorClipInfo[] GetNextAnimatorClipInfo(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetNextAnimatorClipInfo(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetNextAnimatorClipInfo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetNextAnimatorClipInfo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 GetNextAnimatorClipInfoCount(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetNextAnimatorClipInfoCount(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetNextAnimatorClipInfoCount has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetNextAnimatorClipInfoCount has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.AnimatorStateInfo GetNextAnimatorStateInfo(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetNextAnimatorStateInfo(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetNextAnimatorStateInfo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetNextAnimatorStateInfo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.AnimatorStateInfo);
		}

		static private UnityEngine.AnimatorControllerParameter GetParameter(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetParameter(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.GetParameter has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.GetParameter has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean HasState(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return instance.HasState(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.HasState has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.HasState has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void InterruptMatchTarget(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.InterruptMatchTarget();
			}
			if (parameters.CheckTypes<System.Boolean>())
			{
				instance.InterruptMatchTarget(parameters[0].ToObject<System.Boolean>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.InterruptMatchTarget has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean IsInTransition(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.IsInTransition(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.IsInTransition has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.IsInTransition has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean IsParameterControlledByCurve(UnityEngine.Animator instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.Animator.IsParameterControlledByCurve has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.IsParameterControlledByCurve has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void MatchTarget(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.AvatarTarget, UnityEngine.MatchTargetWeightMask, System.Single>())
			{
				instance.MatchTarget(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Quaternion>(), parameters[2].ToObject<UnityEngine.AvatarTarget>(), parameters[3].ToObject<UnityEngine.MatchTargetWeightMask>(), parameters[4].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.AvatarTarget, UnityEngine.MatchTargetWeightMask, System.Single, System.Single>())
			{
				instance.MatchTarget(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Quaternion>(), parameters[2].ToObject<UnityEngine.AvatarTarget>(), parameters[3].ToObject<UnityEngine.MatchTargetWeightMask>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.MatchTarget has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.MatchTarget has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Play(UnityEngine.Animator instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.Animator.Play has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.Play has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void PlayInFixedTime(UnityEngine.Animator instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.Animator.PlayInFixedTime has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.PlayInFixedTime has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Rebind(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Rebind();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.Rebind has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ResetTrigger(UnityEngine.Animator instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.Animator.ResetTrigger has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.ResetTrigger has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetBoneLocalRotation(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.HumanBodyBones, UnityEngine.Quaternion>())
			{
				instance.SetBoneLocalRotation(parameters[0].ToObject<UnityEngine.HumanBodyBones>(), parameters[1].ToObject<UnityEngine.Quaternion>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.SetBoneLocalRotation has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.SetBoneLocalRotation has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetBool(UnityEngine.Animator instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.Animator.SetBool has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.SetBool has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetFloat(UnityEngine.Animator instance, string methodName, Parameters parameters)
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
			if (parameters.CheckTypes<System.String, System.Single, System.Single, System.Single>())
			{
				instance.SetFloat(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Single, System.Single, System.Single>())
			{
				instance.SetFloat(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.SetFloat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.SetFloat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetIKHintPosition(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AvatarIKHint, UnityEngine.Vector3>())
			{
				instance.SetIKHintPosition(parameters[0].ToObject<UnityEngine.AvatarIKHint>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.SetIKHintPosition has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.SetIKHintPosition has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetIKHintPositionWeight(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AvatarIKHint, System.Single>())
			{
				instance.SetIKHintPositionWeight(parameters[0].ToObject<UnityEngine.AvatarIKHint>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.SetIKHintPositionWeight has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.SetIKHintPositionWeight has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetIKPosition(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AvatarIKGoal, UnityEngine.Vector3>())
			{
				instance.SetIKPosition(parameters[0].ToObject<UnityEngine.AvatarIKGoal>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.SetIKPosition has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.SetIKPosition has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetIKPositionWeight(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AvatarIKGoal, System.Single>())
			{
				instance.SetIKPositionWeight(parameters[0].ToObject<UnityEngine.AvatarIKGoal>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.SetIKPositionWeight has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.SetIKPositionWeight has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetIKRotation(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AvatarIKGoal, UnityEngine.Quaternion>())
			{
				instance.SetIKRotation(parameters[0].ToObject<UnityEngine.AvatarIKGoal>(), parameters[1].ToObject<UnityEngine.Quaternion>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.SetIKRotation has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.SetIKRotation has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetIKRotationWeight(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AvatarIKGoal, System.Single>())
			{
				instance.SetIKRotationWeight(parameters[0].ToObject<UnityEngine.AvatarIKGoal>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.SetIKRotationWeight has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.SetIKRotationWeight has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetInteger(UnityEngine.Animator instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.Animator.SetInteger has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.SetInteger has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetLayerWeight(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Single>())
			{
				instance.SetLayerWeight(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.SetLayerWeight has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.SetLayerWeight has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetLookAtPosition(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				instance.SetLookAtPosition(parameters[0].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.SetLookAtPosition has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.SetLookAtPosition has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetLookAtWeight(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				instance.SetLookAtWeight(parameters[0].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				instance.SetLookAtWeight(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				instance.SetLookAtWeight(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single>())
			{
				instance.SetLookAtWeight(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single, System.Single>())
			{
				instance.SetLookAtWeight(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.SetLookAtWeight has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.SetLookAtWeight has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTarget(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AvatarTarget, System.Single>())
			{
				instance.SetTarget(parameters[0].ToObject<UnityEngine.AvatarTarget>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.SetTarget has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.SetTarget has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTrigger(UnityEngine.Animator instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.Animator.SetTrigger has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.SetTrigger has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void StartPlayback(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.StartPlayback();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.StartPlayback has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void StartRecording(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.StartRecording(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.StartRecording has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.StartRecording has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void StopPlayback(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.StopPlayback();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.StopPlayback has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void StopRecording(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.StopRecording();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.StopRecording has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Update(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				instance.Update(parameters[0].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Animator.Update has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.Update has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void WriteDefaultValues(UnityEngine.Animator instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.WriteDefaultValues();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Animator.WriteDefaultValues has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean get_isOptimizable(UnityEngine.Animator instance, string name)
		{
			return instance.isOptimizable;
		}

		static private UnityEngine.Vector3 get_pivotPosition(UnityEngine.Animator instance, string name)
		{
			return instance.pivotPosition;
		}

		static private System.Boolean get_isMatchingTarget(UnityEngine.Animator instance, string name)
		{
			return instance.isMatchingTarget;
		}

		static private System.Single get_speed(UnityEngine.Animator instance, string name)
		{
			return instance.speed;
		}

		static private void set_speed(UnityEngine.Animator instance, string name, System.Single value)
		{
			instance.speed = value;
		}

		static private UnityEngine.Vector3 get_targetPosition(UnityEngine.Animator instance, string name)
		{
			return instance.targetPosition;
		}

		static private UnityEngine.Quaternion get_targetRotation(UnityEngine.Animator instance, string name)
		{
			return instance.targetRotation;
		}

		static private UnityEngine.AnimatorCullingMode get_cullingMode(UnityEngine.Animator instance, string name)
		{
			return instance.cullingMode;
		}

		static private void set_cullingMode(UnityEngine.Animator instance, string name, UnityEngine.AnimatorCullingMode value)
		{
			instance.cullingMode = value;
		}

		static private System.Single get_playbackTime(UnityEngine.Animator instance, string name)
		{
			return instance.playbackTime;
		}

		static private void set_playbackTime(UnityEngine.Animator instance, string name, System.Single value)
		{
			instance.playbackTime = value;
		}

		static private System.Single get_recorderStartTime(UnityEngine.Animator instance, string name)
		{
			return instance.recorderStartTime;
		}

		static private void set_recorderStartTime(UnityEngine.Animator instance, string name, System.Single value)
		{
			instance.recorderStartTime = value;
		}

		static private System.Single get_pivotWeight(UnityEngine.Animator instance, string name)
		{
			return instance.pivotWeight;
		}

		static private System.Single get_recorderStopTime(UnityEngine.Animator instance, string name)
		{
			return instance.recorderStopTime;
		}

		static private void set_recorderStopTime(UnityEngine.Animator instance, string name, System.Single value)
		{
			instance.recorderStopTime = value;
		}

		static private UnityEngine.RuntimeAnimatorController get_runtimeAnimatorController(UnityEngine.Animator instance, string name)
		{
			return instance.runtimeAnimatorController;
		}

		static private void set_runtimeAnimatorController(UnityEngine.Animator instance, string name, UnityEngine.RuntimeAnimatorController value)
		{
			instance.runtimeAnimatorController = value;
		}

		static private System.Boolean get_hasBoundPlayables(UnityEngine.Animator instance, string name)
		{
			return instance.hasBoundPlayables;
		}

		static private UnityEngine.Avatar get_avatar(UnityEngine.Animator instance, string name)
		{
			return instance.avatar;
		}

		static private void set_avatar(UnityEngine.Animator instance, string name, UnityEngine.Avatar value)
		{
			instance.avatar = value;
		}

		static private UnityEngine.Playables.PlayableGraph get_playableGraph(UnityEngine.Animator instance, string name)
		{
			return instance.playableGraph;
		}

		static private System.Boolean get_layersAffectMassCenter(UnityEngine.Animator instance, string name)
		{
			return instance.layersAffectMassCenter;
		}

		static private void set_layersAffectMassCenter(UnityEngine.Animator instance, string name, System.Boolean value)
		{
			instance.layersAffectMassCenter = value;
		}

		static private System.Single get_leftFeetBottomHeight(UnityEngine.Animator instance, string name)
		{
			return instance.leftFeetBottomHeight;
		}

		static private System.Single get_rightFeetBottomHeight(UnityEngine.Animator instance, string name)
		{
			return instance.rightFeetBottomHeight;
		}

		static private System.Boolean get_logWarnings(UnityEngine.Animator instance, string name)
		{
			return instance.logWarnings;
		}

		static private void set_logWarnings(UnityEngine.Animator instance, string name, System.Boolean value)
		{
			instance.logWarnings = value;
		}

		static private UnityEngine.AnimatorRecorderMode get_recorderMode(UnityEngine.Animator instance, string name)
		{
			return instance.recorderMode;
		}

		static private System.Boolean get_fireEvents(UnityEngine.Animator instance, string name)
		{
			return instance.fireEvents;
		}

		static private void set_fireEvents(UnityEngine.Animator instance, string name, System.Boolean value)
		{
			instance.fireEvents = value;
		}

		static private System.Single get_feetPivotActive(UnityEngine.Animator instance, string name)
		{
			return instance.feetPivotActive;
		}

		static private void set_feetPivotActive(UnityEngine.Animator instance, string name, System.Single value)
		{
			instance.feetPivotActive = value;
		}

		static private UnityEngine.AnimatorControllerParameter[] get_parameters(UnityEngine.Animator instance, string name)
		{
			return instance.parameters;
		}

		static private System.Boolean get_isHuman(UnityEngine.Animator instance, string name)
		{
			return instance.isHuman;
		}

		static private System.Boolean get_hasRootMotion(UnityEngine.Animator instance, string name)
		{
			return instance.hasRootMotion;
		}

		static private System.Single get_humanScale(UnityEngine.Animator instance, string name)
		{
			return instance.humanScale;
		}

		static private System.Boolean get_isInitialized(UnityEngine.Animator instance, string name)
		{
			return instance.isInitialized;
		}

		static private UnityEngine.Vector3 get_deltaPosition(UnityEngine.Animator instance, string name)
		{
			return instance.deltaPosition;
		}

		static private UnityEngine.Quaternion get_deltaRotation(UnityEngine.Animator instance, string name)
		{
			return instance.deltaRotation;
		}

		static private UnityEngine.Vector3 get_velocity(UnityEngine.Animator instance, string name)
		{
			return instance.velocity;
		}

		static private UnityEngine.Vector3 get_angularVelocity(UnityEngine.Animator instance, string name)
		{
			return instance.angularVelocity;
		}

		static private System.Int32 get_parameterCount(UnityEngine.Animator instance, string name)
		{
			return instance.parameterCount;
		}

		static private UnityEngine.Vector3 get_rootPosition(UnityEngine.Animator instance, string name)
		{
			return instance.rootPosition;
		}

		static private void set_rootPosition(UnityEngine.Animator instance, string name, UnityEngine.Vector3 value)
		{
			instance.rootPosition = value;
		}

		static private System.Boolean get_applyRootMotion(UnityEngine.Animator instance, string name)
		{
			return instance.applyRootMotion;
		}

		static private void set_applyRootMotion(UnityEngine.Animator instance, string name, System.Boolean value)
		{
			instance.applyRootMotion = value;
		}

		static private UnityEngine.AnimatorUpdateMode get_updateMode(UnityEngine.Animator instance, string name)
		{
			return instance.updateMode;
		}

		static private void set_updateMode(UnityEngine.Animator instance, string name, UnityEngine.AnimatorUpdateMode value)
		{
			instance.updateMode = value;
		}

		static private System.Boolean get_hasTransformHierarchy(UnityEngine.Animator instance, string name)
		{
			return instance.hasTransformHierarchy;
		}

		static private System.Single get_gravityWeight(UnityEngine.Animator instance, string name)
		{
			return instance.gravityWeight;
		}

		static private UnityEngine.Vector3 get_bodyPosition(UnityEngine.Animator instance, string name)
		{
			return instance.bodyPosition;
		}

		static private void set_bodyPosition(UnityEngine.Animator instance, string name, UnityEngine.Vector3 value)
		{
			instance.bodyPosition = value;
		}

		static private UnityEngine.Quaternion get_bodyRotation(UnityEngine.Animator instance, string name)
		{
			return instance.bodyRotation;
		}

		static private void set_bodyRotation(UnityEngine.Animator instance, string name, UnityEngine.Quaternion value)
		{
			instance.bodyRotation = value;
		}

		static private System.Boolean get_stabilizeFeet(UnityEngine.Animator instance, string name)
		{
			return instance.stabilizeFeet;
		}

		static private void set_stabilizeFeet(UnityEngine.Animator instance, string name, System.Boolean value)
		{
			instance.stabilizeFeet = value;
		}

		static private System.Int32 get_layerCount(UnityEngine.Animator instance, string name)
		{
			return instance.layerCount;
		}

		static private UnityEngine.Quaternion get_rootRotation(UnityEngine.Animator instance, string name)
		{
			return instance.rootRotation;
		}

		static private void set_rootRotation(UnityEngine.Animator instance, string name, UnityEngine.Quaternion value)
		{
			instance.rootRotation = value;
		}

		static private System.Boolean get_keepAnimatorControllerStateOnDisable(UnityEngine.Animator instance, string name)
		{
			return instance.keepAnimatorControllerStateOnDisable;
		}

		static private void set_keepAnimatorControllerStateOnDisable(UnityEngine.Animator instance, string name, System.Boolean value)
		{
			instance.keepAnimatorControllerStateOnDisable = value;
		}

	}
}
