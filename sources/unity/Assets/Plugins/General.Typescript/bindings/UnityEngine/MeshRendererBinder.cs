using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMeshRenderer
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.MeshRenderer> self = space.DeclareClass<UnityEngine.MeshRenderer, UnityEngine.Renderer>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("additionalVertexStreams", get_additionalVertexStreams, set_additionalVertexStreams);
			self.BindInstanceProperty("subMeshStartIndex", get_subMeshStartIndex, null);
		}

		static private UnityEngine.MeshRenderer Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.MeshRenderer();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.MeshRenderer.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.MeshRenderer);
		}

		static private UnityEngine.Mesh get_additionalVertexStreams(UnityEngine.MeshRenderer instance, string name)
		{
			return instance.additionalVertexStreams;
		}

		static private void set_additionalVertexStreams(UnityEngine.MeshRenderer instance, string name, UnityEngine.Mesh value)
		{
			instance.additionalVertexStreams = value;
		}

		static private System.Int32 get_subMeshStartIndex(UnityEngine.MeshRenderer instance, string name)
		{
			return instance.subMeshStartIndex;
		}

	}
}
