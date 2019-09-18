using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineGizmos
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Gizmos> self = space.DeclareClass<UnityEngine.Gizmos>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("DrawCube", DrawCube);
			self.BindStaticFunction("DrawFrustum", DrawFrustum);
			self.BindStaticFunction("DrawGUITexture", DrawGUITexture);
			self.BindStaticFunction("DrawIcon", DrawIcon);
			self.BindStaticFunction("DrawLine", DrawLine);
			self.BindStaticFunction("DrawMesh", DrawMesh);
			self.BindStaticFunction("DrawRay", DrawRay);
			self.BindStaticFunction("DrawSphere", DrawSphere);
			self.BindStaticFunction("DrawWireCube", DrawWireCube);
			self.BindStaticFunction("DrawWireMesh", DrawWireMesh);
			self.BindStaticFunction("DrawWireSphere", DrawWireSphere);
			self.BindStaticProperty("color", get_color, set_color);
			self.BindStaticProperty("matrix", get_matrix, set_matrix);
		}

		static private UnityEngine.Gizmos Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Gizmos();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Gizmos.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Gizmos);
		}

		static private void DrawCube(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				UnityEngine.Gizmos.DrawCube(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Gizmos.DrawCube has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Gizmos.DrawCube has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawFrustum(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single, System.Single, System.Single, System.Single>())
			{
				UnityEngine.Gizmos.DrawFrustum(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Gizmos.DrawFrustum has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Gizmos.DrawFrustum has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawGUITexture(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Texture>())
			{
				UnityEngine.Gizmos.DrawGUITexture(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Texture>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Texture, UnityEngine.Material>())
			{
				UnityEngine.Gizmos.DrawGUITexture(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Texture>(), parameters[2].ToObject<UnityEngine.Material>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Texture, System.Int32, System.Int32, System.Int32, System.Int32>())
			{
				UnityEngine.Gizmos.DrawGUITexture(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Texture>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Texture, System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.Material>())
			{
				UnityEngine.Gizmos.DrawGUITexture(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Texture>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.Material>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Gizmos.DrawGUITexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Gizmos.DrawGUITexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawIcon(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, System.String>())
			{
				UnityEngine.Gizmos.DrawIcon(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, System.String, System.Boolean>())
			{
				UnityEngine.Gizmos.DrawIcon(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Gizmos.DrawIcon has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Gizmos.DrawIcon has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawLine(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				UnityEngine.Gizmos.DrawLine(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Gizmos.DrawLine has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Gizmos.DrawLine has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawMesh(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Mesh>())
			{
				UnityEngine.Gizmos.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3>())
			{
				UnityEngine.Gizmos.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32>())
			{
				UnityEngine.Gizmos.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3, UnityEngine.Quaternion>())
			{
				UnityEngine.Gizmos.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Vector3>())
			{
				UnityEngine.Gizmos.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Vector3>())
			{
				UnityEngine.Gizmos.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Vector3, UnityEngine.Quaternion>())
			{
				UnityEngine.Gizmos.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.Quaternion>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Vector3>())
			{
				UnityEngine.Gizmos.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.Quaternion>(), parameters[4].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Gizmos.DrawMesh has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Gizmos.DrawMesh has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawRay(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Ray>())
			{
				UnityEngine.Gizmos.DrawRay(parameters[0].ToObject<UnityEngine.Ray>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				UnityEngine.Gizmos.DrawRay(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Gizmos.DrawRay has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Gizmos.DrawRay has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawSphere(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single>())
			{
				UnityEngine.Gizmos.DrawSphere(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Gizmos.DrawSphere has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Gizmos.DrawSphere has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawWireCube(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				UnityEngine.Gizmos.DrawWireCube(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Gizmos.DrawWireCube has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Gizmos.DrawWireCube has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawWireMesh(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Mesh>())
			{
				UnityEngine.Gizmos.DrawWireMesh(parameters[0].ToObject<UnityEngine.Mesh>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3>())
			{
				UnityEngine.Gizmos.DrawWireMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32>())
			{
				UnityEngine.Gizmos.DrawWireMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3, UnityEngine.Quaternion>())
			{
				UnityEngine.Gizmos.DrawWireMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Vector3>())
			{
				UnityEngine.Gizmos.DrawWireMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Vector3>())
			{
				UnityEngine.Gizmos.DrawWireMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Vector3, UnityEngine.Quaternion>())
			{
				UnityEngine.Gizmos.DrawWireMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.Quaternion>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Vector3>())
			{
				UnityEngine.Gizmos.DrawWireMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Vector3>(), parameters[3].ToObject<UnityEngine.Quaternion>(), parameters[4].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Gizmos.DrawWireMesh has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Gizmos.DrawWireMesh has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawWireSphere(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, System.Single>())
			{
				UnityEngine.Gizmos.DrawWireSphere(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Gizmos.DrawWireSphere has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Gizmos.DrawWireSphere has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Color get_color()
		{
			return UnityEngine.Gizmos.color;
		}

		static private void set_color(UnityEngine.Color value)
		{
			UnityEngine.Gizmos.color = value;
		}

		static private UnityEngine.Matrix4x4 get_matrix()
		{
			return UnityEngine.Gizmos.matrix;
		}

		static private void set_matrix(UnityEngine.Matrix4x4 value)
		{
			UnityEngine.Gizmos.matrix = value;
		}

	}
}
