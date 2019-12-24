using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMeshFilter
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.MeshFilter> self = space.DeclareClass<UnityEngine.MeshFilter, UnityEngine.Component>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("sharedMesh", get_sharedMesh, set_sharedMesh);
			self.BindInstanceProperty("mesh", get_mesh, set_mesh);
		}

		static private UnityEngine.MeshFilter Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.MeshFilter();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.MeshFilter.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.MeshFilter);
		}

		static private UnityEngine.Mesh get_sharedMesh(UnityEngine.MeshFilter instance, string name)
		{
			return instance.sharedMesh;
		}

		static private void set_sharedMesh(UnityEngine.MeshFilter instance, string name, UnityEngine.Mesh value)
		{
			instance.sharedMesh = value;
		}

		static private UnityEngine.Mesh get_mesh(UnityEngine.MeshFilter instance, string name)
		{
			return instance.mesh;
		}

		static private void set_mesh(UnityEngine.MeshFilter instance, string name, UnityEngine.Mesh value)
		{
			instance.mesh = value;
		}

	}
}
