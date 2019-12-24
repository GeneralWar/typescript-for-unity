using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingCameraEvent
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.CameraEvent> instance = space.DeclareEnum<UnityEngine.Rendering.CameraEvent>();
			instance.SetValue("BeforeDepthTexture", (long)UnityEngine.Rendering.CameraEvent.BeforeDepthTexture);
			instance.SetValue("AfterDepthTexture", (long)UnityEngine.Rendering.CameraEvent.AfterDepthTexture);
			instance.SetValue("BeforeDepthNormalsTexture", (long)UnityEngine.Rendering.CameraEvent.BeforeDepthNormalsTexture);
			instance.SetValue("AfterDepthNormalsTexture", (long)UnityEngine.Rendering.CameraEvent.AfterDepthNormalsTexture);
			instance.SetValue("BeforeGBuffer", (long)UnityEngine.Rendering.CameraEvent.BeforeGBuffer);
			instance.SetValue("AfterGBuffer", (long)UnityEngine.Rendering.CameraEvent.AfterGBuffer);
			instance.SetValue("BeforeLighting", (long)UnityEngine.Rendering.CameraEvent.BeforeLighting);
			instance.SetValue("AfterLighting", (long)UnityEngine.Rendering.CameraEvent.AfterLighting);
			instance.SetValue("BeforeFinalPass", (long)UnityEngine.Rendering.CameraEvent.BeforeFinalPass);
			instance.SetValue("AfterFinalPass", (long)UnityEngine.Rendering.CameraEvent.AfterFinalPass);
			instance.SetValue("BeforeForwardOpaque", (long)UnityEngine.Rendering.CameraEvent.BeforeForwardOpaque);
			instance.SetValue("AfterForwardOpaque", (long)UnityEngine.Rendering.CameraEvent.AfterForwardOpaque);
			instance.SetValue("BeforeImageEffectsOpaque", (long)UnityEngine.Rendering.CameraEvent.BeforeImageEffectsOpaque);
			instance.SetValue("AfterImageEffectsOpaque", (long)UnityEngine.Rendering.CameraEvent.AfterImageEffectsOpaque);
			instance.SetValue("BeforeSkybox", (long)UnityEngine.Rendering.CameraEvent.BeforeSkybox);
			instance.SetValue("AfterSkybox", (long)UnityEngine.Rendering.CameraEvent.AfterSkybox);
			instance.SetValue("BeforeForwardAlpha", (long)UnityEngine.Rendering.CameraEvent.BeforeForwardAlpha);
			instance.SetValue("AfterForwardAlpha", (long)UnityEngine.Rendering.CameraEvent.AfterForwardAlpha);
			instance.SetValue("BeforeImageEffects", (long)UnityEngine.Rendering.CameraEvent.BeforeImageEffects);
			instance.SetValue("AfterImageEffects", (long)UnityEngine.Rendering.CameraEvent.AfterImageEffects);
			instance.SetValue("AfterEverything", (long)UnityEngine.Rendering.CameraEvent.AfterEverything);
			instance.SetValue("BeforeReflections", (long)UnityEngine.Rendering.CameraEvent.BeforeReflections);
			instance.SetValue("AfterReflections", (long)UnityEngine.Rendering.CameraEvent.AfterReflections);
			instance.SetValue("BeforeHaloAndLensFlares", (long)UnityEngine.Rendering.CameraEvent.BeforeHaloAndLensFlares);
			instance.SetValue("AfterHaloAndLensFlares", (long)UnityEngine.Rendering.CameraEvent.AfterHaloAndLensFlares);
		}
	}
}
