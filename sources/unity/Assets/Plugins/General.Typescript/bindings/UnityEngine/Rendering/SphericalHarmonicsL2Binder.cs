using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingSphericalHarmonicsL2
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Rendering.SphericalHarmonicsL2> self = space.DeclareClass<UnityEngine.Rendering.SphericalHarmonicsL2>();
			self.BindConstructor();
			self.BindInstanceFunction("AddAmbientLight", AddAmbientLight);
			self.BindInstanceFunction("AddDirectionalLight", AddDirectionalLight);
			self.BindInstanceFunction("Clear", Clear);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("Evaluate", Evaluate);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
		}

		static private void AddAmbientLight(UnityEngine.Rendering.SphericalHarmonicsL2 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Color>())
			{
				instance.AddAmbientLight(parameters[0].ToObject<UnityEngine.Color>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.SphericalHarmonicsL2.AddAmbientLight has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.SphericalHarmonicsL2.AddAmbientLight has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void AddDirectionalLight(UnityEngine.Rendering.SphericalHarmonicsL2 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Color, System.Single>())
			{
				instance.AddDirectionalLight(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Color>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.SphericalHarmonicsL2.AddDirectionalLight has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.SphericalHarmonicsL2.AddDirectionalLight has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Clear(UnityEngine.Rendering.SphericalHarmonicsL2 instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Clear();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.SphericalHarmonicsL2.Clear has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean Equals(UnityEngine.Rendering.SphericalHarmonicsL2 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.SphericalHarmonicsL2>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Rendering.SphericalHarmonicsL2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.SphericalHarmonicsL2.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.SphericalHarmonicsL2.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void Evaluate(UnityEngine.Rendering.SphericalHarmonicsL2 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3[], UnityEngine.Color[]>())
			{
				instance.Evaluate(parameters[0].ToObject<UnityEngine.Vector3[]>(), parameters[1].ToObject<UnityEngine.Color[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.SphericalHarmonicsL2.Evaluate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.SphericalHarmonicsL2.Evaluate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 GetHashCode(UnityEngine.Rendering.SphericalHarmonicsL2 instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetHashCode();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.SphericalHarmonicsL2.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

	}
}
