using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlayablesPlayableGraph
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Playables.PlayableGraph> self = space.DeclareClass<UnityEngine.Playables.PlayableGraph>();
			self.BindConstructor();
			self.BindStaticFunction("Create", Create);
			self.BindInstanceFunction("Destroy", Destroy);
			self.BindInstanceFunction("Evaluate", Evaluate);
			self.BindInstanceFunction("GetOutput", GetOutput);
			self.BindInstanceFunction("GetOutputCount", GetOutputCount);
			self.BindInstanceFunction("GetPlayableCount", GetPlayableCount);
			self.BindInstanceFunction("GetResolver", GetResolver);
			self.BindInstanceFunction("GetRootPlayable", GetRootPlayable);
			self.BindInstanceFunction("GetRootPlayableCount", GetRootPlayableCount);
			self.BindInstanceFunction("GetTimeUpdateMode", GetTimeUpdateMode);
			self.BindInstanceFunction("IsDone", IsDone);
			self.BindInstanceFunction("IsPlaying", IsPlaying);
			self.BindInstanceFunction("IsValid", IsValid);
			self.BindInstanceFunction("Play", Play);
			self.BindInstanceFunction("SetResolver", SetResolver);
			self.BindInstanceFunction("SetTimeUpdateMode", SetTimeUpdateMode);
			self.BindInstanceFunction("Stop", Stop);
		}

		static private UnityEngine.Playables.PlayableGraph Create(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.Playables.PlayableGraph.Create();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Playables.PlayableGraph.Create(parameters[0].ToObject<System.String>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableGraph.Create has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Playables.PlayableGraph);
		}

		static private void Destroy(UnityEngine.Playables.PlayableGraph instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Destroy();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableGraph.Destroy has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Evaluate(UnityEngine.Playables.PlayableGraph instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Evaluate();
			}
			if (parameters.CheckTypes<System.Single>())
			{
				instance.Evaluate(parameters[0].ToObject<System.Single>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableGraph.Evaluate has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.Playables.PlayableOutput GetOutput(UnityEngine.Playables.PlayableGraph instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetOutput(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Playables.PlayableGraph.GetOutput has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableGraph.GetOutput has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Playables.PlayableOutput);
		}

		static private System.Int32 GetOutputCount(UnityEngine.Playables.PlayableGraph instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetOutputCount();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableGraph.GetOutputCount has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Int32 GetPlayableCount(UnityEngine.Playables.PlayableGraph instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetPlayableCount();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableGraph.GetPlayableCount has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private UnityEngine.IExposedPropertyTable GetResolver(UnityEngine.Playables.PlayableGraph instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetResolver();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableGraph.GetResolver has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Playables.Playable GetRootPlayable(UnityEngine.Playables.PlayableGraph instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetRootPlayable(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Playables.PlayableGraph.GetRootPlayable has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableGraph.GetRootPlayable has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Playables.Playable);
		}

		static private System.Int32 GetRootPlayableCount(UnityEngine.Playables.PlayableGraph instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetRootPlayableCount();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableGraph.GetRootPlayableCount has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private UnityEngine.Playables.DirectorUpdateMode GetTimeUpdateMode(UnityEngine.Playables.PlayableGraph instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetTimeUpdateMode();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableGraph.GetTimeUpdateMode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Playables.DirectorUpdateMode);
		}

		static private System.Boolean IsDone(UnityEngine.Playables.PlayableGraph instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsDone();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableGraph.IsDone has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.Boolean IsPlaying(UnityEngine.Playables.PlayableGraph instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsPlaying();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableGraph.IsPlaying has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.Boolean IsValid(UnityEngine.Playables.PlayableGraph instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsValid();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableGraph.IsValid has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private void Play(UnityEngine.Playables.PlayableGraph instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Play();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableGraph.Play has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetResolver(UnityEngine.Playables.PlayableGraph instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.IExposedPropertyTable>())
			{
				instance.SetResolver(parameters[0].ToObject<UnityEngine.IExposedPropertyTable>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Playables.PlayableGraph.SetResolver has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableGraph.SetResolver has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTimeUpdateMode(UnityEngine.Playables.PlayableGraph instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Playables.DirectorUpdateMode>())
			{
				instance.SetTimeUpdateMode(parameters[0].ToObject<UnityEngine.Playables.DirectorUpdateMode>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Playables.PlayableGraph.SetTimeUpdateMode has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableGraph.SetTimeUpdateMode has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Stop(UnityEngine.Playables.PlayableGraph instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Stop();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableGraph.Stop has no implemention with arguments ({0})!", string.Join(", ", types));
		}

	}
}
