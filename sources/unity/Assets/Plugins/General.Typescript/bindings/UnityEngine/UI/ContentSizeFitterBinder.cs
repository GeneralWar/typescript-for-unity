using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIContentSizeFitter
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.ContentSizeFitter> self = space.DeclareClass<UnityEngine.UI.ContentSizeFitter, UnityEngine.EventSystems.UIBehaviour>();
			UnityEngineUIContentSizeFitterFitMode.Bind(self);
			self.BindConstructor();
			self.BindInstanceFunction("SetLayoutHorizontal", SetLayoutHorizontal);
			self.BindInstanceFunction("SetLayoutVertical", SetLayoutVertical);
		}

		static private void SetLayoutHorizontal(UnityEngine.UI.ContentSizeFitter instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ContentSizeFitter.SetLayoutHorizontal has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetLayoutVertical(UnityEngine.UI.ContentSizeFitter instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ContentSizeFitter.SetLayoutVertical has no implemention with arguments ({0})!", string.Join(", ", types));
		}

	}
}
