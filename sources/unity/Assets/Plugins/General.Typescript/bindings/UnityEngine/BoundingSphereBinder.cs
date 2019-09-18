using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineBoundingSphere
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.BoundingSphere> self = space.DeclareClass<UnityEngine.BoundingSphere>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.BoundingSphere Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4>())
			{
				return new UnityEngine.BoundingSphere(parameters[0].ToObject<UnityEngine.Vector4>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single>())
			{
				return new UnityEngine.BoundingSphere(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.BoundingSphere.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.BoundingSphere.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.BoundingSphere);
		}

	}
}
