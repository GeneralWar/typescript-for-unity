using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUICanvasScaler
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.CanvasScaler> self = space.DeclareClass<UnityEngine.UI.CanvasScaler, UnityEngine.EventSystems.UIBehaviour>();
			UnityEngineUICanvasScalerScaleMode.Bind(self);
			UnityEngineUICanvasScalerScreenMatchMode.Bind(self);
			UnityEngineUICanvasScalerUnit.Bind(self);
			self.BindConstructor();
			self.BindInstanceProperty("referencePixelsPerUnit", get_referencePixelsPerUnit, set_referencePixelsPerUnit);
			self.BindInstanceProperty("scaleFactor", get_scaleFactor, set_scaleFactor);
			self.BindInstanceProperty("referenceResolution", get_referenceResolution, set_referenceResolution);
			self.BindInstanceProperty("matchWidthOrHeight", get_matchWidthOrHeight, set_matchWidthOrHeight);
			self.BindInstanceProperty("fallbackScreenDPI", get_fallbackScreenDPI, set_fallbackScreenDPI);
			self.BindInstanceProperty("defaultSpriteDPI", get_defaultSpriteDPI, set_defaultSpriteDPI);
			self.BindInstanceProperty("dynamicPixelsPerUnit", get_dynamicPixelsPerUnit, set_dynamicPixelsPerUnit);
		}

		static private System.Single get_referencePixelsPerUnit(UnityEngine.UI.CanvasScaler instance)
		{
			return instance.referencePixelsPerUnit;
		}

		static private void set_referencePixelsPerUnit(UnityEngine.UI.CanvasScaler instance, System.Single value)
		{
			instance.referencePixelsPerUnit = value;
		}

		static private System.Single get_scaleFactor(UnityEngine.UI.CanvasScaler instance)
		{
			return instance.scaleFactor;
		}

		static private void set_scaleFactor(UnityEngine.UI.CanvasScaler instance, System.Single value)
		{
			instance.scaleFactor = value;
		}

		static private UnityEngine.Vector2 get_referenceResolution(UnityEngine.UI.CanvasScaler instance)
		{
			return instance.referenceResolution;
		}

		static private void set_referenceResolution(UnityEngine.UI.CanvasScaler instance, UnityEngine.Vector2 value)
		{
			instance.referenceResolution = value;
		}

		static private System.Single get_matchWidthOrHeight(UnityEngine.UI.CanvasScaler instance)
		{
			return instance.matchWidthOrHeight;
		}

		static private void set_matchWidthOrHeight(UnityEngine.UI.CanvasScaler instance, System.Single value)
		{
			instance.matchWidthOrHeight = value;
		}

		static private System.Single get_fallbackScreenDPI(UnityEngine.UI.CanvasScaler instance)
		{
			return instance.fallbackScreenDPI;
		}

		static private void set_fallbackScreenDPI(UnityEngine.UI.CanvasScaler instance, System.Single value)
		{
			instance.fallbackScreenDPI = value;
		}

		static private System.Single get_defaultSpriteDPI(UnityEngine.UI.CanvasScaler instance)
		{
			return instance.defaultSpriteDPI;
		}

		static private void set_defaultSpriteDPI(UnityEngine.UI.CanvasScaler instance, System.Single value)
		{
			instance.defaultSpriteDPI = value;
		}

		static private System.Single get_dynamicPixelsPerUnit(UnityEngine.UI.CanvasScaler instance)
		{
			return instance.dynamicPixelsPerUnit;
		}

		static private void set_dynamicPixelsPerUnit(UnityEngine.UI.CanvasScaler instance, System.Single value)
		{
			instance.dynamicPixelsPerUnit = value;
		}

	}
}
