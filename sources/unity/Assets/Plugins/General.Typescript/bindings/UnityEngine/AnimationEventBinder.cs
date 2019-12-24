using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationEvent
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AnimationEvent> self = space.DeclareClass<UnityEngine.AnimationEvent>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("stringParameter", get_stringParameter, set_stringParameter);
			self.BindInstanceProperty("floatParameter", get_floatParameter, set_floatParameter);
			self.BindInstanceProperty("intParameter", get_intParameter, set_intParameter);
			self.BindInstanceProperty("objectReferenceParameter", get_objectReferenceParameter, set_objectReferenceParameter);
			self.BindInstanceProperty("functionName", get_functionName, set_functionName);
			self.BindInstanceProperty("time", get_time, set_time);
			self.BindInstanceProperty("messageOptions", get_messageOptions, set_messageOptions);
			self.BindInstanceProperty("isFiredByLegacy", get_isFiredByLegacy, null);
			self.BindInstanceProperty("isFiredByAnimator", get_isFiredByAnimator, null);
			self.BindInstanceProperty("animationState", get_animationState, null);
			self.BindInstanceProperty("animatorStateInfo", get_animatorStateInfo, null);
			self.BindInstanceProperty("animatorClipInfo", get_animatorClipInfo, null);
		}

		static private UnityEngine.AnimationEvent Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.AnimationEvent();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationEvent.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.AnimationEvent);
		}

		static private System.String get_stringParameter(UnityEngine.AnimationEvent instance, string name)
		{
			return instance.stringParameter;
		}

		static private void set_stringParameter(UnityEngine.AnimationEvent instance, string name, System.String value)
		{
			instance.stringParameter = value;
		}

		static private System.Single get_floatParameter(UnityEngine.AnimationEvent instance, string name)
		{
			return instance.floatParameter;
		}

		static private void set_floatParameter(UnityEngine.AnimationEvent instance, string name, System.Single value)
		{
			instance.floatParameter = value;
		}

		static private System.Int32 get_intParameter(UnityEngine.AnimationEvent instance, string name)
		{
			return instance.intParameter;
		}

		static private void set_intParameter(UnityEngine.AnimationEvent instance, string name, System.Int32 value)
		{
			instance.intParameter = value;
		}

		static private UnityEngine.Object get_objectReferenceParameter(UnityEngine.AnimationEvent instance, string name)
		{
			return instance.objectReferenceParameter;
		}

		static private void set_objectReferenceParameter(UnityEngine.AnimationEvent instance, string name, UnityEngine.Object value)
		{
			instance.objectReferenceParameter = value;
		}

		static private System.String get_functionName(UnityEngine.AnimationEvent instance, string name)
		{
			return instance.functionName;
		}

		static private void set_functionName(UnityEngine.AnimationEvent instance, string name, System.String value)
		{
			instance.functionName = value;
		}

		static private System.Single get_time(UnityEngine.AnimationEvent instance, string name)
		{
			return instance.time;
		}

		static private void set_time(UnityEngine.AnimationEvent instance, string name, System.Single value)
		{
			instance.time = value;
		}

		static private UnityEngine.SendMessageOptions get_messageOptions(UnityEngine.AnimationEvent instance, string name)
		{
			return instance.messageOptions;
		}

		static private void set_messageOptions(UnityEngine.AnimationEvent instance, string name, UnityEngine.SendMessageOptions value)
		{
			instance.messageOptions = value;
		}

		static private System.Boolean get_isFiredByLegacy(UnityEngine.AnimationEvent instance, string name)
		{
			return instance.isFiredByLegacy;
		}

		static private System.Boolean get_isFiredByAnimator(UnityEngine.AnimationEvent instance, string name)
		{
			return instance.isFiredByAnimator;
		}

		static private UnityEngine.AnimationState get_animationState(UnityEngine.AnimationEvent instance, string name)
		{
			return instance.animationState;
		}

		static private UnityEngine.AnimatorStateInfo get_animatorStateInfo(UnityEngine.AnimationEvent instance, string name)
		{
			return instance.animatorStateInfo;
		}

		static private UnityEngine.AnimatorClipInfo get_animatorClipInfo(UnityEngine.AnimationEvent instance, string name)
		{
			return instance.animatorClipInfo;
		}

	}
}
