using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIAnimationTriggers
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.AnimationTriggers> self = space.DeclareClass<UnityEngine.UI.AnimationTriggers>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("normalTrigger", get_normalTrigger, set_normalTrigger);
			self.BindInstanceProperty("highlightedTrigger", get_highlightedTrigger, set_highlightedTrigger);
			self.BindInstanceProperty("pressedTrigger", get_pressedTrigger, set_pressedTrigger);
			self.BindInstanceProperty("disabledTrigger", get_disabledTrigger, set_disabledTrigger);
		}

		static private UnityEngine.UI.AnimationTriggers Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.UI.AnimationTriggers();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.AnimationTriggers.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.UI.AnimationTriggers);
		}

		static private System.String get_normalTrigger(UnityEngine.UI.AnimationTriggers instance)
		{
			return instance.normalTrigger;
		}

		static private void set_normalTrigger(UnityEngine.UI.AnimationTriggers instance, System.String value)
		{
			instance.normalTrigger = value;
		}

		static private System.String get_highlightedTrigger(UnityEngine.UI.AnimationTriggers instance)
		{
			return instance.highlightedTrigger;
		}

		static private void set_highlightedTrigger(UnityEngine.UI.AnimationTriggers instance, System.String value)
		{
			instance.highlightedTrigger = value;
		}

		static private System.String get_pressedTrigger(UnityEngine.UI.AnimationTriggers instance)
		{
			return instance.pressedTrigger;
		}

		static private void set_pressedTrigger(UnityEngine.UI.AnimationTriggers instance, System.String value)
		{
			instance.pressedTrigger = value;
		}

		static private System.String get_disabledTrigger(UnityEngine.UI.AnimationTriggers instance)
		{
			return instance.disabledTrigger;
		}

		static private void set_disabledTrigger(UnityEngine.UI.AnimationTriggers instance, System.String value)
		{
			instance.disabledTrigger = value;
		}

	}
}
