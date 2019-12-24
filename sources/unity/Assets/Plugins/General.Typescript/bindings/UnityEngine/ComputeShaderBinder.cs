using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineComputeShader
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.ComputeShader> self = space.DeclareClass<UnityEngine.ComputeShader, UnityEngine.Object>();
			self.BindConstructor();
			self.BindInstanceFunction("Dispatch", Dispatch);
			self.BindInstanceFunction("DispatchIndirect", DispatchIndirect);
			self.BindInstanceFunction("FindKernel", FindKernel);
			self.BindInstanceFunction("HasKernel", HasKernel);
			self.BindInstanceFunction("SetBool", SetBool);
			self.BindInstanceFunction("SetBuffer", SetBuffer);
			self.BindInstanceFunction("SetFloat", SetFloat);
			self.BindInstanceFunction("SetFloats", SetFloats);
			self.BindInstanceFunction("SetInt", SetInt);
			self.BindInstanceFunction("SetInts", SetInts);
			self.BindInstanceFunction("SetMatrix", SetMatrix);
			self.BindInstanceFunction("SetMatrixArray", SetMatrixArray);
			self.BindInstanceFunction("SetTexture", SetTexture);
			self.BindInstanceFunction("SetTextureFromGlobal", SetTextureFromGlobal);
			self.BindInstanceFunction("SetVector", SetVector);
			self.BindInstanceFunction("SetVectorArray", SetVectorArray);
		}

		static private void Dispatch(UnityEngine.ComputeShader instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32>())
			{
				instance.Dispatch(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeShader.Dispatch has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeShader.Dispatch has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DispatchIndirect(UnityEngine.ComputeShader instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.ComputeBuffer>())
			{
				instance.DispatchIndirect(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.ComputeBuffer>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.ComputeBuffer, System.UInt32>())
			{
				instance.DispatchIndirect(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.ComputeBuffer>(), parameters[2].ToObject<System.UInt32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeShader.DispatchIndirect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeShader.DispatchIndirect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 FindKernel(UnityEngine.ComputeShader instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.FindKernel(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeShader.FindKernel has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeShader.FindKernel has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Boolean HasKernel(UnityEngine.ComputeShader instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.HasKernel(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeShader.HasKernel has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeShader.HasKernel has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void SetBool(UnityEngine.ComputeShader instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Boolean>())
			{
				instance.SetBool(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Boolean>())
			{
				instance.SetBool(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeShader.SetBool has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeShader.SetBool has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetBuffer(UnityEngine.ComputeShader instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.ComputeBuffer>())
			{
				instance.SetBuffer(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.ComputeBuffer>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.String, UnityEngine.ComputeBuffer>())
			{
				instance.SetBuffer(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<UnityEngine.ComputeBuffer>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeShader.SetBuffer has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeShader.SetBuffer has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetFloat(UnityEngine.ComputeShader instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Single>())
			{
				instance.SetFloat(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Single>())
			{
				instance.SetFloat(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeShader.SetFloat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeShader.SetFloat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetFloats(UnityEngine.ComputeShader instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Single[]>())
			{
				instance.SetFloats(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single[]>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Single[]>())
			{
				instance.SetFloats(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeShader.SetFloats has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeShader.SetFloats has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetInt(UnityEngine.ComputeShader instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				instance.SetInt(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Int32>())
			{
				instance.SetInt(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeShader.SetInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeShader.SetInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetInts(UnityEngine.ComputeShader instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Int32[]>())
			{
				instance.SetInts(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32[]>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32[]>())
			{
				instance.SetInts(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeShader.SetInts has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeShader.SetInts has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetMatrix(UnityEngine.ComputeShader instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Matrix4x4>())
			{
				instance.SetMatrix(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.Matrix4x4>())
			{
				instance.SetMatrix(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeShader.SetMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeShader.SetMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetMatrixArray(UnityEngine.ComputeShader instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Matrix4x4[]>())
			{
				instance.SetMatrixArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Matrix4x4[]>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.Matrix4x4[]>())
			{
				instance.SetMatrixArray(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Matrix4x4[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeShader.SetMatrixArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeShader.SetMatrixArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTexture(UnityEngine.ComputeShader instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.Texture>())
			{
				instance.SetTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Texture>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.String, UnityEngine.Texture>())
			{
				instance.SetTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<UnityEngine.Texture>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.Texture, System.Int32>())
			{
				instance.SetTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Texture>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.String, UnityEngine.Texture, System.Int32>())
			{
				instance.SetTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<UnityEngine.Texture>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeShader.SetTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeShader.SetTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTextureFromGlobal(UnityEngine.ComputeShader instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32>())
			{
				instance.SetTextureFromGlobal(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.String, System.String>())
			{
				instance.SetTextureFromGlobal(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeShader.SetTextureFromGlobal has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeShader.SetTextureFromGlobal has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetVector(UnityEngine.ComputeShader instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Vector4>())
			{
				instance.SetVector(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Vector4>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.Vector4>())
			{
				instance.SetVector(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Vector4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeShader.SetVector has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeShader.SetVector has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetVectorArray(UnityEngine.ComputeShader instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Vector4[]>())
			{
				instance.SetVectorArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Vector4[]>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.Vector4[]>())
			{
				instance.SetVectorArray(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Vector4[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ComputeShader.SetVectorArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ComputeShader.SetVectorArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

	}
}
