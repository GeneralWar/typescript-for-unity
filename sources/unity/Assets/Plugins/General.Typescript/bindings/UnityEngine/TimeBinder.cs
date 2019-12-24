using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTime
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Time> self = space.DeclareClass<UnityEngine.Time>();
			self.BindConstructor(Constructor);
			self.BindStaticProperty("time", get_time, null);
			self.BindStaticProperty("realtimeSinceStartup", get_realtimeSinceStartup, null);
			self.BindStaticProperty("renderedFrameCount", get_renderedFrameCount, null);
			self.BindStaticProperty("frameCount", get_frameCount, null);
			self.BindStaticProperty("timeScale", get_timeScale, set_timeScale);
			self.BindStaticProperty("maximumParticleDeltaTime", get_maximumParticleDeltaTime, set_maximumParticleDeltaTime);
			self.BindStaticProperty("smoothDeltaTime", get_smoothDeltaTime, null);
			self.BindStaticProperty("maximumDeltaTime", get_maximumDeltaTime, set_maximumDeltaTime);
			self.BindStaticProperty("fixedDeltaTime", get_fixedDeltaTime, set_fixedDeltaTime);
			self.BindStaticProperty("fixedUnscaledDeltaTime", get_fixedUnscaledDeltaTime, null);
			self.BindStaticProperty("unscaledDeltaTime", get_unscaledDeltaTime, null);
			self.BindStaticProperty("fixedUnscaledTime", get_fixedUnscaledTime, null);
			self.BindStaticProperty("unscaledTime", get_unscaledTime, null);
			self.BindStaticProperty("fixedTime", get_fixedTime, null);
			self.BindStaticProperty("deltaTime", get_deltaTime, null);
			self.BindStaticProperty("timeSinceLevelLoad", get_timeSinceLevelLoad, null);
			self.BindStaticProperty("captureFramerate", get_captureFramerate, set_captureFramerate);
			self.BindStaticProperty("inFixedTimeStep", get_inFixedTimeStep, null);
		}

		static private UnityEngine.Time Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Time();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Time.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Time);
		}

		static private System.Single get_time(Type type, string name)
		{
			return UnityEngine.Time.time;
		}

		static private System.Single get_realtimeSinceStartup(Type type, string name)
		{
			return UnityEngine.Time.realtimeSinceStartup;
		}

		static private System.Int32 get_renderedFrameCount(Type type, string name)
		{
			return UnityEngine.Time.renderedFrameCount;
		}

		static private System.Int32 get_frameCount(Type type, string name)
		{
			return UnityEngine.Time.frameCount;
		}

		static private System.Single get_timeScale(Type type, string name)
		{
			return UnityEngine.Time.timeScale;
		}

		static private void set_timeScale(Type type, string name, System.Single value)
		{
			UnityEngine.Time.timeScale = value;
		}

		static private System.Single get_maximumParticleDeltaTime(Type type, string name)
		{
			return UnityEngine.Time.maximumParticleDeltaTime;
		}

		static private void set_maximumParticleDeltaTime(Type type, string name, System.Single value)
		{
			UnityEngine.Time.maximumParticleDeltaTime = value;
		}

		static private System.Single get_smoothDeltaTime(Type type, string name)
		{
			return UnityEngine.Time.smoothDeltaTime;
		}

		static private System.Single get_maximumDeltaTime(Type type, string name)
		{
			return UnityEngine.Time.maximumDeltaTime;
		}

		static private void set_maximumDeltaTime(Type type, string name, System.Single value)
		{
			UnityEngine.Time.maximumDeltaTime = value;
		}

		static private System.Single get_fixedDeltaTime(Type type, string name)
		{
			return UnityEngine.Time.fixedDeltaTime;
		}

		static private void set_fixedDeltaTime(Type type, string name, System.Single value)
		{
			UnityEngine.Time.fixedDeltaTime = value;
		}

		static private System.Single get_fixedUnscaledDeltaTime(Type type, string name)
		{
			return UnityEngine.Time.fixedUnscaledDeltaTime;
		}

		static private System.Single get_unscaledDeltaTime(Type type, string name)
		{
			return UnityEngine.Time.unscaledDeltaTime;
		}

		static private System.Single get_fixedUnscaledTime(Type type, string name)
		{
			return UnityEngine.Time.fixedUnscaledTime;
		}

		static private System.Single get_unscaledTime(Type type, string name)
		{
			return UnityEngine.Time.unscaledTime;
		}

		static private System.Single get_fixedTime(Type type, string name)
		{
			return UnityEngine.Time.fixedTime;
		}

		static private System.Single get_deltaTime(Type type, string name)
		{
			return UnityEngine.Time.deltaTime;
		}

		static private System.Single get_timeSinceLevelLoad(Type type, string name)
		{
			return UnityEngine.Time.timeSinceLevelLoad;
		}

		static private System.Int32 get_captureFramerate(Type type, string name)
		{
			return UnityEngine.Time.captureFramerate;
		}

		static private void set_captureFramerate(Type type, string name, System.Int32 value)
		{
			UnityEngine.Time.captureFramerate = value;
		}

		static private System.Boolean get_inFixedTimeStep(Type type, string name)
		{
			return UnityEngine.Time.inFixedTimeStep;
		}

	}
}
