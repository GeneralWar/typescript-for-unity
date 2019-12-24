using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIButton
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.Button> self = space.DeclareClass<UnityEngine.UI.Button, UnityEngine.UI.Selectable>();
			self.BindConstructor();
			self.BindInstanceFunction("OnPointerClick", OnPointerClick);
			self.BindInstanceFunction("OnSubmit", OnSubmit);
		}

		static private void OnPointerClick(UnityEngine.UI.Button instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnPointerClick(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Button.OnPointerClick has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Button.OnPointerClick has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnSubmit(UnityEngine.UI.Button instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.BaseEventData>())
			{
				instance.OnSubmit(parameters[0].ToObject<UnityEngine.EventSystems.BaseEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Button.OnSubmit has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Button.OnSubmit has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

	}
}
