using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSkinnedMeshRenderer
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.SkinnedMeshRenderer> self = space.DeclareClass<UnityEngine.SkinnedMeshRenderer, UnityEngine.Renderer>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("BakeMesh", BakeMesh);
			self.BindInstanceFunction("GetBlendShapeWeight", GetBlendShapeWeight);
			self.BindInstanceFunction("SetBlendShapeWeight", SetBlendShapeWeight);
			self.BindInstanceProperty("quality", get_quality, set_quality);
			self.BindInstanceProperty("updateWhenOffscreen", get_updateWhenOffscreen, set_updateWhenOffscreen);
			self.BindInstanceProperty("forceMatrixRecalculationPerRender", get_forceMatrixRecalculationPerRender, set_forceMatrixRecalculationPerRender);
			self.BindInstanceProperty("rootBone", get_rootBone, set_rootBone);
			self.BindInstanceProperty("bones", get_bones, set_bones);
			self.BindInstanceProperty("sharedMesh", get_sharedMesh, set_sharedMesh);
			self.BindInstanceProperty("skinnedMotionVectors", get_skinnedMotionVectors, set_skinnedMotionVectors);
			self.BindInstanceProperty("localBounds", get_localBounds, set_localBounds);
		}

		static private UnityEngine.SkinnedMeshRenderer Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.SkinnedMeshRenderer();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.SkinnedMeshRenderer.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.SkinnedMeshRenderer);
		}

		static private void BakeMesh(UnityEngine.SkinnedMeshRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Mesh>())
			{
				instance.BakeMesh(parameters[0].ToObject<UnityEngine.Mesh>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SkinnedMeshRenderer.BakeMesh has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SkinnedMeshRenderer.BakeMesh has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Single GetBlendShapeWeight(UnityEngine.SkinnedMeshRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetBlendShapeWeight(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SkinnedMeshRenderer.GetBlendShapeWeight has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SkinnedMeshRenderer.GetBlendShapeWeight has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private void SetBlendShapeWeight(UnityEngine.SkinnedMeshRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Single>())
			{
				instance.SetBlendShapeWeight(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SkinnedMeshRenderer.SetBlendShapeWeight has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SkinnedMeshRenderer.SetBlendShapeWeight has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.SkinQuality get_quality(UnityEngine.SkinnedMeshRenderer instance)
		{
			return instance.quality;
		}

		static private void set_quality(UnityEngine.SkinnedMeshRenderer instance, UnityEngine.SkinQuality value)
		{
			instance.quality = value;
		}

		static private System.Boolean get_updateWhenOffscreen(UnityEngine.SkinnedMeshRenderer instance)
		{
			return instance.updateWhenOffscreen;
		}

		static private void set_updateWhenOffscreen(UnityEngine.SkinnedMeshRenderer instance, System.Boolean value)
		{
			instance.updateWhenOffscreen = value;
		}

		static private System.Boolean get_forceMatrixRecalculationPerRender(UnityEngine.SkinnedMeshRenderer instance)
		{
			return instance.forceMatrixRecalculationPerRender;
		}

		static private void set_forceMatrixRecalculationPerRender(UnityEngine.SkinnedMeshRenderer instance, System.Boolean value)
		{
			instance.forceMatrixRecalculationPerRender = value;
		}

		static private UnityEngine.Transform get_rootBone(UnityEngine.SkinnedMeshRenderer instance)
		{
			return instance.rootBone;
		}

		static private void set_rootBone(UnityEngine.SkinnedMeshRenderer instance, UnityEngine.Transform value)
		{
			instance.rootBone = value;
		}

		static private UnityEngine.Transform[] get_bones(UnityEngine.SkinnedMeshRenderer instance)
		{
			return instance.bones;
		}

		static private void set_bones(UnityEngine.SkinnedMeshRenderer instance, UnityEngine.Transform[] value)
		{
			instance.bones = value;
		}

		static private UnityEngine.Mesh get_sharedMesh(UnityEngine.SkinnedMeshRenderer instance)
		{
			return instance.sharedMesh;
		}

		static private void set_sharedMesh(UnityEngine.SkinnedMeshRenderer instance, UnityEngine.Mesh value)
		{
			instance.sharedMesh = value;
		}

		static private System.Boolean get_skinnedMotionVectors(UnityEngine.SkinnedMeshRenderer instance)
		{
			return instance.skinnedMotionVectors;
		}

		static private void set_skinnedMotionVectors(UnityEngine.SkinnedMeshRenderer instance, System.Boolean value)
		{
			instance.skinnedMotionVectors = value;
		}

		static private UnityEngine.Bounds get_localBounds(UnityEngine.SkinnedMeshRenderer instance)
		{
			return instance.localBounds;
		}

		static private void set_localBounds(UnityEngine.SkinnedMeshRenderer instance, UnityEngine.Bounds value)
		{
			instance.localBounds = value;
		}

	}
}
