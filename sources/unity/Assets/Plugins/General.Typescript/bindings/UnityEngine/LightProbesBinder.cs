using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLightProbes
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.LightProbes> self = space.DeclareClass<UnityEngine.LightProbes, UnityEngine.Object>();
			self.BindConstructor();
			self.BindStaticFunction("CalculateInterpolatedLightAndOcclusionProbes", CalculateInterpolatedLightAndOcclusionProbes);
			self.BindInstanceProperty("positions", get_positions, null);
			self.BindInstanceProperty("bakedProbes", get_bakedProbes, set_bakedProbes);
			self.BindInstanceProperty("count", get_count, null);
			self.BindInstanceProperty("cellCount", get_cellCount, null);
		}

		static private void CalculateInterpolatedLightAndOcclusionProbes(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3[], UnityEngine.Rendering.SphericalHarmonicsL2[], UnityEngine.Vector4[]>())
			{
				UnityEngine.LightProbes.CalculateInterpolatedLightAndOcclusionProbes(parameters[0].ToObject<UnityEngine.Vector3[]>(), parameters[1].ToObject<UnityEngine.Rendering.SphericalHarmonicsL2[]>(), parameters[2].ToObject<UnityEngine.Vector4[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.LightProbes.CalculateInterpolatedLightAndOcclusionProbes has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.LightProbes.CalculateInterpolatedLightAndOcclusionProbes has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Vector3[] get_positions(UnityEngine.LightProbes instance, string name)
		{
			return instance.positions;
		}

		static private UnityEngine.Rendering.SphericalHarmonicsL2[] get_bakedProbes(UnityEngine.LightProbes instance, string name)
		{
			return instance.bakedProbes;
		}

		static private void set_bakedProbes(UnityEngine.LightProbes instance, string name, UnityEngine.Rendering.SphericalHarmonicsL2[] value)
		{
			instance.bakedProbes = value;
		}

		static private System.Int32 get_count(UnityEngine.LightProbes instance, string name)
		{
			return instance.count;
		}

		static private System.Int32 get_cellCount(UnityEngine.LightProbes instance, string name)
		{
			return instance.cellCount;
		}

	}
}
