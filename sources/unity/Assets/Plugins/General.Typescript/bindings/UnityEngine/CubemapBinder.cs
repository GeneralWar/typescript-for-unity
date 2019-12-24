using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCubemap
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Cubemap> self = space.DeclareClass<UnityEngine.Cubemap, UnityEngine.Texture>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("CreateExternalTexture", CreateExternalTexture);
			self.BindInstanceFunction("Apply", Apply);
			self.BindInstanceFunction("GetPixel", GetPixel);
			self.BindInstanceFunction("GetPixels", GetPixels);
			self.BindInstanceFunction("SetPixel", SetPixel);
			self.BindInstanceFunction("SetPixels", SetPixels);
			self.BindInstanceFunction("SmoothEdges", SmoothEdges);
			self.BindInstanceProperty("mipmapCount", get_mipmapCount, null);
			self.BindInstanceProperty("format", get_format, null);
			self.BindInstanceProperty("isReadable", get_isReadable, null);
		}

		static private UnityEngine.Cubemap Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.TextureCreationFlags>())
			{
				return new UnityEngine.Cubemap(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Experimental.Rendering.GraphicsFormat>(), parameters[2].ToObject<UnityEngine.Experimental.Rendering.TextureCreationFlags>());
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.TextureFormat, System.Boolean>())
			{
				return new UnityEngine.Cubemap(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.TextureFormat>(), parameters[2].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Cubemap.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Cubemap.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Cubemap);
		}

		static private UnityEngine.Cubemap CreateExternalTexture(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.TextureFormat, System.Boolean, System.IntPtr>())
			{
				return UnityEngine.Cubemap.CreateExternalTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.TextureFormat>(), parameters[2].ToObject<System.Boolean>(), parameters[3].ToObject<System.IntPtr>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Cubemap.CreateExternalTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Cubemap.CreateExternalTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void Apply(UnityEngine.Cubemap instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Cubemap.Apply has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.Color GetPixel(UnityEngine.Cubemap instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.CubemapFace, System.Int32, System.Int32>())
			{
				return instance.GetPixel(parameters[0].ToObject<UnityEngine.CubemapFace>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Cubemap.GetPixel has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Cubemap.GetPixel has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Color);
		}

		static private UnityEngine.Color[] GetPixels(UnityEngine.Cubemap instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.CubemapFace>())
			{
				return instance.GetPixels(parameters[0].ToObject<UnityEngine.CubemapFace>());
			}
			if (parameters.CheckTypes<UnityEngine.CubemapFace, System.Int32>())
			{
				return instance.GetPixels(parameters[0].ToObject<UnityEngine.CubemapFace>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Cubemap.GetPixels has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Cubemap.GetPixels has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void SetPixel(UnityEngine.Cubemap instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.CubemapFace, System.Int32, System.Int32, UnityEngine.Color>())
			{
				instance.SetPixel(parameters[0].ToObject<UnityEngine.CubemapFace>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.Color>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Cubemap.SetPixel has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Cubemap.SetPixel has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetPixels(UnityEngine.Cubemap instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Color[], UnityEngine.CubemapFace>())
			{
				instance.SetPixels(parameters[0].ToObject<UnityEngine.Color[]>(), parameters[1].ToObject<UnityEngine.CubemapFace>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Color[], UnityEngine.CubemapFace, System.Int32>())
			{
				instance.SetPixels(parameters[0].ToObject<UnityEngine.Color[]>(), parameters[1].ToObject<UnityEngine.CubemapFace>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Cubemap.SetPixels has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Cubemap.SetPixels has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SmoothEdges(UnityEngine.Cubemap instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.SmoothEdges();
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.SmoothEdges(parameters[0].ToObject<System.Int32>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Cubemap.SmoothEdges has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Int32 get_mipmapCount(UnityEngine.Cubemap instance, string name)
		{
			return instance.mipmapCount;
		}

		static private UnityEngine.TextureFormat get_format(UnityEngine.Cubemap instance, string name)
		{
			return instance.format;
		}

		static private System.Boolean get_isReadable(UnityEngine.Cubemap instance, string name)
		{
			return instance.isReadable;
		}

	}
}
