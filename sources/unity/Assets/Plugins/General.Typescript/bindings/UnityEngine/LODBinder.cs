using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLOD
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.LOD> self = space.DeclareClass<UnityEngine.LOD>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.LOD Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, UnityEngine.Renderer[]>())
			{
				return new UnityEngine.LOD(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<UnityEngine.Renderer[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.LOD.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.LOD.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.LOD);
		}

	}
}
