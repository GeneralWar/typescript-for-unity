using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineU2DSpriteAtlas
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.U2D.SpriteAtlas> self = space.DeclareClass<UnityEngine.U2D.SpriteAtlas, UnityEngine.Object>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("CanBindTo", CanBindTo);
			self.BindInstanceFunction("GetSprite", GetSprite);
			self.BindInstanceFunction("GetSprites", GetSprites);
			self.BindInstanceProperty("isVariant", get_isVariant, null);
			self.BindInstanceProperty("tag", get_tag, null);
			self.BindInstanceProperty("spriteCount", get_spriteCount, null);
		}

		static private UnityEngine.U2D.SpriteAtlas Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.U2D.SpriteAtlas();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.U2D.SpriteAtlas.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.U2D.SpriteAtlas);
		}

		static private System.Boolean CanBindTo(UnityEngine.U2D.SpriteAtlas instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Sprite>())
			{
				return instance.CanBindTo(parameters[0].ToObject<UnityEngine.Sprite>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.U2D.SpriteAtlas.CanBindTo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.U2D.SpriteAtlas.CanBindTo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.Sprite GetSprite(UnityEngine.U2D.SpriteAtlas instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetSprite(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.U2D.SpriteAtlas.GetSprite has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.U2D.SpriteAtlas.GetSprite has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 GetSprites(UnityEngine.U2D.SpriteAtlas instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Sprite[]>())
			{
				return instance.GetSprites(parameters[0].ToObject<UnityEngine.Sprite[]>());
			}
			if (parameters.CheckTypes<UnityEngine.Sprite[], System.String>())
			{
				return instance.GetSprites(parameters[0].ToObject<UnityEngine.Sprite[]>(), parameters[1].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.U2D.SpriteAtlas.GetSprites has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.U2D.SpriteAtlas.GetSprites has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Boolean get_isVariant(UnityEngine.U2D.SpriteAtlas instance, string name)
		{
			return instance.isVariant;
		}

		static private System.String get_tag(UnityEngine.U2D.SpriteAtlas instance, string name)
		{
			return instance.tag;
		}

		static private System.Int32 get_spriteCount(UnityEngine.U2D.SpriteAtlas instance, string name)
		{
			return instance.spriteCount;
		}

	}
}
