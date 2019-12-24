using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIHorizontalLayoutGroup
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.HorizontalLayoutGroup> self = space.DeclareClass<UnityEngine.UI.HorizontalLayoutGroup, UnityEngine.UI.HorizontalOrVerticalLayoutGroup>();
			self.BindConstructor();
			self.BindInstanceFunction("CalculateLayoutInputHorizontal", CalculateLayoutInputHorizontal);
			self.BindInstanceFunction("CalculateLayoutInputVertical", CalculateLayoutInputVertical);
			self.BindInstanceFunction("SetLayoutHorizontal", SetLayoutHorizontal);
			self.BindInstanceFunction("SetLayoutVertical", SetLayoutVertical);
		}

		static private void CalculateLayoutInputHorizontal(UnityEngine.UI.HorizontalLayoutGroup instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.HorizontalLayoutGroup.CalculateLayoutInputHorizontal has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void CalculateLayoutInputVertical(UnityEngine.UI.HorizontalLayoutGroup instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.HorizontalLayoutGroup.CalculateLayoutInputVertical has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetLayoutHorizontal(UnityEngine.UI.HorizontalLayoutGroup instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.HorizontalLayoutGroup.SetLayoutHorizontal has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetLayoutVertical(UnityEngine.UI.HorizontalLayoutGroup instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.HorizontalLayoutGroup.SetLayoutVertical has no implemention with arguments ({0})!", string.Join(", ", types));
		}

	}
}
