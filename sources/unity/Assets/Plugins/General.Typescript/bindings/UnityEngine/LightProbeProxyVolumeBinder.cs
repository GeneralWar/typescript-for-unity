using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLightProbeProxyVolume
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.LightProbeProxyVolume> self = space.DeclareClass<UnityEngine.LightProbeProxyVolume, UnityEngine.Behaviour>();
			UnityEngineLightProbeProxyVolumeBoundingBoxMode.Bind(self);
			UnityEngineLightProbeProxyVolumeProbePositionMode.Bind(self);
			UnityEngineLightProbeProxyVolumeQualityMode.Bind(self);
			UnityEngineLightProbeProxyVolumeRefreshMode.Bind(self);
			UnityEngineLightProbeProxyVolumeResolutionMode.Bind(self);
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Update", Update);
			self.BindStaticProperty("isFeatureSupported", get_isFeatureSupported, null);
			self.BindInstanceProperty("boundsGlobal", get_boundsGlobal, null);
			self.BindInstanceProperty("sizeCustom", get_sizeCustom, set_sizeCustom);
			self.BindInstanceProperty("originCustom", get_originCustom, set_originCustom);
			self.BindInstanceProperty("probeDensity", get_probeDensity, set_probeDensity);
			self.BindInstanceProperty("gridResolutionX", get_gridResolutionX, set_gridResolutionX);
			self.BindInstanceProperty("gridResolutionY", get_gridResolutionY, set_gridResolutionY);
			self.BindInstanceProperty("gridResolutionZ", get_gridResolutionZ, set_gridResolutionZ);
		}

		static private UnityEngine.LightProbeProxyVolume Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.LightProbeProxyVolume();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.LightProbeProxyVolume.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.LightProbeProxyVolume);
		}

		static private void Update(UnityEngine.LightProbeProxyVolume instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Update();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.LightProbeProxyVolume.Update has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean get_isFeatureSupported()
		{
			return UnityEngine.LightProbeProxyVolume.isFeatureSupported;
		}

		static private UnityEngine.Bounds get_boundsGlobal(UnityEngine.LightProbeProxyVolume instance)
		{
			return instance.boundsGlobal;
		}

		static private UnityEngine.Vector3 get_sizeCustom(UnityEngine.LightProbeProxyVolume instance)
		{
			return instance.sizeCustom;
		}

		static private void set_sizeCustom(UnityEngine.LightProbeProxyVolume instance, UnityEngine.Vector3 value)
		{
			instance.sizeCustom = value;
		}

		static private UnityEngine.Vector3 get_originCustom(UnityEngine.LightProbeProxyVolume instance)
		{
			return instance.originCustom;
		}

		static private void set_originCustom(UnityEngine.LightProbeProxyVolume instance, UnityEngine.Vector3 value)
		{
			instance.originCustom = value;
		}

		static private System.Single get_probeDensity(UnityEngine.LightProbeProxyVolume instance)
		{
			return instance.probeDensity;
		}

		static private void set_probeDensity(UnityEngine.LightProbeProxyVolume instance, System.Single value)
		{
			instance.probeDensity = value;
		}

		static private System.Int32 get_gridResolutionX(UnityEngine.LightProbeProxyVolume instance)
		{
			return instance.gridResolutionX;
		}

		static private void set_gridResolutionX(UnityEngine.LightProbeProxyVolume instance, System.Int32 value)
		{
			instance.gridResolutionX = value;
		}

		static private System.Int32 get_gridResolutionY(UnityEngine.LightProbeProxyVolume instance)
		{
			return instance.gridResolutionY;
		}

		static private void set_gridResolutionY(UnityEngine.LightProbeProxyVolume instance, System.Int32 value)
		{
			instance.gridResolutionY = value;
		}

		static private System.Int32 get_gridResolutionZ(UnityEngine.LightProbeProxyVolume instance)
		{
			return instance.gridResolutionZ;
		}

		static private void set_gridResolutionZ(UnityEngine.LightProbeProxyVolume instance, System.Int32 value)
		{
			instance.gridResolutionZ = value;
		}

	}
}
