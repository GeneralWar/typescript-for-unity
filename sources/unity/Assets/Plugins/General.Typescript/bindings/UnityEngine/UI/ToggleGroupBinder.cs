using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIToggleGroup
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.ToggleGroup> self = space.DeclareClass<UnityEngine.UI.ToggleGroup, UnityEngine.EventSystems.UIBehaviour>();
			self.BindConstructor();
			self.BindInstanceFunction("AnyTogglesOn", AnyTogglesOn);
			self.BindInstanceFunction("NotifyToggleOn", NotifyToggleOn);
			self.BindInstanceFunction("RegisterToggle", RegisterToggle);
			self.BindInstanceFunction("SetAllTogglesOff", SetAllTogglesOff);
			self.BindInstanceFunction("UnregisterToggle", UnregisterToggle);
			self.BindInstanceProperty("allowSwitchOff", get_allowSwitchOff, set_allowSwitchOff);
		}

		static private System.Boolean AnyTogglesOn(UnityEngine.UI.ToggleGroup instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.AnyTogglesOn();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ToggleGroup.AnyTogglesOn has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private void NotifyToggleOn(UnityEngine.UI.ToggleGroup instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.Toggle>())
			{
				instance.NotifyToggleOn(parameters[0].ToObject<UnityEngine.UI.Toggle>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.ToggleGroup.NotifyToggleOn has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ToggleGroup.NotifyToggleOn has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void RegisterToggle(UnityEngine.UI.ToggleGroup instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.Toggle>())
			{
				instance.RegisterToggle(parameters[0].ToObject<UnityEngine.UI.Toggle>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.ToggleGroup.RegisterToggle has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ToggleGroup.RegisterToggle has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetAllTogglesOff(UnityEngine.UI.ToggleGroup instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.SetAllTogglesOff();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ToggleGroup.SetAllTogglesOff has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void UnregisterToggle(UnityEngine.UI.ToggleGroup instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.Toggle>())
			{
				instance.UnregisterToggle(parameters[0].ToObject<UnityEngine.UI.Toggle>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.ToggleGroup.UnregisterToggle has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ToggleGroup.UnregisterToggle has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean get_allowSwitchOff(UnityEngine.UI.ToggleGroup instance)
		{
			return instance.allowSwitchOff;
		}

		static private void set_allowSwitchOff(UnityEngine.UI.ToggleGroup instance, System.Boolean value)
		{
			instance.allowSwitchOff = value;
		}

	}
}
