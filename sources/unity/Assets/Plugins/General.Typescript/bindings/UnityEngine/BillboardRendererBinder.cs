using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineBillboardRenderer
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.BillboardRenderer> self = space.DeclareClass<UnityEngine.BillboardRenderer, UnityEngine.Renderer>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("billboard", get_billboard, set_billboard);
		}

		static private UnityEngine.BillboardRenderer Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.BillboardRenderer();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.BillboardRenderer.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.BillboardRenderer);
		}

		static private UnityEngine.BillboardAsset get_billboard(UnityEngine.BillboardRenderer instance)
		{
			return instance.billboard;
		}

		static private void set_billboard(UnityEngine.BillboardRenderer instance, UnityEngine.BillboardAsset value)
		{
			instance.billboard = value;
		}

	}
}
