using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineProfilingRecorder
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Profiling.Recorder> self = space.DeclareClass<UnityEngine.Profiling.Recorder>();
			self.BindConstructor();
			self.BindStaticFunction("Get", Get);
			self.BindInstanceFunction("CollectFromAllThreads", CollectFromAllThreads);
			self.BindInstanceFunction("FilterToCurrentThread", FilterToCurrentThread);
			self.BindInstanceProperty("isValid", get_isValid, null);
			self.BindInstanceProperty("enabled", get_enabled, set_enabled);
			self.BindInstanceProperty("elapsedNanoseconds", get_elapsedNanoseconds, null);
			self.BindInstanceProperty("sampleBlockCount", get_sampleBlockCount, null);
		}

		static private UnityEngine.Profiling.Recorder Get(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Profiling.Recorder.Get(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Profiling.Recorder.Get has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Recorder.Get has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void CollectFromAllThreads(UnityEngine.Profiling.Recorder instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.CollectFromAllThreads();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Recorder.CollectFromAllThreads has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void FilterToCurrentThread(UnityEngine.Profiling.Recorder instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.FilterToCurrentThread();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Recorder.FilterToCurrentThread has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean get_isValid(UnityEngine.Profiling.Recorder instance)
		{
			return instance.isValid;
		}

		static private System.Boolean get_enabled(UnityEngine.Profiling.Recorder instance)
		{
			return instance.enabled;
		}

		static private void set_enabled(UnityEngine.Profiling.Recorder instance, System.Boolean value)
		{
			instance.enabled = value;
		}

		static private System.Int64 get_elapsedNanoseconds(UnityEngine.Profiling.Recorder instance)
		{
			return instance.elapsedNanoseconds;
		}

		static private System.Int32 get_sampleBlockCount(UnityEngine.Profiling.Recorder instance)
		{
			return instance.sampleBlockCount;
		}

	}
}
