using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineOcclusionArea
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.OcclusionArea> self = space.DeclareClass<UnityEngine.OcclusionArea, UnityEngine.Component>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("center", get_center, set_center);
			self.BindInstanceProperty("size", get_size, set_size);
		}

		static private UnityEngine.OcclusionArea Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.OcclusionArea();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.OcclusionArea.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.OcclusionArea);
		}

		static private UnityEngine.Vector3 get_center(UnityEngine.OcclusionArea instance)
		{
			return instance.center;
		}

		static private void set_center(UnityEngine.OcclusionArea instance, UnityEngine.Vector3 value)
		{
			instance.center = value;
		}

		static private UnityEngine.Vector3 get_size(UnityEngine.OcclusionArea instance)
		{
			return instance.size;
		}

		static private void set_size(UnityEngine.OcclusionArea instance, UnityEngine.Vector3 value)
		{
			instance.size = value;
		}

	}
}
