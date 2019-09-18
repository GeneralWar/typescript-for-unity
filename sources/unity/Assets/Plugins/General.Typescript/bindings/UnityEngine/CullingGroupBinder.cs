using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCullingGroup
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.CullingGroup> self = space.DeclareClass<UnityEngine.CullingGroup>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Dispose", Dispose);
			self.BindInstanceFunction("EraseSwapBack", EraseSwapBack);
			self.BindInstanceFunction("GetDistance", GetDistance);
			self.BindInstanceFunction("IsVisible", IsVisible);
			self.BindInstanceFunction("QueryIndices", QueryIndices);
			self.BindInstanceFunction("SetBoundingDistances", SetBoundingDistances);
			self.BindInstanceFunction("SetBoundingSphereCount", SetBoundingSphereCount);
			self.BindInstanceFunction("SetBoundingSpheres", SetBoundingSpheres);
			self.BindInstanceFunction("SetDistanceReferencePoint", SetDistanceReferencePoint);
			self.BindInstanceProperty("enabled", get_enabled, set_enabled);
			self.BindInstanceProperty("targetCamera", get_targetCamera, set_targetCamera);
		}

		static private UnityEngine.CullingGroup Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.CullingGroup();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CullingGroup.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.CullingGroup);
		}

		static private void Dispose(UnityEngine.CullingGroup instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Dispose();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CullingGroup.Dispose has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void EraseSwapBack(UnityEngine.CullingGroup instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.EraseSwapBack(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CullingGroup.EraseSwapBack has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CullingGroup.EraseSwapBack has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 GetDistance(UnityEngine.CullingGroup instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetDistance(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CullingGroup.GetDistance has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CullingGroup.GetDistance has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Boolean IsVisible(UnityEngine.CullingGroup instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.IsVisible(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CullingGroup.IsVisible has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CullingGroup.IsVisible has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 QueryIndices(UnityEngine.CullingGroup instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean, System.Int32[], System.Int32>())
			{
				return instance.QueryIndices(parameters[0].ToObject<System.Boolean>(), parameters[1].ToObject<System.Int32[]>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32[], System.Int32>())
			{
				return instance.QueryIndices(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32[]>(), parameters[2].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Boolean, System.Int32, System.Int32[], System.Int32>())
			{
				return instance.QueryIndices(parameters[0].ToObject<System.Boolean>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32[]>(), parameters[3].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CullingGroup.QueryIndices has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CullingGroup.QueryIndices has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void SetBoundingDistances(UnityEngine.CullingGroup instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single[]>())
			{
				instance.SetBoundingDistances(parameters[0].ToObject<System.Single[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CullingGroup.SetBoundingDistances has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CullingGroup.SetBoundingDistances has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetBoundingSphereCount(UnityEngine.CullingGroup instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.SetBoundingSphereCount(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CullingGroup.SetBoundingSphereCount has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CullingGroup.SetBoundingSphereCount has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetBoundingSpheres(UnityEngine.CullingGroup instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.BoundingSphere[]>())
			{
				instance.SetBoundingSpheres(parameters[0].ToObject<UnityEngine.BoundingSphere[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CullingGroup.SetBoundingSpheres has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CullingGroup.SetBoundingSpheres has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetDistanceReferencePoint(UnityEngine.CullingGroup instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				instance.SetDistanceReferencePoint(parameters[0].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Transform>())
			{
				instance.SetDistanceReferencePoint(parameters[0].ToObject<UnityEngine.Transform>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CullingGroup.SetDistanceReferencePoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CullingGroup.SetDistanceReferencePoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean get_enabled(UnityEngine.CullingGroup instance)
		{
			return instance.enabled;
		}

		static private void set_enabled(UnityEngine.CullingGroup instance, System.Boolean value)
		{
			instance.enabled = value;
		}

		static private UnityEngine.Camera get_targetCamera(UnityEngine.CullingGroup instance)
		{
			return instance.targetCamera;
		}

		static private void set_targetCamera(UnityEngine.CullingGroup instance, UnityEngine.Camera value)
		{
			instance.targetCamera = value;
		}

	}
}
