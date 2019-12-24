using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIToggle
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.Toggle> self = space.DeclareClass<UnityEngine.UI.Toggle, UnityEngine.UI.Selectable>();
			UnityEngineUIToggleToggleTransition.Bind(self);
			self.BindConstructor();
			self.BindInstanceFunction("GraphicUpdateComplete", GraphicUpdateComplete);
			self.BindInstanceFunction("LayoutComplete", LayoutComplete);
			self.BindInstanceFunction("OnPointerClick", OnPointerClick);
			self.BindInstanceFunction("OnSubmit", OnSubmit);
			self.BindInstanceFunction("Rebuild", Rebuild);
			self.BindInstanceProperty("group", get_group, set_group);
			self.BindInstanceProperty("isOn", get_isOn, set_isOn);
		}

		static private void GraphicUpdateComplete(UnityEngine.UI.Toggle instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.GraphicUpdateComplete();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Toggle.GraphicUpdateComplete has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void LayoutComplete(UnityEngine.UI.Toggle instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.LayoutComplete();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Toggle.LayoutComplete has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void OnPointerClick(UnityEngine.UI.Toggle instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnPointerClick(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Toggle.OnPointerClick has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Toggle.OnPointerClick has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnSubmit(UnityEngine.UI.Toggle instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.BaseEventData>())
			{
				instance.OnSubmit(parameters[0].ToObject<UnityEngine.EventSystems.BaseEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Toggle.OnSubmit has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Toggle.OnSubmit has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Rebuild(UnityEngine.UI.Toggle instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.CanvasUpdate>())
			{
				instance.Rebuild(parameters[0].ToObject<UnityEngine.UI.CanvasUpdate>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Toggle.Rebuild has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Toggle.Rebuild has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.UI.ToggleGroup get_group(UnityEngine.UI.Toggle instance, string name)
		{
			return instance.group;
		}

		static private void set_group(UnityEngine.UI.Toggle instance, string name, UnityEngine.UI.ToggleGroup value)
		{
			instance.group = value;
		}

		static private System.Boolean get_isOn(UnityEngine.UI.Toggle instance, string name)
		{
			return instance.isOn;
		}

		static private void set_isOn(UnityEngine.UI.Toggle instance, string name, System.Boolean value)
		{
			instance.isOn = value;
		}

	}
}
