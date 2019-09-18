using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSkybox
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Skybox> self = space.DeclareClass<UnityEngine.Skybox, UnityEngine.Behaviour>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("material", get_material, set_material);
		}

		static private UnityEngine.Skybox Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Skybox();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Skybox.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Skybox);
		}

		static private UnityEngine.Material get_material(UnityEngine.Skybox instance)
		{
			return instance.material;
		}

		static private void set_material(UnityEngine.Skybox instance, UnityEngine.Material value)
		{
			instance.material = value;
		}

	}
}
