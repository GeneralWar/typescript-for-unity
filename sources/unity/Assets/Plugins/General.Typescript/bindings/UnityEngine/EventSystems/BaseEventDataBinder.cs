using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineEventSystemsBaseEventData
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.EventSystems.BaseEventData> self = space.DeclareClass<UnityEngine.EventSystems.BaseEventData>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("currentInputModule", get_currentInputModule, null);
			self.BindInstanceProperty("selectedObject", get_selectedObject, set_selectedObject);
		}

		static private UnityEngine.EventSystems.BaseEventData Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.EventSystem>())
			{
				return new UnityEngine.EventSystems.BaseEventData(parameters[0].ToObject<UnityEngine.EventSystems.EventSystem>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.BaseEventData.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.BaseEventData.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.EventSystems.BaseEventData);
		}

		static private UnityEngine.EventSystems.BaseInputModule get_currentInputModule(UnityEngine.EventSystems.BaseEventData instance)
		{
			return instance.currentInputModule;
		}

		static private UnityEngine.GameObject get_selectedObject(UnityEngine.EventSystems.BaseEventData instance)
		{
			return instance.selectedObject;
		}

		static private void set_selectedObject(UnityEngine.EventSystems.BaseEventData instance, UnityEngine.GameObject value)
		{
			instance.selectedObject = value;
		}

	}
}
