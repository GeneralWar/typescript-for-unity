using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineProfilingCustomSampler
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Profiling.CustomSampler> self = space.DeclareClass<UnityEngine.Profiling.CustomSampler>();
			self.BindConstructor();
			self.BindStaticFunction("Create", Create);
			self.BindInstanceFunction("Begin", Begin);
			self.BindInstanceFunction("End", End);
		}

		static private UnityEngine.Profiling.CustomSampler Create(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Profiling.CustomSampler.Create(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Profiling.CustomSampler.Create has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.CustomSampler.Create has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void Begin(UnityEngine.Profiling.CustomSampler instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Begin();
			}
			if (parameters.CheckTypes<UnityEngine.Object>())
			{
				instance.Begin(parameters[0].ToObject<UnityEngine.Object>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.CustomSampler.Begin has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void End(UnityEngine.Profiling.CustomSampler instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.End();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Profiling.CustomSampler.End has no implemention with arguments ({0})!", string.Join(", ", types));
		}

	}
}
