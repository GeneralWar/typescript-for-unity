using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlayablesPlayableOutputHandle
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Playables.PlayableOutputHandle> self = space.DeclareClass<UnityEngine.Playables.PlayableOutputHandle>();
			self.BindConstructor();
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindStaticProperty("Null", get_Null, null);
		}

		static private System.Boolean Equals(UnityEngine.Playables.PlayableOutputHandle instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.Playables.PlayableOutputHandle>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Playables.PlayableOutputHandle>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Playables.PlayableOutputHandle.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableOutputHandle.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.Playables.PlayableOutputHandle instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetHashCode();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableOutputHandle.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private UnityEngine.Playables.PlayableOutputHandle get_Null()
		{
			return UnityEngine.Playables.PlayableOutputHandle.Null;
		}

	}
}
