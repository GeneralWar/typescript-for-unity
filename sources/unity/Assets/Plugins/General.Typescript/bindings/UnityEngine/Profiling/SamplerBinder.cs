using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineProfilingSampler
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Profiling.Sampler> self = space.DeclareClass<UnityEngine.Profiling.Sampler>();
			self.BindConstructor();
			self.BindStaticFunction("Get", Get);
			self.BindInstanceFunction("GetRecorder", GetRecorder);
			self.BindInstanceProperty("isValid", get_isValid, null);
			self.BindInstanceProperty("name", get_name, null);
		}

		static private UnityEngine.Profiling.Sampler Get(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Profiling.Sampler.Get(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Profiling.Sampler.Get has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Sampler.Get has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.Profiling.Recorder GetRecorder(UnityEngine.Profiling.Sampler instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetRecorder();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.Sampler.GetRecorder has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Boolean get_isValid(UnityEngine.Profiling.Sampler instance)
		{
			return instance.isValid;
		}

		static private System.String get_name(UnityEngine.Profiling.Sampler instance)
		{
			return instance.name;
		}

	}
}
