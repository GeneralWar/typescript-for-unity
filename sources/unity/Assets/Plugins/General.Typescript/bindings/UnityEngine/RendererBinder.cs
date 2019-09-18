using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderer
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Renderer> self = space.DeclareClass<UnityEngine.Renderer, UnityEngine.Component>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("GetPropertyBlock", GetPropertyBlock);
			self.BindInstanceFunction("HasPropertyBlock", HasPropertyBlock);
			self.BindInstanceFunction("SetPropertyBlock", SetPropertyBlock);
			self.BindInstanceProperty("bounds", get_bounds, null);
			self.BindInstanceProperty("material", get_material, set_material);
			self.BindInstanceProperty("materials", get_materials, set_materials);
			self.BindInstanceProperty("realtimeLightmapScaleOffset", get_realtimeLightmapScaleOffset, set_realtimeLightmapScaleOffset);
			self.BindInstanceProperty("lightmapScaleOffset", get_lightmapScaleOffset, set_lightmapScaleOffset);
			self.BindInstanceProperty("realtimeLightmapIndex", get_realtimeLightmapIndex, set_realtimeLightmapIndex);
			self.BindInstanceProperty("lightmapIndex", get_lightmapIndex, set_lightmapIndex);
			self.BindInstanceProperty("probeAnchor", get_probeAnchor, set_probeAnchor);
			self.BindInstanceProperty("lightProbeProxyVolumeOverride", get_lightProbeProxyVolumeOverride, set_lightProbeProxyVolumeOverride);
			self.BindInstanceProperty("localToWorldMatrix", get_localToWorldMatrix, null);
			self.BindInstanceProperty("worldToLocalMatrix", get_worldToLocalMatrix, null);
			self.BindInstanceProperty("isPartOfStaticBatch", get_isPartOfStaticBatch, null);
			self.BindInstanceProperty("sharedMaterial", get_sharedMaterial, set_sharedMaterial);
			self.BindInstanceProperty("allowOcclusionWhenDynamic", get_allowOcclusionWhenDynamic, set_allowOcclusionWhenDynamic);
			self.BindInstanceProperty("sortingLayerID", get_sortingLayerID, set_sortingLayerID);
			self.BindInstanceProperty("sortingLayerName", get_sortingLayerName, set_sortingLayerName);
			self.BindInstanceProperty("rendererPriority", get_rendererPriority, set_rendererPriority);
			self.BindInstanceProperty("renderingLayerMask", get_renderingLayerMask, set_renderingLayerMask);
			self.BindInstanceProperty("reflectionProbeUsage", get_reflectionProbeUsage, set_reflectionProbeUsage);
			self.BindInstanceProperty("lightProbeUsage", get_lightProbeUsage, set_lightProbeUsage);
			self.BindInstanceProperty("motionVectorGenerationMode", get_motionVectorGenerationMode, set_motionVectorGenerationMode);
			self.BindInstanceProperty("receiveShadows", get_receiveShadows, set_receiveShadows);
			self.BindInstanceProperty("shadowCastingMode", get_shadowCastingMode, set_shadowCastingMode);
			self.BindInstanceProperty("isVisible", get_isVisible, null);
			self.BindInstanceProperty("enabled", get_enabled, set_enabled);
			self.BindInstanceProperty("sortingOrder", get_sortingOrder, set_sortingOrder);
			self.BindInstanceProperty("sharedMaterials", get_sharedMaterials, set_sharedMaterials);
		}

		static private UnityEngine.Renderer Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Renderer();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Renderer.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Renderer);
		}

		static private void GetPropertyBlock(UnityEngine.Renderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.MaterialPropertyBlock>())
			{
				instance.GetPropertyBlock(parameters[0].ToObject<UnityEngine.MaterialPropertyBlock>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.MaterialPropertyBlock, System.Int32>())
			{
				instance.GetPropertyBlock(parameters[0].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Renderer.GetPropertyBlock has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Renderer.GetPropertyBlock has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean HasPropertyBlock(UnityEngine.Renderer instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.HasPropertyBlock();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Renderer.HasPropertyBlock has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private void SetPropertyBlock(UnityEngine.Renderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.MaterialPropertyBlock>())
			{
				instance.SetPropertyBlock(parameters[0].ToObject<UnityEngine.MaterialPropertyBlock>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.MaterialPropertyBlock, System.Int32>())
			{
				instance.SetPropertyBlock(parameters[0].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Renderer.SetPropertyBlock has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Renderer.SetPropertyBlock has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Bounds get_bounds(UnityEngine.Renderer instance)
		{
			return instance.bounds;
		}

		static private UnityEngine.Material get_material(UnityEngine.Renderer instance)
		{
			return instance.material;
		}

		static private void set_material(UnityEngine.Renderer instance, UnityEngine.Material value)
		{
			instance.material = value;
		}

		static private UnityEngine.Material[] get_materials(UnityEngine.Renderer instance)
		{
			return instance.materials;
		}

		static private void set_materials(UnityEngine.Renderer instance, UnityEngine.Material[] value)
		{
			instance.materials = value;
		}

		static private UnityEngine.Vector4 get_realtimeLightmapScaleOffset(UnityEngine.Renderer instance)
		{
			return instance.realtimeLightmapScaleOffset;
		}

		static private void set_realtimeLightmapScaleOffset(UnityEngine.Renderer instance, UnityEngine.Vector4 value)
		{
			instance.realtimeLightmapScaleOffset = value;
		}

		static private UnityEngine.Vector4 get_lightmapScaleOffset(UnityEngine.Renderer instance)
		{
			return instance.lightmapScaleOffset;
		}

		static private void set_lightmapScaleOffset(UnityEngine.Renderer instance, UnityEngine.Vector4 value)
		{
			instance.lightmapScaleOffset = value;
		}

		static private System.Int32 get_realtimeLightmapIndex(UnityEngine.Renderer instance)
		{
			return instance.realtimeLightmapIndex;
		}

		static private void set_realtimeLightmapIndex(UnityEngine.Renderer instance, System.Int32 value)
		{
			instance.realtimeLightmapIndex = value;
		}

		static private System.Int32 get_lightmapIndex(UnityEngine.Renderer instance)
		{
			return instance.lightmapIndex;
		}

		static private void set_lightmapIndex(UnityEngine.Renderer instance, System.Int32 value)
		{
			instance.lightmapIndex = value;
		}

		static private UnityEngine.Transform get_probeAnchor(UnityEngine.Renderer instance)
		{
			return instance.probeAnchor;
		}

		static private void set_probeAnchor(UnityEngine.Renderer instance, UnityEngine.Transform value)
		{
			instance.probeAnchor = value;
		}

		static private UnityEngine.GameObject get_lightProbeProxyVolumeOverride(UnityEngine.Renderer instance)
		{
			return instance.lightProbeProxyVolumeOverride;
		}

		static private void set_lightProbeProxyVolumeOverride(UnityEngine.Renderer instance, UnityEngine.GameObject value)
		{
			instance.lightProbeProxyVolumeOverride = value;
		}

		static private UnityEngine.Matrix4x4 get_localToWorldMatrix(UnityEngine.Renderer instance)
		{
			return instance.localToWorldMatrix;
		}

		static private UnityEngine.Matrix4x4 get_worldToLocalMatrix(UnityEngine.Renderer instance)
		{
			return instance.worldToLocalMatrix;
		}

		static private System.Boolean get_isPartOfStaticBatch(UnityEngine.Renderer instance)
		{
			return instance.isPartOfStaticBatch;
		}

		static private UnityEngine.Material get_sharedMaterial(UnityEngine.Renderer instance)
		{
			return instance.sharedMaterial;
		}

		static private void set_sharedMaterial(UnityEngine.Renderer instance, UnityEngine.Material value)
		{
			instance.sharedMaterial = value;
		}

		static private System.Boolean get_allowOcclusionWhenDynamic(UnityEngine.Renderer instance)
		{
			return instance.allowOcclusionWhenDynamic;
		}

		static private void set_allowOcclusionWhenDynamic(UnityEngine.Renderer instance, System.Boolean value)
		{
			instance.allowOcclusionWhenDynamic = value;
		}

		static private System.Int32 get_sortingLayerID(UnityEngine.Renderer instance)
		{
			return instance.sortingLayerID;
		}

		static private void set_sortingLayerID(UnityEngine.Renderer instance, System.Int32 value)
		{
			instance.sortingLayerID = value;
		}

		static private System.String get_sortingLayerName(UnityEngine.Renderer instance)
		{
			return instance.sortingLayerName;
		}

		static private void set_sortingLayerName(UnityEngine.Renderer instance, System.String value)
		{
			instance.sortingLayerName = value;
		}

		static private System.Int32 get_rendererPriority(UnityEngine.Renderer instance)
		{
			return instance.rendererPriority;
		}

		static private void set_rendererPriority(UnityEngine.Renderer instance, System.Int32 value)
		{
			instance.rendererPriority = value;
		}

		static private System.UInt32 get_renderingLayerMask(UnityEngine.Renderer instance)
		{
			return instance.renderingLayerMask;
		}

		static private void set_renderingLayerMask(UnityEngine.Renderer instance, System.UInt32 value)
		{
			instance.renderingLayerMask = value;
		}

		static private UnityEngine.Rendering.ReflectionProbeUsage get_reflectionProbeUsage(UnityEngine.Renderer instance)
		{
			return instance.reflectionProbeUsage;
		}

		static private void set_reflectionProbeUsage(UnityEngine.Renderer instance, UnityEngine.Rendering.ReflectionProbeUsage value)
		{
			instance.reflectionProbeUsage = value;
		}

		static private UnityEngine.Rendering.LightProbeUsage get_lightProbeUsage(UnityEngine.Renderer instance)
		{
			return instance.lightProbeUsage;
		}

		static private void set_lightProbeUsage(UnityEngine.Renderer instance, UnityEngine.Rendering.LightProbeUsage value)
		{
			instance.lightProbeUsage = value;
		}

		static private UnityEngine.MotionVectorGenerationMode get_motionVectorGenerationMode(UnityEngine.Renderer instance)
		{
			return instance.motionVectorGenerationMode;
		}

		static private void set_motionVectorGenerationMode(UnityEngine.Renderer instance, UnityEngine.MotionVectorGenerationMode value)
		{
			instance.motionVectorGenerationMode = value;
		}

		static private System.Boolean get_receiveShadows(UnityEngine.Renderer instance)
		{
			return instance.receiveShadows;
		}

		static private void set_receiveShadows(UnityEngine.Renderer instance, System.Boolean value)
		{
			instance.receiveShadows = value;
		}

		static private UnityEngine.Rendering.ShadowCastingMode get_shadowCastingMode(UnityEngine.Renderer instance)
		{
			return instance.shadowCastingMode;
		}

		static private void set_shadowCastingMode(UnityEngine.Renderer instance, UnityEngine.Rendering.ShadowCastingMode value)
		{
			instance.shadowCastingMode = value;
		}

		static private System.Boolean get_isVisible(UnityEngine.Renderer instance)
		{
			return instance.isVisible;
		}

		static private System.Boolean get_enabled(UnityEngine.Renderer instance)
		{
			return instance.enabled;
		}

		static private void set_enabled(UnityEngine.Renderer instance, System.Boolean value)
		{
			instance.enabled = value;
		}

		static private System.Int32 get_sortingOrder(UnityEngine.Renderer instance)
		{
			return instance.sortingOrder;
		}

		static private void set_sortingOrder(UnityEngine.Renderer instance, System.Int32 value)
		{
			instance.sortingOrder = value;
		}

		static private UnityEngine.Material[] get_sharedMaterials(UnityEngine.Renderer instance)
		{
			return instance.sharedMaterials;
		}

		static private void set_sharedMaterials(UnityEngine.Renderer instance, UnityEngine.Material[] value)
		{
			instance.sharedMaterials = value;
		}

	}
}
