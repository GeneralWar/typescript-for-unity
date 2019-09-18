using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSpriteRenderer
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.SpriteRenderer> self = space.DeclareClass<UnityEngine.SpriteRenderer, UnityEngine.Renderer>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("sprite", get_sprite, set_sprite);
			self.BindInstanceProperty("drawMode", get_drawMode, set_drawMode);
			self.BindInstanceProperty("size", get_size, set_size);
			self.BindInstanceProperty("adaptiveModeThreshold", get_adaptiveModeThreshold, set_adaptiveModeThreshold);
			self.BindInstanceProperty("tileMode", get_tileMode, set_tileMode);
			self.BindInstanceProperty("color", get_color, set_color);
			self.BindInstanceProperty("maskInteraction", get_maskInteraction, set_maskInteraction);
			self.BindInstanceProperty("flipX", get_flipX, set_flipX);
			self.BindInstanceProperty("flipY", get_flipY, set_flipY);
			self.BindInstanceProperty("spriteSortPoint", get_spriteSortPoint, set_spriteSortPoint);
		}

		static private UnityEngine.SpriteRenderer Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.SpriteRenderer();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.SpriteRenderer.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.SpriteRenderer);
		}

		static private UnityEngine.Sprite get_sprite(UnityEngine.SpriteRenderer instance)
		{
			return instance.sprite;
		}

		static private void set_sprite(UnityEngine.SpriteRenderer instance, UnityEngine.Sprite value)
		{
			instance.sprite = value;
		}

		static private UnityEngine.SpriteDrawMode get_drawMode(UnityEngine.SpriteRenderer instance)
		{
			return instance.drawMode;
		}

		static private void set_drawMode(UnityEngine.SpriteRenderer instance, UnityEngine.SpriteDrawMode value)
		{
			instance.drawMode = value;
		}

		static private UnityEngine.Vector2 get_size(UnityEngine.SpriteRenderer instance)
		{
			return instance.size;
		}

		static private void set_size(UnityEngine.SpriteRenderer instance, UnityEngine.Vector2 value)
		{
			instance.size = value;
		}

		static private System.Single get_adaptiveModeThreshold(UnityEngine.SpriteRenderer instance)
		{
			return instance.adaptiveModeThreshold;
		}

		static private void set_adaptiveModeThreshold(UnityEngine.SpriteRenderer instance, System.Single value)
		{
			instance.adaptiveModeThreshold = value;
		}

		static private UnityEngine.SpriteTileMode get_tileMode(UnityEngine.SpriteRenderer instance)
		{
			return instance.tileMode;
		}

		static private void set_tileMode(UnityEngine.SpriteRenderer instance, UnityEngine.SpriteTileMode value)
		{
			instance.tileMode = value;
		}

		static private UnityEngine.Color get_color(UnityEngine.SpriteRenderer instance)
		{
			return instance.color;
		}

		static private void set_color(UnityEngine.SpriteRenderer instance, UnityEngine.Color value)
		{
			instance.color = value;
		}

		static private UnityEngine.SpriteMaskInteraction get_maskInteraction(UnityEngine.SpriteRenderer instance)
		{
			return instance.maskInteraction;
		}

		static private void set_maskInteraction(UnityEngine.SpriteRenderer instance, UnityEngine.SpriteMaskInteraction value)
		{
			instance.maskInteraction = value;
		}

		static private System.Boolean get_flipX(UnityEngine.SpriteRenderer instance)
		{
			return instance.flipX;
		}

		static private void set_flipX(UnityEngine.SpriteRenderer instance, System.Boolean value)
		{
			instance.flipX = value;
		}

		static private System.Boolean get_flipY(UnityEngine.SpriteRenderer instance)
		{
			return instance.flipY;
		}

		static private void set_flipY(UnityEngine.SpriteRenderer instance, System.Boolean value)
		{
			instance.flipY = value;
		}

		static private UnityEngine.SpriteSortPoint get_spriteSortPoint(UnityEngine.SpriteRenderer instance)
		{
			return instance.spriteSortPoint;
		}

		static private void set_spriteSortPoint(UnityEngine.SpriteRenderer instance, UnityEngine.SpriteSortPoint value)
		{
			instance.spriteSortPoint = value;
		}

	}
}
