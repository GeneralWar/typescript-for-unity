using System;

namespace General.Typescript
{
    public class UIBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("UI");

			UnityEngineUIAnimationTriggers.Bind(self);
			UnityEngineUIAspectRatioFitter.Bind(self);
			UnityEngineUIButton.Bind(self);
			UnityEngineUICanvasScaler.Bind(self);
			UnityEngineUICanvasUpdate.Bind(self);
			UnityEngineUICanvasUpdateRegistry.Bind(self);
			UnityEngineUIClipperRegistry.Bind(self);
			UnityEngineUIColorBlock.Bind(self);
			UnityEngineUIContentSizeFitter.Bind(self);
			UnityEngineUIDropdown.Bind(self);
			UnityEngineUIFontData.Bind(self);
			UnityEngineUIGraphicRaycaster.Bind(self);
			UnityEngineUIGraphicRegistry.Bind(self);
			UnityEngineUIGridLayoutGroup.Bind(self);
			UnityEngineUIHorizontalLayoutGroup.Bind(self);
			UnityEngineUIImage.Bind(self);
			UnityEngineUIInputField.Bind(self);
			UnityEngineUILayoutElement.Bind(self);
			UnityEngineUILayoutRebuilder.Bind(self);
			UnityEngineUIMask.Bind(self);
			UnityEngineUIMaskUtilities.Bind(self);
			UnityEngineUINavigation.Bind(self);
			UnityEngineUIOutline.Bind(self);
			UnityEngineUIPositionAsUV1.Bind(self);
			UnityEngineUIRawImage.Bind(self);
			UnityEngineUIRectMask2D.Bind(self);
			UnityEngineUIScrollbar.Bind(self);
			UnityEngineUIScrollRect.Bind(self);
			UnityEngineUISelectable.Bind(self);
			UnityEngineUIShadow.Bind(self);
			UnityEngineUISlider.Bind(self);
			UnityEngineUISpriteState.Bind(self);
			UnityEngineUIToggle.Bind(self);
			UnityEngineUIToggleGroup.Bind(self);
			UnityEngineUIVertexHelper.Bind(self);
			UnityEngineUIVerticalLayoutGroup.Bind(self);
        }
    }
}