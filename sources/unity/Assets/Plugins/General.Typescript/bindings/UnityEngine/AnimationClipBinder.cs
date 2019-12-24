using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationClip
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AnimationClip> self = space.DeclareClass<UnityEngine.AnimationClip, UnityEngine.Motion>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("AddEvent", AddEvent);
			self.BindInstanceFunction("ClearCurves", ClearCurves);
			self.BindInstanceFunction("EnsureQuaternionContinuity", EnsureQuaternionContinuity);
			self.BindInstanceFunction("SampleAnimation", SampleAnimation);
			self.BindInstanceFunction("SetCurve", SetCurve);
			self.BindInstanceProperty("events", get_events, set_events);
			self.BindInstanceProperty("length", get_length, null);
			self.BindInstanceProperty("frameRate", get_frameRate, set_frameRate);
			self.BindInstanceProperty("wrapMode", get_wrapMode, set_wrapMode);
			self.BindInstanceProperty("localBounds", get_localBounds, set_localBounds);
			self.BindInstanceProperty("legacy", get_legacy, set_legacy);
			self.BindInstanceProperty("humanMotion", get_humanMotion, null);
			self.BindInstanceProperty("empty", get_empty, null);
			self.BindInstanceProperty("hasGenericRootTransform", get_hasGenericRootTransform, null);
			self.BindInstanceProperty("hasMotionFloatCurves", get_hasMotionFloatCurves, null);
			self.BindInstanceProperty("hasMotionCurves", get_hasMotionCurves, null);
			self.BindInstanceProperty("hasRootCurves", get_hasRootCurves, null);
		}

		static private UnityEngine.AnimationClip Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.AnimationClip();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationClip.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.AnimationClip);
		}

		static private void AddEvent(UnityEngine.AnimationClip instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.AnimationEvent>())
			{
				instance.AddEvent(parameters[0].ToObject<UnityEngine.AnimationEvent>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimationClip.AddEvent has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationClip.AddEvent has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void ClearCurves(UnityEngine.AnimationClip instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ClearCurves();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationClip.ClearCurves has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void EnsureQuaternionContinuity(UnityEngine.AnimationClip instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.EnsureQuaternionContinuity();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationClip.EnsureQuaternionContinuity has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SampleAnimation(UnityEngine.AnimationClip instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.GameObject, System.Single>())
			{
				instance.SampleAnimation(parameters[0].ToObject<UnityEngine.GameObject>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimationClip.SampleAnimation has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationClip.SampleAnimation has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetCurve(UnityEngine.AnimationClip instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Type, System.String, UnityEngine.AnimationCurve>())
			{
				instance.SetCurve(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Type>(), parameters[2].ToObject<System.String>(), parameters[3].ToObject<UnityEngine.AnimationCurve>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimationClip.SetCurve has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationClip.SetCurve has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.AnimationEvent[] get_events(UnityEngine.AnimationClip instance, string name)
		{
			return instance.events;
		}

		static private void set_events(UnityEngine.AnimationClip instance, string name, UnityEngine.AnimationEvent[] value)
		{
			instance.events = value;
		}

		static private System.Single get_length(UnityEngine.AnimationClip instance, string name)
		{
			return instance.length;
		}

		static private System.Single get_frameRate(UnityEngine.AnimationClip instance, string name)
		{
			return instance.frameRate;
		}

		static private void set_frameRate(UnityEngine.AnimationClip instance, string name, System.Single value)
		{
			instance.frameRate = value;
		}

		static private UnityEngine.WrapMode get_wrapMode(UnityEngine.AnimationClip instance, string name)
		{
			return instance.wrapMode;
		}

		static private void set_wrapMode(UnityEngine.AnimationClip instance, string name, UnityEngine.WrapMode value)
		{
			instance.wrapMode = value;
		}

		static private UnityEngine.Bounds get_localBounds(UnityEngine.AnimationClip instance, string name)
		{
			return instance.localBounds;
		}

		static private void set_localBounds(UnityEngine.AnimationClip instance, string name, UnityEngine.Bounds value)
		{
			instance.localBounds = value;
		}

		static private System.Boolean get_legacy(UnityEngine.AnimationClip instance, string name)
		{
			return instance.legacy;
		}

		static private void set_legacy(UnityEngine.AnimationClip instance, string name, System.Boolean value)
		{
			instance.legacy = value;
		}

		static private System.Boolean get_humanMotion(UnityEngine.AnimationClip instance, string name)
		{
			return instance.humanMotion;
		}

		static private System.Boolean get_empty(UnityEngine.AnimationClip instance, string name)
		{
			return instance.empty;
		}

		static private System.Boolean get_hasGenericRootTransform(UnityEngine.AnimationClip instance, string name)
		{
			return instance.hasGenericRootTransform;
		}

		static private System.Boolean get_hasMotionFloatCurves(UnityEngine.AnimationClip instance, string name)
		{
			return instance.hasMotionFloatCurves;
		}

		static private System.Boolean get_hasMotionCurves(UnityEngine.AnimationClip instance, string name)
		{
			return instance.hasMotionCurves;
		}

		static private System.Boolean get_hasRootCurves(UnityEngine.AnimationClip instance, string name)
		{
			return instance.hasRootCurves;
		}

	}
}
