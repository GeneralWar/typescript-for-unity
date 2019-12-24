using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCanvas
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Canvas> self = space.DeclareClass<UnityEngine.Canvas, UnityEngine.Behaviour>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("ForceUpdateCanvases", ForceUpdateCanvases);
			self.BindStaticFunction("GetDefaultCanvasMaterial", GetDefaultCanvasMaterial);
			self.BindStaticFunction("GetETC1SupportedCanvasMaterial", GetETC1SupportedCanvasMaterial);
			self.BindInstanceProperty("renderMode", get_renderMode, set_renderMode);
			self.BindInstanceProperty("rootCanvas", get_rootCanvas, null);
			self.BindInstanceProperty("sortingLayerName", get_sortingLayerName, set_sortingLayerName);
			self.BindInstanceProperty("additionalShaderChannels", get_additionalShaderChannels, set_additionalShaderChannels);
			self.BindInstanceProperty("cachedSortingLayerValue", get_cachedSortingLayerValue, null);
			self.BindInstanceProperty("sortingLayerID", get_sortingLayerID, set_sortingLayerID);
			self.BindInstanceProperty("targetDisplay", get_targetDisplay, set_targetDisplay);
			self.BindInstanceProperty("sortingOrder", get_sortingOrder, set_sortingOrder);
			self.BindInstanceProperty("worldCamera", get_worldCamera, set_worldCamera);
			self.BindInstanceProperty("overrideSorting", get_overrideSorting, set_overrideSorting);
			self.BindInstanceProperty("planeDistance", get_planeDistance, set_planeDistance);
			self.BindInstanceProperty("pixelPerfect", get_pixelPerfect, set_pixelPerfect);
			self.BindInstanceProperty("overridePixelPerfect", get_overridePixelPerfect, set_overridePixelPerfect);
			self.BindInstanceProperty("referencePixelsPerUnit", get_referencePixelsPerUnit, set_referencePixelsPerUnit);
			self.BindInstanceProperty("scaleFactor", get_scaleFactor, set_scaleFactor);
			self.BindInstanceProperty("pixelRect", get_pixelRect, null);
			self.BindInstanceProperty("isRootCanvas", get_isRootCanvas, null);
			self.BindInstanceProperty("renderOrder", get_renderOrder, null);
			self.BindInstanceProperty("normalizedSortingGridSize", get_normalizedSortingGridSize, set_normalizedSortingGridSize);
		}

		static private UnityEngine.Canvas Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Canvas();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Canvas.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Canvas);
		}

		static private void ForceUpdateCanvases(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.Canvas.ForceUpdateCanvases();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Canvas.ForceUpdateCanvases has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.Material GetDefaultCanvasMaterial(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.Canvas.GetDefaultCanvasMaterial();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Canvas.GetDefaultCanvasMaterial has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Material GetETC1SupportedCanvasMaterial(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.Canvas.GetETC1SupportedCanvasMaterial();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Canvas.GetETC1SupportedCanvasMaterial has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.RenderMode get_renderMode(UnityEngine.Canvas instance, string name)
		{
			return instance.renderMode;
		}

		static private void set_renderMode(UnityEngine.Canvas instance, string name, UnityEngine.RenderMode value)
		{
			instance.renderMode = value;
		}

		static private UnityEngine.Canvas get_rootCanvas(UnityEngine.Canvas instance, string name)
		{
			return instance.rootCanvas;
		}

		static private System.String get_sortingLayerName(UnityEngine.Canvas instance, string name)
		{
			return instance.sortingLayerName;
		}

		static private void set_sortingLayerName(UnityEngine.Canvas instance, string name, System.String value)
		{
			instance.sortingLayerName = value;
		}

		static private UnityEngine.AdditionalCanvasShaderChannels get_additionalShaderChannels(UnityEngine.Canvas instance, string name)
		{
			return instance.additionalShaderChannels;
		}

		static private void set_additionalShaderChannels(UnityEngine.Canvas instance, string name, UnityEngine.AdditionalCanvasShaderChannels value)
		{
			instance.additionalShaderChannels = value;
		}

		static private System.Int32 get_cachedSortingLayerValue(UnityEngine.Canvas instance, string name)
		{
			return instance.cachedSortingLayerValue;
		}

		static private System.Int32 get_sortingLayerID(UnityEngine.Canvas instance, string name)
		{
			return instance.sortingLayerID;
		}

		static private void set_sortingLayerID(UnityEngine.Canvas instance, string name, System.Int32 value)
		{
			instance.sortingLayerID = value;
		}

		static private System.Int32 get_targetDisplay(UnityEngine.Canvas instance, string name)
		{
			return instance.targetDisplay;
		}

		static private void set_targetDisplay(UnityEngine.Canvas instance, string name, System.Int32 value)
		{
			instance.targetDisplay = value;
		}

		static private System.Int32 get_sortingOrder(UnityEngine.Canvas instance, string name)
		{
			return instance.sortingOrder;
		}

		static private void set_sortingOrder(UnityEngine.Canvas instance, string name, System.Int32 value)
		{
			instance.sortingOrder = value;
		}

		static private UnityEngine.Camera get_worldCamera(UnityEngine.Canvas instance, string name)
		{
			return instance.worldCamera;
		}

		static private void set_worldCamera(UnityEngine.Canvas instance, string name, UnityEngine.Camera value)
		{
			instance.worldCamera = value;
		}

		static private System.Boolean get_overrideSorting(UnityEngine.Canvas instance, string name)
		{
			return instance.overrideSorting;
		}

		static private void set_overrideSorting(UnityEngine.Canvas instance, string name, System.Boolean value)
		{
			instance.overrideSorting = value;
		}

		static private System.Single get_planeDistance(UnityEngine.Canvas instance, string name)
		{
			return instance.planeDistance;
		}

		static private void set_planeDistance(UnityEngine.Canvas instance, string name, System.Single value)
		{
			instance.planeDistance = value;
		}

		static private System.Boolean get_pixelPerfect(UnityEngine.Canvas instance, string name)
		{
			return instance.pixelPerfect;
		}

		static private void set_pixelPerfect(UnityEngine.Canvas instance, string name, System.Boolean value)
		{
			instance.pixelPerfect = value;
		}

		static private System.Boolean get_overridePixelPerfect(UnityEngine.Canvas instance, string name)
		{
			return instance.overridePixelPerfect;
		}

		static private void set_overridePixelPerfect(UnityEngine.Canvas instance, string name, System.Boolean value)
		{
			instance.overridePixelPerfect = value;
		}

		static private System.Single get_referencePixelsPerUnit(UnityEngine.Canvas instance, string name)
		{
			return instance.referencePixelsPerUnit;
		}

		static private void set_referencePixelsPerUnit(UnityEngine.Canvas instance, string name, System.Single value)
		{
			instance.referencePixelsPerUnit = value;
		}

		static private System.Single get_scaleFactor(UnityEngine.Canvas instance, string name)
		{
			return instance.scaleFactor;
		}

		static private void set_scaleFactor(UnityEngine.Canvas instance, string name, System.Single value)
		{
			instance.scaleFactor = value;
		}

		static private UnityEngine.Rect get_pixelRect(UnityEngine.Canvas instance, string name)
		{
			return instance.pixelRect;
		}

		static private System.Boolean get_isRootCanvas(UnityEngine.Canvas instance, string name)
		{
			return instance.isRootCanvas;
		}

		static private System.Int32 get_renderOrder(UnityEngine.Canvas instance, string name)
		{
			return instance.renderOrder;
		}

		static private System.Single get_normalizedSortingGridSize(UnityEngine.Canvas instance, string name)
		{
			return instance.normalizedSortingGridSize;
		}

		static private void set_normalizedSortingGridSize(UnityEngine.Canvas instance, string name, System.Single value)
		{
			instance.normalizedSortingGridSize = value;
		}

	}
}
