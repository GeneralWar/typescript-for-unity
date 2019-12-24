using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineShader
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Shader> self = space.DeclareClass<UnityEngine.Shader, UnityEngine.Object>();
			self.BindConstructor();
			self.BindStaticFunction("DisableKeyword", DisableKeyword);
			self.BindStaticFunction("EnableKeyword", EnableKeyword);
			self.BindStaticFunction("Find", Find);
			self.BindStaticFunction("GetGlobalColor", GetGlobalColor);
			self.BindStaticFunction("GetGlobalFloat", GetGlobalFloat);
			self.BindStaticFunction("GetGlobalFloatArray", GetGlobalFloatArray);
			self.BindStaticFunction("GetGlobalInt", GetGlobalInt);
			self.BindStaticFunction("GetGlobalMatrix", GetGlobalMatrix);
			self.BindStaticFunction("GetGlobalMatrixArray", GetGlobalMatrixArray);
			self.BindStaticFunction("GetGlobalTexture", GetGlobalTexture);
			self.BindStaticFunction("GetGlobalVector", GetGlobalVector);
			self.BindStaticFunction("GetGlobalVectorArray", GetGlobalVectorArray);
			self.BindStaticFunction("IsKeywordEnabled", IsKeywordEnabled);
			self.BindStaticFunction("PropertyToID", PropertyToID);
			self.BindStaticFunction("SetGlobalBuffer", SetGlobalBuffer);
			self.BindStaticFunction("SetGlobalColor", SetGlobalColor);
			self.BindStaticFunction("SetGlobalFloat", SetGlobalFloat);
			self.BindStaticFunction("SetGlobalFloatArray", SetGlobalFloatArray);
			self.BindStaticFunction("SetGlobalInt", SetGlobalInt);
			self.BindStaticFunction("SetGlobalMatrix", SetGlobalMatrix);
			self.BindStaticFunction("SetGlobalMatrixArray", SetGlobalMatrixArray);
			self.BindStaticFunction("SetGlobalTexture", SetGlobalTexture);
			self.BindStaticFunction("SetGlobalVector", SetGlobalVector);
			self.BindStaticFunction("SetGlobalVectorArray", SetGlobalVectorArray);
			self.BindStaticFunction("WarmupAllShaders", WarmupAllShaders);
			self.BindStaticProperty("globalMaximumLOD", get_globalMaximumLOD, set_globalMaximumLOD);
			self.BindStaticProperty("globalRenderPipeline", get_globalRenderPipeline, set_globalRenderPipeline);
			self.BindInstanceProperty("maximumLOD", get_maximumLOD, set_maximumLOD);
			self.BindInstanceProperty("isSupported", get_isSupported, null);
			self.BindInstanceProperty("renderQueue", get_renderQueue, null);
		}

		static private void DisableKeyword(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				UnityEngine.Shader.DisableKeyword(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.DisableKeyword has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.DisableKeyword has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void EnableKeyword(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				UnityEngine.Shader.EnableKeyword(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.EnableKeyword has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.EnableKeyword has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Shader Find(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Shader.Find(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.Find has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.Find has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.Color GetGlobalColor(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Shader.GetGlobalColor(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Shader.GetGlobalColor(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.GetGlobalColor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.GetGlobalColor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Color);
		}

		static private System.Single GetGlobalFloat(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Shader.GetGlobalFloat(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Shader.GetGlobalFloat(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.GetGlobalFloat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.GetGlobalFloat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single[] GetGlobalFloatArray(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Shader.GetGlobalFloatArray(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Shader.GetGlobalFloatArray(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.GetGlobalFloatArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.GetGlobalFloatArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 GetGlobalInt(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Shader.GetGlobalInt(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Shader.GetGlobalInt(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.GetGlobalInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.GetGlobalInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.Matrix4x4 GetGlobalMatrix(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Shader.GetGlobalMatrix(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Shader.GetGlobalMatrix(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.GetGlobalMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.GetGlobalMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private UnityEngine.Matrix4x4[] GetGlobalMatrixArray(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Shader.GetGlobalMatrixArray(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Shader.GetGlobalMatrixArray(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.GetGlobalMatrixArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.GetGlobalMatrixArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.Texture GetGlobalTexture(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Shader.GetGlobalTexture(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Shader.GetGlobalTexture(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.GetGlobalTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.GetGlobalTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.Vector4 GetGlobalVector(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Shader.GetGlobalVector(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Shader.GetGlobalVector(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.GetGlobalVector has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.GetGlobalVector has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector4);
		}

		static private UnityEngine.Vector4[] GetGlobalVectorArray(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Shader.GetGlobalVectorArray(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Shader.GetGlobalVectorArray(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.GetGlobalVectorArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.GetGlobalVectorArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean IsKeywordEnabled(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Shader.IsKeywordEnabled(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.IsKeywordEnabled has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.IsKeywordEnabled has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 PropertyToID(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Shader.PropertyToID(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.PropertyToID has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.PropertyToID has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void SetGlobalBuffer(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.ComputeBuffer>())
			{
				UnityEngine.Shader.SetGlobalBuffer(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.ComputeBuffer>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.ComputeBuffer>())
			{
				UnityEngine.Shader.SetGlobalBuffer(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.ComputeBuffer>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.SetGlobalBuffer has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.SetGlobalBuffer has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalColor(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Color>())
			{
				UnityEngine.Shader.SetGlobalColor(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Color>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.Color>())
			{
				UnityEngine.Shader.SetGlobalColor(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Color>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.SetGlobalColor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.SetGlobalColor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalFloat(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Single>())
			{
				UnityEngine.Shader.SetGlobalFloat(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Single>())
			{
				UnityEngine.Shader.SetGlobalFloat(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.SetGlobalFloat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.SetGlobalFloat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalFloatArray(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Single[]>())
			{
				UnityEngine.Shader.SetGlobalFloatArray(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single[]>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Single[]>())
			{
				UnityEngine.Shader.SetGlobalFloatArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.SetGlobalFloatArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.SetGlobalFloatArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalInt(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Int32>())
			{
				UnityEngine.Shader.SetGlobalInt(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				UnityEngine.Shader.SetGlobalInt(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.SetGlobalInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.SetGlobalInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalMatrix(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Matrix4x4>())
			{
				UnityEngine.Shader.SetGlobalMatrix(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.Matrix4x4>())
			{
				UnityEngine.Shader.SetGlobalMatrix(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.SetGlobalMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.SetGlobalMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalMatrixArray(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Matrix4x4[]>())
			{
				UnityEngine.Shader.SetGlobalMatrixArray(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Matrix4x4[]>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.Matrix4x4[]>())
			{
				UnityEngine.Shader.SetGlobalMatrixArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Matrix4x4[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.SetGlobalMatrixArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.SetGlobalMatrixArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalTexture(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Texture>())
			{
				UnityEngine.Shader.SetGlobalTexture(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Texture>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.Texture>())
			{
				UnityEngine.Shader.SetGlobalTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Texture>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.SetGlobalTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.SetGlobalTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalVector(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Vector4>())
			{
				UnityEngine.Shader.SetGlobalVector(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Vector4>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.Vector4>())
			{
				UnityEngine.Shader.SetGlobalVector(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Vector4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.SetGlobalVector has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.SetGlobalVector has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalVectorArray(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Vector4[]>())
			{
				UnityEngine.Shader.SetGlobalVectorArray(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Vector4[]>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.Vector4[]>())
			{
				UnityEngine.Shader.SetGlobalVectorArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Vector4[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Shader.SetGlobalVectorArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.SetGlobalVectorArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void WarmupAllShaders(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.Shader.WarmupAllShaders();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Shader.WarmupAllShaders has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Int32 get_globalMaximumLOD(Type type, string name)
		{
			return UnityEngine.Shader.globalMaximumLOD;
		}

		static private void set_globalMaximumLOD(Type type, string name, System.Int32 value)
		{
			UnityEngine.Shader.globalMaximumLOD = value;
		}

		static private System.String get_globalRenderPipeline(Type type, string name)
		{
			return UnityEngine.Shader.globalRenderPipeline;
		}

		static private void set_globalRenderPipeline(Type type, string name, System.String value)
		{
			UnityEngine.Shader.globalRenderPipeline = value;
		}

		static private System.Int32 get_maximumLOD(UnityEngine.Shader instance, string name)
		{
			return instance.maximumLOD;
		}

		static private void set_maximumLOD(UnityEngine.Shader instance, string name, System.Int32 value)
		{
			instance.maximumLOD = value;
		}

		static private System.Boolean get_isSupported(UnityEngine.Shader instance, string name)
		{
			return instance.isSupported;
		}

		static private System.Int32 get_renderQueue(UnityEngine.Shader instance, string name)
		{
			return instance.renderQueue;
		}

	}
}
