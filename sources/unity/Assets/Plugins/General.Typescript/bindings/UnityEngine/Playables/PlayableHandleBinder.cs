using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlayablesPlayableHandle
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Playables.PlayableHandle> self = space.DeclareClass<UnityEngine.Playables.PlayableHandle>();
			self.BindConstructor();
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindStaticProperty("Null", get_Null, null);
		}

		static private System.Boolean Equals(UnityEngine.Playables.PlayableHandle instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.Playables.PlayableHandle>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Playables.PlayableHandle>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Playables.PlayableHandle.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableHandle.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.Playables.PlayableHandle instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Playables.PlayableHandle.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private UnityEngine.Playables.PlayableHandle get_Null()
		{
			return UnityEngine.Playables.PlayableHandle.Null;
		}

	}
}
