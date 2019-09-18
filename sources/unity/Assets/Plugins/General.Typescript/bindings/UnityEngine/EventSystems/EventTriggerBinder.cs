using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineEventSystemsEventTrigger
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.EventSystems.EventTrigger> self = space.DeclareClass<UnityEngine.EventSystems.EventTrigger, UnityEngine.MonoBehaviour>();
			self.BindConstructor();
			self.BindInstanceFunction("OnBeginDrag", OnBeginDrag);
			self.BindInstanceFunction("OnCancel", OnCancel);
			self.BindInstanceFunction("OnDeselect", OnDeselect);
			self.BindInstanceFunction("OnDrag", OnDrag);
			self.BindInstanceFunction("OnDrop", OnDrop);
			self.BindInstanceFunction("OnEndDrag", OnEndDrag);
			self.BindInstanceFunction("OnInitializePotentialDrag", OnInitializePotentialDrag);
			self.BindInstanceFunction("OnMove", OnMove);
			self.BindInstanceFunction("OnPointerClick", OnPointerClick);
			self.BindInstanceFunction("OnPointerDown", OnPointerDown);
			self.BindInstanceFunction("OnPointerEnter", OnPointerEnter);
			self.BindInstanceFunction("OnPointerExit", OnPointerExit);
			self.BindInstanceFunction("OnPointerUp", OnPointerUp);
			self.BindInstanceFunction("OnScroll", OnScroll);
			self.BindInstanceFunction("OnSelect", OnSelect);
			self.BindInstanceFunction("OnSubmit", OnSubmit);
			self.BindInstanceFunction("OnUpdateSelected", OnUpdateSelected);
		}

		static private void OnBeginDrag(UnityEngine.EventSystems.EventTrigger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnBeginDrag(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventTrigger.OnBeginDrag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventTrigger.OnBeginDrag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnCancel(UnityEngine.EventSystems.EventTrigger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.BaseEventData>())
			{
				instance.OnCancel(parameters[0].ToObject<UnityEngine.EventSystems.BaseEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventTrigger.OnCancel has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventTrigger.OnCancel has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnDeselect(UnityEngine.EventSystems.EventTrigger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.BaseEventData>())
			{
				instance.OnDeselect(parameters[0].ToObject<UnityEngine.EventSystems.BaseEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventTrigger.OnDeselect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventTrigger.OnDeselect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnDrag(UnityEngine.EventSystems.EventTrigger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnDrag(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventTrigger.OnDrag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventTrigger.OnDrag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnDrop(UnityEngine.EventSystems.EventTrigger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnDrop(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventTrigger.OnDrop has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventTrigger.OnDrop has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnEndDrag(UnityEngine.EventSystems.EventTrigger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnEndDrag(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventTrigger.OnEndDrag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventTrigger.OnEndDrag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnInitializePotentialDrag(UnityEngine.EventSystems.EventTrigger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnInitializePotentialDrag(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventTrigger.OnInitializePotentialDrag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventTrigger.OnInitializePotentialDrag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnMove(UnityEngine.EventSystems.EventTrigger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.AxisEventData>())
			{
				instance.OnMove(parameters[0].ToObject<UnityEngine.EventSystems.AxisEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventTrigger.OnMove has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventTrigger.OnMove has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnPointerClick(UnityEngine.EventSystems.EventTrigger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnPointerClick(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventTrigger.OnPointerClick has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventTrigger.OnPointerClick has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnPointerDown(UnityEngine.EventSystems.EventTrigger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnPointerDown(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventTrigger.OnPointerDown has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventTrigger.OnPointerDown has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnPointerEnter(UnityEngine.EventSystems.EventTrigger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnPointerEnter(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventTrigger.OnPointerEnter has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventTrigger.OnPointerEnter has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnPointerExit(UnityEngine.EventSystems.EventTrigger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnPointerExit(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventTrigger.OnPointerExit has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventTrigger.OnPointerExit has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnPointerUp(UnityEngine.EventSystems.EventTrigger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnPointerUp(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventTrigger.OnPointerUp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventTrigger.OnPointerUp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnScroll(UnityEngine.EventSystems.EventTrigger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.PointerEventData>())
			{
				instance.OnScroll(parameters[0].ToObject<UnityEngine.EventSystems.PointerEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventTrigger.OnScroll has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventTrigger.OnScroll has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnSelect(UnityEngine.EventSystems.EventTrigger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.BaseEventData>())
			{
				instance.OnSelect(parameters[0].ToObject<UnityEngine.EventSystems.BaseEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventTrigger.OnSelect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventTrigger.OnSelect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnSubmit(UnityEngine.EventSystems.EventTrigger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.BaseEventData>())
			{
				instance.OnSubmit(parameters[0].ToObject<UnityEngine.EventSystems.BaseEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventTrigger.OnSubmit has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventTrigger.OnSubmit has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void OnUpdateSelected(UnityEngine.EventSystems.EventTrigger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.EventSystems.BaseEventData>())
			{
				instance.OnUpdateSelected(parameters[0].ToObject<UnityEngine.EventSystems.BaseEventData>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.EventSystems.EventTrigger.OnUpdateSelected has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.EventSystems.EventTrigger.OnUpdateSelected has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

	}
}
