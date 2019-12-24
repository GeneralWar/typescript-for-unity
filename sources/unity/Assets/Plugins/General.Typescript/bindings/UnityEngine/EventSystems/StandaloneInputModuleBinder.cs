using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineEventSystemsStandaloneInputModule
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.EventSystems.StandaloneInputModule> self = space.DeclareClass<UnityEngine.EventSystems.StandaloneInputModule, UnityEngine.EventSystems.PointerInputModule>();
			self.BindConstructor();
			self.BindInstanceFunction("ActivateModule", ActivateModule);
			self.BindInstanceFunction("DeactivateModule", DeactivateModule);
			self.BindInstanceFunction("IsModuleSupported", IsModuleSupported);
			self.BindInstanceFunction("Process", Process);
			self.BindInstanceFunction("ShouldActivateModule", ShouldActivateModule);
			self.BindInstanceFunction("UpdateModule", UpdateModule);
			self.BindInstanceProperty("forceModuleActive", get_forceModuleActive, set_forceModuleActive);
			self.BindInstanceProperty("inputActionsPerSecond", get_inputActionsPerSecond, set_inputActionsPerSecond);
			self.BindInstanceProperty("repeatDelay", get_repeatDelay, set_repeatDelay);
			self.BindInstanceProperty("horizontalAxis", get_horizontalAxis, set_horizontalAxis);
			self.BindInstanceProperty("verticalAxis", get_verticalAxis, set_verticalAxis);
			self.BindInstanceProperty("submitButton", get_submitButton, set_submitButton);
			self.BindInstanceProperty("cancelButton", get_cancelButton, set_cancelButton);
		}

		static private void ActivateModule(UnityEngine.EventSystems.StandaloneInputModule instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ActivateModule();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.StandaloneInputModule.ActivateModule has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void DeactivateModule(UnityEngine.EventSystems.StandaloneInputModule instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.DeactivateModule();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.StandaloneInputModule.DeactivateModule has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean IsModuleSupported(UnityEngine.EventSystems.StandaloneInputModule instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsModuleSupported();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.StandaloneInputModule.IsModuleSupported has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private void Process(UnityEngine.EventSystems.StandaloneInputModule instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Process();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.StandaloneInputModule.Process has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean ShouldActivateModule(UnityEngine.EventSystems.StandaloneInputModule instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ShouldActivateModule();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.StandaloneInputModule.ShouldActivateModule has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private void UpdateModule(UnityEngine.EventSystems.StandaloneInputModule instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.UpdateModule();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.StandaloneInputModule.UpdateModule has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean get_forceModuleActive(UnityEngine.EventSystems.StandaloneInputModule instance, string name)
		{
			return instance.forceModuleActive;
		}

		static private void set_forceModuleActive(UnityEngine.EventSystems.StandaloneInputModule instance, string name, System.Boolean value)
		{
			instance.forceModuleActive = value;
		}

		static private System.Single get_inputActionsPerSecond(UnityEngine.EventSystems.StandaloneInputModule instance, string name)
		{
			return instance.inputActionsPerSecond;
		}

		static private void set_inputActionsPerSecond(UnityEngine.EventSystems.StandaloneInputModule instance, string name, System.Single value)
		{
			instance.inputActionsPerSecond = value;
		}

		static private System.Single get_repeatDelay(UnityEngine.EventSystems.StandaloneInputModule instance, string name)
		{
			return instance.repeatDelay;
		}

		static private void set_repeatDelay(UnityEngine.EventSystems.StandaloneInputModule instance, string name, System.Single value)
		{
			instance.repeatDelay = value;
		}

		static private System.String get_horizontalAxis(UnityEngine.EventSystems.StandaloneInputModule instance, string name)
		{
			return instance.horizontalAxis;
		}

		static private void set_horizontalAxis(UnityEngine.EventSystems.StandaloneInputModule instance, string name, System.String value)
		{
			instance.horizontalAxis = value;
		}

		static private System.String get_verticalAxis(UnityEngine.EventSystems.StandaloneInputModule instance, string name)
		{
			return instance.verticalAxis;
		}

		static private void set_verticalAxis(UnityEngine.EventSystems.StandaloneInputModule instance, string name, System.String value)
		{
			instance.verticalAxis = value;
		}

		static private System.String get_submitButton(UnityEngine.EventSystems.StandaloneInputModule instance, string name)
		{
			return instance.submitButton;
		}

		static private void set_submitButton(UnityEngine.EventSystems.StandaloneInputModule instance, string name, System.String value)
		{
			instance.submitButton = value;
		}

		static private System.String get_cancelButton(UnityEngine.EventSystems.StandaloneInputModule instance, string name)
		{
			return instance.cancelButton;
		}

		static private void set_cancelButton(UnityEngine.EventSystems.StandaloneInputModule instance, string name, System.String value)
		{
			instance.cancelButton = value;
		}

	}
}
