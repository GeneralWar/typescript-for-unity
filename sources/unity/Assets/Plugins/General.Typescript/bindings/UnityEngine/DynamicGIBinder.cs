using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineDynamicGI
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.DynamicGI> self = space.DeclareClass<UnityEngine.DynamicGI>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("SetEmissive", SetEmissive);
			self.BindStaticFunction("SetEnvironmentData", SetEnvironmentData);
			self.BindStaticFunction("UpdateEnvironment", UpdateEnvironment);
			self.BindStaticProperty("indirectScale", get_indirectScale, set_indirectScale);
			self.BindStaticProperty("updateThreshold", get_updateThreshold, set_updateThreshold);
			self.BindStaticProperty("materialUpdateTimeSlice", get_materialUpdateTimeSlice, set_materialUpdateTimeSlice);
			self.BindStaticProperty("synchronousMode", get_synchronousMode, set_synchronousMode);
			self.BindStaticProperty("isConverged", get_isConverged, null);
		}

		static private UnityEngine.DynamicGI Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.DynamicGI();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.DynamicGI.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.DynamicGI);
		}

		static private void SetEmissive(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Renderer, UnityEngine.Color>())
			{
				UnityEngine.DynamicGI.SetEmissive(parameters[0].ToObject<UnityEngine.Renderer>(), parameters[1].ToObject<UnityEngine.Color>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.DynamicGI.SetEmissive has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.DynamicGI.SetEmissive has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetEnvironmentData(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single[]>())
			{
				UnityEngine.DynamicGI.SetEnvironmentData(parameters[0].ToObject<System.Single[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.DynamicGI.SetEnvironmentData has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.DynamicGI.SetEnvironmentData has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void UpdateEnvironment(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.DynamicGI.UpdateEnvironment();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.DynamicGI.UpdateEnvironment has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Single get_indirectScale()
		{
			return UnityEngine.DynamicGI.indirectScale;
		}

		static private void set_indirectScale(System.Single value)
		{
			UnityEngine.DynamicGI.indirectScale = value;
		}

		static private System.Single get_updateThreshold()
		{
			return UnityEngine.DynamicGI.updateThreshold;
		}

		static private void set_updateThreshold(System.Single value)
		{
			UnityEngine.DynamicGI.updateThreshold = value;
		}

		static private System.Int32 get_materialUpdateTimeSlice()
		{
			return UnityEngine.DynamicGI.materialUpdateTimeSlice;
		}

		static private void set_materialUpdateTimeSlice(System.Int32 value)
		{
			UnityEngine.DynamicGI.materialUpdateTimeSlice = value;
		}

		static private System.Boolean get_synchronousMode()
		{
			return UnityEngine.DynamicGI.synchronousMode;
		}

		static private void set_synchronousMode(System.Boolean value)
		{
			UnityEngine.DynamicGI.synchronousMode = value;
		}

		static private System.Boolean get_isConverged()
		{
			return UnityEngine.DynamicGI.isConverged;
		}

	}
}
