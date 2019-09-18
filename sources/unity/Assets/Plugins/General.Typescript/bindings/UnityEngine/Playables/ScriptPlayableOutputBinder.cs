using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlayablesScriptPlayableOutput
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Playables.ScriptPlayableOutput> self = space.DeclareClass<UnityEngine.Playables.ScriptPlayableOutput>();
			self.BindConstructor();
			self.BindStaticFunction("Create", Create);
			self.BindInstanceFunction("GetHandle", GetHandle);
			self.BindStaticProperty("Null", get_Null, null);
		}

		static private UnityEngine.Playables.ScriptPlayableOutput Create(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Playables.PlayableGraph, System.String>())
			{
				return UnityEngine.Playables.ScriptPlayableOutput.Create(parameters[0].ToObject<UnityEngine.Playables.PlayableGraph>(), parameters[1].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Playables.ScriptPlayableOutput.Create has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.ScriptPlayableOutput.Create has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Playables.ScriptPlayableOutput);
		}

		static private UnityEngine.Playables.PlayableOutputHandle GetHandle(UnityEngine.Playables.ScriptPlayableOutput instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.ScriptPlayableOutput.GetHandle has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Playables.PlayableOutputHandle);
		}

		static private UnityEngine.Playables.ScriptPlayableOutput get_Null()
		{
			return UnityEngine.Playables.ScriptPlayableOutput.Null;
		}

	}
}
