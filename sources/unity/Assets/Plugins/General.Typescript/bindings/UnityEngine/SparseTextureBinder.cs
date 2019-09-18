using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSparseTexture
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.SparseTexture> self = space.DeclareClass<UnityEngine.SparseTexture, UnityEngine.Texture>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("UnloadTile", UnloadTile);
			self.BindInstanceFunction("UpdateTile", UpdateTile);
			self.BindInstanceFunction("UpdateTileRaw", UpdateTileRaw);
			self.BindInstanceProperty("tileWidth", get_tileWidth, null);
			self.BindInstanceProperty("tileHeight", get_tileHeight, null);
			self.BindInstanceProperty("isCreated", get_isCreated, null);
		}

		static private UnityEngine.SparseTexture Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, System.Int32>())
			{
				return new UnityEngine.SparseTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Experimental.Rendering.GraphicsFormat>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.TextureFormat, System.Int32>())
			{
				return new UnityEngine.SparseTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.TextureFormat>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.TextureFormat, System.Int32, System.Boolean>())
			{
				return new UnityEngine.SparseTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.TextureFormat>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SparseTexture.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SparseTexture.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.SparseTexture);
		}

		static private void UnloadTile(UnityEngine.SparseTexture instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32>())
			{
				instance.UnloadTile(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SparseTexture.UnloadTile has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SparseTexture.UnloadTile has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void UpdateTile(UnityEngine.SparseTexture instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, UnityEngine.Color32[]>())
			{
				instance.UpdateTile(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.Color32[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SparseTexture.UpdateTile has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SparseTexture.UpdateTile has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void UpdateTileRaw(UnityEngine.SparseTexture instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Byte[]>())
			{
				instance.UpdateTileRaw(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Byte[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SparseTexture.UpdateTileRaw has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SparseTexture.UpdateTileRaw has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 get_tileWidth(UnityEngine.SparseTexture instance)
		{
			return instance.tileWidth;
		}

		static private System.Int32 get_tileHeight(UnityEngine.SparseTexture instance)
		{
			return instance.tileHeight;
		}

		static private System.Boolean get_isCreated(UnityEngine.SparseTexture instance)
		{
			return instance.isCreated;
		}

	}
}
