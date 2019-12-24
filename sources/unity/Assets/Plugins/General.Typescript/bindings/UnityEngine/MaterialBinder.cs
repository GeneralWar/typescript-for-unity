using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMaterial
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Material> self = space.DeclareClass<UnityEngine.Material, UnityEngine.Object>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("CopyPropertiesFromMaterial", CopyPropertiesFromMaterial);
			self.BindInstanceFunction("DisableKeyword", DisableKeyword);
			self.BindInstanceFunction("EnableKeyword", EnableKeyword);
			self.BindInstanceFunction("FindPass", FindPass);
			self.BindInstanceFunction("GetColor", GetColor);
			self.BindInstanceFunction("GetColorArray", GetColorArray);
			self.BindInstanceFunction("GetFloat", GetFloat);
			self.BindInstanceFunction("GetFloatArray", GetFloatArray);
			self.BindInstanceFunction("GetInt", GetInt);
			self.BindInstanceFunction("GetMatrix", GetMatrix);
			self.BindInstanceFunction("GetMatrixArray", GetMatrixArray);
			self.BindInstanceFunction("GetPassName", GetPassName);
			self.BindInstanceFunction("GetShaderPassEnabled", GetShaderPassEnabled);
			self.BindInstanceFunction("GetTag", GetTag);
			self.BindInstanceFunction("GetTexture", GetTexture);
			self.BindInstanceFunction("GetTextureOffset", GetTextureOffset);
			self.BindInstanceFunction("GetTexturePropertyNameIDs", GetTexturePropertyNameIDs);
			self.BindInstanceFunction("GetTexturePropertyNames", GetTexturePropertyNames);
			self.BindInstanceFunction("GetTextureScale", GetTextureScale);
			self.BindInstanceFunction("GetVector", GetVector);
			self.BindInstanceFunction("GetVectorArray", GetVectorArray);
			self.BindInstanceFunction("HasProperty", HasProperty);
			self.BindInstanceFunction("IsKeywordEnabled", IsKeywordEnabled);
			self.BindInstanceFunction("Lerp", Lerp);
			self.BindInstanceFunction("SetBuffer", SetBuffer);
			self.BindInstanceFunction("SetColor", SetColor);
			self.BindInstanceFunction("SetColorArray", SetColorArray);
			self.BindInstanceFunction("SetFloat", SetFloat);
			self.BindInstanceFunction("SetFloatArray", SetFloatArray);
			self.BindInstanceFunction("SetInt", SetInt);
			self.BindInstanceFunction("SetMatrix", SetMatrix);
			self.BindInstanceFunction("SetMatrixArray", SetMatrixArray);
			self.BindInstanceFunction("SetOverrideTag", SetOverrideTag);
			self.BindInstanceFunction("SetPass", SetPass);
			self.BindInstanceFunction("SetShaderPassEnabled", SetShaderPassEnabled);
			self.BindInstanceFunction("SetTexture", SetTexture);
			self.BindInstanceFunction("SetTextureOffset", SetTextureOffset);
			self.BindInstanceFunction("SetTextureScale", SetTextureScale);
			self.BindInstanceFunction("SetVector", SetVector);
			self.BindInstanceFunction("SetVectorArray", SetVectorArray);
			self.BindInstanceProperty("shader", get_shader, set_shader);
			self.BindInstanceProperty("color", get_color, set_color);
			self.BindInstanceProperty("mainTexture", get_mainTexture, set_mainTexture);
			self.BindInstanceProperty("mainTextureOffset", get_mainTextureOffset, set_mainTextureOffset);
			self.BindInstanceProperty("mainTextureScale", get_mainTextureScale, set_mainTextureScale);
			self.BindInstanceProperty("renderQueue", get_renderQueue, set_renderQueue);
			self.BindInstanceProperty("globalIlluminationFlags", get_globalIlluminationFlags, set_globalIlluminationFlags);
			self.BindInstanceProperty("doubleSidedGI", get_doubleSidedGI, set_doubleSidedGI);
			self.BindInstanceProperty("enableInstancing", get_enableInstancing, set_enableInstancing);
			self.BindInstanceProperty("passCount", get_passCount, null);
			self.BindInstanceProperty("shaderKeywords", get_shaderKeywords, set_shaderKeywords);
		}

		static private UnityEngine.Material Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Shader>())
			{
				return new UnityEngine.Material(parameters[0].ToObject<UnityEngine.Shader>());
			}
			if (parameters.CheckTypes<UnityEngine.Material>())
			{
				return new UnityEngine.Material(parameters[0].ToObject<UnityEngine.Material>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Material);
		}

		static private void CopyPropertiesFromMaterial(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Material>())
			{
				instance.CopyPropertiesFromMaterial(parameters[0].ToObject<UnityEngine.Material>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.CopyPropertiesFromMaterial has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.CopyPropertiesFromMaterial has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DisableKeyword(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.DisableKeyword(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.DisableKeyword has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.DisableKeyword has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void EnableKeyword(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.EnableKeyword(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.EnableKeyword has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.EnableKeyword has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 FindPass(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.FindPass(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.FindPass has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.FindPass has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.Color GetColor(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetColor(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetColor(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.GetColor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.GetColor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Color);
		}

		static private UnityEngine.Color[] GetColorArray(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetColorArray(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetColorArray(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.GetColorArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.GetColorArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Single GetFloat(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetFloat(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetFloat(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.GetFloat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.GetFloat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single[] GetFloatArray(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetFloatArray(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetFloatArray(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.GetFloatArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.GetFloatArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 GetInt(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetInt(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetInt(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.GetInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.GetInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.Matrix4x4 GetMatrix(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetMatrix(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetMatrix(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.GetMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.GetMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private UnityEngine.Matrix4x4[] GetMatrixArray(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetMatrixArray(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetMatrixArray(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.GetMatrixArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.GetMatrixArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.String GetPassName(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetPassName(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.GetPassName has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.GetPassName has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean GetShaderPassEnabled(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetShaderPassEnabled(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.GetShaderPassEnabled has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.GetShaderPassEnabled has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.String GetTag(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Boolean>())
			{
				return instance.GetTag(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<System.String, System.Boolean, System.String>())
			{
				return instance.GetTag(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Boolean>(), parameters[2].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.GetTag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.GetTag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.Texture GetTexture(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetTexture(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetTexture(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.GetTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.GetTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.Vector2 GetTextureOffset(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetTextureOffset(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetTextureOffset(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.GetTextureOffset has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.GetTextureOffset has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private System.Int32[] GetTexturePropertyNameIDs(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetTexturePropertyNameIDs();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.GetTexturePropertyNameIDs has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.String[] GetTexturePropertyNames(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetTexturePropertyNames();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.GetTexturePropertyNames has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Vector2 GetTextureScale(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetTextureScale(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetTextureScale(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.GetTextureScale has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.GetTextureScale has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private UnityEngine.Vector4 GetVector(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetVector(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetVector(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.GetVector has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.GetVector has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector4);
		}

		static private UnityEngine.Vector4[] GetVectorArray(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetVectorArray(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetVectorArray(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.GetVectorArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.GetVectorArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean HasProperty(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.HasProperty(parameters[0].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return instance.HasProperty(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.HasProperty has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.HasProperty has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean IsKeywordEnabled(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.IsKeywordEnabled(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.IsKeywordEnabled has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.IsKeywordEnabled has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void Lerp(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Material, UnityEngine.Material, System.Single>())
			{
				instance.Lerp(parameters[0].ToObject<UnityEngine.Material>(), parameters[1].ToObject<UnityEngine.Material>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.Lerp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.Lerp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetBuffer(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.ComputeBuffer>())
			{
				instance.SetBuffer(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.ComputeBuffer>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.ComputeBuffer>())
			{
				instance.SetBuffer(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.ComputeBuffer>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.SetBuffer has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.SetBuffer has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetColor(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Color>())
			{
				instance.SetColor(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Color>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.Color>())
			{
				instance.SetColor(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Color>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.SetColor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.SetColor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetColorArray(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Color[]>())
			{
				instance.SetColorArray(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Color[]>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.Color[]>())
			{
				instance.SetColorArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Color[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.SetColorArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.SetColorArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetFloat(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Single>())
			{
				instance.SetFloat(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Single>())
			{
				instance.SetFloat(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.SetFloat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.SetFloat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetFloatArray(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Single[]>())
			{
				instance.SetFloatArray(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single[]>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Single[]>())
			{
				instance.SetFloatArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.SetFloatArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.SetFloatArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetInt(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Int32>())
			{
				instance.SetInt(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				instance.SetInt(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.SetInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.SetInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetMatrix(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Matrix4x4>())
			{
				instance.SetMatrix(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.Matrix4x4>())
			{
				instance.SetMatrix(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.SetMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.SetMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetMatrixArray(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Matrix4x4[]>())
			{
				instance.SetMatrixArray(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Matrix4x4[]>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.Matrix4x4[]>())
			{
				instance.SetMatrixArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Matrix4x4[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.SetMatrixArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.SetMatrixArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetOverrideTag(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.String>())
			{
				instance.SetOverrideTag(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.SetOverrideTag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.SetOverrideTag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean SetPass(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.SetPass(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.SetPass has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.SetPass has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void SetShaderPassEnabled(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Boolean>())
			{
				instance.SetShaderPassEnabled(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.SetShaderPassEnabled has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.SetShaderPassEnabled has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTexture(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Texture>())
			{
				instance.SetTexture(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Texture>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.Texture>())
			{
				instance.SetTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Texture>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.SetTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.SetTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTextureOffset(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Vector2>())
			{
				instance.SetTextureOffset(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Vector2>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.Vector2>())
			{
				instance.SetTextureOffset(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Vector2>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.SetTextureOffset has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.SetTextureOffset has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTextureScale(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Vector2>())
			{
				instance.SetTextureScale(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Vector2>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.Vector2>())
			{
				instance.SetTextureScale(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Vector2>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.SetTextureScale has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.SetTextureScale has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetVector(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Vector4>())
			{
				instance.SetVector(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Vector4>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.Vector4>())
			{
				instance.SetVector(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Vector4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.SetVector has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.SetVector has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetVectorArray(UnityEngine.Material instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Vector4[]>())
			{
				instance.SetVectorArray(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Vector4[]>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.Vector4[]>())
			{
				instance.SetVectorArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Vector4[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Material.SetVectorArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Material.SetVectorArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Shader get_shader(UnityEngine.Material instance, string name)
		{
			return instance.shader;
		}

		static private void set_shader(UnityEngine.Material instance, string name, UnityEngine.Shader value)
		{
			instance.shader = value;
		}

		static private UnityEngine.Color get_color(UnityEngine.Material instance, string name)
		{
			return instance.color;
		}

		static private void set_color(UnityEngine.Material instance, string name, UnityEngine.Color value)
		{
			instance.color = value;
		}

		static private UnityEngine.Texture get_mainTexture(UnityEngine.Material instance, string name)
		{
			return instance.mainTexture;
		}

		static private void set_mainTexture(UnityEngine.Material instance, string name, UnityEngine.Texture value)
		{
			instance.mainTexture = value;
		}

		static private UnityEngine.Vector2 get_mainTextureOffset(UnityEngine.Material instance, string name)
		{
			return instance.mainTextureOffset;
		}

		static private void set_mainTextureOffset(UnityEngine.Material instance, string name, UnityEngine.Vector2 value)
		{
			instance.mainTextureOffset = value;
		}

		static private UnityEngine.Vector2 get_mainTextureScale(UnityEngine.Material instance, string name)
		{
			return instance.mainTextureScale;
		}

		static private void set_mainTextureScale(UnityEngine.Material instance, string name, UnityEngine.Vector2 value)
		{
			instance.mainTextureScale = value;
		}

		static private System.Int32 get_renderQueue(UnityEngine.Material instance, string name)
		{
			return instance.renderQueue;
		}

		static private void set_renderQueue(UnityEngine.Material instance, string name, System.Int32 value)
		{
			instance.renderQueue = value;
		}

		static private UnityEngine.MaterialGlobalIlluminationFlags get_globalIlluminationFlags(UnityEngine.Material instance, string name)
		{
			return instance.globalIlluminationFlags;
		}

		static private void set_globalIlluminationFlags(UnityEngine.Material instance, string name, UnityEngine.MaterialGlobalIlluminationFlags value)
		{
			instance.globalIlluminationFlags = value;
		}

		static private System.Boolean get_doubleSidedGI(UnityEngine.Material instance, string name)
		{
			return instance.doubleSidedGI;
		}

		static private void set_doubleSidedGI(UnityEngine.Material instance, string name, System.Boolean value)
		{
			instance.doubleSidedGI = value;
		}

		static private System.Boolean get_enableInstancing(UnityEngine.Material instance, string name)
		{
			return instance.enableInstancing;
		}

		static private void set_enableInstancing(UnityEngine.Material instance, string name, System.Boolean value)
		{
			instance.enableInstancing = value;
		}

		static private System.Int32 get_passCount(UnityEngine.Material instance, string name)
		{
			return instance.passCount;
		}

		static private System.String[] get_shaderKeywords(UnityEngine.Material instance, string name)
		{
			return instance.shaderKeywords;
		}

		static private void set_shaderKeywords(UnityEngine.Material instance, string name, System.String[] value)
		{
			instance.shaderKeywords = value;
		}

	}
}
