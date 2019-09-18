using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLineUtility
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.LineUtility> self = space.DeclareClass<UnityEngine.LineUtility>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.LineUtility Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.LineUtility();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.LineUtility.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.LineUtility);
		}

	}
}
