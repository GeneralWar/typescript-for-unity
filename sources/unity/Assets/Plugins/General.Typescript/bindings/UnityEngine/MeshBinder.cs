using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMesh
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Mesh> self = space.DeclareClass<UnityEngine.Mesh, UnityEngine.Object>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("AddBlendShapeFrame", AddBlendShapeFrame);
			self.BindInstanceFunction("Clear", Clear);
			self.BindInstanceFunction("ClearBlendShapes", ClearBlendShapes);
			self.BindInstanceFunction("CombineMeshes", CombineMeshes);
			self.BindInstanceFunction("GetBaseVertex", GetBaseVertex);
			self.BindInstanceFunction("GetBlendShapeFrameCount", GetBlendShapeFrameCount);
			self.BindInstanceFunction("GetBlendShapeFrameVertices", GetBlendShapeFrameVertices);
			self.BindInstanceFunction("GetBlendShapeFrameWeight", GetBlendShapeFrameWeight);
			self.BindInstanceFunction("GetBlendShapeIndex", GetBlendShapeIndex);
			self.BindInstanceFunction("GetBlendShapeName", GetBlendShapeName);
			self.BindInstanceFunction("GetIndexCount", GetIndexCount);
			self.BindInstanceFunction("GetIndexStart", GetIndexStart);
			self.BindInstanceFunction("GetIndices", GetIndices);
			self.BindInstanceFunction("GetNativeIndexBufferPtr", GetNativeIndexBufferPtr);
			self.BindInstanceFunction("GetNativeVertexBufferPtr", GetNativeVertexBufferPtr);
			self.BindInstanceFunction("GetTopology", GetTopology);
			self.BindInstanceFunction("GetTriangles", GetTriangles);
			self.BindInstanceFunction("GetUVDistributionMetric", GetUVDistributionMetric);
			self.BindInstanceFunction("MarkDynamic", MarkDynamic);
			self.BindInstanceFunction("RecalculateBounds", RecalculateBounds);
			self.BindInstanceFunction("RecalculateNormals", RecalculateNormals);
			self.BindInstanceFunction("RecalculateTangents", RecalculateTangents);
			self.BindInstanceFunction("SetIndices", SetIndices);
			self.BindInstanceFunction("SetTriangles", SetTriangles);
			self.BindInstanceFunction("UploadMeshData", UploadMeshData);
			self.BindInstanceProperty("indexFormat", get_indexFormat, set_indexFormat);
			self.BindInstanceProperty("colors", get_colors, set_colors);
			self.BindInstanceProperty("uv8", get_uv8, set_uv8);
			self.BindInstanceProperty("uv7", get_uv7, set_uv7);
			self.BindInstanceProperty("uv6", get_uv6, set_uv6);
			self.BindInstanceProperty("uv5", get_uv5, set_uv5);
			self.BindInstanceProperty("uv4", get_uv4, set_uv4);
			self.BindInstanceProperty("uv3", get_uv3, set_uv3);
			self.BindInstanceProperty("uv2", get_uv2, set_uv2);
			self.BindInstanceProperty("uv", get_uv, set_uv);
			self.BindInstanceProperty("colors32", get_colors32, set_colors32);
			self.BindInstanceProperty("tangents", get_tangents, set_tangents);
			self.BindInstanceProperty("vertices", get_vertices, set_vertices);
			self.BindInstanceProperty("bounds", get_bounds, set_bounds);
			self.BindInstanceProperty("subMeshCount", get_subMeshCount, set_subMeshCount);
			self.BindInstanceProperty("vertexCount", get_vertexCount, null);
			self.BindInstanceProperty("isReadable", get_isReadable, null);
			self.BindInstanceProperty("bindposes", get_bindposes, set_bindposes);
			self.BindInstanceProperty("boneWeights", get_boneWeights, set_boneWeights);
			self.BindInstanceProperty("blendShapeCount", get_blendShapeCount, null);
			self.BindInstanceProperty("vertexBufferCount", get_vertexBufferCount, null);
			self.BindInstanceProperty("normals", get_normals, set_normals);
			self.BindInstanceProperty("triangles", get_triangles, set_triangles);
		}

		static private UnityEngine.Mesh Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Mesh();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Mesh);
		}

		static private void AddBlendShapeFrame(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Single, UnityEngine.Vector3[], UnityEngine.Vector3[], UnityEngine.Vector3[]>())
			{
				instance.AddBlendShapeFrame(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.Vector3[]>(), parameters[3].ToObject<UnityEngine.Vector3[]>(), parameters[4].ToObject<UnityEngine.Vector3[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.AddBlendShapeFrame has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.AddBlendShapeFrame has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Clear(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Clear();
			}
			if (parameters.CheckTypes<System.Boolean>())
			{
				instance.Clear(parameters[0].ToObject<System.Boolean>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.Clear has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ClearBlendShapes(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ClearBlendShapes();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.ClearBlendShapes has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void CombineMeshes(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.CombineInstance[]>())
			{
				instance.CombineMeshes(parameters[0].ToObject<UnityEngine.CombineInstance[]>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.CombineInstance[], System.Boolean>())
			{
				instance.CombineMeshes(parameters[0].ToObject<UnityEngine.CombineInstance[]>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.CombineInstance[], System.Boolean, System.Boolean>())
			{
				instance.CombineMeshes(parameters[0].ToObject<UnityEngine.CombineInstance[]>(), parameters[1].ToObject<System.Boolean>(), parameters[2].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.CombineInstance[], System.Boolean, System.Boolean, System.Boolean>())
			{
				instance.CombineMeshes(parameters[0].ToObject<UnityEngine.CombineInstance[]>(), parameters[1].ToObject<System.Boolean>(), parameters[2].ToObject<System.Boolean>(), parameters[3].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.CombineMeshes has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.CombineMeshes has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.UInt32 GetBaseVertex(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetBaseVertex(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.GetBaseVertex has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.GetBaseVertex has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.UInt32);
		}

		static private System.Int32 GetBlendShapeFrameCount(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetBlendShapeFrameCount(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.GetBlendShapeFrameCount has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.GetBlendShapeFrameCount has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void GetBlendShapeFrameVertices(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.Vector3[], UnityEngine.Vector3[], UnityEngine.Vector3[]>())
			{
				instance.GetBlendShapeFrameVertices(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Vector3[]>(), parameters[3].ToObject<UnityEngine.Vector3[]>(), parameters[4].ToObject<UnityEngine.Vector3[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.GetBlendShapeFrameVertices has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.GetBlendShapeFrameVertices has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Single GetBlendShapeFrameWeight(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return instance.GetBlendShapeFrameWeight(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.GetBlendShapeFrameWeight has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.GetBlendShapeFrameWeight has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Int32 GetBlendShapeIndex(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetBlendShapeIndex(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.GetBlendShapeIndex has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.GetBlendShapeIndex has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.String GetBlendShapeName(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetBlendShapeName(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.GetBlendShapeName has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.GetBlendShapeName has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.UInt32 GetIndexCount(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetIndexCount(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.GetIndexCount has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.GetIndexCount has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.UInt32);
		}

		static private System.UInt32 GetIndexStart(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetIndexStart(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.GetIndexStart has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.GetIndexStart has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.UInt32);
		}

		static private System.Int32[] GetIndices(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetIndices(parameters[0].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Boolean>())
			{
				return instance.GetIndices(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.GetIndices has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.GetIndices has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.IntPtr GetNativeIndexBufferPtr(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetNativeIndexBufferPtr();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.GetNativeIndexBufferPtr has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.IntPtr);
		}

		static private System.IntPtr GetNativeVertexBufferPtr(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetNativeVertexBufferPtr(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.GetNativeVertexBufferPtr has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.GetNativeVertexBufferPtr has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.IntPtr);
		}

		static private UnityEngine.MeshTopology GetTopology(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetTopology(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.GetTopology has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.GetTopology has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.MeshTopology);
		}

		static private System.Int32[] GetTriangles(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetTriangles(parameters[0].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.Boolean>())
			{
				return instance.GetTriangles(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.GetTriangles has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.GetTriangles has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Single GetUVDistributionMetric(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetUVDistributionMetric(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.GetUVDistributionMetric has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.GetUVDistributionMetric has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private void MarkDynamic(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.MarkDynamic();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.MarkDynamic has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void RecalculateBounds(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.RecalculateBounds();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.RecalculateBounds has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void RecalculateNormals(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.RecalculateNormals();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.RecalculateNormals has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void RecalculateTangents(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.RecalculateTangents();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.RecalculateTangents has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetIndices(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32[], UnityEngine.MeshTopology, System.Int32>())
			{
				instance.SetIndices(parameters[0].ToObject<System.Int32[]>(), parameters[1].ToObject<UnityEngine.MeshTopology>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32[], UnityEngine.MeshTopology, System.Int32, System.Boolean>())
			{
				instance.SetIndices(parameters[0].ToObject<System.Int32[]>(), parameters[1].ToObject<UnityEngine.MeshTopology>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<System.Int32[], UnityEngine.MeshTopology, System.Int32, System.Boolean, System.Int32>())
			{
				instance.SetIndices(parameters[0].ToObject<System.Int32[]>(), parameters[1].ToObject<UnityEngine.MeshTopology>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Boolean>(), parameters[4].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.SetIndices has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.SetIndices has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTriangles(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32[], System.Int32>())
			{
				instance.SetTriangles(parameters[0].ToObject<System.Int32[]>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32[], System.Int32, System.Boolean>())
			{
				instance.SetTriangles(parameters[0].ToObject<System.Int32[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<System.Int32[], System.Int32, System.Boolean, System.Int32>())
			{
				instance.SetTriangles(parameters[0].ToObject<System.Int32[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Boolean>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.SetTriangles has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.SetTriangles has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void UploadMeshData(UnityEngine.Mesh instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean>())
			{
				instance.UploadMeshData(parameters[0].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mesh.UploadMeshData has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mesh.UploadMeshData has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Rendering.IndexFormat get_indexFormat(UnityEngine.Mesh instance)
		{
			return instance.indexFormat;
		}

		static private void set_indexFormat(UnityEngine.Mesh instance, UnityEngine.Rendering.IndexFormat value)
		{
			instance.indexFormat = value;
		}

		static private UnityEngine.Color[] get_colors(UnityEngine.Mesh instance)
		{
			return instance.colors;
		}

		static private void set_colors(UnityEngine.Mesh instance, UnityEngine.Color[] value)
		{
			instance.colors = value;
		}

		static private UnityEngine.Vector2[] get_uv8(UnityEngine.Mesh instance)
		{
			return instance.uv8;
		}

		static private void set_uv8(UnityEngine.Mesh instance, UnityEngine.Vector2[] value)
		{
			instance.uv8 = value;
		}

		static private UnityEngine.Vector2[] get_uv7(UnityEngine.Mesh instance)
		{
			return instance.uv7;
		}

		static private void set_uv7(UnityEngine.Mesh instance, UnityEngine.Vector2[] value)
		{
			instance.uv7 = value;
		}

		static private UnityEngine.Vector2[] get_uv6(UnityEngine.Mesh instance)
		{
			return instance.uv6;
		}

		static private void set_uv6(UnityEngine.Mesh instance, UnityEngine.Vector2[] value)
		{
			instance.uv6 = value;
		}

		static private UnityEngine.Vector2[] get_uv5(UnityEngine.Mesh instance)
		{
			return instance.uv5;
		}

		static private void set_uv5(UnityEngine.Mesh instance, UnityEngine.Vector2[] value)
		{
			instance.uv5 = value;
		}

		static private UnityEngine.Vector2[] get_uv4(UnityEngine.Mesh instance)
		{
			return instance.uv4;
		}

		static private void set_uv4(UnityEngine.Mesh instance, UnityEngine.Vector2[] value)
		{
			instance.uv4 = value;
		}

		static private UnityEngine.Vector2[] get_uv3(UnityEngine.Mesh instance)
		{
			return instance.uv3;
		}

		static private void set_uv3(UnityEngine.Mesh instance, UnityEngine.Vector2[] value)
		{
			instance.uv3 = value;
		}

		static private UnityEngine.Vector2[] get_uv2(UnityEngine.Mesh instance)
		{
			return instance.uv2;
		}

		static private void set_uv2(UnityEngine.Mesh instance, UnityEngine.Vector2[] value)
		{
			instance.uv2 = value;
		}

		static private UnityEngine.Vector2[] get_uv(UnityEngine.Mesh instance)
		{
			return instance.uv;
		}

		static private void set_uv(UnityEngine.Mesh instance, UnityEngine.Vector2[] value)
		{
			instance.uv = value;
		}

		static private UnityEngine.Color32[] get_colors32(UnityEngine.Mesh instance)
		{
			return instance.colors32;
		}

		static private void set_colors32(UnityEngine.Mesh instance, UnityEngine.Color32[] value)
		{
			instance.colors32 = value;
		}

		static private UnityEngine.Vector4[] get_tangents(UnityEngine.Mesh instance)
		{
			return instance.tangents;
		}

		static private void set_tangents(UnityEngine.Mesh instance, UnityEngine.Vector4[] value)
		{
			instance.tangents = value;
		}

		static private UnityEngine.Vector3[] get_vertices(UnityEngine.Mesh instance)
		{
			return instance.vertices;
		}

		static private void set_vertices(UnityEngine.Mesh instance, UnityEngine.Vector3[] value)
		{
			instance.vertices = value;
		}

		static private UnityEngine.Bounds get_bounds(UnityEngine.Mesh instance)
		{
			return instance.bounds;
		}

		static private void set_bounds(UnityEngine.Mesh instance, UnityEngine.Bounds value)
		{
			instance.bounds = value;
		}

		static private System.Int32 get_subMeshCount(UnityEngine.Mesh instance)
		{
			return instance.subMeshCount;
		}

		static private void set_subMeshCount(UnityEngine.Mesh instance, System.Int32 value)
		{
			instance.subMeshCount = value;
		}

		static private System.Int32 get_vertexCount(UnityEngine.Mesh instance)
		{
			return instance.vertexCount;
		}

		static private System.Boolean get_isReadable(UnityEngine.Mesh instance)
		{
			return instance.isReadable;
		}

		static private UnityEngine.Matrix4x4[] get_bindposes(UnityEngine.Mesh instance)
		{
			return instance.bindposes;
		}

		static private void set_bindposes(UnityEngine.Mesh instance, UnityEngine.Matrix4x4[] value)
		{
			instance.bindposes = value;
		}

		static private UnityEngine.BoneWeight[] get_boneWeights(UnityEngine.Mesh instance)
		{
			return instance.boneWeights;
		}

		static private void set_boneWeights(UnityEngine.Mesh instance, UnityEngine.BoneWeight[] value)
		{
			instance.boneWeights = value;
		}

		static private System.Int32 get_blendShapeCount(UnityEngine.Mesh instance)
		{
			return instance.blendShapeCount;
		}

		static private System.Int32 get_vertexBufferCount(UnityEngine.Mesh instance)
		{
			return instance.vertexBufferCount;
		}

		static private UnityEngine.Vector3[] get_normals(UnityEngine.Mesh instance)
		{
			return instance.normals;
		}

		static private void set_normals(UnityEngine.Mesh instance, UnityEngine.Vector3[] value)
		{
			instance.normals = value;
		}

		static private System.Int32[] get_triangles(UnityEngine.Mesh instance)
		{
			return instance.triangles;
		}

		static private void set_triangles(UnityEngine.Mesh instance, System.Int32[] value)
		{
			instance.triangles = value;
		}

	}
}
