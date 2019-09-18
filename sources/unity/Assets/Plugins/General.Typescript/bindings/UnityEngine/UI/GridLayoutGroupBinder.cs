using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIGridLayoutGroup
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.GridLayoutGroup> self = space.DeclareClass<UnityEngine.UI.GridLayoutGroup, UnityEngine.UI.LayoutGroup>();
			UnityEngineUIGridLayoutGroupAxis.Bind(self);
			UnityEngineUIGridLayoutGroupConstraint.Bind(self);
			UnityEngineUIGridLayoutGroupCorner.Bind(self);
			self.BindConstructor();
			self.BindInstanceFunction("CalculateLayoutInputHorizontal", CalculateLayoutInputHorizontal);
			self.BindInstanceFunction("CalculateLayoutInputVertical", CalculateLayoutInputVertical);
			self.BindInstanceFunction("SetLayoutHorizontal", SetLayoutHorizontal);
			self.BindInstanceFunction("SetLayoutVertical", SetLayoutVertical);
			self.BindInstanceProperty("cellSize", get_cellSize, set_cellSize);
			self.BindInstanceProperty("spacing", get_spacing, set_spacing);
			self.BindInstanceProperty("constraintCount", get_constraintCount, set_constraintCount);
		}

		static private void CalculateLayoutInputHorizontal(UnityEngine.UI.GridLayoutGroup instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.CalculateLayoutInputHorizontal();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.GridLayoutGroup.CalculateLayoutInputHorizontal has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void CalculateLayoutInputVertical(UnityEngine.UI.GridLayoutGroup instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.CalculateLayoutInputVertical();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.GridLayoutGroup.CalculateLayoutInputVertical has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetLayoutHorizontal(UnityEngine.UI.GridLayoutGroup instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.SetLayoutHorizontal();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.GridLayoutGroup.SetLayoutHorizontal has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetLayoutVertical(UnityEngine.UI.GridLayoutGroup instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.SetLayoutVertical();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.GridLayoutGroup.SetLayoutVertical has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.Vector2 get_cellSize(UnityEngine.UI.GridLayoutGroup instance)
		{
			return instance.cellSize;
		}

		static private void set_cellSize(UnityEngine.UI.GridLayoutGroup instance, UnityEngine.Vector2 value)
		{
			instance.cellSize = value;
		}

		static private UnityEngine.Vector2 get_spacing(UnityEngine.UI.GridLayoutGroup instance)
		{
			return instance.spacing;
		}

		static private void set_spacing(UnityEngine.UI.GridLayoutGroup instance, UnityEngine.Vector2 value)
		{
			instance.spacing = value;
		}

		static private System.Int32 get_constraintCount(UnityEngine.UI.GridLayoutGroup instance)
		{
			return instance.constraintCount;
		}

		static private void set_constraintCount(UnityEngine.UI.GridLayoutGroup instance, System.Int32 value)
		{
			instance.constraintCount = value;
		}

	}
}
