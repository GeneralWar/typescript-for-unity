using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCubemapArray
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.CubemapArray> self = space.DeclareClass<UnityEngine.CubemapArray, UnityEngine.Texture>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Apply", Apply);
			self.BindInstanceFunction("GetPixels", GetPixels);
			self.BindInstanceFunction("GetPixels32", GetPixels32);
			self.BindInstanceFunction("SetPixels", SetPixels);
			self.BindInstanceFunction("SetPixels32", SetPixels32);
			self.BindInstanceProperty("cubemapCount", get_cubemapCount, null);
			self.BindInstanceProperty("format", get_format, null);
			self.BindInstanceProperty("isReadable", get_isReadable, null);
		}

		static private UnityEngine.CubemapArray Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.Experimental.Rendering.GraphicsFormat, UnityEngine.Experimental.Rendering.TextureCreationFlags>())
			{
				return new UnityEngine.CubemapArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Experimental.Rendering.GraphicsFormat>(), parameters[3].ToObject<UnityEngine.Experimental.Rendering.TextureCreationFlags>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.TextureFormat, System.Boolean>())
			{
				return new UnityEngine.CubemapArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.TextureFormat>(), parameters[3].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.TextureFormat, System.Boolean, System.Boolean>())
			{
				return new UnityEngine.CubemapArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.TextureFormat>(), parameters[3].ToObject<System.Boolean>(), parameters[4].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CubemapArray.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CubemapArray.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.CubemapArray);
		}

		static private void Apply(UnityEngine.CubemapArray instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CubemapArray.Apply has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.Color[] GetPixels(UnityEngine.CubemapArray instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.CubemapFace, System.Int32>())
			{
				return instance.GetPixels(parameters[0].ToObject<UnityEngine.CubemapFace>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.CubemapFace, System.Int32, System.Int32>())
			{
				return instance.GetPixels(parameters[0].ToObject<UnityEngine.CubemapFace>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CubemapArray.GetPixels has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CubemapArray.GetPixels has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.Color32[] GetPixels32(UnityEngine.CubemapArray instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.CubemapFace, System.Int32>())
			{
				return instance.GetPixels32(parameters[0].ToObject<UnityEngine.CubemapFace>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.CubemapFace, System.Int32, System.Int32>())
			{
				return instance.GetPixels32(parameters[0].ToObject<UnityEngine.CubemapFace>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CubemapArray.GetPixels32 has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CubemapArray.GetPixels32 has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void SetPixels(UnityEngine.CubemapArray instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Color[], UnityEngine.CubemapFace, System.Int32>())
			{
				instance.SetPixels(parameters[0].ToObject<UnityEngine.Color[]>(), parameters[1].ToObject<UnityEngine.CubemapFace>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Color[], UnityEngine.CubemapFace, System.Int32, System.Int32>())
			{
				instance.SetPixels(parameters[0].ToObject<UnityEngine.Color[]>(), parameters[1].ToObject<UnityEngine.CubemapFace>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CubemapArray.SetPixels has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CubemapArray.SetPixels has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetPixels32(UnityEngine.CubemapArray instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Color32[], UnityEngine.CubemapFace, System.Int32>())
			{
				instance.SetPixels32(parameters[0].ToObject<UnityEngine.Color32[]>(), parameters[1].ToObject<UnityEngine.CubemapFace>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Color32[], UnityEngine.CubemapFace, System.Int32, System.Int32>())
			{
				instance.SetPixels32(parameters[0].ToObject<UnityEngine.Color32[]>(), parameters[1].ToObject<UnityEngine.CubemapFace>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CubemapArray.SetPixels32 has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CubemapArray.SetPixels32 has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 get_cubemapCount(UnityEngine.CubemapArray instance)
		{
			return instance.cubemapCount;
		}

		static private UnityEngine.TextureFormat get_format(UnityEngine.CubemapArray instance)
		{
			return instance.format;
		}

		static private System.Boolean get_isReadable(UnityEngine.CubemapArray instance)
		{
			return instance.isReadable;
		}

	}
}
