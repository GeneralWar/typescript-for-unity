using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingCommandBuffer
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Rendering.CommandBuffer> self = space.DeclareClass<UnityEngine.Rendering.CommandBuffer>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("BeginSample", BeginSample);
			self.BindInstanceFunction("Blit", Blit);
			self.BindInstanceFunction("Clear", Clear);
			self.BindInstanceFunction("ClearRandomWriteTargets", ClearRandomWriteTargets);
			self.BindInstanceFunction("ClearRenderTarget", ClearRenderTarget);
			self.BindInstanceFunction("ConvertTexture", ConvertTexture);
			self.BindInstanceFunction("CopyCounterValue", CopyCounterValue);
			self.BindInstanceFunction("CopyTexture", CopyTexture);
			self.BindInstanceFunction("CreateGPUFence", CreateGPUFence);
			self.BindInstanceFunction("DisableScissorRect", DisableScissorRect);
			self.BindInstanceFunction("DisableShaderKeyword", DisableShaderKeyword);
			self.BindInstanceFunction("DispatchCompute", DispatchCompute);
			self.BindInstanceFunction("Dispose", Dispose);
			self.BindInstanceFunction("DrawMesh", DrawMesh);
			self.BindInstanceFunction("DrawMeshInstanced", DrawMeshInstanced);
			self.BindInstanceFunction("DrawMeshInstancedIndirect", DrawMeshInstancedIndirect);
			self.BindInstanceFunction("DrawProcedural", DrawProcedural);
			self.BindInstanceFunction("DrawProceduralIndirect", DrawProceduralIndirect);
			self.BindInstanceFunction("DrawRenderer", DrawRenderer);
			self.BindInstanceFunction("EnableScissorRect", EnableScissorRect);
			self.BindInstanceFunction("EnableShaderKeyword", EnableShaderKeyword);
			self.BindInstanceFunction("EndSample", EndSample);
			self.BindInstanceFunction("GenerateMips", GenerateMips);
			self.BindInstanceFunction("GetTemporaryRT", GetTemporaryRT);
			self.BindInstanceFunction("GetTemporaryRTArray", GetTemporaryRTArray);
			self.BindInstanceFunction("IssuePluginCustomBlit", IssuePluginCustomBlit);
			self.BindInstanceFunction("IssuePluginCustomTextureUpdateV2", IssuePluginCustomTextureUpdateV2);
			self.BindInstanceFunction("IssuePluginEvent", IssuePluginEvent);
			self.BindInstanceFunction("IssuePluginEventAndData", IssuePluginEventAndData);
			self.BindInstanceFunction("Release", Release);
			self.BindInstanceFunction("ReleaseTemporaryRT", ReleaseTemporaryRT);
			self.BindInstanceFunction("ResolveAntiAliasedSurface", ResolveAntiAliasedSurface);
			self.BindInstanceFunction("SetComputeBufferParam", SetComputeBufferParam);
			self.BindInstanceFunction("SetComputeFloatParam", SetComputeFloatParam);
			self.BindInstanceFunction("SetComputeFloatParams", SetComputeFloatParams);
			self.BindInstanceFunction("SetComputeIntParam", SetComputeIntParam);
			self.BindInstanceFunction("SetComputeIntParams", SetComputeIntParams);
			self.BindInstanceFunction("SetComputeMatrixArrayParam", SetComputeMatrixArrayParam);
			self.BindInstanceFunction("SetComputeMatrixParam", SetComputeMatrixParam);
			self.BindInstanceFunction("SetComputeTextureParam", SetComputeTextureParam);
			self.BindInstanceFunction("SetComputeVectorArrayParam", SetComputeVectorArrayParam);
			self.BindInstanceFunction("SetComputeVectorParam", SetComputeVectorParam);
			self.BindInstanceFunction("SetGlobalBuffer", SetGlobalBuffer);
			self.BindInstanceFunction("SetGlobalColor", SetGlobalColor);
			self.BindInstanceFunction("SetGlobalDepthBias", SetGlobalDepthBias);
			self.BindInstanceFunction("SetGlobalFloat", SetGlobalFloat);
			self.BindInstanceFunction("SetGlobalFloatArray", SetGlobalFloatArray);
			self.BindInstanceFunction("SetGlobalInt", SetGlobalInt);
			self.BindInstanceFunction("SetGlobalMatrix", SetGlobalMatrix);
			self.BindInstanceFunction("SetGlobalMatrixArray", SetGlobalMatrixArray);
			self.BindInstanceFunction("SetGlobalTexture", SetGlobalTexture);
			self.BindInstanceFunction("SetGlobalVector", SetGlobalVector);
			self.BindInstanceFunction("SetGlobalVectorArray", SetGlobalVectorArray);
			self.BindInstanceFunction("SetInvertCulling", SetInvertCulling);
			self.BindInstanceFunction("SetProjectionMatrix", SetProjectionMatrix);
			self.BindInstanceFunction("SetRandomWriteTarget", SetRandomWriteTarget);
			self.BindInstanceFunction("SetRenderTarget", SetRenderTarget);
			self.BindInstanceFunction("SetShadowSamplingMode", SetShadowSamplingMode);
			self.BindInstanceFunction("SetViewMatrix", SetViewMatrix);
			self.BindInstanceFunction("SetViewport", SetViewport);
			self.BindInstanceFunction("SetViewProjectionMatrices", SetViewProjectionMatrices);
			self.BindInstanceFunction("WaitOnGPUFence", WaitOnGPUFence);
			self.BindInstanceProperty("name", get_name, set_name);
			self.BindInstanceProperty("sizeInBytes", get_sizeInBytes, null);
		}

		static private UnityEngine.Rendering.CommandBuffer Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Rendering.CommandBuffer();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Rendering.CommandBuffer);
		}

		static private void BeginSample(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.BeginSample(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.BeginSample has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.BeginSample has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Blit(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Texture, UnityEngine.Rendering.RenderTargetIdentifier>())
			{
				instance.Blit(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier>())
			{
				instance.Blit(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Texture, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Material>())
			{
				instance.Blit(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[2].ToObject<UnityEngine.Material>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Material>())
			{
				instance.Blit(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[2].ToObject<UnityEngine.Material>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Texture, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Vector2, UnityEngine.Vector2>())
			{
				instance.Blit(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[2].ToObject<UnityEngine.Vector2>(), parameters[3].ToObject<UnityEngine.Vector2>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Texture, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Material, System.Int32>())
			{
				instance.Blit(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Vector2, UnityEngine.Vector2>())
			{
				instance.Blit(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[2].ToObject<UnityEngine.Vector2>(), parameters[3].ToObject<UnityEngine.Vector2>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Material, System.Int32>())
			{
				instance.Blit(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.Blit has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.Blit has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Clear(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.Clear has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ClearRandomWriteTargets(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ClearRandomWriteTargets();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.ClearRandomWriteTargets has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ClearRenderTarget(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean, System.Boolean, UnityEngine.Color>())
			{
				instance.ClearRenderTarget(parameters[0].ToObject<System.Boolean>(), parameters[1].ToObject<System.Boolean>(), parameters[2].ToObject<UnityEngine.Color>());
				return;
			}
			if (parameters.CheckTypes<System.Boolean, System.Boolean, UnityEngine.Color, System.Single>())
			{
				instance.ClearRenderTarget(parameters[0].ToObject<System.Boolean>(), parameters[1].ToObject<System.Boolean>(), parameters[2].ToObject<UnityEngine.Color>(), parameters[3].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.ClearRenderTarget has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.ClearRenderTarget has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void ConvertTexture(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier>())
			{
				instance.ConvertTexture(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, System.Int32, UnityEngine.Rendering.RenderTargetIdentifier, System.Int32>())
			{
				instance.ConvertTexture(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.ConvertTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.ConvertTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void CopyCounterValue(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ComputeBuffer, UnityEngine.ComputeBuffer, System.UInt32>())
			{
				instance.CopyCounterValue(parameters[0].ToObject<UnityEngine.ComputeBuffer>(), parameters[1].ToObject<UnityEngine.ComputeBuffer>(), parameters[2].ToObject<System.UInt32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.CopyCounterValue has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.CopyCounterValue has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void CopyTexture(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier>())
			{
				instance.CopyTexture(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, System.Int32, UnityEngine.Rendering.RenderTargetIdentifier, System.Int32>())
			{
				instance.CopyTexture(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, System.Int32, System.Int32, UnityEngine.Rendering.RenderTargetIdentifier, System.Int32, System.Int32>())
			{
				instance.CopyTexture(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, System.Int32, System.Int32, System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.Rendering.RenderTargetIdentifier, System.Int32, System.Int32, System.Int32, System.Int32>())
			{
				instance.CopyTexture(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<System.Int32>(), parameters[7].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[8].ToObject<System.Int32>(), parameters[9].ToObject<System.Int32>(), parameters[10].ToObject<System.Int32>(), parameters[11].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.CopyTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.CopyTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Rendering.GPUFence CreateGPUFence(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.CreateGPUFence();
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.SynchronisationStage>())
			{
				return instance.CreateGPUFence(parameters[0].ToObject<UnityEngine.Rendering.SynchronisationStage>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.CreateGPUFence has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Rendering.GPUFence);
		}

		static private void DisableScissorRect(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.DisableScissorRect();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.DisableScissorRect has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void DisableShaderKeyword(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.DisableShaderKeyword(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.DisableShaderKeyword has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.DisableShaderKeyword has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DispatchCompute(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.Int32, UnityEngine.ComputeBuffer, System.UInt32>())
			{
				instance.DispatchCompute(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.ComputeBuffer>(), parameters[3].ToObject<System.UInt32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.Int32, System.Int32, System.Int32, System.Int32>())
			{
				instance.DispatchCompute(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.DispatchCompute has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.DispatchCompute has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Dispose(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.Dispose has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void DrawMesh(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material>())
			{
				instance.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<UnityEngine.Material>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32>())
			{
				instance.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, System.Int32>())
			{
				instance.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, System.Int32, UnityEngine.MaterialPropertyBlock>())
			{
				instance.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.MaterialPropertyBlock>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.DrawMesh has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.DrawMesh has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawMeshInstanced(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, System.Int32, UnityEngine.Matrix4x4[]>())
			{
				instance.DrawMeshInstanced(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Matrix4x4[]>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, System.Int32, UnityEngine.Matrix4x4[], System.Int32>())
			{
				instance.DrawMeshInstanced(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Matrix4x4[]>(), parameters[5].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, System.Int32, UnityEngine.Matrix4x4[], System.Int32, UnityEngine.MaterialPropertyBlock>())
			{
				instance.DrawMeshInstanced(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Matrix4x4[]>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.DrawMeshInstanced has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.DrawMeshInstanced has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawMeshInstancedIndirect(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, System.Int32, UnityEngine.ComputeBuffer>())
			{
				instance.DrawMeshInstancedIndirect(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.ComputeBuffer>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, System.Int32, UnityEngine.ComputeBuffer, System.Int32>())
			{
				instance.DrawMeshInstancedIndirect(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.ComputeBuffer>(), parameters[5].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, System.Int32, UnityEngine.ComputeBuffer, System.Int32, UnityEngine.MaterialPropertyBlock>())
			{
				instance.DrawMeshInstancedIndirect(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.ComputeBuffer>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.DrawMeshInstancedIndirect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.DrawMeshInstancedIndirect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawProcedural(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.MeshTopology, System.Int32>())
			{
				instance.DrawProcedural(parameters[0].ToObject<UnityEngine.Matrix4x4>(), parameters[1].ToObject<UnityEngine.Material>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.MeshTopology>(), parameters[4].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.MeshTopology, System.Int32, System.Int32>())
			{
				instance.DrawProcedural(parameters[0].ToObject<UnityEngine.Matrix4x4>(), parameters[1].ToObject<UnityEngine.Material>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.MeshTopology>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.MeshTopology, System.Int32, System.Int32, UnityEngine.MaterialPropertyBlock>())
			{
				instance.DrawProcedural(parameters[0].ToObject<UnityEngine.Matrix4x4>(), parameters[1].ToObject<UnityEngine.Material>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.MeshTopology>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.DrawProcedural has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.DrawProcedural has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawProceduralIndirect(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer>())
			{
				instance.DrawProceduralIndirect(parameters[0].ToObject<UnityEngine.Matrix4x4>(), parameters[1].ToObject<UnityEngine.Material>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.MeshTopology>(), parameters[4].ToObject<UnityEngine.ComputeBuffer>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, System.Int32>())
			{
				instance.DrawProceduralIndirect(parameters[0].ToObject<UnityEngine.Matrix4x4>(), parameters[1].ToObject<UnityEngine.Material>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.MeshTopology>(), parameters[4].ToObject<UnityEngine.ComputeBuffer>(), parameters[5].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, System.Int32, UnityEngine.MaterialPropertyBlock>())
			{
				instance.DrawProceduralIndirect(parameters[0].ToObject<UnityEngine.Matrix4x4>(), parameters[1].ToObject<UnityEngine.Material>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.MeshTopology>(), parameters[4].ToObject<UnityEngine.ComputeBuffer>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.DrawProceduralIndirect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.DrawProceduralIndirect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawRenderer(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Renderer, UnityEngine.Material>())
			{
				instance.DrawRenderer(parameters[0].ToObject<UnityEngine.Renderer>(), parameters[1].ToObject<UnityEngine.Material>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Renderer, UnityEngine.Material, System.Int32>())
			{
				instance.DrawRenderer(parameters[0].ToObject<UnityEngine.Renderer>(), parameters[1].ToObject<UnityEngine.Material>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Renderer, UnityEngine.Material, System.Int32, System.Int32>())
			{
				instance.DrawRenderer(parameters[0].ToObject<UnityEngine.Renderer>(), parameters[1].ToObject<UnityEngine.Material>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.DrawRenderer has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.DrawRenderer has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void EnableScissorRect(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rect>())
			{
				instance.EnableScissorRect(parameters[0].ToObject<UnityEngine.Rect>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.EnableScissorRect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.EnableScissorRect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void EnableShaderKeyword(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.EnableShaderKeyword(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.EnableShaderKeyword has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.EnableShaderKeyword has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void EndSample(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.EndSample(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.EndSample has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.EndSample has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void GenerateMips(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RenderTexture>())
			{
				instance.GenerateMips(parameters[0].ToObject<UnityEngine.RenderTexture>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.GenerateMips has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.GenerateMips has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void GetTemporaryRT(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.RenderTextureDescriptor>())
			{
				instance.GetTemporaryRT(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.RenderTextureDescriptor>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32>())
			{
				instance.GetTemporaryRT(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.RenderTextureDescriptor, UnityEngine.FilterMode>())
			{
				instance.GetTemporaryRT(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.RenderTextureDescriptor>(), parameters[2].ToObject<UnityEngine.FilterMode>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32>())
			{
				instance.GetTemporaryRT(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.FilterMode>())
			{
				instance.GetTemporaryRT(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.FilterMode>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat>())
			{
				instance.GetTemporaryRT(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.FilterMode>(), parameters[5].ToObject<UnityEngine.RenderTextureFormat>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite>())
			{
				instance.GetTemporaryRT(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.FilterMode>(), parameters[5].ToObject<UnityEngine.RenderTextureFormat>(), parameters[6].ToObject<UnityEngine.RenderTextureReadWrite>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, System.Int32>())
			{
				instance.GetTemporaryRT(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.FilterMode>(), parameters[5].ToObject<UnityEngine.RenderTextureFormat>(), parameters[6].ToObject<UnityEngine.RenderTextureReadWrite>(), parameters[7].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, System.Int32, System.Boolean>())
			{
				instance.GetTemporaryRT(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.FilterMode>(), parameters[5].ToObject<UnityEngine.RenderTextureFormat>(), parameters[6].ToObject<UnityEngine.RenderTextureReadWrite>(), parameters[7].ToObject<System.Int32>(), parameters[8].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, System.Int32, System.Boolean, UnityEngine.RenderTextureMemoryless>())
			{
				instance.GetTemporaryRT(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.FilterMode>(), parameters[5].ToObject<UnityEngine.RenderTextureFormat>(), parameters[6].ToObject<UnityEngine.RenderTextureReadWrite>(), parameters[7].ToObject<System.Int32>(), parameters[8].ToObject<System.Boolean>(), parameters[9].ToObject<UnityEngine.RenderTextureMemoryless>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, System.Int32, System.Boolean, UnityEngine.RenderTextureMemoryless, System.Boolean>())
			{
				instance.GetTemporaryRT(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.FilterMode>(), parameters[5].ToObject<UnityEngine.RenderTextureFormat>(), parameters[6].ToObject<UnityEngine.RenderTextureReadWrite>(), parameters[7].ToObject<System.Int32>(), parameters[8].ToObject<System.Boolean>(), parameters[9].ToObject<UnityEngine.RenderTextureMemoryless>(), parameters[10].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.GetTemporaryRT has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.GetTemporaryRT has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void GetTemporaryRTArray(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32>())
			{
				instance.GetTemporaryRTArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, System.Int32>())
			{
				instance.GetTemporaryRTArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.FilterMode>())
			{
				instance.GetTemporaryRTArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.FilterMode>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat>())
			{
				instance.GetTemporaryRTArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.FilterMode>(), parameters[6].ToObject<UnityEngine.RenderTextureFormat>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite>())
			{
				instance.GetTemporaryRTArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.FilterMode>(), parameters[6].ToObject<UnityEngine.RenderTextureFormat>(), parameters[7].ToObject<UnityEngine.RenderTextureReadWrite>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, System.Int32>())
			{
				instance.GetTemporaryRTArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.FilterMode>(), parameters[6].ToObject<UnityEngine.RenderTextureFormat>(), parameters[7].ToObject<UnityEngine.RenderTextureReadWrite>(), parameters[8].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, System.Int32, System.Boolean>())
			{
				instance.GetTemporaryRTArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.FilterMode>(), parameters[6].ToObject<UnityEngine.RenderTextureFormat>(), parameters[7].ToObject<UnityEngine.RenderTextureReadWrite>(), parameters[8].ToObject<System.Int32>(), parameters[9].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.FilterMode, UnityEngine.RenderTextureFormat, UnityEngine.RenderTextureReadWrite, System.Int32, System.Boolean, System.Boolean>())
			{
				instance.GetTemporaryRTArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.FilterMode>(), parameters[6].ToObject<UnityEngine.RenderTextureFormat>(), parameters[7].ToObject<UnityEngine.RenderTextureReadWrite>(), parameters[8].ToObject<System.Int32>(), parameters[9].ToObject<System.Boolean>(), parameters[10].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.GetTemporaryRTArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.GetTemporaryRTArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void IssuePluginCustomBlit(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.UInt32, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, System.UInt32, System.UInt32>())
			{
				instance.IssuePluginCustomBlit(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.UInt32>(), parameters[2].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[3].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[4].ToObject<System.UInt32>(), parameters[5].ToObject<System.UInt32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.IssuePluginCustomBlit has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.IssuePluginCustomBlit has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void IssuePluginCustomTextureUpdateV2(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, UnityEngine.Texture, System.UInt32>())
			{
				instance.IssuePluginCustomTextureUpdateV2(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<UnityEngine.Texture>(), parameters[2].ToObject<System.UInt32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.IssuePluginCustomTextureUpdateV2 has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.IssuePluginCustomTextureUpdateV2 has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void IssuePluginEvent(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32>())
			{
				instance.IssuePluginEvent(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.IssuePluginEvent has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.IssuePluginEvent has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void IssuePluginEventAndData(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IntPtr, System.Int32, System.IntPtr>())
			{
				instance.IssuePluginEventAndData(parameters[0].ToObject<System.IntPtr>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.IntPtr>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.IssuePluginEventAndData has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.IssuePluginEventAndData has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Release(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Release();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.Release has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ReleaseTemporaryRT(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.ReleaseTemporaryRT(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.ReleaseTemporaryRT has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.ReleaseTemporaryRT has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void ResolveAntiAliasedSurface(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RenderTexture, UnityEngine.RenderTexture>())
			{
				instance.ResolveAntiAliasedSurface(parameters[0].ToObject<UnityEngine.RenderTexture>(), parameters[1].ToObject<UnityEngine.RenderTexture>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.ResolveAntiAliasedSurface has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.ResolveAntiAliasedSurface has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetComputeBufferParam(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.Int32, System.Int32, UnityEngine.ComputeBuffer>())
			{
				instance.SetComputeBufferParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.ComputeBuffer>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.Int32, System.String, UnityEngine.ComputeBuffer>())
			{
				instance.SetComputeBufferParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.String>(), parameters[3].ToObject<UnityEngine.ComputeBuffer>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetComputeBufferParam has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetComputeBufferParam has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetComputeFloatParam(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.Int32, System.Single>())
			{
				instance.SetComputeFloatParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.String, System.Single>())
			{
				instance.SetComputeFloatParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetComputeFloatParam has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetComputeFloatParam has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetComputeFloatParams(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.String, System.Single[]>())
			{
				instance.SetComputeFloatParams(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Single[]>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.Int32, System.Single[]>())
			{
				instance.SetComputeFloatParams(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Single[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetComputeFloatParams has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetComputeFloatParams has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetComputeIntParam(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.Int32, System.Int32>())
			{
				instance.SetComputeIntParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.String, System.Int32>())
			{
				instance.SetComputeIntParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetComputeIntParam has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetComputeIntParam has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetComputeIntParams(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.String, System.Int32[]>())
			{
				instance.SetComputeIntParams(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Int32[]>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.Int32, System.Int32[]>())
			{
				instance.SetComputeIntParams(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetComputeIntParams has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetComputeIntParams has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetComputeMatrixArrayParam(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.Int32, UnityEngine.Matrix4x4[]>())
			{
				instance.SetComputeMatrixArrayParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Matrix4x4[]>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.String, UnityEngine.Matrix4x4[]>())
			{
				instance.SetComputeMatrixArrayParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<UnityEngine.Matrix4x4[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetComputeMatrixArrayParam has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetComputeMatrixArrayParam has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetComputeMatrixParam(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.Int32, UnityEngine.Matrix4x4>())
			{
				instance.SetComputeMatrixParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.String, UnityEngine.Matrix4x4>())
			{
				instance.SetComputeMatrixParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetComputeMatrixParam has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetComputeMatrixParam has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetComputeTextureParam(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.Int32, System.String, UnityEngine.Rendering.RenderTargetIdentifier>())
			{
				instance.SetComputeTextureParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.String>(), parameters[3].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.Int32, System.Int32, UnityEngine.Rendering.RenderTargetIdentifier>())
			{
				instance.SetComputeTextureParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.Int32, System.String, UnityEngine.Rendering.RenderTargetIdentifier, System.Int32>())
			{
				instance.SetComputeTextureParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.String>(), parameters[3].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[4].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.Int32, System.Int32, UnityEngine.Rendering.RenderTargetIdentifier, System.Int32>())
			{
				instance.SetComputeTextureParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[4].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetComputeTextureParam has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetComputeTextureParam has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetComputeVectorArrayParam(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.Int32, UnityEngine.Vector4[]>())
			{
				instance.SetComputeVectorArrayParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Vector4[]>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.String, UnityEngine.Vector4[]>())
			{
				instance.SetComputeVectorArrayParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<UnityEngine.Vector4[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetComputeVectorArrayParam has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetComputeVectorArrayParam has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetComputeVectorParam(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.Int32, UnityEngine.Vector4>())
			{
				instance.SetComputeVectorParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Vector4>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.ComputeShader, System.String, UnityEngine.Vector4>())
			{
				instance.SetComputeVectorParam(parameters[0].ToObject<UnityEngine.ComputeShader>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<UnityEngine.Vector4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetComputeVectorParam has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetComputeVectorParam has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalBuffer(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.ComputeBuffer>())
			{
				instance.SetGlobalBuffer(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.ComputeBuffer>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.ComputeBuffer>())
			{
				instance.SetGlobalBuffer(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.ComputeBuffer>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetGlobalBuffer has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetGlobalBuffer has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalColor(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Color>())
			{
				instance.SetGlobalColor(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Color>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.Color>())
			{
				instance.SetGlobalColor(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Color>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetGlobalColor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetGlobalColor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalDepthBias(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				instance.SetGlobalDepthBias(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetGlobalDepthBias has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetGlobalDepthBias has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalFloat(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Single>())
			{
				instance.SetGlobalFloat(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Single>())
			{
				instance.SetGlobalFloat(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetGlobalFloat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetGlobalFloat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalFloatArray(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Single[]>())
			{
				instance.SetGlobalFloatArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single[]>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Single[]>())
			{
				instance.SetGlobalFloatArray(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetGlobalFloatArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetGlobalFloatArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalInt(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				instance.SetGlobalInt(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Int32>())
			{
				instance.SetGlobalInt(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetGlobalInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetGlobalInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalMatrix(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Matrix4x4>())
			{
				instance.SetGlobalMatrix(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.Matrix4x4>())
			{
				instance.SetGlobalMatrix(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetGlobalMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetGlobalMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalMatrixArray(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Matrix4x4[]>())
			{
				instance.SetGlobalMatrixArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Matrix4x4[]>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.Matrix4x4[]>())
			{
				instance.SetGlobalMatrixArray(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Matrix4x4[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetGlobalMatrixArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetGlobalMatrixArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalTexture(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Rendering.RenderTargetIdentifier>())
			{
				instance.SetGlobalTexture(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.Rendering.RenderTargetIdentifier>())
			{
				instance.SetGlobalTexture(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetGlobalTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetGlobalTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalVector(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Vector4>())
			{
				instance.SetGlobalVector(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Vector4>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.Vector4>())
			{
				instance.SetGlobalVector(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Vector4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetGlobalVector has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetGlobalVector has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetGlobalVectorArray(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Vector4[]>())
			{
				instance.SetGlobalVectorArray(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Vector4[]>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.Vector4[]>())
			{
				instance.SetGlobalVectorArray(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Vector4[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetGlobalVectorArray has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetGlobalVectorArray has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetInvertCulling(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean>())
			{
				instance.SetInvertCulling(parameters[0].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetInvertCulling has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetInvertCulling has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetProjectionMatrix(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Matrix4x4>())
			{
				instance.SetProjectionMatrix(parameters[0].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetProjectionMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetProjectionMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetRandomWriteTarget(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Rendering.RenderTargetIdentifier>())
			{
				instance.SetRandomWriteTarget(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.ComputeBuffer>())
			{
				instance.SetRandomWriteTarget(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.ComputeBuffer>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.ComputeBuffer, System.Boolean>())
			{
				instance.SetRandomWriteTarget(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.ComputeBuffer>(), parameters[2].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetRandomWriteTarget has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetRandomWriteTarget has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetRenderTarget(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier>())
			{
				instance.SetRenderTarget(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetBinding>())
			{
				instance.SetRenderTarget(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetBinding>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, System.Int32>())
			{
				instance.SetRenderTarget(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier>())
			{
				instance.SetRenderTarget(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier[], UnityEngine.Rendering.RenderTargetIdentifier>())
			{
				instance.SetRenderTarget(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier[]>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction>())
			{
				instance.SetRenderTarget(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<UnityEngine.Rendering.RenderBufferLoadAction>(), parameters[2].ToObject<UnityEngine.Rendering.RenderBufferStoreAction>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, System.Int32, UnityEngine.CubemapFace>())
			{
				instance.SetRenderTarget(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.CubemapFace>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, System.Int32>())
			{
				instance.SetRenderTarget(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, System.Int32, UnityEngine.CubemapFace, System.Int32>())
			{
				instance.SetRenderTarget(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.CubemapFace>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, System.Int32, UnityEngine.CubemapFace>())
			{
				instance.SetRenderTarget(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.CubemapFace>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction>())
			{
				instance.SetRenderTarget(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<UnityEngine.Rendering.RenderBufferLoadAction>(), parameters[2].ToObject<UnityEngine.Rendering.RenderBufferStoreAction>(), parameters[3].ToObject<UnityEngine.Rendering.RenderBufferLoadAction>(), parameters[4].ToObject<UnityEngine.Rendering.RenderBufferStoreAction>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderTargetIdentifier, System.Int32, UnityEngine.CubemapFace, System.Int32>())
			{
				instance.SetRenderTarget(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.CubemapFace>(), parameters[4].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction, UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.RenderBufferLoadAction, UnityEngine.Rendering.RenderBufferStoreAction>())
			{
				instance.SetRenderTarget(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<UnityEngine.Rendering.RenderBufferLoadAction>(), parameters[2].ToObject<UnityEngine.Rendering.RenderBufferStoreAction>(), parameters[3].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[4].ToObject<UnityEngine.Rendering.RenderBufferLoadAction>(), parameters[5].ToObject<UnityEngine.Rendering.RenderBufferStoreAction>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetRenderTarget has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetRenderTarget has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetShadowSamplingMode(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.RenderTargetIdentifier, UnityEngine.Rendering.ShadowSamplingMode>())
			{
				instance.SetShadowSamplingMode(parameters[0].ToObject<UnityEngine.Rendering.RenderTargetIdentifier>(), parameters[1].ToObject<UnityEngine.Rendering.ShadowSamplingMode>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetShadowSamplingMode has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetShadowSamplingMode has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetViewMatrix(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Matrix4x4>())
			{
				instance.SetViewMatrix(parameters[0].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetViewMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetViewMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetViewport(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rect>())
			{
				instance.SetViewport(parameters[0].ToObject<UnityEngine.Rect>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetViewport has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetViewport has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetViewProjectionMatrices(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Matrix4x4, UnityEngine.Matrix4x4>())
			{
				instance.SetViewProjectionMatrices(parameters[0].ToObject<UnityEngine.Matrix4x4>(), parameters[1].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.SetViewProjectionMatrices has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.SetViewProjectionMatrices has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void WaitOnGPUFence(UnityEngine.Rendering.CommandBuffer instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.GPUFence>())
			{
				instance.WaitOnGPUFence(parameters[0].ToObject<UnityEngine.Rendering.GPUFence>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.GPUFence, UnityEngine.Rendering.SynchronisationStage>())
			{
				instance.WaitOnGPUFence(parameters[0].ToObject<UnityEngine.Rendering.GPUFence>(), parameters[1].ToObject<UnityEngine.Rendering.SynchronisationStage>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Rendering.CommandBuffer.WaitOnGPUFence has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.CommandBuffer.WaitOnGPUFence has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.String get_name(UnityEngine.Rendering.CommandBuffer instance, string name)
		{
			return instance.name;
		}

		static private void set_name(UnityEngine.Rendering.CommandBuffer instance, string name, System.String value)
		{
			instance.name = value;
		}

		static private System.Int32 get_sizeInBytes(UnityEngine.Rendering.CommandBuffer instance, string name)
		{
			return instance.sizeInBytes;
		}

	}
}
