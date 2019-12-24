using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIColorBlock
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.ColorBlock> self = space.DeclareClass<UnityEngine.UI.ColorBlock>();
			self.BindConstructor();
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindStaticProperty("defaultColorBlock", get_defaultColorBlock, null);
			self.BindInstanceProperty("normalColor", get_normalColor, set_normalColor);
			self.BindInstanceProperty("highlightedColor", get_highlightedColor, set_highlightedColor);
			self.BindInstanceProperty("pressedColor", get_pressedColor, set_pressedColor);
			self.BindInstanceProperty("disabledColor", get_disabledColor, set_disabledColor);
			self.BindInstanceProperty("colorMultiplier", get_colorMultiplier, set_colorMultiplier);
			self.BindInstanceProperty("fadeDuration", get_fadeDuration, set_fadeDuration);
		}

		static private System.Boolean Equals(UnityEngine.UI.ColorBlock instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.UI.ColorBlock>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.UI.ColorBlock>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.ColorBlock.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ColorBlock.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.UI.ColorBlock instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetHashCode();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ColorBlock.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private UnityEngine.UI.ColorBlock get_defaultColorBlock(Type type, string name)
		{
			return UnityEngine.UI.ColorBlock.defaultColorBlock;
		}

		static private UnityEngine.Color get_normalColor(UnityEngine.UI.ColorBlock instance, string name)
		{
			return instance.normalColor;
		}

		static private void set_normalColor(UnityEngine.UI.ColorBlock instance, string name, UnityEngine.Color value)
		{
			instance.normalColor = value;
		}

		static private UnityEngine.Color get_highlightedColor(UnityEngine.UI.ColorBlock instance, string name)
		{
			return instance.highlightedColor;
		}

		static private void set_highlightedColor(UnityEngine.UI.ColorBlock instance, string name, UnityEngine.Color value)
		{
			instance.highlightedColor = value;
		}

		static private UnityEngine.Color get_pressedColor(UnityEngine.UI.ColorBlock instance, string name)
		{
			return instance.pressedColor;
		}

		static private void set_pressedColor(UnityEngine.UI.ColorBlock instance, string name, UnityEngine.Color value)
		{
			instance.pressedColor = value;
		}

		static private UnityEngine.Color get_disabledColor(UnityEngine.UI.ColorBlock instance, string name)
		{
			return instance.disabledColor;
		}

		static private void set_disabledColor(UnityEngine.UI.ColorBlock instance, string name, UnityEngine.Color value)
		{
			instance.disabledColor = value;
		}

		static private System.Single get_colorMultiplier(UnityEngine.UI.ColorBlock instance, string name)
		{
			return instance.colorMultiplier;
		}

		static private void set_colorMultiplier(UnityEngine.UI.ColorBlock instance, string name, System.Single value)
		{
			instance.colorMultiplier = value;
		}

		static private System.Single get_fadeDuration(UnityEngine.UI.ColorBlock instance, string name)
		{
			return instance.fadeDuration;
		}

		static private void set_fadeDuration(UnityEngine.UI.ColorBlock instance, string name, System.Single value)
		{
			instance.fadeDuration = value;
		}

	}
}
