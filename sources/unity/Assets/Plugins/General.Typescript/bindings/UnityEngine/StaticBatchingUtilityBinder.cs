using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineStaticBatchingUtility
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.StaticBatchingUtility> self = space.DeclareClass<UnityEngine.StaticBatchingUtility>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("Combine", Combine);
		}

		static private UnityEngine.StaticBatchingUtility Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.StaticBatchingUtility();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.StaticBatchingUtility.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.StaticBatchingUtility);
		}

		static private void Combine(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.GameObject>())
			{
				UnityEngine.StaticBatchingUtility.Combine(parameters[0].ToObject<UnityEngine.GameObject>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.GameObject[], UnityEngine.GameObject>())
			{
				UnityEngine.StaticBatchingUtility.Combine(parameters[0].ToObject<UnityEngine.GameObject[]>(), parameters[1].ToObject<UnityEngine.GameObject>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.StaticBatchingUtility.Combine has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.StaticBatchingUtility.Combine has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

	}
}
