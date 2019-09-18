using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineGraphics
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Graphics> self = space.DeclareClass<UnityEngine.Graphics>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("Blit", Blit);
			self.BindStaticFunction("BlitMultiTap", BlitMultiTap);
			self.BindStaticFunction("ClearRandomWriteTargets", ClearRandomWriteTargets);
			self.BindStaticFunction("ConvertTexture", ConvertTexture);
			self.BindStaticFunction("CopyTexture", CopyTexture);
			self.BindStaticFunction("CreateGPUFence", CreateGPUFence);
			self.BindStaticFunction("DrawMesh", DrawMesh);
			self.BindStaticFunction("DrawMeshInstanced", DrawMeshInstanced);
			self.BindStaticFunction("DrawMeshInstancedIndirect", DrawMeshInstancedIndirect);
			self.BindStaticFunction("DrawMeshNow", DrawMeshNow);
			self.BindStaticFunction("DrawProcedural", DrawProcedural);
			self.BindStaticFunction("DrawProceduralIndirect", DrawProceduralIndirect);
			self.BindStaticFunction("DrawTexture", DrawTexture);
			self.BindStaticFunction("ExecuteCommandBuffer", ExecuteCommandBuffer);
			self.BindStaticFunction("ExecuteCommandBufferAsync", ExecuteCommandBufferAsync);
			self.BindStaticFunction("SetRandomWriteTarget", SetRandomWriteTarget);
			self.BindStaticFunction("SetRenderTarget", SetRenderTarget);
			self.BindStaticFunction("WaitOnGPUFence", WaitOnGPUFence);
			self.BindStaticProperty("activeColorGamut", get_activeColorGamut, null);
			self.BindStaticProperty("activeTier", get_activeTier, set_activeTier);
			self.BindStaticProperty("activeColorBuffer", get_activeColorBuffer, null);
			self.BindStaticProperty("activeDepthBuffer", get_activeDepthBuffer, null);
		}

		static private UnityEngine.Graphics Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Graphics();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Graphics);
		}

		static private void Blit(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Texture, UnityEngine.RenderTexture>())
			{
				UnityEngine.Graphics.Blit(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<UnityEngine.RenderTexture>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Texture, UnityEngine.Material>())
			{
				UnityEngine.Graphics.Blit(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<UnityEngine.Material>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Texture, UnityEngine.RenderTexture, UnityEngine.Material>())
			{
				UnityEngine.Graphics.Blit(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<UnityEngine.RenderTexture>(), parameters[2].ToObject<UnityEngine.Material>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Texture, UnityEngine.Material, System.Int32>())
			{
				UnityEngine.Graphics.Blit(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<UnityEngine.Material>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Texture, UnityEngine.RenderTexture, UnityEngine.Vector2, UnityEngine.Vector2>())
			{
				UnityEngine.Graphics.Blit(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<UnityEngine.RenderTexture>(), parameters[2].ToObject<UnityEngine.Vector2>(), parameters[3].ToObject<UnityEngine.Vector2>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Texture, UnityEngine.RenderTexture, UnityEngine.Material, System.Int32>())
			{
				UnityEngine.Graphics.Blit(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<UnityEngine.RenderTexture>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Graphics.Blit has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.Blit has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void BlitMultiTap(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Texture, UnityEngine.RenderTexture, UnityEngine.Material, UnityEngine.Vector2[]>())
			{
				UnityEngine.Graphics.BlitMultiTap(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<UnityEngine.RenderTexture>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Vector2[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Graphics.BlitMultiTap has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.BlitMultiTap has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void ClearRandomWriteTargets(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.Graphics.ClearRandomWriteTargets();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.ClearRandomWriteTargets has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean ConvertTexture(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Texture, UnityEngine.Texture>())
			{
				return UnityEngine.Graphics.ConvertTexture(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<UnityEngine.Texture>());
			}
			if (parameters.CheckTypes<UnityEngine.Texture, System.Int32, UnityEngine.Texture, System.Int32>())
			{
				return UnityEngine.Graphics.ConvertTexture(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Texture>(), parameters[3].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Graphics.ConvertTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.ConvertTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void CopyTexture(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Texture, UnityEngine.Texture>())
			{
				UnityEngine.Graphics.CopyTexture(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<UnityEngine.Texture>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Texture, System.Int32, UnityEngine.Texture, System.Int32>())
			{
				UnityEngine.Graphics.CopyTexture(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Texture>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Texture, System.Int32, System.Int32, UnityEngine.Texture, System.Int32, System.Int32>())
			{
				UnityEngine.Graphics.CopyTexture(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.Texture>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Texture, System.Int32, System.Int32, System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.Texture, System.Int32, System.Int32, System.Int32, System.Int32>())
			{
				UnityEngine.Graphics.CopyTexture(parameters[0].ToObject<UnityEngine.Texture>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<System.Int32>(), parameters[7].ToObject<UnityEngine.Texture>(), parameters[8].ToObject<System.Int32>(), parameters[9].ToObject<System.Int32>(), parameters[10].ToObject<System.Int32>(), parameters[11].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Graphics.CopyTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.CopyTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Rendering.GPUFence CreateGPUFence(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.Graphics.CreateGPUFence();
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.SynchronisationStage>())
			{
				return UnityEngine.Graphics.CreateGPUFence(parameters[0].ToObject<UnityEngine.Rendering.SynchronisationStage>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.CreateGPUFence has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Rendering.GPUFence);
		}

		static private void DrawMesh(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.Camera>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Camera>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Material, System.Int32>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<UnityEngine.Material>(), parameters[4].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Camera>(), parameters[5].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Material, System.Int32, UnityEngine.Camera>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<UnityEngine.Material>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.Camera>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<UnityEngine.Material>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.Camera>(), parameters[6].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Camera>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock, System.Boolean>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Camera>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[7].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<UnityEngine.Material>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.Camera>(), parameters[6].ToObject<System.Int32>(), parameters[7].ToObject<UnityEngine.MaterialPropertyBlock>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Camera>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[7].ToObject<UnityEngine.Rendering.ShadowCastingMode>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock, System.Boolean, System.Boolean>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Camera>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[7].ToObject<System.Boolean>(), parameters[8].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock, System.Boolean>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<UnityEngine.Material>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.Camera>(), parameters[6].ToObject<System.Int32>(), parameters[7].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[8].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Camera>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[7].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[8].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<UnityEngine.Material>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.Camera>(), parameters[6].ToObject<System.Int32>(), parameters[7].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[8].ToObject<UnityEngine.Rendering.ShadowCastingMode>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock, System.Boolean, System.Boolean>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<UnityEngine.Material>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.Camera>(), parameters[6].ToObject<System.Int32>(), parameters[7].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[8].ToObject<System.Boolean>(), parameters[9].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock, System.Boolean, System.Boolean, System.Boolean>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Camera>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[7].ToObject<System.Boolean>(), parameters[8].ToObject<System.Boolean>(), parameters[9].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean, UnityEngine.Transform>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Camera>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[7].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[8].ToObject<System.Boolean>(), parameters[9].ToObject<UnityEngine.Transform>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<UnityEngine.Material>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.Camera>(), parameters[6].ToObject<System.Int32>(), parameters[7].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[8].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[9].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock, System.Boolean, System.Boolean, System.Boolean>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<UnityEngine.Material>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.Camera>(), parameters[6].ToObject<System.Int32>(), parameters[7].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[8].ToObject<System.Boolean>(), parameters[9].ToObject<System.Boolean>(), parameters[10].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean, UnityEngine.Transform, System.Boolean>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Camera>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[7].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[8].ToObject<System.Boolean>(), parameters[9].ToObject<UnityEngine.Transform>(), parameters[10].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean, UnityEngine.Transform>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<UnityEngine.Material>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.Camera>(), parameters[6].ToObject<System.Int32>(), parameters[7].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[8].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[9].ToObject<System.Boolean>(), parameters[10].ToObject<UnityEngine.Transform>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean, UnityEngine.Transform, UnityEngine.Rendering.LightProbeUsage>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Camera>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[7].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[8].ToObject<System.Boolean>(), parameters[9].ToObject<UnityEngine.Transform>(), parameters[10].ToObject<UnityEngine.Rendering.LightProbeUsage>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean, UnityEngine.Transform, UnityEngine.Rendering.LightProbeUsage, UnityEngine.LightProbeProxyVolume>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<UnityEngine.Camera>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[7].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[8].ToObject<System.Boolean>(), parameters[9].ToObject<UnityEngine.Transform>(), parameters[10].ToObject<UnityEngine.Rendering.LightProbeUsage>(), parameters[11].ToObject<UnityEngine.LightProbeProxyVolume>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Material, System.Int32, UnityEngine.Camera, System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean, UnityEngine.Transform, System.Boolean>())
			{
				UnityEngine.Graphics.DrawMesh(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<UnityEngine.Material>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.Camera>(), parameters[6].ToObject<System.Int32>(), parameters[7].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[8].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[9].ToObject<System.Boolean>(), parameters[10].ToObject<UnityEngine.Transform>(), parameters[11].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Graphics.DrawMesh has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.DrawMesh has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawMeshInstanced(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Matrix4x4[]>())
			{
				UnityEngine.Graphics.DrawMeshInstanced(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Matrix4x4[]>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Matrix4x4[], System.Int32>())
			{
				UnityEngine.Graphics.DrawMeshInstanced(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Matrix4x4[]>(), parameters[4].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Matrix4x4[], System.Int32, UnityEngine.MaterialPropertyBlock>())
			{
				UnityEngine.Graphics.DrawMeshInstanced(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Matrix4x4[]>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.MaterialPropertyBlock>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Matrix4x4[], System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode>())
			{
				UnityEngine.Graphics.DrawMeshInstanced(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Matrix4x4[]>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[6].ToObject<UnityEngine.Rendering.ShadowCastingMode>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Matrix4x4[], System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean>())
			{
				UnityEngine.Graphics.DrawMeshInstanced(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Matrix4x4[]>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[6].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[7].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Matrix4x4[], System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean, System.Int32>())
			{
				UnityEngine.Graphics.DrawMeshInstanced(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Matrix4x4[]>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[6].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[7].ToObject<System.Boolean>(), parameters[8].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Matrix4x4[], System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean, System.Int32, UnityEngine.Camera>())
			{
				UnityEngine.Graphics.DrawMeshInstanced(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Matrix4x4[]>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[6].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[7].ToObject<System.Boolean>(), parameters[8].ToObject<System.Int32>(), parameters[9].ToObject<UnityEngine.Camera>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Matrix4x4[], System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean, System.Int32, UnityEngine.Camera, UnityEngine.Rendering.LightProbeUsage>())
			{
				UnityEngine.Graphics.DrawMeshInstanced(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Matrix4x4[]>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[6].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[7].ToObject<System.Boolean>(), parameters[8].ToObject<System.Int32>(), parameters[9].ToObject<UnityEngine.Camera>(), parameters[10].ToObject<UnityEngine.Rendering.LightProbeUsage>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Matrix4x4[], System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean, System.Int32, UnityEngine.Camera, UnityEngine.Rendering.LightProbeUsage, UnityEngine.LightProbeProxyVolume>())
			{
				UnityEngine.Graphics.DrawMeshInstanced(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Matrix4x4[]>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[6].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[7].ToObject<System.Boolean>(), parameters[8].ToObject<System.Int32>(), parameters[9].ToObject<UnityEngine.Camera>(), parameters[10].ToObject<UnityEngine.Rendering.LightProbeUsage>(), parameters[11].ToObject<UnityEngine.LightProbeProxyVolume>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Graphics.DrawMeshInstanced has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.DrawMeshInstanced has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawMeshInstancedIndirect(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Bounds, UnityEngine.ComputeBuffer>())
			{
				UnityEngine.Graphics.DrawMeshInstancedIndirect(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Bounds>(), parameters[4].ToObject<UnityEngine.ComputeBuffer>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Bounds, UnityEngine.ComputeBuffer, System.Int32>())
			{
				UnityEngine.Graphics.DrawMeshInstancedIndirect(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Bounds>(), parameters[4].ToObject<UnityEngine.ComputeBuffer>(), parameters[5].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Bounds, UnityEngine.ComputeBuffer, System.Int32, UnityEngine.MaterialPropertyBlock>())
			{
				UnityEngine.Graphics.DrawMeshInstancedIndirect(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Bounds>(), parameters[4].ToObject<UnityEngine.ComputeBuffer>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Bounds, UnityEngine.ComputeBuffer, System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode>())
			{
				UnityEngine.Graphics.DrawMeshInstancedIndirect(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Bounds>(), parameters[4].ToObject<UnityEngine.ComputeBuffer>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[7].ToObject<UnityEngine.Rendering.ShadowCastingMode>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Bounds, UnityEngine.ComputeBuffer, System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean>())
			{
				UnityEngine.Graphics.DrawMeshInstancedIndirect(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Bounds>(), parameters[4].ToObject<UnityEngine.ComputeBuffer>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[7].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[8].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Bounds, UnityEngine.ComputeBuffer, System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean, System.Int32>())
			{
				UnityEngine.Graphics.DrawMeshInstancedIndirect(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Bounds>(), parameters[4].ToObject<UnityEngine.ComputeBuffer>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[7].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[8].ToObject<System.Boolean>(), parameters[9].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Bounds, UnityEngine.ComputeBuffer, System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean, System.Int32, UnityEngine.Camera>())
			{
				UnityEngine.Graphics.DrawMeshInstancedIndirect(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Bounds>(), parameters[4].ToObject<UnityEngine.ComputeBuffer>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[7].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[8].ToObject<System.Boolean>(), parameters[9].ToObject<System.Int32>(), parameters[10].ToObject<UnityEngine.Camera>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Bounds, UnityEngine.ComputeBuffer, System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean, System.Int32, UnityEngine.Camera, UnityEngine.Rendering.LightProbeUsage>())
			{
				UnityEngine.Graphics.DrawMeshInstancedIndirect(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Bounds>(), parameters[4].ToObject<UnityEngine.ComputeBuffer>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[7].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[8].ToObject<System.Boolean>(), parameters[9].ToObject<System.Int32>(), parameters[10].ToObject<UnityEngine.Camera>(), parameters[11].ToObject<UnityEngine.Rendering.LightProbeUsage>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, System.Int32, UnityEngine.Material, UnityEngine.Bounds, UnityEngine.ComputeBuffer, System.Int32, UnityEngine.MaterialPropertyBlock, UnityEngine.Rendering.ShadowCastingMode, System.Boolean, System.Int32, UnityEngine.Camera, UnityEngine.Rendering.LightProbeUsage, UnityEngine.LightProbeProxyVolume>())
			{
				UnityEngine.Graphics.DrawMeshInstancedIndirect(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<UnityEngine.Bounds>(), parameters[4].ToObject<UnityEngine.ComputeBuffer>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.MaterialPropertyBlock>(), parameters[7].ToObject<UnityEngine.Rendering.ShadowCastingMode>(), parameters[8].ToObject<System.Boolean>(), parameters[9].ToObject<System.Int32>(), parameters[10].ToObject<UnityEngine.Camera>(), parameters[11].ToObject<UnityEngine.Rendering.LightProbeUsage>(), parameters[12].ToObject<UnityEngine.LightProbeProxyVolume>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Graphics.DrawMeshInstancedIndirect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.DrawMeshInstancedIndirect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawMeshNow(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4>())
			{
				UnityEngine.Graphics.DrawMeshNow(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Matrix4x4, System.Int32>())
			{
				UnityEngine.Graphics.DrawMeshNow(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Matrix4x4>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3, UnityEngine.Quaternion>())
			{
				UnityEngine.Graphics.DrawMeshNow(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Mesh, UnityEngine.Vector3, UnityEngine.Quaternion, System.Int32>())
			{
				UnityEngine.Graphics.DrawMeshNow(parameters[0].ToObject<UnityEngine.Mesh>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Graphics.DrawMeshNow has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.DrawMeshNow has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawProcedural(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.MeshTopology, System.Int32>())
			{
				UnityEngine.Graphics.DrawProcedural(parameters[0].ToObject<UnityEngine.MeshTopology>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.MeshTopology, System.Int32, System.Int32>())
			{
				UnityEngine.Graphics.DrawProcedural(parameters[0].ToObject<UnityEngine.MeshTopology>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Graphics.DrawProcedural has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.DrawProcedural has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawProceduralIndirect(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.MeshTopology, UnityEngine.ComputeBuffer>())
			{
				UnityEngine.Graphics.DrawProceduralIndirect(parameters[0].ToObject<UnityEngine.MeshTopology>(), parameters[1].ToObject<UnityEngine.ComputeBuffer>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.MeshTopology, UnityEngine.ComputeBuffer, System.Int32>())
			{
				UnityEngine.Graphics.DrawProceduralIndirect(parameters[0].ToObject<UnityEngine.MeshTopology>(), parameters[1].ToObject<UnityEngine.ComputeBuffer>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Graphics.DrawProceduralIndirect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.DrawProceduralIndirect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawTexture(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Texture>())
			{
				UnityEngine.Graphics.DrawTexture(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Texture>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Texture, UnityEngine.Material>())
			{
				UnityEngine.Graphics.DrawTexture(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Texture>(), parameters[2].ToObject<UnityEngine.Material>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Texture, UnityEngine.Material, System.Int32>())
			{
				UnityEngine.Graphics.DrawTexture(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Texture>(), parameters[2].ToObject<UnityEngine.Material>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Texture, System.Int32, System.Int32, System.Int32, System.Int32>())
			{
				UnityEngine.Graphics.DrawTexture(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Texture>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Texture, UnityEngine.Rect, System.Int32, System.Int32, System.Int32, System.Int32>())
			{
				UnityEngine.Graphics.DrawTexture(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Texture>(), parameters[2].ToObject<UnityEngine.Rect>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Texture, System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.Material>())
			{
				UnityEngine.Graphics.DrawTexture(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Texture>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.Material>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Texture, System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.Material, System.Int32>())
			{
				UnityEngine.Graphics.DrawTexture(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Texture>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<UnityEngine.Material>(), parameters[7].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Texture, UnityEngine.Rect, System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.Color>())
			{
				UnityEngine.Graphics.DrawTexture(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Texture>(), parameters[2].ToObject<UnityEngine.Rect>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<System.Int32>(), parameters[7].ToObject<UnityEngine.Color>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Texture, UnityEngine.Rect, System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.Material>())
			{
				UnityEngine.Graphics.DrawTexture(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Texture>(), parameters[2].ToObject<UnityEngine.Rect>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<System.Int32>(), parameters[7].ToObject<UnityEngine.Material>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Texture, UnityEngine.Rect, System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.Material, System.Int32>())
			{
				UnityEngine.Graphics.DrawTexture(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Texture>(), parameters[2].ToObject<UnityEngine.Rect>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<System.Int32>(), parameters[7].ToObject<UnityEngine.Material>(), parameters[8].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Texture, UnityEngine.Rect, System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.Color, UnityEngine.Material>())
			{
				UnityEngine.Graphics.DrawTexture(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Texture>(), parameters[2].ToObject<UnityEngine.Rect>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<System.Int32>(), parameters[7].ToObject<UnityEngine.Color>(), parameters[8].ToObject<UnityEngine.Material>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rect, UnityEngine.Texture, UnityEngine.Rect, System.Int32, System.Int32, System.Int32, System.Int32, UnityEngine.Color, UnityEngine.Material, System.Int32>())
			{
				UnityEngine.Graphics.DrawTexture(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<UnityEngine.Texture>(), parameters[2].ToObject<UnityEngine.Rect>(), parameters[3].ToObject<System.Int32>(), parameters[4].ToObject<System.Int32>(), parameters[5].ToObject<System.Int32>(), parameters[6].ToObject<System.Int32>(), parameters[7].ToObject<UnityEngine.Color>(), parameters[8].ToObject<UnityEngine.Material>(), parameters[9].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Graphics.DrawTexture has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.DrawTexture has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void ExecuteCommandBuffer(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.CommandBuffer>())
			{
				UnityEngine.Graphics.ExecuteCommandBuffer(parameters[0].ToObject<UnityEngine.Rendering.CommandBuffer>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Graphics.ExecuteCommandBuffer has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.ExecuteCommandBuffer has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void ExecuteCommandBufferAsync(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.CommandBuffer, UnityEngine.Rendering.ComputeQueueType>())
			{
				UnityEngine.Graphics.ExecuteCommandBufferAsync(parameters[0].ToObject<UnityEngine.Rendering.CommandBuffer>(), parameters[1].ToObject<UnityEngine.Rendering.ComputeQueueType>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Graphics.ExecuteCommandBufferAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.ExecuteCommandBufferAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetRandomWriteTarget(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.RenderTexture>())
			{
				UnityEngine.Graphics.SetRandomWriteTarget(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.RenderTexture>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.ComputeBuffer>())
			{
				UnityEngine.Graphics.SetRandomWriteTarget(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.ComputeBuffer>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.ComputeBuffer, System.Boolean>())
			{
				UnityEngine.Graphics.SetRandomWriteTarget(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.ComputeBuffer>(), parameters[2].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Graphics.SetRandomWriteTarget has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.SetRandomWriteTarget has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetRenderTarget(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RenderTargetSetup>())
			{
				UnityEngine.Graphics.SetRenderTarget(parameters[0].ToObject<UnityEngine.RenderTargetSetup>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.RenderTexture>())
			{
				UnityEngine.Graphics.SetRenderTarget(parameters[0].ToObject<UnityEngine.RenderTexture>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.RenderBuffer[], UnityEngine.RenderBuffer>())
			{
				UnityEngine.Graphics.SetRenderTarget(parameters[0].ToObject<UnityEngine.RenderBuffer[]>(), parameters[1].ToObject<UnityEngine.RenderBuffer>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.RenderTexture, System.Int32>())
			{
				UnityEngine.Graphics.SetRenderTarget(parameters[0].ToObject<UnityEngine.RenderTexture>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.RenderBuffer, UnityEngine.RenderBuffer>())
			{
				UnityEngine.Graphics.SetRenderTarget(parameters[0].ToObject<UnityEngine.RenderBuffer>(), parameters[1].ToObject<UnityEngine.RenderBuffer>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.RenderTexture, System.Int32, UnityEngine.CubemapFace>())
			{
				UnityEngine.Graphics.SetRenderTarget(parameters[0].ToObject<UnityEngine.RenderTexture>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.CubemapFace>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.RenderBuffer, UnityEngine.RenderBuffer, System.Int32>())
			{
				UnityEngine.Graphics.SetRenderTarget(parameters[0].ToObject<UnityEngine.RenderBuffer>(), parameters[1].ToObject<UnityEngine.RenderBuffer>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.RenderTexture, System.Int32, UnityEngine.CubemapFace, System.Int32>())
			{
				UnityEngine.Graphics.SetRenderTarget(parameters[0].ToObject<UnityEngine.RenderTexture>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.CubemapFace>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.RenderBuffer, UnityEngine.RenderBuffer, System.Int32, UnityEngine.CubemapFace>())
			{
				UnityEngine.Graphics.SetRenderTarget(parameters[0].ToObject<UnityEngine.RenderBuffer>(), parameters[1].ToObject<UnityEngine.RenderBuffer>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.CubemapFace>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.RenderBuffer, UnityEngine.RenderBuffer, System.Int32, UnityEngine.CubemapFace, System.Int32>())
			{
				UnityEngine.Graphics.SetRenderTarget(parameters[0].ToObject<UnityEngine.RenderBuffer>(), parameters[1].ToObject<UnityEngine.RenderBuffer>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<UnityEngine.CubemapFace>(), parameters[4].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Graphics.SetRenderTarget has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.SetRenderTarget has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void WaitOnGPUFence(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.GPUFence>())
			{
				UnityEngine.Graphics.WaitOnGPUFence(parameters[0].ToObject<UnityEngine.Rendering.GPUFence>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Rendering.GPUFence, UnityEngine.Rendering.SynchronisationStage>())
			{
				UnityEngine.Graphics.WaitOnGPUFence(parameters[0].ToObject<UnityEngine.Rendering.GPUFence>(), parameters[1].ToObject<UnityEngine.Rendering.SynchronisationStage>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Graphics.WaitOnGPUFence has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Graphics.WaitOnGPUFence has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.ColorGamut get_activeColorGamut()
		{
			return UnityEngine.Graphics.activeColorGamut;
		}

		static private UnityEngine.Rendering.GraphicsTier get_activeTier()
		{
			return UnityEngine.Graphics.activeTier;
		}

		static private void set_activeTier(UnityEngine.Rendering.GraphicsTier value)
		{
			UnityEngine.Graphics.activeTier = value;
		}

		static private UnityEngine.RenderBuffer get_activeColorBuffer()
		{
			return UnityEngine.Graphics.activeColorBuffer;
		}

		static private UnityEngine.RenderBuffer get_activeDepthBuffer()
		{
			return UnityEngine.Graphics.activeDepthBuffer;
		}

	}
}
