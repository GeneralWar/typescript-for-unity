using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCombineInstance
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.CombineInstance> self = space.DeclareClass<UnityEngine.CombineInstance>();
			self.BindConstructor();
			self.BindInstanceProperty("mesh", get_mesh, set_mesh);
			self.BindInstanceProperty("subMeshIndex", get_subMeshIndex, set_subMeshIndex);
			self.BindInstanceProperty("transform", get_transform, set_transform);
			self.BindInstanceProperty("lightmapScaleOffset", get_lightmapScaleOffset, set_lightmapScaleOffset);
			self.BindInstanceProperty("realtimeLightmapScaleOffset", get_realtimeLightmapScaleOffset, set_realtimeLightmapScaleOffset);
		}

		static private UnityEngine.Mesh get_mesh(UnityEngine.CombineInstance instance, string name)
		{
			return instance.mesh;
		}

		static private void set_mesh(UnityEngine.CombineInstance instance, string name, UnityEngine.Mesh value)
		{
			instance.mesh = value;
		}

		static private System.Int32 get_subMeshIndex(UnityEngine.CombineInstance instance, string name)
		{
			return instance.subMeshIndex;
		}

		static private void set_subMeshIndex(UnityEngine.CombineInstance instance, string name, System.Int32 value)
		{
			instance.subMeshIndex = value;
		}

		static private UnityEngine.Matrix4x4 get_transform(UnityEngine.CombineInstance instance, string name)
		{
			return instance.transform;
		}

		static private void set_transform(UnityEngine.CombineInstance instance, string name, UnityEngine.Matrix4x4 value)
		{
			instance.transform = value;
		}

		static private UnityEngine.Vector4 get_lightmapScaleOffset(UnityEngine.CombineInstance instance, string name)
		{
			return instance.lightmapScaleOffset;
		}

		static private void set_lightmapScaleOffset(UnityEngine.CombineInstance instance, string name, UnityEngine.Vector4 value)
		{
			instance.lightmapScaleOffset = value;
		}

		static private UnityEngine.Vector4 get_realtimeLightmapScaleOffset(UnityEngine.CombineInstance instance, string name)
		{
			return instance.realtimeLightmapScaleOffset;
		}

		static private void set_realtimeLightmapScaleOffset(UnityEngine.CombineInstance instance, string name, UnityEngine.Vector4 value)
		{
			instance.realtimeLightmapScaleOffset = value;
		}

	}
}
