using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIAspectRatioFitter
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.AspectRatioFitter> self = space.DeclareClass<UnityEngine.UI.AspectRatioFitter, UnityEngine.EventSystems.UIBehaviour>();
			UnityEngineUIAspectRatioFitterAspectMode.Bind(self);
			self.BindConstructor();
			self.BindInstanceFunction("SetLayoutHorizontal", SetLayoutHorizontal);
			self.BindInstanceFunction("SetLayoutVertical", SetLayoutVertical);
			self.BindInstanceProperty("aspectRatio", get_aspectRatio, set_aspectRatio);
		}

		static private void SetLayoutHorizontal(UnityEngine.UI.AspectRatioFitter instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.AspectRatioFitter.SetLayoutHorizontal has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetLayoutVertical(UnityEngine.UI.AspectRatioFitter instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.AspectRatioFitter.SetLayoutVertical has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Single get_aspectRatio(UnityEngine.UI.AspectRatioFitter instance, string name)
		{
			return instance.aspectRatio;
		}

		static private void set_aspectRatio(UnityEngine.UI.AspectRatioFitter instance, string name, System.Single value)
		{
			instance.aspectRatio = value;
		}

	}
}
