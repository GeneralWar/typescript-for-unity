using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCamera
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Camera> self = space.DeclareClass<UnityEngine.Camera, UnityEngine.Behaviour>();
			UnityEngineCameraGateFitMode.Bind(self);
			UnityEngineCameraMonoOrStereoscopicEye.Bind(self);
			UnityEngineCameraStereoscopicEye.Bind(self);
			self.BindConstructor(Constructor);
			self.BindStaticFunction("FocalLengthToFOV", FocalLengthToFOV);
			self.BindStaticFunction("FOVToFocalLength", FOVToFocalLength);
			self.BindStaticFunction("GetAllCameras", GetAllCameras);
			self.BindStaticFunction("SetupCurrent", SetupCurrent);
			self.BindInstanceFunction("AddCommandBuffer", AddCommandBuffer);
			self.BindInstanceFunction("AddCommandBufferAsync", AddCommandBufferAsync);
			self.BindInstanceFunction("CalculateFrustumCorners", CalculateFrustumCorners);
			self.BindInstanceFunction("CalculateObliqueMatrix", CalculateObliqueMatrix);
			self.BindInstanceFunction("CopyFrom", CopyFrom);
			self.BindInstanceFunction("CopyStereoDeviceProjectionMatrixToNonJittered", CopyStereoDeviceProjectionMatrixToNonJittered);
			self.BindInstanceFunction("GetCommandBuffers", GetCommandBuffers);
			self.BindInstanceFunction("GetStereoNonJitteredProjectionMatrix", GetStereoNonJitteredProjectionMatrix);
			self.BindInstanceFunction("GetStereoProjectionMatrix", GetStereoProjectionMatrix);
			self.BindInstanceFunction("GetStereoViewMatrix", GetStereoViewMatrix);
			self.BindInstanceFunction("RemoveAllCommandBuffers", RemoveAllCommandBuffers);
			self.BindInstanceFunction("RemoveCommandBuffer", RemoveCommandBuffer);
			self.BindInstanceFunction("RemoveCommandBuffers", RemoveCommandBuffers);
			self.BindInstanceFunction("Render", Render);
			self.BindInstanceFunction("RenderDontRestore", RenderDontRestore);
			self.BindInstanceFunction("RenderToCubemap", RenderToCubemap);
			self.BindInstanceFunction("RenderWithShader", RenderWithShader);
			self.BindInstanceFunction("Reset", Reset);
			self.BindInstanceFunction("ResetAspect", ResetAspect);
			self.BindInstanceFunction("ResetCullingMatrix", ResetCullingMatrix);
			self.BindInstanceFunction("ResetProjectionMatrix", ResetProjectionMatrix);
			self.BindInstanceFunction("ResetReplacementShader", ResetReplacementShader);
			self.BindInstanceFunction("ResetStereoProjectionMatrices", ResetStereoProjectionMatrices);
			self.BindInstanceFunction("ResetStereoViewMatrices", ResetStereoViewMatrices);
			self.BindInstanceFunction("ResetTransparencySortSettings", ResetTransparencySortSettings);
			self.BindInstanceFunction("ResetWorldToCameraMatrix", ResetWorldToCameraMatrix);
			self.BindInstanceFunction("ScreenPointToRay", ScreenPointToRay);
			self.BindInstanceFunction("ScreenToViewportPoint", ScreenToViewportPoint);
			self.BindInstanceFunction("ScreenToWorldPoint", ScreenToWorldPoint);
			self.BindInstanceFunction("SetReplacementShader", SetReplacementShader);
			self.BindInstanceFunction("SetStereoProjectionMatrix", SetStereoProjectionMatrix);
			self.BindInstanceFunction("SetStereoViewMatrix", SetStereoViewMatrix);
			self.BindInstanceFunction("SetTargetBuffers", SetTargetBuffers);
			self.BindInstanceFunction("ViewportPointToRay", ViewportPointToRay);
			self.BindInstanceFunction("ViewportToScreenPoint", ViewportToScreenPoint);
			self.BindInstanceFunction("ViewportToWorldPoint", ViewportToWorldPoint);
			self.BindInstanceFunction("WorldToScreenPoint", WorldToScreenPoint);
			self.BindInstanceFunction("WorldToViewportPoint", WorldToViewportPoint);
			self.BindStaticProperty("main", get_main, null);
			self.BindStaticProperty("current", get_current, null);
			self.BindStaticProperty("allCamerasCount", get_allCamerasCount, null);
			self.BindStaticProperty("allCameras", get_allCameras, null);
			self.BindInstanceProperty("nearClipPlane", get_nearClipPlane, set_nearClipPlane);
			self.BindInstanceProperty("sensorSize", get_sensorSize, set_sensorSize);
			self.BindInstanceProperty("lensShift", get_lensShift, set_lensShift);
			self.BindInstanceProperty("focalLength", get_focalLength, set_focalLength);
			self.BindInstanceProperty("rect", get_rect, set_rect);
			self.BindInstanceProperty("pixelRect", get_pixelRect, set_pixelRect);
			self.BindInstanceProperty("pixelWidth", get_pixelWidth, null);
			self.BindInstanceProperty("pixelHeight", get_pixelHeight, null);
			self.BindInstanceProperty("scaledPixelWidth", get_scaledPixelWidth, null);
			self.BindInstanceProperty("scaledPixelHeight", get_scaledPixelHeight, null);
			self.BindInstanceProperty("targetTexture", get_targetTexture, set_targetTexture);
			self.BindInstanceProperty("activeTexture", get_activeTexture, null);
			self.BindInstanceProperty("targetDisplay", get_targetDisplay, set_targetDisplay);
			self.BindInstanceProperty("cameraToWorldMatrix", get_cameraToWorldMatrix, null);
			self.BindInstanceProperty("worldToCameraMatrix", get_worldToCameraMatrix, set_worldToCameraMatrix);
			self.BindInstanceProperty("projectionMatrix", get_projectionMatrix, set_projectionMatrix);
			self.BindInstanceProperty("nonJitteredProjectionMatrix", get_nonJitteredProjectionMatrix, set_nonJitteredProjectionMatrix);
			self.BindInstanceProperty("useJitteredProjectionMatrixForTransparentRendering", get_useJitteredProjectionMatrixForTransparentRendering, set_useJitteredProjectionMatrixForTransparentRendering);
			self.BindInstanceProperty("previousViewProjectionMatrix", get_previousViewProjectionMatrix, null);
			self.BindInstanceProperty("scene", get_scene, set_scene);
			self.BindInstanceProperty("stereoEnabled", get_stereoEnabled, null);
			self.BindInstanceProperty("stereoSeparation", get_stereoSeparation, set_stereoSeparation);
			self.BindInstanceProperty("stereoConvergence", get_stereoConvergence, set_stereoConvergence);
			self.BindInstanceProperty("areVRStereoViewMatricesWithinSingleCullTolerance", get_areVRStereoViewMatricesWithinSingleCullTolerance, null);
			self.BindInstanceProperty("usePhysicalProperties", get_usePhysicalProperties, set_usePhysicalProperties);
			self.BindInstanceProperty("clearStencilAfterLightingPass", get_clearStencilAfterLightingPass, set_clearStencilAfterLightingPass);
			self.BindInstanceProperty("depthTextureMode", get_depthTextureMode, set_depthTextureMode);
			self.BindInstanceProperty("clearFlags", get_clearFlags, set_clearFlags);
			self.BindInstanceProperty("farClipPlane", get_farClipPlane, set_farClipPlane);
			self.BindInstanceProperty("fieldOfView", get_fieldOfView, set_fieldOfView);
			self.BindInstanceProperty("renderingPath", get_renderingPath, set_renderingPath);
			self.BindInstanceProperty("actualRenderingPath", get_actualRenderingPath, null);
			self.BindInstanceProperty("allowHDR", get_allowHDR, set_allowHDR);
			self.BindInstanceProperty("allowMSAA", get_allowMSAA, set_allowMSAA);
			self.BindInstanceProperty("allowDynamicResolution", get_allowDynamicResolution, set_allowDynamicResolution);
			self.BindInstanceProperty("forceIntoRenderTexture", get_forceIntoRenderTexture, set_forceIntoRenderTexture);
			self.BindInstanceProperty("orthographicSize", get_orthographicSize, set_orthographicSize);
			self.BindInstanceProperty("orthographic", get_orthographic, set_orthographic);
			self.BindInstanceProperty("opaqueSortMode", get_opaqueSortMode, set_opaqueSortMode);
			self.BindInstanceProperty("stereoTargetEye", get_stereoTargetEye, set_stereoTargetEye);
			self.BindInstanceProperty("transparencySortMode", get_transparencySortMode, set_transparencySortMode);
			self.BindInstanceProperty("depth", get_depth, set_depth);
			self.BindInstanceProperty("aspect", get_aspect, set_aspect);
			self.BindInstanceProperty("velocity", get_velocity, null);
			self.BindInstanceProperty("cullingMask", get_cullingMask, set_cullingMask);
			self.BindInstanceProperty("eventMask", get_eventMask, set_eventMask);
			self.BindInstanceProperty("layerCullSpherical", get_layerCullSpherical, set_layerCullSpherical);
			self.BindInstanceProperty("cameraType", get_cameraType, set_cameraType);
			self.BindInstanceProperty("layerCullDistances", get_layerCullDistances, set_layerCullDistances);
			self.BindInstanceProperty("useOcclusionCulling", get_useOcclusionCulling, set_useOcclusionCulling);
			self.BindInstanceProperty("cullingMatrix", get_cullingMatrix, set_cullingMatrix);
			self.BindInstanceProperty("backgroundColor", get_backgroundColor, set_backgroundColor);
			self.BindInstanceProperty("transparencySortAxis", get_transparencySortAxis, set_transparencySortAxis);
			self.BindInstanceProperty("commandBufferCount", get_commandBufferCount, null);
		}

		static private UnityEngine.Camera Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Camera();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Camera);
		}

		static private System.Single FocalLengthToFOV(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return UnityEngine.Camera.FocalLengthToFOV(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.FocalLengthToFOV has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.FocalLengthToFOV has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single FOVToFocalLength(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return UnityEngine.Camera.FOVToFocalLength(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.FOVToFocalLength has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.FOVToFocalLength has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Int32 GetAllCameras(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Camera[]>())
			{
				return UnityEngine.Camera.GetAllCameras(parameters[0].ToObject<UnityEngine.Camera[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.GetAllCameras has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.GetAllCameras has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void SetupCurrent(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Camera>())
			{
				UnityEngine.Camera.SetupCurrent(parameters[0].ToObject<UnityEngine.Camera>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.SetupCurrent has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.SetupCurrent has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void AddCommandBuffer(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.CameraEvent, UnityEngine.Rendering.CommandBuffer>())
			{
				instance.AddCommandBuffer(parameters[0].ToObject<UnityEngine.Rendering.CameraEvent>(), parameters[1].ToObject<UnityEngine.Rendering.CommandBuffer>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.AddCommandBuffer has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.AddCommandBuffer has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void AddCommandBufferAsync(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.CameraEvent, UnityEngine.Rendering.CommandBuffer, UnityEngine.Rendering.ComputeQueueType>())
			{
				instance.AddCommandBufferAsync(parameters[0].ToObject<UnityEngine.Rendering.CameraEvent>(), parameters[1].ToObject<UnityEngine.Rendering.CommandBuffer>(), parameters[2].ToObject<UnityEngine.Rendering.ComputeQueueType>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.AddCommandBufferAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.AddCommandBufferAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void CalculateFrustumCorners(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rect, System.Single, UnityEngine.Camera.MonoOrStereoscopicEye, UnityEngine.Vector3[]>())
			{
				instance.CalculateFrustumCorners(parameters[0].ToObject<UnityEngine.Rect>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<UnityEngine.Camera.MonoOrStereoscopicEye>(), parameters[3].ToObject<UnityEngine.Vector3[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.CalculateFrustumCorners has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.CalculateFrustumCorners has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Matrix4x4 CalculateObliqueMatrix(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4>())
			{
				return instance.CalculateObliqueMatrix(parameters[0].ToObject<UnityEngine.Vector4>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.CalculateObliqueMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.CalculateObliqueMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private void CopyFrom(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Camera>())
			{
				instance.CopyFrom(parameters[0].ToObject<UnityEngine.Camera>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.CopyFrom has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.CopyFrom has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void CopyStereoDeviceProjectionMatrixToNonJittered(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Camera.StereoscopicEye>())
			{
				instance.CopyStereoDeviceProjectionMatrixToNonJittered(parameters[0].ToObject<UnityEngine.Camera.StereoscopicEye>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.CopyStereoDeviceProjectionMatrixToNonJittered has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.CopyStereoDeviceProjectionMatrixToNonJittered has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Rendering.CommandBuffer[] GetCommandBuffers(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.CameraEvent>())
			{
				return instance.GetCommandBuffers(parameters[0].ToObject<UnityEngine.Rendering.CameraEvent>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.GetCommandBuffers has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.GetCommandBuffers has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.Matrix4x4 GetStereoNonJitteredProjectionMatrix(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Camera.StereoscopicEye>())
			{
				return instance.GetStereoNonJitteredProjectionMatrix(parameters[0].ToObject<UnityEngine.Camera.StereoscopicEye>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.GetStereoNonJitteredProjectionMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.GetStereoNonJitteredProjectionMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private UnityEngine.Matrix4x4 GetStereoProjectionMatrix(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Camera.StereoscopicEye>())
			{
				return instance.GetStereoProjectionMatrix(parameters[0].ToObject<UnityEngine.Camera.StereoscopicEye>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.GetStereoProjectionMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.GetStereoProjectionMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private UnityEngine.Matrix4x4 GetStereoViewMatrix(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Camera.StereoscopicEye>())
			{
				return instance.GetStereoViewMatrix(parameters[0].ToObject<UnityEngine.Camera.StereoscopicEye>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.GetStereoViewMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.GetStereoViewMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Matrix4x4);
		}

		static private void RemoveAllCommandBuffers(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.RemoveAllCommandBuffers();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.RemoveAllCommandBuffers has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void RemoveCommandBuffer(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.CameraEvent, UnityEngine.Rendering.CommandBuffer>())
			{
				instance.RemoveCommandBuffer(parameters[0].ToObject<UnityEngine.Rendering.CameraEvent>(), parameters[1].ToObject<UnityEngine.Rendering.CommandBuffer>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.RemoveCommandBuffer has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.RemoveCommandBuffer has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void RemoveCommandBuffers(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Rendering.CameraEvent>())
			{
				instance.RemoveCommandBuffers(parameters[0].ToObject<UnityEngine.Rendering.CameraEvent>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.RemoveCommandBuffers has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.RemoveCommandBuffers has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Render(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Render();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.Render has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void RenderDontRestore(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.RenderDontRestore();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.RenderDontRestore has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean RenderToCubemap(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Cubemap>())
			{
				return instance.RenderToCubemap(parameters[0].ToObject<UnityEngine.Cubemap>());
			}
			if (parameters.CheckTypes<UnityEngine.RenderTexture>())
			{
				return instance.RenderToCubemap(parameters[0].ToObject<UnityEngine.RenderTexture>());
			}
			if (parameters.CheckTypes<UnityEngine.Cubemap, System.Int32>())
			{
				return instance.RenderToCubemap(parameters[0].ToObject<UnityEngine.Cubemap>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.RenderTexture, System.Int32>())
			{
				return instance.RenderToCubemap(parameters[0].ToObject<UnityEngine.RenderTexture>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<UnityEngine.RenderTexture, System.Int32, UnityEngine.Camera.MonoOrStereoscopicEye>())
			{
				return instance.RenderToCubemap(parameters[0].ToObject<UnityEngine.RenderTexture>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.Camera.MonoOrStereoscopicEye>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.RenderToCubemap has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.RenderToCubemap has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void RenderWithShader(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Shader, System.String>())
			{
				instance.RenderWithShader(parameters[0].ToObject<UnityEngine.Shader>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.RenderWithShader has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.RenderWithShader has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Reset(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Reset();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.Reset has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ResetAspect(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ResetAspect();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.ResetAspect has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ResetCullingMatrix(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ResetCullingMatrix();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.ResetCullingMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ResetProjectionMatrix(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ResetProjectionMatrix();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.ResetProjectionMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ResetReplacementShader(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ResetReplacementShader();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.ResetReplacementShader has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ResetStereoProjectionMatrices(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ResetStereoProjectionMatrices();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.ResetStereoProjectionMatrices has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ResetStereoViewMatrices(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ResetStereoViewMatrices();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.ResetStereoViewMatrices has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ResetTransparencySortSettings(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ResetTransparencySortSettings();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.ResetTransparencySortSettings has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ResetWorldToCameraMatrix(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ResetWorldToCameraMatrix();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.ResetWorldToCameraMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.Ray ScreenPointToRay(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.ScreenPointToRay(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Camera.MonoOrStereoscopicEye>())
			{
				return instance.ScreenPointToRay(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Camera.MonoOrStereoscopicEye>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.ScreenPointToRay has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.ScreenPointToRay has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Ray);
		}

		static private UnityEngine.Vector3 ScreenToViewportPoint(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.ScreenToViewportPoint(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.ScreenToViewportPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.ScreenToViewportPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private UnityEngine.Vector3 ScreenToWorldPoint(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.ScreenToWorldPoint(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Camera.MonoOrStereoscopicEye>())
			{
				return instance.ScreenToWorldPoint(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Camera.MonoOrStereoscopicEye>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.ScreenToWorldPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.ScreenToWorldPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private void SetReplacementShader(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Shader, System.String>())
			{
				instance.SetReplacementShader(parameters[0].ToObject<UnityEngine.Shader>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.SetReplacementShader has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.SetReplacementShader has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetStereoProjectionMatrix(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Camera.StereoscopicEye, UnityEngine.Matrix4x4>())
			{
				instance.SetStereoProjectionMatrix(parameters[0].ToObject<UnityEngine.Camera.StereoscopicEye>(), parameters[1].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.SetStereoProjectionMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.SetStereoProjectionMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetStereoViewMatrix(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Camera.StereoscopicEye, UnityEngine.Matrix4x4>())
			{
				instance.SetStereoViewMatrix(parameters[0].ToObject<UnityEngine.Camera.StereoscopicEye>(), parameters[1].ToObject<UnityEngine.Matrix4x4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.SetStereoViewMatrix has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.SetStereoViewMatrix has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetTargetBuffers(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RenderBuffer, UnityEngine.RenderBuffer>())
			{
				instance.SetTargetBuffers(parameters[0].ToObject<UnityEngine.RenderBuffer>(), parameters[1].ToObject<UnityEngine.RenderBuffer>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.RenderBuffer[], UnityEngine.RenderBuffer>())
			{
				instance.SetTargetBuffers(parameters[0].ToObject<UnityEngine.RenderBuffer[]>(), parameters[1].ToObject<UnityEngine.RenderBuffer>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.SetTargetBuffers has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.SetTargetBuffers has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Ray ViewportPointToRay(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.ViewportPointToRay(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Camera.MonoOrStereoscopicEye>())
			{
				return instance.ViewportPointToRay(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Camera.MonoOrStereoscopicEye>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.ViewportPointToRay has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.ViewportPointToRay has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Ray);
		}

		static private UnityEngine.Vector3 ViewportToScreenPoint(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.ViewportToScreenPoint(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.ViewportToScreenPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.ViewportToScreenPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private UnityEngine.Vector3 ViewportToWorldPoint(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.ViewportToWorldPoint(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Camera.MonoOrStereoscopicEye>())
			{
				return instance.ViewportToWorldPoint(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Camera.MonoOrStereoscopicEye>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.ViewportToWorldPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.ViewportToWorldPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private UnityEngine.Vector3 WorldToScreenPoint(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.WorldToScreenPoint(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Camera.MonoOrStereoscopicEye>())
			{
				return instance.WorldToScreenPoint(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Camera.MonoOrStereoscopicEye>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.WorldToScreenPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.WorldToScreenPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private UnityEngine.Vector3 WorldToViewportPoint(UnityEngine.Camera instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return instance.WorldToViewportPoint(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Camera.MonoOrStereoscopicEye>())
			{
				return instance.WorldToViewportPoint(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Camera.MonoOrStereoscopicEye>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Camera.WorldToViewportPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Camera.WorldToViewportPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private UnityEngine.Camera get_main(Type type, string name)
		{
			return UnityEngine.Camera.main;
		}

		static private UnityEngine.Camera get_current(Type type, string name)
		{
			return UnityEngine.Camera.current;
		}

		static private System.Int32 get_allCamerasCount(Type type, string name)
		{
			return UnityEngine.Camera.allCamerasCount;
		}

		static private UnityEngine.Camera[] get_allCameras(Type type, string name)
		{
			return UnityEngine.Camera.allCameras;
		}

		static private System.Single get_nearClipPlane(UnityEngine.Camera instance, string name)
		{
			return instance.nearClipPlane;
		}

		static private void set_nearClipPlane(UnityEngine.Camera instance, string name, System.Single value)
		{
			instance.nearClipPlane = value;
		}

		static private UnityEngine.Vector2 get_sensorSize(UnityEngine.Camera instance, string name)
		{
			return instance.sensorSize;
		}

		static private void set_sensorSize(UnityEngine.Camera instance, string name, UnityEngine.Vector2 value)
		{
			instance.sensorSize = value;
		}

		static private UnityEngine.Vector2 get_lensShift(UnityEngine.Camera instance, string name)
		{
			return instance.lensShift;
		}

		static private void set_lensShift(UnityEngine.Camera instance, string name, UnityEngine.Vector2 value)
		{
			instance.lensShift = value;
		}

		static private System.Single get_focalLength(UnityEngine.Camera instance, string name)
		{
			return instance.focalLength;
		}

		static private void set_focalLength(UnityEngine.Camera instance, string name, System.Single value)
		{
			instance.focalLength = value;
		}

		static private UnityEngine.Rect get_rect(UnityEngine.Camera instance, string name)
		{
			return instance.rect;
		}

		static private void set_rect(UnityEngine.Camera instance, string name, UnityEngine.Rect value)
		{
			instance.rect = value;
		}

		static private UnityEngine.Rect get_pixelRect(UnityEngine.Camera instance, string name)
		{
			return instance.pixelRect;
		}

		static private void set_pixelRect(UnityEngine.Camera instance, string name, UnityEngine.Rect value)
		{
			instance.pixelRect = value;
		}

		static private System.Int32 get_pixelWidth(UnityEngine.Camera instance, string name)
		{
			return instance.pixelWidth;
		}

		static private System.Int32 get_pixelHeight(UnityEngine.Camera instance, string name)
		{
			return instance.pixelHeight;
		}

		static private System.Int32 get_scaledPixelWidth(UnityEngine.Camera instance, string name)
		{
			return instance.scaledPixelWidth;
		}

		static private System.Int32 get_scaledPixelHeight(UnityEngine.Camera instance, string name)
		{
			return instance.scaledPixelHeight;
		}

		static private UnityEngine.RenderTexture get_targetTexture(UnityEngine.Camera instance, string name)
		{
			return instance.targetTexture;
		}

		static private void set_targetTexture(UnityEngine.Camera instance, string name, UnityEngine.RenderTexture value)
		{
			instance.targetTexture = value;
		}

		static private UnityEngine.RenderTexture get_activeTexture(UnityEngine.Camera instance, string name)
		{
			return instance.activeTexture;
		}

		static private System.Int32 get_targetDisplay(UnityEngine.Camera instance, string name)
		{
			return instance.targetDisplay;
		}

		static private void set_targetDisplay(UnityEngine.Camera instance, string name, System.Int32 value)
		{
			instance.targetDisplay = value;
		}

		static private UnityEngine.Matrix4x4 get_cameraToWorldMatrix(UnityEngine.Camera instance, string name)
		{
			return instance.cameraToWorldMatrix;
		}

		static private UnityEngine.Matrix4x4 get_worldToCameraMatrix(UnityEngine.Camera instance, string name)
		{
			return instance.worldToCameraMatrix;
		}

		static private void set_worldToCameraMatrix(UnityEngine.Camera instance, string name, UnityEngine.Matrix4x4 value)
		{
			instance.worldToCameraMatrix = value;
		}

		static private UnityEngine.Matrix4x4 get_projectionMatrix(UnityEngine.Camera instance, string name)
		{
			return instance.projectionMatrix;
		}

		static private void set_projectionMatrix(UnityEngine.Camera instance, string name, UnityEngine.Matrix4x4 value)
		{
			instance.projectionMatrix = value;
		}

		static private UnityEngine.Matrix4x4 get_nonJitteredProjectionMatrix(UnityEngine.Camera instance, string name)
		{
			return instance.nonJitteredProjectionMatrix;
		}

		static private void set_nonJitteredProjectionMatrix(UnityEngine.Camera instance, string name, UnityEngine.Matrix4x4 value)
		{
			instance.nonJitteredProjectionMatrix = value;
		}

		static private System.Boolean get_useJitteredProjectionMatrixForTransparentRendering(UnityEngine.Camera instance, string name)
		{
			return instance.useJitteredProjectionMatrixForTransparentRendering;
		}

		static private void set_useJitteredProjectionMatrixForTransparentRendering(UnityEngine.Camera instance, string name, System.Boolean value)
		{
			instance.useJitteredProjectionMatrixForTransparentRendering = value;
		}

		static private UnityEngine.Matrix4x4 get_previousViewProjectionMatrix(UnityEngine.Camera instance, string name)
		{
			return instance.previousViewProjectionMatrix;
		}

		static private UnityEngine.SceneManagement.Scene get_scene(UnityEngine.Camera instance, string name)
		{
			return instance.scene;
		}

		static private void set_scene(UnityEngine.Camera instance, string name, UnityEngine.SceneManagement.Scene value)
		{
			instance.scene = value;
		}

		static private System.Boolean get_stereoEnabled(UnityEngine.Camera instance, string name)
		{
			return instance.stereoEnabled;
		}

		static private System.Single get_stereoSeparation(UnityEngine.Camera instance, string name)
		{
			return instance.stereoSeparation;
		}

		static private void set_stereoSeparation(UnityEngine.Camera instance, string name, System.Single value)
		{
			instance.stereoSeparation = value;
		}

		static private System.Single get_stereoConvergence(UnityEngine.Camera instance, string name)
		{
			return instance.stereoConvergence;
		}

		static private void set_stereoConvergence(UnityEngine.Camera instance, string name, System.Single value)
		{
			instance.stereoConvergence = value;
		}

		static private System.Boolean get_areVRStereoViewMatricesWithinSingleCullTolerance(UnityEngine.Camera instance, string name)
		{
			return instance.areVRStereoViewMatricesWithinSingleCullTolerance;
		}

		static private System.Boolean get_usePhysicalProperties(UnityEngine.Camera instance, string name)
		{
			return instance.usePhysicalProperties;
		}

		static private void set_usePhysicalProperties(UnityEngine.Camera instance, string name, System.Boolean value)
		{
			instance.usePhysicalProperties = value;
		}

		static private System.Boolean get_clearStencilAfterLightingPass(UnityEngine.Camera instance, string name)
		{
			return instance.clearStencilAfterLightingPass;
		}

		static private void set_clearStencilAfterLightingPass(UnityEngine.Camera instance, string name, System.Boolean value)
		{
			instance.clearStencilAfterLightingPass = value;
		}

		static private UnityEngine.DepthTextureMode get_depthTextureMode(UnityEngine.Camera instance, string name)
		{
			return instance.depthTextureMode;
		}

		static private void set_depthTextureMode(UnityEngine.Camera instance, string name, UnityEngine.DepthTextureMode value)
		{
			instance.depthTextureMode = value;
		}

		static private UnityEngine.CameraClearFlags get_clearFlags(UnityEngine.Camera instance, string name)
		{
			return instance.clearFlags;
		}

		static private void set_clearFlags(UnityEngine.Camera instance, string name, UnityEngine.CameraClearFlags value)
		{
			instance.clearFlags = value;
		}

		static private System.Single get_farClipPlane(UnityEngine.Camera instance, string name)
		{
			return instance.farClipPlane;
		}

		static private void set_farClipPlane(UnityEngine.Camera instance, string name, System.Single value)
		{
			instance.farClipPlane = value;
		}

		static private System.Single get_fieldOfView(UnityEngine.Camera instance, string name)
		{
			return instance.fieldOfView;
		}

		static private void set_fieldOfView(UnityEngine.Camera instance, string name, System.Single value)
		{
			instance.fieldOfView = value;
		}

		static private UnityEngine.RenderingPath get_renderingPath(UnityEngine.Camera instance, string name)
		{
			return instance.renderingPath;
		}

		static private void set_renderingPath(UnityEngine.Camera instance, string name, UnityEngine.RenderingPath value)
		{
			instance.renderingPath = value;
		}

		static private UnityEngine.RenderingPath get_actualRenderingPath(UnityEngine.Camera instance, string name)
		{
			return instance.actualRenderingPath;
		}

		static private System.Boolean get_allowHDR(UnityEngine.Camera instance, string name)
		{
			return instance.allowHDR;
		}

		static private void set_allowHDR(UnityEngine.Camera instance, string name, System.Boolean value)
		{
			instance.allowHDR = value;
		}

		static private System.Boolean get_allowMSAA(UnityEngine.Camera instance, string name)
		{
			return instance.allowMSAA;
		}

		static private void set_allowMSAA(UnityEngine.Camera instance, string name, System.Boolean value)
		{
			instance.allowMSAA = value;
		}

		static private System.Boolean get_allowDynamicResolution(UnityEngine.Camera instance, string name)
		{
			return instance.allowDynamicResolution;
		}

		static private void set_allowDynamicResolution(UnityEngine.Camera instance, string name, System.Boolean value)
		{
			instance.allowDynamicResolution = value;
		}

		static private System.Boolean get_forceIntoRenderTexture(UnityEngine.Camera instance, string name)
		{
			return instance.forceIntoRenderTexture;
		}

		static private void set_forceIntoRenderTexture(UnityEngine.Camera instance, string name, System.Boolean value)
		{
			instance.forceIntoRenderTexture = value;
		}

		static private System.Single get_orthographicSize(UnityEngine.Camera instance, string name)
		{
			return instance.orthographicSize;
		}

		static private void set_orthographicSize(UnityEngine.Camera instance, string name, System.Single value)
		{
			instance.orthographicSize = value;
		}

		static private System.Boolean get_orthographic(UnityEngine.Camera instance, string name)
		{
			return instance.orthographic;
		}

		static private void set_orthographic(UnityEngine.Camera instance, string name, System.Boolean value)
		{
			instance.orthographic = value;
		}

		static private UnityEngine.Rendering.OpaqueSortMode get_opaqueSortMode(UnityEngine.Camera instance, string name)
		{
			return instance.opaqueSortMode;
		}

		static private void set_opaqueSortMode(UnityEngine.Camera instance, string name, UnityEngine.Rendering.OpaqueSortMode value)
		{
			instance.opaqueSortMode = value;
		}

		static private UnityEngine.StereoTargetEyeMask get_stereoTargetEye(UnityEngine.Camera instance, string name)
		{
			return instance.stereoTargetEye;
		}

		static private void set_stereoTargetEye(UnityEngine.Camera instance, string name, UnityEngine.StereoTargetEyeMask value)
		{
			instance.stereoTargetEye = value;
		}

		static private UnityEngine.TransparencySortMode get_transparencySortMode(UnityEngine.Camera instance, string name)
		{
			return instance.transparencySortMode;
		}

		static private void set_transparencySortMode(UnityEngine.Camera instance, string name, UnityEngine.TransparencySortMode value)
		{
			instance.transparencySortMode = value;
		}

		static private System.Single get_depth(UnityEngine.Camera instance, string name)
		{
			return instance.depth;
		}

		static private void set_depth(UnityEngine.Camera instance, string name, System.Single value)
		{
			instance.depth = value;
		}

		static private System.Single get_aspect(UnityEngine.Camera instance, string name)
		{
			return instance.aspect;
		}

		static private void set_aspect(UnityEngine.Camera instance, string name, System.Single value)
		{
			instance.aspect = value;
		}

		static private UnityEngine.Vector3 get_velocity(UnityEngine.Camera instance, string name)
		{
			return instance.velocity;
		}

		static private System.Int32 get_cullingMask(UnityEngine.Camera instance, string name)
		{
			return instance.cullingMask;
		}

		static private void set_cullingMask(UnityEngine.Camera instance, string name, System.Int32 value)
		{
			instance.cullingMask = value;
		}

		static private System.Int32 get_eventMask(UnityEngine.Camera instance, string name)
		{
			return instance.eventMask;
		}

		static private void set_eventMask(UnityEngine.Camera instance, string name, System.Int32 value)
		{
			instance.eventMask = value;
		}

		static private System.Boolean get_layerCullSpherical(UnityEngine.Camera instance, string name)
		{
			return instance.layerCullSpherical;
		}

		static private void set_layerCullSpherical(UnityEngine.Camera instance, string name, System.Boolean value)
		{
			instance.layerCullSpherical = value;
		}

		static private UnityEngine.CameraType get_cameraType(UnityEngine.Camera instance, string name)
		{
			return instance.cameraType;
		}

		static private void set_cameraType(UnityEngine.Camera instance, string name, UnityEngine.CameraType value)
		{
			instance.cameraType = value;
		}

		static private System.Single[] get_layerCullDistances(UnityEngine.Camera instance, string name)
		{
			return instance.layerCullDistances;
		}

		static private void set_layerCullDistances(UnityEngine.Camera instance, string name, System.Single[] value)
		{
			instance.layerCullDistances = value;
		}

		static private System.Boolean get_useOcclusionCulling(UnityEngine.Camera instance, string name)
		{
			return instance.useOcclusionCulling;
		}

		static private void set_useOcclusionCulling(UnityEngine.Camera instance, string name, System.Boolean value)
		{
			instance.useOcclusionCulling = value;
		}

		static private UnityEngine.Matrix4x4 get_cullingMatrix(UnityEngine.Camera instance, string name)
		{
			return instance.cullingMatrix;
		}

		static private void set_cullingMatrix(UnityEngine.Camera instance, string name, UnityEngine.Matrix4x4 value)
		{
			instance.cullingMatrix = value;
		}

		static private UnityEngine.Color get_backgroundColor(UnityEngine.Camera instance, string name)
		{
			return instance.backgroundColor;
		}

		static private void set_backgroundColor(UnityEngine.Camera instance, string name, UnityEngine.Color value)
		{
			instance.backgroundColor = value;
		}

		static private UnityEngine.Vector3 get_transparencySortAxis(UnityEngine.Camera instance, string name)
		{
			return instance.transparencySortAxis;
		}

		static private void set_transparencySortAxis(UnityEngine.Camera instance, string name, UnityEngine.Vector3 value)
		{
			instance.transparencySortAxis = value;
		}

		static private System.Int32 get_commandBufferCount(UnityEngine.Camera instance, string name)
		{
			return instance.commandBufferCount;
		}

	}
}
