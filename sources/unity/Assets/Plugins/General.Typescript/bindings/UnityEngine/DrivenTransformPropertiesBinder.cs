using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineDrivenTransformProperties
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.DrivenTransformProperties> instance = space.DeclareEnum<UnityEngine.DrivenTransformProperties>();
			instance.SetValue("None", (long)UnityEngine.DrivenTransformProperties.None);
			instance.SetValue("AnchoredPositionX", (long)UnityEngine.DrivenTransformProperties.AnchoredPositionX);
			instance.SetValue("AnchoredPositionY", (long)UnityEngine.DrivenTransformProperties.AnchoredPositionY);
			instance.SetValue("AnchoredPosition", (long)UnityEngine.DrivenTransformProperties.AnchoredPosition);
			instance.SetValue("AnchoredPositionZ", (long)UnityEngine.DrivenTransformProperties.AnchoredPositionZ);
			instance.SetValue("AnchoredPosition3D", (long)UnityEngine.DrivenTransformProperties.AnchoredPosition3D);
			instance.SetValue("Rotation", (long)UnityEngine.DrivenTransformProperties.Rotation);
			instance.SetValue("ScaleX", (long)UnityEngine.DrivenTransformProperties.ScaleX);
			instance.SetValue("ScaleY", (long)UnityEngine.DrivenTransformProperties.ScaleY);
			instance.SetValue("ScaleZ", (long)UnityEngine.DrivenTransformProperties.ScaleZ);
			instance.SetValue("Scale", (long)UnityEngine.DrivenTransformProperties.Scale);
			instance.SetValue("AnchorMinX", (long)UnityEngine.DrivenTransformProperties.AnchorMinX);
			instance.SetValue("AnchorMinY", (long)UnityEngine.DrivenTransformProperties.AnchorMinY);
			instance.SetValue("AnchorMin", (long)UnityEngine.DrivenTransformProperties.AnchorMin);
			instance.SetValue("AnchorMaxX", (long)UnityEngine.DrivenTransformProperties.AnchorMaxX);
			instance.SetValue("AnchorMaxY", (long)UnityEngine.DrivenTransformProperties.AnchorMaxY);
			instance.SetValue("AnchorMax", (long)UnityEngine.DrivenTransformProperties.AnchorMax);
			instance.SetValue("Anchors", (long)UnityEngine.DrivenTransformProperties.Anchors);
			instance.SetValue("SizeDeltaX", (long)UnityEngine.DrivenTransformProperties.SizeDeltaX);
			instance.SetValue("SizeDeltaY", (long)UnityEngine.DrivenTransformProperties.SizeDeltaY);
			instance.SetValue("SizeDelta", (long)UnityEngine.DrivenTransformProperties.SizeDelta);
			instance.SetValue("PivotX", (long)UnityEngine.DrivenTransformProperties.PivotX);
			instance.SetValue("PivotY", (long)UnityEngine.DrivenTransformProperties.PivotY);
			instance.SetValue("Pivot", (long)UnityEngine.DrivenTransformProperties.Pivot);
			instance.SetValue("All", (long)UnityEngine.DrivenTransformProperties.All);
		}
	}
}
