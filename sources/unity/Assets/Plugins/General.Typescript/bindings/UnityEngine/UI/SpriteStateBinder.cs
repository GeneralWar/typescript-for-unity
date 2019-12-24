using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUISpriteState
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.SpriteState> self = space.DeclareClass<UnityEngine.UI.SpriteState>();
			self.BindConstructor();
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceProperty("highlightedSprite", get_highlightedSprite, set_highlightedSprite);
			self.BindInstanceProperty("pressedSprite", get_pressedSprite, set_pressedSprite);
			self.BindInstanceProperty("disabledSprite", get_disabledSprite, set_disabledSprite);
		}

		static private System.Boolean Equals(UnityEngine.UI.SpriteState instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.SpriteState>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.UI.SpriteState>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.SpriteState.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.SpriteState.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.Sprite get_highlightedSprite(UnityEngine.UI.SpriteState instance, string name)
		{
			return instance.highlightedSprite;
		}

		static private void set_highlightedSprite(UnityEngine.UI.SpriteState instance, string name, UnityEngine.Sprite value)
		{
			instance.highlightedSprite = value;
		}

		static private UnityEngine.Sprite get_pressedSprite(UnityEngine.UI.SpriteState instance, string name)
		{
			return instance.pressedSprite;
		}

		static private void set_pressedSprite(UnityEngine.UI.SpriteState instance, string name, UnityEngine.Sprite value)
		{
			instance.pressedSprite = value;
		}

		static private UnityEngine.Sprite get_disabledSprite(UnityEngine.UI.SpriteState instance, string name)
		{
			return instance.disabledSprite;
		}

		static private void set_disabledSprite(UnityEngine.UI.SpriteState instance, string name, UnityEngine.Sprite value)
		{
			instance.disabledSprite = value;
		}

	}
}
