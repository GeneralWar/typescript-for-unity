using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWaitForSeconds
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.WaitForSeconds> self = space.DeclareClass<UnityEngine.WaitForSeconds>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.WaitForSeconds Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return new UnityEngine.WaitForSeconds(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WaitForSeconds.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WaitForSeconds.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.WaitForSeconds);
		}

	}
}
