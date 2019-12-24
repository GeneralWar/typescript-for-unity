using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIVerticalLayoutGroup
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.VerticalLayoutGroup> self = space.DeclareClass<UnityEngine.UI.VerticalLayoutGroup, UnityEngine.UI.HorizontalOrVerticalLayoutGroup>();
			self.BindConstructor();
			self.BindInstanceFunction("CalculateLayoutInputHorizontal", CalculateLayoutInputHorizontal);
			self.BindInstanceFunction("CalculateLayoutInputVertical", CalculateLayoutInputVertical);
			self.BindInstanceFunction("SetLayoutHorizontal", SetLayoutHorizontal);
			self.BindInstanceFunction("SetLayoutVertical", SetLayoutVertical);
		}

		static private void CalculateLayoutInputHorizontal(UnityEngine.UI.VerticalLayoutGroup instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.VerticalLayoutGroup.CalculateLayoutInputHorizontal has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void CalculateLayoutInputVertical(UnityEngine.UI.VerticalLayoutGroup instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.VerticalLayoutGroup.CalculateLayoutInputVertical has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetLayoutHorizontal(UnityEngine.UI.VerticalLayoutGroup instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.VerticalLayoutGroup.SetLayoutHorizontal has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetLayoutVertical(UnityEngine.UI.VerticalLayoutGroup instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.VerticalLayoutGroup.SetLayoutVertical has no implemention with arguments ({0})!", string.Join(", ", types));
		}

	}
}
