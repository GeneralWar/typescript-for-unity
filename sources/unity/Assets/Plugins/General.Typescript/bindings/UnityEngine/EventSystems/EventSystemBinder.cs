using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineEventSystemsEventSystem
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.EventSystems.EventSystem> self = space.DeclareClass<UnityEngine.EventSystems.EventSystem, UnityEngine.EventSystems.UIBehaviour>();
			self.BindConstructor();
			self.BindInstanceFunction("IsPointerOverGameObject", IsPointerOverGameObject);
			self.BindInstanceFunction("SetSelectedGameObject", SetSelectedGameObject);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceFunction("UpdateModules", UpdateModules);
			self.BindStaticProperty("current", get_current, set_current);
			self.BindInstanceProperty("sendNavigationEvents", get_sendNavigationEvents, set_sendNavigationEvents);
			self.BindInstanceProperty("pixelDragThreshold", get_pixelDragThreshold, set_pixelDragThreshold);
			self.BindInstanceProperty("currentInputModule", get_currentInputModule, null);
			self.BindInstanceProperty("firstSelectedGameObject", get_firstSelectedGameObject, set_firstSelectedGameObject);
			self.BindInstanceProperty("currentSelectedGameObject", get_currentSelectedGameObject, null);
			self.BindInstanceProperty("isFocused", get_isFocused, null);
			self.BindInstanceProperty("alreadySelecting", get_alreadySelecting, null);
		}

		static private System.Boolean IsPointerOverGameObject(UnityEngine.EventSystems.EventSystem instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsPointerOverGameObject();
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.IsPointerOverGameObject(parameters[0].ToObject<System.Int32>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventSystem.IsPointerOverGameObject has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private void SetSelectedGameObject(UnityEngine.EventSystems.EventSystem instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.GameObject>())
			{
				instance.SetSelectedGameObject(parameters[0].ToObject<UnityEngine.GameObject>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.GameObject, UnityEngine.EventSystems.BaseEventData>())
			{
				instance.SetSelectedGameObject(parameters[0].ToObject<UnityEngine.GameObject>(), parameters[1].ToObject<UnityEngine.EventSystems.BaseEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventSystem.SetSelectedGameObject has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventSystem.SetSelectedGameObject has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.String ToString(UnityEngine.EventSystems.EventSystem instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventSystem.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void UpdateModules(UnityEngine.EventSystems.EventSystem instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.UpdateModules();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventSystem.UpdateModules has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.EventSystems.EventSystem get_current()
		{
			return UnityEngine.EventSystems.EventSystem.current;
		}

		static private void set_current(UnityEngine.EventSystems.EventSystem value)
		{
			UnityEngine.EventSystems.EventSystem.current = value;
		}

		static private System.Boolean get_sendNavigationEvents(UnityEngine.EventSystems.EventSystem instance)
		{
			return instance.sendNavigationEvents;
		}

		static private void set_sendNavigationEvents(UnityEngine.EventSystems.EventSystem instance, System.Boolean value)
		{
			instance.sendNavigationEvents = value;
		}

		static private System.Int32 get_pixelDragThreshold(UnityEngine.EventSystems.EventSystem instance)
		{
			return instance.pixelDragThreshold;
		}

		static private void set_pixelDragThreshold(UnityEngine.EventSystems.EventSystem instance, System.Int32 value)
		{
			instance.pixelDragThreshold = value;
		}

		static private UnityEngine.EventSystems.BaseInputModule get_currentInputModule(UnityEngine.EventSystems.EventSystem instance)
		{
			return instance.currentInputModule;
		}

		static private UnityEngine.GameObject get_firstSelectedGameObject(UnityEngine.EventSystems.EventSystem instance)
		{
			return instance.firstSelectedGameObject;
		}

		static private void set_firstSelectedGameObject(UnityEngine.EventSystems.EventSystem instance, UnityEngine.GameObject value)
		{
			instance.firstSelectedGameObject = value;
		}

		static private UnityEngine.GameObject get_currentSelectedGameObject(UnityEngine.EventSystems.EventSystem instance)
		{
			return instance.currentSelectedGameObject;
		}

		static private System.Boolean get_isFocused(UnityEngine.EventSystems.EventSystem instance)
		{
			return instance.isFocused;
		}

		static private System.Boolean get_alreadySelecting(UnityEngine.EventSystems.EventSystem instance)
		{
			return instance.alreadySelecting;
		}

	}
}
