using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationState
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AnimationState> self = space.DeclareClass<UnityEngine.AnimationState>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("AddMixingTransform", AddMixingTransform);
			self.BindInstanceFunction("RemoveMixingTransform", RemoveMixingTransform);
			self.BindInstanceProperty("enabled", get_enabled, set_enabled);
			self.BindInstanceProperty("weight", get_weight, set_weight);
			self.BindInstanceProperty("wrapMode", get_wrapMode, set_wrapMode);
			self.BindInstanceProperty("time", get_time, set_time);
			self.BindInstanceProperty("normalizedTime", get_normalizedTime, set_normalizedTime);
			self.BindInstanceProperty("speed", get_speed, set_speed);
			self.BindInstanceProperty("normalizedSpeed", get_normalizedSpeed, set_normalizedSpeed);
			self.BindInstanceProperty("length", get_length, null);
			self.BindInstanceProperty("layer", get_layer, set_layer);
			self.BindInstanceProperty("clip", get_clip, null);
			self.BindInstanceProperty("name", get_name, set_name);
			self.BindInstanceProperty("blendMode", get_blendMode, set_blendMode);
		}

		static private UnityEngine.AnimationState Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.AnimationState();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationState.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.AnimationState);
		}

		static private void AddMixingTransform(UnityEngine.AnimationState instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Transform>())
			{
				instance.AddMixingTransform(parameters[0].ToObject<UnityEngine.Transform>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Transform, System.Boolean>())
			{
				instance.AddMixingTransform(parameters[0].ToObject<UnityEngine.Transform>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimationState.AddMixingTransform has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationState.AddMixingTransform has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void RemoveMixingTransform(UnityEngine.AnimationState instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Transform>())
			{
				instance.RemoveMixingTransform(parameters[0].ToObject<UnityEngine.Transform>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimationState.RemoveMixingTransform has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationState.RemoveMixingTransform has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean get_enabled(UnityEngine.AnimationState instance, string name)
		{
			return instance.enabled;
		}

		static private void set_enabled(UnityEngine.AnimationState instance, string name, System.Boolean value)
		{
			instance.enabled = value;
		}

		static private System.Single get_weight(UnityEngine.AnimationState instance, string name)
		{
			return instance.weight;
		}

		static private void set_weight(UnityEngine.AnimationState instance, string name, System.Single value)
		{
			instance.weight = value;
		}

		static private UnityEngine.WrapMode get_wrapMode(UnityEngine.AnimationState instance, string name)
		{
			return instance.wrapMode;
		}

		static private void set_wrapMode(UnityEngine.AnimationState instance, string name, UnityEngine.WrapMode value)
		{
			instance.wrapMode = value;
		}

		static private System.Single get_time(UnityEngine.AnimationState instance, string name)
		{
			return instance.time;
		}

		static private void set_time(UnityEngine.AnimationState instance, string name, System.Single value)
		{
			instance.time = value;
		}

		static private System.Single get_normalizedTime(UnityEngine.AnimationState instance, string name)
		{
			return instance.normalizedTime;
		}

		static private void set_normalizedTime(UnityEngine.AnimationState instance, string name, System.Single value)
		{
			instance.normalizedTime = value;
		}

		static private System.Single get_speed(UnityEngine.AnimationState instance, string name)
		{
			return instance.speed;
		}

		static private void set_speed(UnityEngine.AnimationState instance, string name, System.Single value)
		{
			instance.speed = value;
		}

		static private System.Single get_normalizedSpeed(UnityEngine.AnimationState instance, string name)
		{
			return instance.normalizedSpeed;
		}

		static private void set_normalizedSpeed(UnityEngine.AnimationState instance, string name, System.Single value)
		{
			instance.normalizedSpeed = value;
		}

		static private System.Single get_length(UnityEngine.AnimationState instance, string name)
		{
			return instance.length;
		}

		static private System.Int32 get_layer(UnityEngine.AnimationState instance, string name)
		{
			return instance.layer;
		}

		static private void set_layer(UnityEngine.AnimationState instance, string name, System.Int32 value)
		{
			instance.layer = value;
		}

		static private UnityEngine.AnimationClip get_clip(UnityEngine.AnimationState instance, string name)
		{
			return instance.clip;
		}

		static private System.String get_name(UnityEngine.AnimationState instance, string name)
		{
			return instance.name;
		}

		static private void set_name(UnityEngine.AnimationState instance, string name, System.String value)
		{
			instance.name = value;
		}

		static private UnityEngine.AnimationBlendMode get_blendMode(UnityEngine.AnimationState instance, string name)
		{
			return instance.blendMode;
		}

		static private void set_blendMode(UnityEngine.AnimationState instance, string name, UnityEngine.AnimationBlendMode value)
		{
			instance.blendMode = value;
		}

	}
}
