using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingSortingGroup
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Rendering.SortingGroup> self = space.DeclareClass<UnityEngine.Rendering.SortingGroup, UnityEngine.Behaviour>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("sortingLayerName", get_sortingLayerName, set_sortingLayerName);
			self.BindInstanceProperty("sortingLayerID", get_sortingLayerID, set_sortingLayerID);
			self.BindInstanceProperty("sortingOrder", get_sortingOrder, set_sortingOrder);
		}

		static private UnityEngine.Rendering.SortingGroup Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Rendering.SortingGroup();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.SortingGroup.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Rendering.SortingGroup);
		}

		static private System.String get_sortingLayerName(UnityEngine.Rendering.SortingGroup instance)
		{
			return instance.sortingLayerName;
		}

		static private void set_sortingLayerName(UnityEngine.Rendering.SortingGroup instance, System.String value)
		{
			instance.sortingLayerName = value;
		}

		static private System.Int32 get_sortingLayerID(UnityEngine.Rendering.SortingGroup instance)
		{
			return instance.sortingLayerID;
		}

		static private void set_sortingLayerID(UnityEngine.Rendering.SortingGroup instance, System.Int32 value)
		{
			instance.sortingLayerID = value;
		}

		static private System.Int32 get_sortingOrder(UnityEngine.Rendering.SortingGroup instance)
		{
			return instance.sortingOrder;
		}

		static private void set_sortingOrder(UnityEngine.Rendering.SortingGroup instance, System.Int32 value)
		{
			instance.sortingOrder = value;
		}

	}
}
