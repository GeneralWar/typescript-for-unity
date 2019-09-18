using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCanvasRenderer
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.CanvasRenderer> self = space.DeclareClass<UnityEngine.CanvasRenderer, UnityEngine.Component>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Clear", Clear);
			self.BindInstanceFunction("DisableRectClipping", DisableRectClipping);
			self.BindInstanceFunction("EnableRectClipping", EnableRectClipping);
			self.BindInstanceFunction("GetAlpha", GetAlpha);
			self.BindInstanceFunction("GetColor", GetColor);
			self.BindInstanceFunction("GetInheritedAlpha", GetInheritedAlpha);
			self.BindInstanceFunction("GetMaterial", GetMaterial);
			self.BindInstanceFunction("GetPopMaterial", GetPopMaterial);
			self.BindInstanceFunction("SetAlpha", SetAlpha);
			self.BindInstanceFunction("SetAlphaTexture", SetAlphaTexture);
			self.BindInstanceFunction("SetColor", SetColor);
			self.BindInstanceFunction("SetMaterial", SetMaterial);
			self.BindInstanceFunction("SetMesh", SetMesh);
			self.BindInstanceFunction("SetPopMaterial", SetPopMaterial);
			self.BindInstanceFunction("SetTexture", SetTexture);
			self.BindInstanceProperty("hasPopInstruction", get_hasPopInstruction, set_hasPopInstruction);
			self.BindInstanceProperty("materialCount", get_materialCount, set_materialCount);
			self.BindInstanceProperty("popMaterialCount", get_popMaterialCount, set_popMaterialCount);
			self.BindInstanceProperty("absoluteDepth", get_absoluteDepth, null);
			self.BindInstanceProperty("hasMoved", get_hasMoved, null);
			self.BindInstanceProperty("cullTransparentMesh", get_cullTransparentMesh, set_cullTransparentMesh);
			self.BindInstanceProperty("hasRectClipping", get_hasRectClipping, null);
			self.BindInstanceProperty("relativeDepth", get_relativeDepth, null);
			self.BindInstanceProperty("cull", get_cull, set_cull);
		}

		static private UnityEngine.CanvasRenderer Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.CanvasRenderer();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasRenderer.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.CanvasRenderer);
		}

		static private void Clear(UnityEngine.CanvasRenderer instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasRenderer.Clear has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void DisableRectClipping(UnityEngine.CanvasRenderer instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.DisableRectClipping();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasRenderer.DisableRectClipping has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void EnableRectClipping(UnityEngine.CanvasRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rect>())
			{
				instance.EnableRectClipping(parameters[0].ToObject<UnityEngine.Rect>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CanvasRenderer.EnableRectClipping has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasRenderer.EnableRectClipping has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Single GetAlpha(UnityEngine.CanvasRenderer instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetAlpha();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasRenderer.GetAlpha has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Single);
		}

		static private UnityEngine.Color GetColor(UnityEngine.CanvasRenderer instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetColor();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasRenderer.GetColor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Color);
		}

		static private System.Single GetInheritedAlpha(UnityEngine.CanvasRenderer instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetInheritedAlpha();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasRenderer.GetInheritedAlpha has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Single);
		}

		static private UnityEngine.Material GetMaterial(UnityEngine.CanvasRenderer instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetMaterial();
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetMaterial(parameters[0].ToObject<System.Int32>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasRenderer.GetMaterial has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Material GetPopMaterial(UnityEngine.CanvasRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetPopMaterial(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CanvasRenderer.GetPopMaterial has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasRenderer.GetPopMaterial has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void SetAlpha(UnityEngine.CanvasRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				instance.SetAlpha(parameters[0].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CanvasRenderer.SetAlpha has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasRenderer.SetAlpha has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetAlphaTexture(UnityEngine.CanvasRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Texture>())
			{
				instance.SetAlphaTexture(parameters[0].ToObject<UnityEngine.Texture>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CanvasRenderer.SetAlphaTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasRenderer.SetAlphaTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetColor(UnityEngine.CanvasRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Color>())
			{
				instance.SetColor(parameters[0].ToObject<UnityEngine.Color>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CanvasRenderer.SetColor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasRenderer.SetColor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetMaterial(UnityEngine.CanvasRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Material, System.Int32>())
			{
				instance.SetMaterial(parameters[0].ToObject<UnityEngine.Material>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Material, UnityEngine.Texture>())
			{
				instance.SetMaterial(parameters[0].ToObject<UnityEngine.Material>(), parameters[1].ToObject<UnityEngine.Texture>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CanvasRenderer.SetMaterial has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasRenderer.SetMaterial has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetMesh(UnityEngine.CanvasRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Mesh>())
			{
				instance.SetMesh(parameters[0].ToObject<UnityEngine.Mesh>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CanvasRenderer.SetMesh has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasRenderer.SetMesh has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetPopMaterial(UnityEngine.CanvasRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Material, System.Int32>())
			{
				instance.SetPopMaterial(parameters[0].ToObject<UnityEngine.Material>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CanvasRenderer.SetPopMaterial has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasRenderer.SetPopMaterial has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTexture(UnityEngine.CanvasRenderer instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Texture>())
			{
				instance.SetTexture(parameters[0].ToObject<UnityEngine.Texture>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CanvasRenderer.SetTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CanvasRenderer.SetTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean get_hasPopInstruction(UnityEngine.CanvasRenderer instance)
		{
			return instance.hasPopInstruction;
		}

		static private void set_hasPopInstruction(UnityEngine.CanvasRenderer instance, System.Boolean value)
		{
			instance.hasPopInstruction = value;
		}

		static private System.Int32 get_materialCount(UnityEngine.CanvasRenderer instance)
		{
			return instance.materialCount;
		}

		static private void set_materialCount(UnityEngine.CanvasRenderer instance, System.Int32 value)
		{
			instance.materialCount = value;
		}

		static private System.Int32 get_popMaterialCount(UnityEngine.CanvasRenderer instance)
		{
			return instance.popMaterialCount;
		}

		static private void set_popMaterialCount(UnityEngine.CanvasRenderer instance, System.Int32 value)
		{
			instance.popMaterialCount = value;
		}

		static private System.Int32 get_absoluteDepth(UnityEngine.CanvasRenderer instance)
		{
			return instance.absoluteDepth;
		}

		static private System.Boolean get_hasMoved(UnityEngine.CanvasRenderer instance)
		{
			return instance.hasMoved;
		}

		static private System.Boolean get_cullTransparentMesh(UnityEngine.CanvasRenderer instance)
		{
			return instance.cullTransparentMesh;
		}

		static private void set_cullTransparentMesh(UnityEngine.CanvasRenderer instance, System.Boolean value)
		{
			instance.cullTransparentMesh = value;
		}

		static private System.Boolean get_hasRectClipping(UnityEngine.CanvasRenderer instance)
		{
			return instance.hasRectClipping;
		}

		static private System.Int32 get_relativeDepth(UnityEngine.CanvasRenderer instance)
		{
			return instance.relativeDepth;
		}

		static private System.Boolean get_cull(UnityEngine.CanvasRenderer instance)
		{
			return instance.cull;
		}

		static private void set_cull(UnityEngine.CanvasRenderer instance, System.Boolean value)
		{
			instance.cull = value;
		}

	}
}
