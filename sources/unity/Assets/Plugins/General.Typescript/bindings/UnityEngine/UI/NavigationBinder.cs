using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUINavigation
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.Navigation> self = space.DeclareClass<UnityEngine.UI.Navigation>();
			UnityEngineUINavigationMode.Bind(self);
			self.BindConstructor();
			self.BindInstanceFunction("Equals", Equals);
			self.BindStaticProperty("defaultNavigation", get_defaultNavigation, null);
			self.BindInstanceProperty("selectOnUp", get_selectOnUp, set_selectOnUp);
			self.BindInstanceProperty("selectOnDown", get_selectOnDown, set_selectOnDown);
			self.BindInstanceProperty("selectOnLeft", get_selectOnLeft, set_selectOnLeft);
			self.BindInstanceProperty("selectOnRight", get_selectOnRight, set_selectOnRight);
		}

		static private System.Boolean Equals(UnityEngine.UI.Navigation instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.Navigation>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.UI.Navigation>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Navigation.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Navigation.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.UI.Navigation get_defaultNavigation()
		{
			return UnityEngine.UI.Navigation.defaultNavigation;
		}

		static private UnityEngine.UI.Selectable get_selectOnUp(UnityEngine.UI.Navigation instance)
		{
			return instance.selectOnUp;
		}

		static private void set_selectOnUp(UnityEngine.UI.Navigation instance, UnityEngine.UI.Selectable value)
		{
			instance.selectOnUp = value;
		}

		static private UnityEngine.UI.Selectable get_selectOnDown(UnityEngine.UI.Navigation instance)
		{
			return instance.selectOnDown;
		}

		static private void set_selectOnDown(UnityEngine.UI.Navigation instance, UnityEngine.UI.Selectable value)
		{
			instance.selectOnDown = value;
		}

		static private UnityEngine.UI.Selectable get_selectOnLeft(UnityEngine.UI.Navigation instance)
		{
			return instance.selectOnLeft;
		}

		static private void set_selectOnLeft(UnityEngine.UI.Navigation instance, UnityEngine.UI.Selectable value)
		{
			instance.selectOnLeft = value;
		}

		static private UnityEngine.UI.Selectable get_selectOnRight(UnityEngine.UI.Navigation instance)
		{
			return instance.selectOnRight;
		}

		static private void set_selectOnRight(UnityEngine.UI.Navigation instance, UnityEngine.UI.Selectable value)
		{
			instance.selectOnRight = value;
		}

	}
}
