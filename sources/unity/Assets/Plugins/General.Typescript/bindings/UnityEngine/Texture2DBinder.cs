using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTexture2D
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Texture2D> self = space.DeclareClass<UnityEngine.Texture2D, UnityEngine.Texture>();
			UnityEngineTexture2DEXRFlags.Bind(self);
			self.BindConstructor(Constructor);
			self.BindStaticFunction("CreateExternalTexture", CreateExternalTexture);
			self.BindInstanceFunction("Apply", Apply);
			self.BindInstanceFunction("ClearRequestedMipmapLevel", ClearRequestedMipmapLevel);
			self.BindInstanceFunction("Compress", Compress);
			self.BindInstanceFunction("GetPixel", GetPixel);
			self.BindInstanceFunction("GetPixelBilinear", GetPixelBilinear);
			self.BindInstanceFunction("GetPixels", GetPixels);
			self.BindInstanceFunction("GetPixels32", GetPixels32);
			self.BindInstanceFunction("GetRawTextureData", GetRawTextureData);
			self.BindInstanceFunction("IsRequestedMipmapLevelLoaded", IsRequestedMipmapLevelLoaded);
			self.BindInstanceFunction("LoadRawTextureData", LoadRawTextureData);
			self.BindInstanceFunction("PackTextures", PackTextures);
			self.BindInstanceFunction("ReadPixels", ReadPixels);
			self.BindInstanceFunction("Resize", Resize);
			self.BindInstanceFunction("SetPixel", SetPixel);
			self.BindInstanceFunction("SetPixels", SetPixels);
			self.BindInstanceFunction("SetPixels32", SetPixels32);
			self.BindInstanceFunction("UpdateExternalTexture", UpdateExternalTexture);
			self.BindStaticProperty("whiteTexture", get_whiteTexture, null);
			self.BindStaticProperty("blackTexture", get_blackTexture, null);
			self.BindInstanceProperty("mipmapCount", get_mipmapCount, null);
			self.BindInstanceProperty("format", get_format, null);
			self.BindInstanceProperty("isReadable", get_isReadable, null);
			self.BindInstanceProperty("streamingMipmaps", get_streamingMipmaps, null);
			self.BindInstanceProperty("streamingMipmapsPriority", get_streamingMipmapsPriority, null);
			self.BindInstanceProperty("requestedMipmapLevel", get_requestedMipmapLevel, set_requestedMipmapLevel);
			self.BindInstanceProperty("desiredMipmapLevel", get_desiredMipmapLevel, null);
			self.BindInstanceProperty("loadingMipmapLevel", get_loadingMipmapLevel, null);
			self.BindInstanceProperty("loadedMipmapLevel", get_loadedMipmapLevel, null);
		}

		static private UnityEngine.Texture2D Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return new UnityEngine.Texture2D(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.TextureCreationFlags>())
			{
				return new UnityEngine.Texture2D(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Experimental.Rendering.GraphicsFormat>(), parameters[3].ToObject<UnityEngine.Experimental.Rendering.TextureCreationFlags>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.TextureFormat, System.Boolean>())
			{
				return new UnityEngine.Texture2D(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.TextureFormat>(), parameters[3].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.TextureFormat, System.Boolean, System.Boolean>())
			{
				return new UnityEngine.Texture2D(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.TextureFormat>(), parameters[3].ToObject<System.Boolean>(), parameters[4].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Texture2D.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Texture2D);
		}

		static private UnityEngine.Texture2D CreateExternalTexture(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.TextureFormat, System.Boolean, System.Boolean, System.IntPtr>())
			{
				return UnityEngine.Texture2D.CreateExternalTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.TextureFormat>(), parameters[3].ToObject<System.Boolean>(), parameters[4].ToObject<System.Boolean>(), parameters[5].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Texture2D.CreateExternalTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.CreateExternalTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void Apply(UnityEngine.Texture2D instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Apply();
			}
			if (parameters.CheckTypes<System.Boolean>())
			{
				instance.Apply(parameters[0].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<System.Boolean, System.Boolean>())
			{
				instance.Apply(parameters[0].ToObject<System.Boolean>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.Apply has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ClearRequestedMipmapLevel(UnityEngine.Texture2D instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ClearRequestedMipmapLevel();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.ClearRequestedMipmapLevel has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Compress(UnityEngine.Texture2D instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean>())
			{
				instance.Compress(parameters[0].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Texture2D.Compress has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.Compress has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Color GetPixel(UnityEngine.Texture2D instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return instance.GetPixel(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Texture2D.GetPixel has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.GetPixel has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Color);
		}

		static private UnityEngine.Color GetPixelBilinear(UnityEngine.Texture2D instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return instance.GetPixelBilinear(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Texture2D.GetPixelBilinear has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.GetPixelBilinear has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Color);
		}

		static private UnityEngine.Color[] GetPixels(UnityEngine.Texture2D instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetPixels();
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetPixels(parameters[0].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32>())
			{
				return instance.GetPixels(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, System.Int32>())
			{
				return instance.GetPixels(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.GetPixels has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Color32[] GetPixels32(UnityEngine.Texture2D instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetPixels32();
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetPixels32(parameters[0].ToObject<System.Int32>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.GetPixels32 has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Byte[] GetRawTextureData(UnityEngine.Texture2D instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetRawTextureData();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.GetRawTextureData has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Boolean IsRequestedMipmapLevelLoaded(UnityEngine.Texture2D instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsRequestedMipmapLevelLoaded();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.IsRequestedMipmapLevelLoaded has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private void LoadRawTextureData(UnityEngine.Texture2D instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[]>())
			{
				instance.LoadRawTextureData(parameters[0].ToObject<System.Byte[]>());
				return;
			}
			if (parameters.CheckTypes<System.IntPtr, System.Int32>())
			{
				instance.LoadRawTextureData(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Texture2D.LoadRawTextureData has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.LoadRawTextureData has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Rect[] PackTextures(UnityEngine.Texture2D instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Texture2D[], System.Int32>())
			{
				return instance.PackTextures(parameters[0].ToObject<UnityEngine.Texture2D[]>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Texture2D[], System.Int32, System.Int32>())
			{
				return instance.PackTextures(parameters[0].ToObject<UnityEngine.Texture2D[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.Texture2D[], System.Int32, System.Int32, System.Boolean>())
			{
				return instance.PackTextures(parameters[0].ToObject<UnityEngine.Texture2D[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Texture2D.PackTextures has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.PackTextures has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void ReadPixels(UnityEngine.Texture2D instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rect, System.Int32, System.Int32>())
			{
				instance.ReadPixels(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rect, System.Int32, System.Int32, System.Boolean>())
			{
				instance.ReadPixels(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Texture2D.ReadPixels has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.ReadPixels has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean Resize(UnityEngine.Texture2D instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return instance.Resize(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.TextureFormat, System.Boolean>())
			{
				return instance.Resize(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.TextureFormat>(), parameters[3].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Texture2D.Resize has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.Resize has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void SetPixel(UnityEngine.Texture2D instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.Color>())
			{
				instance.SetPixel(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Color>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Texture2D.SetPixel has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.SetPixel has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetPixels(UnityEngine.Texture2D instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Color[]>())
			{
				instance.SetPixels(parameters[0].ToObject<UnityEngine.Color[]>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Color[], System.Int32>())
			{
				instance.SetPixels(parameters[0].ToObject<UnityEngine.Color[]>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.Color[]>())
			{
				instance.SetPixels(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Color[]>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.Color[], System.Int32>())
			{
				instance.SetPixels(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Color[]>(), parameters[5].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Texture2D.SetPixels has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.SetPixels has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetPixels32(UnityEngine.Texture2D instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Color32[]>())
			{
				instance.SetPixels32(parameters[0].ToObject<UnityEngine.Color32[]>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Color32[], System.Int32>())
			{
				instance.SetPixels32(parameters[0].ToObject<UnityEngine.Color32[]>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.Color32[]>())
			{
				instance.SetPixels32(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Color32[]>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.Color32[], System.Int32>())
			{
				instance.SetPixels32(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Color32[]>(), parameters[5].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Texture2D.SetPixels32 has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.SetPixels32 has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void UpdateExternalTexture(UnityEngine.Texture2D instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr>())
			{
				instance.UpdateExternalTexture(parameters[0].ToObject<System.IntPtr>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Texture2D.UpdateExternalTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Texture2D.UpdateExternalTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Texture2D get_whiteTexture()
		{
			return UnityEngine.Texture2D.whiteTexture;
		}

		static private UnityEngine.Texture2D get_blackTexture()
		{
			return UnityEngine.Texture2D.blackTexture;
		}

		static private System.Int32 get_mipmapCount(UnityEngine.Texture2D instance)
		{
			return instance.mipmapCount;
		}

		static private UnityEngine.TextureFormat get_format(UnityEngine.Texture2D instance)
		{
			return instance.format;
		}

		static private System.Boolean get_isReadable(UnityEngine.Texture2D instance)
		{
			return instance.isReadable;
		}

		static private System.Boolean get_streamingMipmaps(UnityEngine.Texture2D instance)
		{
			return instance.streamingMipmaps;
		}

		static private System.Int32 get_streamingMipmapsPriority(UnityEngine.Texture2D instance)
		{
			return instance.streamingMipmapsPriority;
		}

		static private System.Int32 get_requestedMipmapLevel(UnityEngine.Texture2D instance)
		{
			return instance.requestedMipmapLevel;
		}

		static private void set_requestedMipmapLevel(UnityEngine.Texture2D instance, System.Int32 value)
		{
			instance.requestedMipmapLevel = value;
		}

		static private System.Int32 get_desiredMipmapLevel(UnityEngine.Texture2D instance)
		{
			return instance.desiredMipmapLevel;
		}

		static private System.Int32 get_loadingMipmapLevel(UnityEngine.Texture2D instance)
		{
			return instance.loadingMipmapLevel;
		}

		static private System.Int32 get_loadedMipmapLevel(UnityEngine.Texture2D instance)
		{
			return instance.loadedMipmapLevel;
		}

	}
}
