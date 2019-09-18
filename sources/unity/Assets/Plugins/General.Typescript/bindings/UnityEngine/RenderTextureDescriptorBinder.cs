using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderTextureDescriptor
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.RenderTextureDescriptor> self = space.DeclareClass<UnityEngine.RenderTextureDescriptor>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("width", get_width, set_width);
			self.BindInstanceProperty("height", get_height, set_height);
			self.BindInstanceProperty("msaaSamples", get_msaaSamples, set_msaaSamples);
			self.BindInstanceProperty("volumeDepth", get_volumeDepth, set_volumeDepth);
			self.BindInstanceProperty("colorFormat", get_colorFormat, set_colorFormat);
			self.BindInstanceProperty("depthBufferBits", get_depthBufferBits, set_depthBufferBits);
			self.BindInstanceProperty("dimension", get_dimension, set_dimension);
			self.BindInstanceProperty("shadowSamplingMode", get_shadowSamplingMode, set_shadowSamplingMode);
			self.BindInstanceProperty("vrUsage", get_vrUsage, set_vrUsage);
			self.BindInstanceProperty("flags", get_flags, null);
			self.BindInstanceProperty("memoryless", get_memoryless, set_memoryless);
			self.BindInstanceProperty("sRGB", get_sRGB, set_sRGB);
			self.BindInstanceProperty("useMipMap", get_useMipMap, set_useMipMap);
			self.BindInstanceProperty("autoGenerateMips", get_autoGenerateMips, set_autoGenerateMips);
			self.BindInstanceProperty("enableRandomWrite", get_enableRandomWrite, set_enableRandomWrite);
			self.BindInstanceProperty("bindMS", get_bindMS, set_bindMS);
		}

		static private UnityEngine.RenderTextureDescriptor Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return new UnityEngine.RenderTextureDescriptor(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.RenderTextureFormat>())
			{
				return new UnityEngine.RenderTextureDescriptor(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.RenderTextureFormat>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.RenderTextureFormat, System.Int32>())
			{
				return new UnityEngine.RenderTextureDescriptor(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.RenderTextureFormat>(), parameters[3].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RenderTextureDescriptor.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RenderTextureDescriptor.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.RenderTextureDescriptor);
		}

		static private System.Int32 get_width(UnityEngine.RenderTextureDescriptor instance)
		{
			return instance.width;
		}

		static private void set_width(UnityEngine.RenderTextureDescriptor instance, System.Int32 value)
		{
			instance.width = value;
		}

		static private System.Int32 get_height(UnityEngine.RenderTextureDescriptor instance)
		{
			return instance.height;
		}

		static private void set_height(UnityEngine.RenderTextureDescriptor instance, System.Int32 value)
		{
			instance.height = value;
		}

		static private System.Int32 get_msaaSamples(UnityEngine.RenderTextureDescriptor instance)
		{
			return instance.msaaSamples;
		}

		static private void set_msaaSamples(UnityEngine.RenderTextureDescriptor instance, System.Int32 value)
		{
			instance.msaaSamples = value;
		}

		static private System.Int32 get_volumeDepth(UnityEngine.RenderTextureDescriptor instance)
		{
			return instance.volumeDepth;
		}

		static private void set_volumeDepth(UnityEngine.RenderTextureDescriptor instance, System.Int32 value)
		{
			instance.volumeDepth = value;
		}

		static private UnityEngine.RenderTextureFormat get_colorFormat(UnityEngine.RenderTextureDescriptor instance)
		{
			return instance.colorFormat;
		}

		static private void set_colorFormat(UnityEngine.RenderTextureDescriptor instance, UnityEngine.RenderTextureFormat value)
		{
			instance.colorFormat = value;
		}

		static private System.Int32 get_depthBufferBits(UnityEngine.RenderTextureDescriptor instance)
		{
			return instance.depthBufferBits;
		}

		static private void set_depthBufferBits(UnityEngine.RenderTextureDescriptor instance, System.Int32 value)
		{
			instance.depthBufferBits = value;
		}

		static private UnityEngine.Rendering.TextureDimension get_dimension(UnityEngine.RenderTextureDescriptor instance)
		{
			return instance.dimension;
		}

		static private void set_dimension(UnityEngine.RenderTextureDescriptor instance, UnityEngine.Rendering.TextureDimension value)
		{
			instance.dimension = value;
		}

		static private UnityEngine.Rendering.ShadowSamplingMode get_shadowSamplingMode(UnityEngine.RenderTextureDescriptor instance)
		{
			return instance.shadowSamplingMode;
		}

		static private void set_shadowSamplingMode(UnityEngine.RenderTextureDescriptor instance, UnityEngine.Rendering.ShadowSamplingMode value)
		{
			instance.shadowSamplingMode = value;
		}

		static private UnityEngine.VRTextureUsage get_vrUsage(UnityEngine.RenderTextureDescriptor instance)
		{
			return instance.vrUsage;
		}

		static private void set_vrUsage(UnityEngine.RenderTextureDescriptor instance, UnityEngine.VRTextureUsage value)
		{
			instance.vrUsage = value;
		}

		static private UnityEngine.RenderTextureCreationFlags get_flags(UnityEngine.RenderTextureDescriptor instance)
		{
			return instance.flags;
		}

		static private UnityEngine.RenderTextureMemoryless get_memoryless(UnityEngine.RenderTextureDescriptor instance)
		{
			return instance.memoryless;
		}

		static private void set_memoryless(UnityEngine.RenderTextureDescriptor instance, UnityEngine.RenderTextureMemoryless value)
		{
			instance.memoryless = value;
		}

		static private System.Boolean get_sRGB(UnityEngine.RenderTextureDescriptor instance)
		{
			return instance.sRGB;
		}

		static private void set_sRGB(UnityEngine.RenderTextureDescriptor instance, System.Boolean value)
		{
			instance.sRGB = value;
		}

		static private System.Boolean get_useMipMap(UnityEngine.RenderTextureDescriptor instance)
		{
			return instance.useMipMap;
		}

		static private void set_useMipMap(UnityEngine.RenderTextureDescriptor instance, System.Boolean value)
		{
			instance.useMipMap = value;
		}

		static private System.Boolean get_autoGenerateMips(UnityEngine.RenderTextureDescriptor instance)
		{
			return instance.autoGenerateMips;
		}

		static private void set_autoGenerateMips(UnityEngine.RenderTextureDescriptor instance, System.Boolean value)
		{
			instance.autoGenerateMips = value;
		}

		static private System.Boolean get_enableRandomWrite(UnityEngine.RenderTextureDescriptor instance)
		{
			return instance.enableRandomWrite;
		}

		static private void set_enableRandomWrite(UnityEngine.RenderTextureDescriptor instance, System.Boolean value)
		{
			instance.enableRandomWrite = value;
		}

		static private System.Boolean get_bindMS(UnityEngine.RenderTextureDescriptor instance)
		{
			return instance.bindMS;
		}

		static private void set_bindMS(UnityEngine.RenderTextureDescriptor instance, System.Boolean value)
		{
			instance.bindMS = value;
		}

	}
}
