using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineBillboardAsset
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.BillboardAsset> self = space.DeclareClass<UnityEngine.BillboardAsset, UnityEngine.Object>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("GetImageTexCoords", GetImageTexCoords);
			self.BindInstanceFunction("GetIndices", GetIndices);
			self.BindInstanceFunction("GetVertices", GetVertices);
			self.BindInstanceFunction("SetImageTexCoords", SetImageTexCoords);
			self.BindInstanceFunction("SetIndices", SetIndices);
			self.BindInstanceFunction("SetVertices", SetVertices);
			self.BindInstanceProperty("width", get_width, set_width);
			self.BindInstanceProperty("height", get_height, set_height);
			self.BindInstanceProperty("bottom", get_bottom, set_bottom);
			self.BindInstanceProperty("imageCount", get_imageCount, null);
			self.BindInstanceProperty("vertexCount", get_vertexCount, null);
			self.BindInstanceProperty("indexCount", get_indexCount, null);
			self.BindInstanceProperty("material", get_material, set_material);
		}

		static private UnityEngine.BillboardAsset Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.BillboardAsset();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.BillboardAsset.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.BillboardAsset);
		}

		static private UnityEngine.Vector4[] GetImageTexCoords(UnityEngine.BillboardAsset instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetImageTexCoords();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.BillboardAsset.GetImageTexCoords has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.UInt16[] GetIndices(UnityEngine.BillboardAsset instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetIndices();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.BillboardAsset.GetIndices has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Vector2[] GetVertices(UnityEngine.BillboardAsset instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetVertices();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.BillboardAsset.GetVertices has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void SetImageTexCoords(UnityEngine.BillboardAsset instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4[]>())
			{
				instance.SetImageTexCoords(parameters[0].ToObject<UnityEngine.Vector4[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.BillboardAsset.SetImageTexCoords has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.BillboardAsset.SetImageTexCoords has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetIndices(UnityEngine.BillboardAsset instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.UInt16[]>())
			{
				instance.SetIndices(parameters[0].ToObject<System.UInt16[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.BillboardAsset.SetIndices has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.BillboardAsset.SetIndices has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetVertices(UnityEngine.BillboardAsset instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2[]>())
			{
				instance.SetVertices(parameters[0].ToObject<UnityEngine.Vector2[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.BillboardAsset.SetVertices has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.BillboardAsset.SetVertices has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Single get_width(UnityEngine.BillboardAsset instance)
		{
			return instance.width;
		}

		static private void set_width(UnityEngine.BillboardAsset instance, System.Single value)
		{
			instance.width = value;
		}

		static private System.Single get_height(UnityEngine.BillboardAsset instance)
		{
			return instance.height;
		}

		static private void set_height(UnityEngine.BillboardAsset instance, System.Single value)
		{
			instance.height = value;
		}

		static private System.Single get_bottom(UnityEngine.BillboardAsset instance)
		{
			return instance.bottom;
		}

		static private void set_bottom(UnityEngine.BillboardAsset instance, System.Single value)
		{
			instance.bottom = value;
		}

		static private System.Int32 get_imageCount(UnityEngine.BillboardAsset instance)
		{
			return instance.imageCount;
		}

		static private System.Int32 get_vertexCount(UnityEngine.BillboardAsset instance)
		{
			return instance.vertexCount;
		}

		static private System.Int32 get_indexCount(UnityEngine.BillboardAsset instance)
		{
			return instance.indexCount;
		}

		static private UnityEngine.Material get_material(UnityEngine.BillboardAsset instance)
		{
			return instance.material;
		}

		static private void set_material(UnityEngine.BillboardAsset instance, UnityEngine.Material value)
		{
			instance.material = value;
		}

	}
}
