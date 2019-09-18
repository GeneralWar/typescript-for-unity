using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCustomRenderTexture
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.CustomRenderTexture> self = space.DeclareClass<UnityEngine.CustomRenderTexture, UnityEngine.RenderTexture>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("ClearUpdateZones", ClearUpdateZones);
			self.BindInstanceFunction("Initialize", Initialize);
			self.BindInstanceFunction("SetUpdateZones", SetUpdateZones);
			self.BindInstanceFunction("Update", Update);
			self.BindInstanceProperty("material", get_material, set_material);
			self.BindInstanceProperty("initializationMaterial", get_initializationMaterial, set_initializationMaterial);
			self.BindInstanceProperty("initializationTexture", get_initializationTexture, set_initializationTexture);
			self.BindInstanceProperty("initializationSource", get_initializationSource, set_initializationSource);
			self.BindInstanceProperty("initializationColor", get_initializationColor, set_initializationColor);
			self.BindInstanceProperty("updateMode", get_updateMode, set_updateMode);
			self.BindInstanceProperty("initializationMode", get_initializationMode, set_initializationMode);
			self.BindInstanceProperty("updateZoneSpace", get_updateZoneSpace, set_updateZoneSpace);
			self.BindInstanceProperty("shaderPass", get_shaderPass, set_shaderPass);
			self.BindInstanceProperty("cubemapFaceMask", get_cubemapFaceMask, set_cubemapFaceMask);
			self.BindInstanceProperty("doubleBuffered", get_doubleBuffered, set_doubleBuffered);
			self.BindInstanceProperty("wrapUpdateZones", get_wrapUpdateZones, set_wrapUpdateZones);
		}

		static private UnityEngine.CustomRenderTexture Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return new UnityEngine.CustomRenderTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.RenderTextureFormat>())
			{
				return new UnityEngine.CustomRenderTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.RenderTextureFormat>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.Experimental.Rendering.GraphicsFormat>())
			{
				return new UnityEngine.CustomRenderTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Experimental.Rendering.GraphicsFormat>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite>())
			{
				return new UnityEngine.CustomRenderTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.RenderTextureFormat>(), parameters[3].ToObject<UnityEngine.RenderTextureReadWrite>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CustomRenderTexture.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CustomRenderTexture.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.CustomRenderTexture);
		}

		static private void ClearUpdateZones(UnityEngine.CustomRenderTexture instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ClearUpdateZones();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CustomRenderTexture.ClearUpdateZones has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Initialize(UnityEngine.CustomRenderTexture instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Initialize();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CustomRenderTexture.Initialize has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetUpdateZones(UnityEngine.CustomRenderTexture instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.CustomRenderTextureUpdateZone[]>())
			{
				instance.SetUpdateZones(parameters[0].ToObject<UnityEngine.CustomRenderTextureUpdateZone[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CustomRenderTexture.SetUpdateZones has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CustomRenderTexture.SetUpdateZones has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Update(UnityEngine.CustomRenderTexture instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Update();
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.Update(parameters[0].ToObject<System.Int32>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CustomRenderTexture.Update has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.Material get_material(UnityEngine.CustomRenderTexture instance)
		{
			return instance.material;
		}

		static private void set_material(UnityEngine.CustomRenderTexture instance, UnityEngine.Material value)
		{
			instance.material = value;
		}

		static private UnityEngine.Material get_initializationMaterial(UnityEngine.CustomRenderTexture instance)
		{
			return instance.initializationMaterial;
		}

		static private void set_initializationMaterial(UnityEngine.CustomRenderTexture instance, UnityEngine.Material value)
		{
			instance.initializationMaterial = value;
		}

		static private UnityEngine.Texture get_initializationTexture(UnityEngine.CustomRenderTexture instance)
		{
			return instance.initializationTexture;
		}

		static private void set_initializationTexture(UnityEngine.CustomRenderTexture instance, UnityEngine.Texture value)
		{
			instance.initializationTexture = value;
		}

		static private UnityEngine.CustomRenderTextureInitializationSource get_initializationSource(UnityEngine.CustomRenderTexture instance)
		{
			return instance.initializationSource;
		}

		static private void set_initializationSource(UnityEngine.CustomRenderTexture instance, UnityEngine.CustomRenderTextureInitializationSource value)
		{
			instance.initializationSource = value;
		}

		static private UnityEngine.Color get_initializationColor(UnityEngine.CustomRenderTexture instance)
		{
			return instance.initializationColor;
		}

		static private void set_initializationColor(UnityEngine.CustomRenderTexture instance, UnityEngine.Color value)
		{
			instance.initializationColor = value;
		}

		static private UnityEngine.CustomRenderTextureUpdateMode get_updateMode(UnityEngine.CustomRenderTexture instance)
		{
			return instance.updateMode;
		}

		static private void set_updateMode(UnityEngine.CustomRenderTexture instance, UnityEngine.CustomRenderTextureUpdateMode value)
		{
			instance.updateMode = value;
		}

		static private UnityEngine.CustomRenderTextureUpdateMode get_initializationMode(UnityEngine.CustomRenderTexture instance)
		{
			return instance.initializationMode;
		}

		static private void set_initializationMode(UnityEngine.CustomRenderTexture instance, UnityEngine.CustomRenderTextureUpdateMode value)
		{
			instance.initializationMode = value;
		}

		static private UnityEngine.CustomRenderTextureUpdateZoneSpace get_updateZoneSpace(UnityEngine.CustomRenderTexture instance)
		{
			return instance.updateZoneSpace;
		}

		static private void set_updateZoneSpace(UnityEngine.CustomRenderTexture instance, UnityEngine.CustomRenderTextureUpdateZoneSpace value)
		{
			instance.updateZoneSpace = value;
		}

		static private System.Int32 get_shaderPass(UnityEngine.CustomRenderTexture instance)
		{
			return instance.shaderPass;
		}

		static private void set_shaderPass(UnityEngine.CustomRenderTexture instance, System.Int32 value)
		{
			instance.shaderPass = value;
		}

		static private System.UInt32 get_cubemapFaceMask(UnityEngine.CustomRenderTexture instance)
		{
			return instance.cubemapFaceMask;
		}

		static private void set_cubemapFaceMask(UnityEngine.CustomRenderTexture instance, System.UInt32 value)
		{
			instance.cubemapFaceMask = value;
		}

		static private System.Boolean get_doubleBuffered(UnityEngine.CustomRenderTexture instance)
		{
			return instance.doubleBuffered;
		}

		static private void set_doubleBuffered(UnityEngine.CustomRenderTexture instance, System.Boolean value)
		{
			instance.doubleBuffered = value;
		}

		static private System.Boolean get_wrapUpdateZones(UnityEngine.CustomRenderTexture instance)
		{
			return instance.wrapUpdateZones;
		}

		static private void set_wrapUpdateZones(UnityEngine.CustomRenderTexture instance, System.Boolean value)
		{
			instance.wrapUpdateZones = value;
		}

	}
}
