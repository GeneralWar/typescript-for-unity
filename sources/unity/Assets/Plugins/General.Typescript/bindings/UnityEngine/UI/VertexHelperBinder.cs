using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIVertexHelper
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.VertexHelper> self = space.DeclareClass<UnityEngine.UI.VertexHelper>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("AddTriangle", AddTriangle);
			self.BindInstanceFunction("AddUIVertexQuad", AddUIVertexQuad);
			self.BindInstanceFunction("AddVert", AddVert);
			self.BindInstanceFunction("Clear", Clear);
			self.BindInstanceFunction("Dispose", Dispose);
			self.BindInstanceFunction("FillMesh", FillMesh);
			self.BindInstanceFunction("SetUIVertex", SetUIVertex);
			self.BindInstanceProperty("currentVertCount", get_currentVertCount, null);
			self.BindInstanceProperty("currentIndexCount", get_currentIndexCount, null);
		}

		static private UnityEngine.UI.VertexHelper Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.UI.VertexHelper();
			}
			if (parameters.CheckTypes<UnityEngine.Mesh>())
			{
				return new UnityEngine.UI.VertexHelper(parameters[0].ToObject<UnityEngine.Mesh>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.VertexHelper.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.UI.VertexHelper);
		}

		static private void AddTriangle(UnityEngine.UI.VertexHelper instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32>())
			{
				instance.AddTriangle(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.VertexHelper.AddTriangle has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.VertexHelper.AddTriangle has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void AddUIVertexQuad(UnityEngine.UI.VertexHelper instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UIVertex[]>())
			{
				instance.AddUIVertexQuad(parameters[0].ToObject<UnityEngine.UIVertex[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.VertexHelper.AddUIVertexQuad has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.VertexHelper.AddUIVertexQuad has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void AddVert(UnityEngine.UI.VertexHelper instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UIVertex>())
			{
				instance.AddVert(parameters[0].ToObject<UnityEngine.UIVertex>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Color32, UnityEngine.Vector2>())
			{
				instance.AddVert(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Color32>(), parameters[2].ToObject<UnityEngine.Vector2>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Color32, UnityEngine.Vector2, UnityEngine.Vector2, UnityEngine.Vector3, UnityEngine.Vector4>())
			{
				instance.AddVert(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Color32>(), parameters[2].ToObject<UnityEngine.Vector2>(), parameters[3].ToObject<UnityEngine.Vector2>(), parameters[4].ToObject<UnityEngine.Vector3>(), parameters[5].ToObject<UnityEngine.Vector4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.VertexHelper.AddVert has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.VertexHelper.AddVert has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Clear(UnityEngine.UI.VertexHelper instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.VertexHelper.Clear has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Dispose(UnityEngine.UI.VertexHelper instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.VertexHelper.Dispose has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void FillMesh(UnityEngine.UI.VertexHelper instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Mesh>())
			{
				instance.FillMesh(parameters[0].ToObject<UnityEngine.Mesh>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.VertexHelper.FillMesh has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.VertexHelper.FillMesh has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetUIVertex(UnityEngine.UI.VertexHelper instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UIVertex, System.Int32>())
			{
				instance.SetUIVertex(parameters[0].ToObject<UnityEngine.UIVertex>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.VertexHelper.SetUIVertex has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.VertexHelper.SetUIVertex has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 get_currentVertCount(UnityEngine.UI.VertexHelper instance)
		{
			return instance.currentVertCount;
		}

		static private System.Int32 get_currentIndexCount(UnityEngine.UI.VertexHelper instance)
		{
			return instance.currentIndexCount;
		}

	}
}
