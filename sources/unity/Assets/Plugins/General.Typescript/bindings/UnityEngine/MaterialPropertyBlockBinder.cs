using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMaterialPropertyBlock
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.MaterialPropertyBlock> self = space.DeclareClass<UnityEngine.MaterialPropertyBlock>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Clear", Clear);
			self.BindInstanceFunction("CopyProbeOcclusionArrayFrom", CopyProbeOcclusionArrayFrom);
			self.BindInstanceFunction("CopySHCoefficientArraysFrom", CopySHCoefficientArraysFrom);
			self.BindInstanceFunction("GetColor", GetColor);
			self.BindInstanceFunction("GetFloat", GetFloat);
			self.BindInstanceFunction("GetFloatArray", GetFloatArray);
			self.BindInstanceFunction("GetInt", GetInt);
			self.BindInstanceFunction("GetMatrix", GetMatrix);
			self.BindInstanceFunction("GetMatrixArray", GetMatrixArray);
			self.BindInstanceFunction("GetTexture", GetTexture);
			self.BindInstanceFunction("GetVector", GetVector);
			self.BindInstanceFunction("GetVectorArray", GetVectorArray);
			self.BindInstanceFunction("SetBuffer", SetBuffer);
			self.BindInstanceFunction("SetColor", SetColor);
			self.BindInstanceFunction("SetFloat", SetFloat);
			self.BindInstanceFunction("SetFloatArray", SetFloatArray);
			self.BindInstanceFunction("SetInt", SetInt);
			self.BindInstanceFunction("SetMatrix", SetMatrix);
			self.BindInstanceFunction("SetMatrixArray", SetMatrixArray);
			self.BindInstanceFunction("SetTexture", SetTexture);
			self.BindInstanceFunction("SetVector", SetVector);
			self.BindInstanceFunction("SetVectorArray", SetVectorArray);
			self.BindInstanceProperty("isEmpty", get_isEmpty, null);
		}

		static private UnityEngine.MaterialPropertyBlock Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.MaterialPropertyBlock();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.MaterialPropertyBlock);
		}

		static private void Clear(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.Clear has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void CopyProbeOcclusionArrayFrom(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4[]>())
			{
				instance.CopyProbeOcclusionArrayFrom(parameters[0].ToObject<UnityEngine.Vector4[]>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector4[], System.Int32, System.Int32, System.Int32>())
			{
				instance.CopyProbeOcclusionArrayFrom(parameters[0].ToObject<UnityEngine.Vector4[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.CopyProbeOcclusionArrayFrom has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.CopyProbeOcclusionArrayFrom has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void CopySHCoefficientArraysFrom(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.SphericalHarmonicsL2[]>())
			{
				instance.CopySHCoefficientArraysFrom(parameters[0].ToObject<UnityEngine.Rendering.SphericalHarmonicsL2[]>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.SphericalHarmonicsL2[], System.Int32, System.Int32, System.Int32>())
			{
				instance.CopySHCoefficientArraysFrom(parameters[0].ToObject<UnityEngine.Rendering.SphericalHarmonicsL2[]>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.CopySHCoefficientArraysFrom has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.CopySHCoefficientArraysFrom has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Color GetColor(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.GetColor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.GetColor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Color);
		}

		static private System.Single GetFloat(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.GetFloat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.GetFloat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single[] GetFloatArray(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.GetFloatArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.GetFloatArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 GetInt(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.GetInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.GetInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.Matrix4x4 GetMatrix(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.GetMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.GetMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private UnityEngine.Matrix4x4[] GetMatrixArray(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.GetMatrixArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.GetMatrixArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.Texture GetTexture(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.GetTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.GetTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.Vector4 GetVector(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.GetVector has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.GetVector has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector4);
		}

		static private UnityEngine.Vector4[] GetVectorArray(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.GetVectorArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.GetVectorArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void SetBuffer(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.SetBuffer has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.SetBuffer has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetColor(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.SetColor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.SetColor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetFloat(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.SetFloat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.SetFloat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetFloatArray(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.SetFloatArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.SetFloatArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetInt(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.SetInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.SetInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetMatrix(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.SetMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.SetMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetMatrixArray(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.SetMatrixArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.SetMatrixArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTexture(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.SetTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.SetTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetVector(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.SetVector has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.SetVector has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetVectorArray(UnityEngine.MaterialPropertyBlock instance, string methodName, Parameters parameters)
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
				UnityEngine.Debug.LogError("UnityEngine.MaterialPropertyBlock.SetVectorArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.MaterialPropertyBlock.SetVectorArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean get_isEmpty(UnityEngine.MaterialPropertyBlock instance, string name)
		{
			return instance.isEmpty;
		}

	}
}
