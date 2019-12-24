using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSprite
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Sprite> self = space.DeclareClass<UnityEngine.Sprite, UnityEngine.Object>();
			self.BindConstructor();
			self.BindStaticFunction("Create", Create);
			self.BindInstanceFunction("GetPhysicsShapeCount", GetPhysicsShapeCount);
			self.BindInstanceFunction("GetPhysicsShapePointCount", GetPhysicsShapePointCount);
			self.BindInstanceFunction("OverrideGeometry", OverrideGeometry);
			self.BindInstanceProperty("bounds", get_bounds, null);
			self.BindInstanceProperty("rect", get_rect, null);
			self.BindInstanceProperty("border", get_border, null);
			self.BindInstanceProperty("texture", get_texture, null);
			self.BindInstanceProperty("pixelsPerUnit", get_pixelsPerUnit, null);
			self.BindInstanceProperty("associatedAlphaSplitTexture", get_associatedAlphaSplitTexture, null);
			self.BindInstanceProperty("pivot", get_pivot, null);
			self.BindInstanceProperty("packed", get_packed, null);
			self.BindInstanceProperty("packingMode", get_packingMode, null);
			self.BindInstanceProperty("packingRotation", get_packingRotation, null);
			self.BindInstanceProperty("textureRect", get_textureRect, null);
			self.BindInstanceProperty("textureRectOffset", get_textureRectOffset, null);
			self.BindInstanceProperty("vertices", get_vertices, null);
			self.BindInstanceProperty("triangles", get_triangles, null);
			self.BindInstanceProperty("uv", get_uv, null);
		}

		static private UnityEngine.Sprite Create(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2>())
			{
				return UnityEngine.Sprite.Create(parameters[0].ToObject<UnityEngine.Texture2D>(), parameters[1].ToObject<UnityEngine.Rect>(), parameters[2].ToObject<UnityEngine.Vector2>());
			}
			if (parameters.CheckTypes<UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, System.Single>())
			{
				return UnityEngine.Sprite.Create(parameters[0].ToObject<UnityEngine.Texture2D>(), parameters[1].ToObject<UnityEngine.Rect>(), parameters[2].ToObject<UnityEngine.Vector2>(), parameters[3].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, System.Single, System.UInt32>())
			{
				return UnityEngine.Sprite.Create(parameters[0].ToObject<UnityEngine.Texture2D>(), parameters[1].ToObject<UnityEngine.Rect>(), parameters[2].ToObject<UnityEngine.Vector2>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.UInt32>());
			}
			if (parameters.CheckTypes<UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, System.Single, System.UInt32, UnityEngine.SpriteMeshType>())
			{
				return UnityEngine.Sprite.Create(parameters[0].ToObject<UnityEngine.Texture2D>(), parameters[1].ToObject<UnityEngine.Rect>(), parameters[2].ToObject<UnityEngine.Vector2>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.UInt32>(), parameters[5].ToObject<UnityEngine.SpriteMeshType>());
			}
			if (parameters.CheckTypes<UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, System.Single, System.UInt32, UnityEngine.SpriteMeshType, UnityEngine.Vector4>())
			{
				return UnityEngine.Sprite.Create(parameters[0].ToObject<UnityEngine.Texture2D>(), parameters[1].ToObject<UnityEngine.Rect>(), parameters[2].ToObject<UnityEngine.Vector2>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.UInt32>(), parameters[5].ToObject<UnityEngine.SpriteMeshType>(), parameters[6].ToObject<UnityEngine.Vector4>());
			}
			if (parameters.CheckTypes<UnityEngine.Texture2D, UnityEngine.Rect, UnityEngine.Vector2, System.Single, System.UInt32, UnityEngine.SpriteMeshType, UnityEngine.Vector4, System.Boolean>())
			{
				return UnityEngine.Sprite.Create(parameters[0].ToObject<UnityEngine.Texture2D>(), parameters[1].ToObject<UnityEngine.Rect>(), parameters[2].ToObject<UnityEngine.Vector2>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.UInt32>(), parameters[5].ToObject<UnityEngine.SpriteMeshType>(), parameters[6].ToObject<UnityEngine.Vector4>(), parameters[7].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Sprite.Create has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Sprite.Create has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 GetPhysicsShapeCount(UnityEngine.Sprite instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetPhysicsShapeCount();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Sprite.GetPhysicsShapeCount has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Int32 GetPhysicsShapePointCount(UnityEngine.Sprite instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetPhysicsShapePointCount(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Sprite.GetPhysicsShapePointCount has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Sprite.GetPhysicsShapePointCount has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void OverrideGeometry(UnityEngine.Sprite instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2[], System.UInt16[]>())
			{
				instance.OverrideGeometry(parameters[0].ToObject<UnityEngine.Vector2[]>(), parameters[1].ToObject<System.UInt16[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Sprite.OverrideGeometry has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Sprite.OverrideGeometry has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Bounds get_bounds(UnityEngine.Sprite instance, string name)
		{
			return instance.bounds;
		}

		static private UnityEngine.Rect get_rect(UnityEngine.Sprite instance, string name)
		{
			return instance.rect;
		}

		static private UnityEngine.Vector4 get_border(UnityEngine.Sprite instance, string name)
		{
			return instance.border;
		}

		static private UnityEngine.Texture2D get_texture(UnityEngine.Sprite instance, string name)
		{
			return instance.texture;
		}

		static private System.Single get_pixelsPerUnit(UnityEngine.Sprite instance, string name)
		{
			return instance.pixelsPerUnit;
		}

		static private UnityEngine.Texture2D get_associatedAlphaSplitTexture(UnityEngine.Sprite instance, string name)
		{
			return instance.associatedAlphaSplitTexture;
		}

		static private UnityEngine.Vector2 get_pivot(UnityEngine.Sprite instance, string name)
		{
			return instance.pivot;
		}

		static private System.Boolean get_packed(UnityEngine.Sprite instance, string name)
		{
			return instance.packed;
		}

		static private UnityEngine.SpritePackingMode get_packingMode(UnityEngine.Sprite instance, string name)
		{
			return instance.packingMode;
		}

		static private UnityEngine.SpritePackingRotation get_packingRotation(UnityEngine.Sprite instance, string name)
		{
			return instance.packingRotation;
		}

		static private UnityEngine.Rect get_textureRect(UnityEngine.Sprite instance, string name)
		{
			return instance.textureRect;
		}

		static private UnityEngine.Vector2 get_textureRectOffset(UnityEngine.Sprite instance, string name)
		{
			return instance.textureRectOffset;
		}

		static private UnityEngine.Vector2[] get_vertices(UnityEngine.Sprite instance, string name)
		{
			return instance.vertices;
		}

		static private System.UInt16[] get_triangles(UnityEngine.Sprite instance, string name)
		{
			return instance.triangles;
		}

		static private UnityEngine.Vector2[] get_uv(UnityEngine.Sprite instance, string name)
		{
			return instance.uv;
		}

	}
}
