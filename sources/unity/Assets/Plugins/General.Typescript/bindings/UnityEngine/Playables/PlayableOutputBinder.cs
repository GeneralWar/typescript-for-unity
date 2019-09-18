using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlayablesPlayableOutput
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Playables.PlayableOutput> self = space.DeclareClass<UnityEngine.Playables.PlayableOutput>();
			self.BindConstructor();
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHandle", GetHandle);
			self.BindInstanceFunction("GetPlayableOutputType", GetPlayableOutputType);
			self.BindStaticProperty("Null", get_Null, null);
		}

		static private System.Boolean Equals(UnityEngine.Playables.PlayableOutput instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Playables.PlayableOutput>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Playables.PlayableOutput>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Playables.PlayableOutput.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableOutput.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.Playables.PlayableOutputHandle GetHandle(UnityEngine.Playables.PlayableOutput instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableOutput.GetHandle has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Playables.PlayableOutputHandle);
		}

		static private System.Type GetPlayableOutputType(UnityEngine.Playables.PlayableOutput instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetPlayableOutputType();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableOutput.GetPlayableOutputType has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Playables.PlayableOutput get_Null()
		{
			return UnityEngine.Playables.PlayableOutput.Null;
		}

	}
}
