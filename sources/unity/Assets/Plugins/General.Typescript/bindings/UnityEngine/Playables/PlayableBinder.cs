using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlayablesPlayable
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Playables.Playable> self = space.DeclareClass<UnityEngine.Playables.Playable>();
			self.BindConstructor();
			self.BindStaticFunction("Create", Create);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHandle", GetHandle);
			self.BindInstanceFunction("GetPlayableType", GetPlayableType);
			self.BindStaticProperty("Null", get_Null, null);
		}

		static private UnityEngine.Playables.Playable Create(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Playables.PlayableGraph, System.Int32>())
			{
				return UnityEngine.Playables.Playable.Create(parameters[0].ToObject<UnityEngine.Playables.PlayableGraph>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Playables.Playable.Create has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.Playable.Create has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Playables.Playable);
		}

		static private System.Boolean Equals(UnityEngine.Playables.Playable instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Playables.Playable>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Playables.Playable>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Playables.Playable.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.Playable.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.Playables.PlayableHandle GetHandle(UnityEngine.Playables.Playable instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.Playable.GetHandle has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Playables.PlayableHandle);
		}

		static private System.Type GetPlayableType(UnityEngine.Playables.Playable instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetPlayableType();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.Playable.GetPlayableType has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Playables.Playable get_Null()
		{
			return UnityEngine.Playables.Playable.Null;
		}

	}
}
