using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderTexture
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.RenderTexture> self = space.DeclareClass<UnityEngine.RenderTexture, UnityEngine.Texture>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("GetTemporary", GetTemporary);
			self.BindStaticFunction("ReleaseTemporary", ReleaseTemporary);
			self.BindStaticFunction("SupportsStencil", SupportsStencil);
			self.BindInstanceFunction("ConvertToEquirect", ConvertToEquirect);
			self.BindInstanceFunction("Create", Create);
			self.BindInstanceFunction("DiscardContents", DiscardContents);
			self.BindInstanceFunction("GenerateMips", GenerateMips);
			self.BindInstanceFunction("GetNativeDepthBufferPtr", GetNativeDepthBufferPtr);
			self.BindInstanceFunction("IsCreated", IsCreated);
			self.BindInstanceFunction("MarkRestoreExpected", MarkRestoreExpected);
			self.BindInstanceFunction("Release", Release);
			self.BindInstanceFunction("ResolveAntiAliasedSurface", ResolveAntiAliasedSurface);
			self.BindInstanceFunction("SetGlobalShaderProperty", SetGlobalShaderProperty);
			self.BindStaticProperty("active", get_active, set_active);
			self.BindInstanceProperty("width", get_width, set_width);
			self.BindInstanceProperty("depthBuffer", get_depthBuffer, null);
			self.BindInstanceProperty("colorBuffer", get_colorBuffer, null);
			self.BindInstanceProperty("isPowerOfTwo", get_isPowerOfTwo, set_isPowerOfTwo);
			self.BindInstanceProperty("useDynamicScale", get_useDynamicScale, set_useDynamicScale);
			self.BindInstanceProperty("enableRandomWrite", get_enableRandomWrite, set_enableRandomWrite);
			self.BindInstanceProperty("bindTextureMS", get_bindTextureMS, set_bindTextureMS);
			self.BindInstanceProperty("antiAliasing", get_antiAliasing, set_antiAliasing);
			self.BindInstanceProperty("depth", get_depth, set_depth);
			self.BindInstanceProperty("volumeDepth", get_volumeDepth, set_volumeDepth);
			self.BindInstanceProperty("memorylessMode", get_memorylessMode, set_memorylessMode);
			self.BindInstanceProperty("vrUsage", get_vrUsage, set_vrUsage);
			self.BindInstanceProperty("format", get_format, set_format);
			self.BindInstanceProperty("sRGB", get_sRGB, null);
			self.BindInstanceProperty("useMipMap", get_useMipMap, set_useMipMap);
			self.BindInstanceProperty("dimension", get_dimension, set_dimension);
			self.BindInstanceProperty("height", get_height, set_height);
			self.BindInstanceProperty("autoGenerateMips", get_autoGenerateMips, set_autoGenerateMips);
			self.BindInstanceProperty("descriptor", get_descriptor, set_descriptor);
		}

		static private UnityEngine.RenderTexture Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RenderTextureDescriptor>())
			{
				return new UnityEngine.RenderTexture(parameters[0].ToObject<UnityEngine.RenderTextureDescriptor>());
			}
			if (parameters.CheckTypes<UnityEngine.RenderTexture>())
			{
				return new UnityEngine.RenderTexture(parameters[0].ToObject<UnityEngine.RenderTexture>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32>())
			{
				return new UnityEngine.RenderTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, UnityEngine.Experimental.Rendering.GraphicsFormat>())
			{
				return new UnityEngine.RenderTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.Experimental.Rendering.GraphicsFormat>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, UnityEngine.RenderTextureFormat>())
			{
				return new UnityEngine.RenderTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.RenderTextureFormat>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite>())
			{
				return new UnityEngine.RenderTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.RenderTextureFormat>(), parameters[4].ToObject<UnityEngine.RenderTextureReadWrite>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RenderTexture.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RenderTexture.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.RenderTexture);
		}

		static private UnityEngine.RenderTexture GetTemporary(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RenderTextureDescriptor>())
			{
				return UnityEngine.RenderTexture.GetTemporary(parameters[0].ToObject<UnityEngine.RenderTextureDescriptor>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return UnityEngine.RenderTexture.GetTemporary(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32>())
			{
				return UnityEngine.RenderTexture.GetTemporary(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, UnityEngine.RenderTextureFormat>())
			{
				return UnityEngine.RenderTexture.GetTemporary(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.RenderTextureFormat>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite>())
			{
				return UnityEngine.RenderTexture.GetTemporary(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.RenderTextureFormat>(), parameters[4].ToObject<UnityEngine.RenderTextureReadWrite>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, System.Int32>())
			{
				return UnityEngine.RenderTexture.GetTemporary(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.RenderTextureFormat>(), parameters[4].ToObject<UnityEngine.RenderTextureReadWrite>(), parameters[5].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, System.Int32, UnityEngine.RenderTextureMemoryless>())
			{
				return UnityEngine.RenderTexture.GetTemporary(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.RenderTextureFormat>(), parameters[4].ToObject<UnityEngine.RenderTextureReadWrite>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.RenderTextureMemoryless>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, System.Int32, UnityEngine.RenderTextureMemoryless, UnityEngine.VRTextureUsage>())
			{
				return UnityEngine.RenderTexture.GetTemporary(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.RenderTextureFormat>(), parameters[4].ToObject<UnityEngine.RenderTextureReadWrite>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.RenderTextureMemoryless>(), parameters[7].ToObject<UnityEngine.VRTextureUsage>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, System.Int32, UnityEngine.RenderTextureMemoryless, UnityEngine.VRTextureUsage, System.Boolean>())
			{
				return UnityEngine.RenderTexture.GetTemporary(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.RenderTextureFormat>(), parameters[4].ToObject<UnityEngine.RenderTextureReadWrite>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.RenderTextureMemoryless>(), parameters[7].ToObject<UnityEngine.VRTextureUsage>(), parameters[8].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RenderTexture.GetTemporary has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RenderTexture.GetTemporary has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void ReleaseTemporary(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RenderTexture>())
			{
				UnityEngine.RenderTexture.ReleaseTemporary(parameters[0].ToObject<UnityEngine.RenderTexture>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RenderTexture.ReleaseTemporary has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RenderTexture.ReleaseTemporary has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean SupportsStencil(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RenderTexture>())
			{
				return UnityEngine.RenderTexture.SupportsStencil(parameters[0].ToObject<UnityEngine.RenderTexture>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RenderTexture.SupportsStencil has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RenderTexture.SupportsStencil has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void ConvertToEquirect(UnityEngine.RenderTexture instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RenderTexture, UnityEngine.Camera.MonoOrStereoscopicEye>())
			{
				instance.ConvertToEquirect(parameters[0].ToObject<UnityEngine.RenderTexture>(), parameters[1].ToObject<UnityEngine.Camera.MonoOrStereoscopicEye>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RenderTexture.ConvertToEquirect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RenderTexture.ConvertToEquirect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean Create(UnityEngine.RenderTexture instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.Create();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.RenderTexture.Create has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private void DiscardContents(UnityEngine.RenderTexture instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.DiscardContents();
			}
			if (parameters.CheckTypes<System.Boolean, System.Boolean>())
			{
				instance.DiscardContents(parameters[0].ToObject<System.Boolean>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.RenderTexture.DiscardContents has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void GenerateMips(UnityEngine.RenderTexture instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.GenerateMips();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.RenderTexture.GenerateMips has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.IntPtr GetNativeDepthBufferPtr(UnityEngine.RenderTexture instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetNativeDepthBufferPtr();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.RenderTexture.GetNativeDepthBufferPtr has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.IntPtr);
		}

		static private System.Boolean IsCreated(UnityEngine.RenderTexture instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsCreated();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.RenderTexture.IsCreated has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private void MarkRestoreExpected(UnityEngine.RenderTexture instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.MarkRestoreExpected();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.RenderTexture.MarkRestoreExpected has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Release(UnityEngine.RenderTexture instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Release();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.RenderTexture.Release has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ResolveAntiAliasedSurface(UnityEngine.RenderTexture instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ResolveAntiAliasedSurface();
			}
			if (parameters.CheckTypes<UnityEngine.RenderTexture>())
			{
				instance.ResolveAntiAliasedSurface(parameters[0].ToObject<UnityEngine.RenderTexture>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.RenderTexture.ResolveAntiAliasedSurface has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetGlobalShaderProperty(UnityEngine.RenderTexture instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.SetGlobalShaderProperty(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RenderTexture.SetGlobalShaderProperty has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RenderTexture.SetGlobalShaderProperty has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.RenderTexture get_active()
		{
			return UnityEngine.RenderTexture.active;
		}

		static private void set_active(UnityEngine.RenderTexture value)
		{
			UnityEngine.RenderTexture.active = value;
		}

		static private System.Int32 get_width(UnityEngine.RenderTexture instance)
		{
			return instance.width;
		}

		static private void set_width(UnityEngine.RenderTexture instance, System.Int32 value)
		{
			instance.width = value;
		}

		static private UnityEngine.RenderBuffer get_depthBuffer(UnityEngine.RenderTexture instance)
		{
			return instance.depthBuffer;
		}

		static private UnityEngine.RenderBuffer get_colorBuffer(UnityEngine.RenderTexture instance)
		{
			return instance.colorBuffer;
		}

		static private System.Boolean get_isPowerOfTwo(UnityEngine.RenderTexture instance)
		{
			return instance.isPowerOfTwo;
		}

		static private void set_isPowerOfTwo(UnityEngine.RenderTexture instance, System.Boolean value)
		{
			instance.isPowerOfTwo = value;
		}

		static private System.Boolean get_useDynamicScale(UnityEngine.RenderTexture instance)
		{
			return instance.useDynamicScale;
		}

		static private void set_useDynamicScale(UnityEngine.RenderTexture instance, System.Boolean value)
		{
			instance.useDynamicScale = value;
		}

		static private System.Boolean get_enableRandomWrite(UnityEngine.RenderTexture instance)
		{
			return instance.enableRandomWrite;
		}

		static private void set_enableRandomWrite(UnityEngine.RenderTexture instance, System.Boolean value)
		{
			instance.enableRandomWrite = value;
		}

		static private System.Boolean get_bindTextureMS(UnityEngine.RenderTexture instance)
		{
			return instance.bindTextureMS;
		}

		static private void set_bindTextureMS(UnityEngine.RenderTexture instance, System.Boolean value)
		{
			instance.bindTextureMS = value;
		}

		static private System.Int32 get_antiAliasing(UnityEngine.RenderTexture instance)
		{
			return instance.antiAliasing;
		}

		static private void set_antiAliasing(UnityEngine.RenderTexture instance, System.Int32 value)
		{
			instance.antiAliasing = value;
		}

		static private System.Int32 get_depth(UnityEngine.RenderTexture instance)
		{
			return instance.depth;
		}

		static private void set_depth(UnityEngine.RenderTexture instance, System.Int32 value)
		{
			instance.depth = value;
		}

		static private System.Int32 get_volumeDepth(UnityEngine.RenderTexture instance)
		{
			return instance.volumeDepth;
		}

		static private void set_volumeDepth(UnityEngine.RenderTexture instance, System.Int32 value)
		{
			instance.volumeDepth = value;
		}

		static private UnityEngine.RenderTextureMemoryless get_memorylessMode(UnityEngine.RenderTexture instance)
		{
			return instance.memorylessMode;
		}

		static private void set_memorylessMode(UnityEngine.RenderTexture instance, UnityEngine.RenderTextureMemoryless value)
		{
			instance.memorylessMode = value;
		}

		static private UnityEngine.VRTextureUsage get_vrUsage(UnityEngine.RenderTexture instance)
		{
			return instance.vrUsage;
		}

		static private void set_vrUsage(UnityEngine.RenderTexture instance, UnityEngine.VRTextureUsage value)
		{
			instance.vrUsage = value;
		}

		static private UnityEngine.RenderTextureFormat get_format(UnityEngine.RenderTexture instance)
		{
			return instance.format;
		}

		static private void set_format(UnityEngine.RenderTexture instance, UnityEngine.RenderTextureFormat value)
		{
			instance.format = value;
		}

		static private System.Boolean get_sRGB(UnityEngine.RenderTexture instance)
		{
			return instance.sRGB;
		}

		static private System.Boolean get_useMipMap(UnityEngine.RenderTexture instance)
		{
			return instance.useMipMap;
		}

		static private void set_useMipMap(UnityEngine.RenderTexture instance, System.Boolean value)
		{
			instance.useMipMap = value;
		}

		static private UnityEngine.Rendering.TextureDimension get_dimension(UnityEngine.RenderTexture instance)
		{
			return instance.dimension;
		}

		static private void set_dimension(UnityEngine.RenderTexture instance, UnityEngine.Rendering.TextureDimension value)
		{
			instance.dimension = value;
		}

		static private System.Int32 get_height(UnityEngine.RenderTexture instance)
		{
			return instance.height;
		}

		static private void set_height(UnityEngine.RenderTexture instance, System.Int32 value)
		{
			instance.height = value;
		}

		static private System.Boolean get_autoGenerateMips(UnityEngine.RenderTexture instance)
		{
			return instance.autoGenerateMips;
		}

		static private void set_autoGenerateMips(UnityEngine.RenderTexture instance, System.Boolean value)
		{
			instance.autoGenerateMips = value;
		}

		static private UnityEngine.RenderTextureDescriptor get_descriptor(UnityEngine.RenderTexture instance)
		{
			return instance.descriptor;
		}

		static private void set_descriptor(UnityEngine.RenderTexture instance, UnityEngine.RenderTextureDescriptor value)
		{
			instance.descriptor = value;
		}

	}
}
