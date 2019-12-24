using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIImage
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.Image> self = space.DeclareClass<UnityEngine.UI.Image, UnityEngine.UI.MaskableGraphic>();
			UnityEngineUIImageFillMethod.Bind(self);
			UnityEngineUIImageOrigin180.Bind(self);
			UnityEngineUIImageOrigin360.Bind(self);
			UnityEngineUIImageOrigin90.Bind(self);
			UnityEngineUIImageOriginHorizontal.Bind(self);
			UnityEngineUIImageOriginVertical.Bind(self);
			UnityEngineUIImageType.Bind(self);
			self.BindConstructor();
			self.BindInstanceFunction("CalculateLayoutInputHorizontal", CalculateLayoutInputHorizontal);
			self.BindInstanceFunction("CalculateLayoutInputVertical", CalculateLayoutInputVertical);
			self.BindInstanceFunction("IsRaycastLocationValid", IsRaycastLocationValid);
			self.BindInstanceFunction("OnAfterDeserialize", OnAfterDeserialize);
			self.BindInstanceFunction("OnBeforeSerialize", OnBeforeSerialize);
			self.BindInstanceFunction("SetNativeSize", SetNativeSize);
			self.BindStaticProperty("defaultETC1GraphicMaterial", get_defaultETC1GraphicMaterial, null);
			self.BindInstanceProperty("sprite", get_sprite, set_sprite);
			self.BindInstanceProperty("preferredHeight", get_preferredHeight, null);
			self.BindInstanceProperty("minHeight", get_minHeight, null);
			self.BindInstanceProperty("flexibleWidth", get_flexibleWidth, null);
			self.BindInstanceProperty("preferredWidth", get_preferredWidth, null);
			self.BindInstanceProperty("minWidth", get_minWidth, null);
			self.BindInstanceProperty("material", get_material, set_material);
			self.BindInstanceProperty("pixelsPerUnit", get_pixelsPerUnit, null);
			self.BindInstanceProperty("hasBorder", get_hasBorder, null);
			self.BindInstanceProperty("mainTexture", get_mainTexture, null);
			self.BindInstanceProperty("useSpriteMesh", get_useSpriteMesh, set_useSpriteMesh);
			self.BindInstanceProperty("alphaHitTestMinimumThreshold", get_alphaHitTestMinimumThreshold, set_alphaHitTestMinimumThreshold);
			self.BindInstanceProperty("fillOrigin", get_fillOrigin, set_fillOrigin);
			self.BindInstanceProperty("fillClockwise", get_fillClockwise, set_fillClockwise);
			self.BindInstanceProperty("fillAmount", get_fillAmount, set_fillAmount);
			self.BindInstanceProperty("fillCenter", get_fillCenter, set_fillCenter);
			self.BindInstanceProperty("preserveAspect", get_preserveAspect, set_preserveAspect);
			self.BindInstanceProperty("overrideSprite", get_overrideSprite, set_overrideSprite);
			self.BindInstanceProperty("flexibleHeight", get_flexibleHeight, null);
			self.BindInstanceProperty("layoutPriority", get_layoutPriority, null);
		}

		static private void CalculateLayoutInputHorizontal(UnityEngine.UI.Image instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.CalculateLayoutInputHorizontal();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Image.CalculateLayoutInputHorizontal has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void CalculateLayoutInputVertical(UnityEngine.UI.Image instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.CalculateLayoutInputVertical();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Image.CalculateLayoutInputVertical has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean IsRaycastLocationValid(UnityEngine.UI.Image instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Camera>())
			{
				return instance.IsRaycastLocationValid(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Camera>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Image.IsRaycastLocationValid has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Image.IsRaycastLocationValid has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void OnAfterDeserialize(UnityEngine.UI.Image instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.OnAfterDeserialize();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Image.OnAfterDeserialize has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void OnBeforeSerialize(UnityEngine.UI.Image instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.OnBeforeSerialize();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Image.OnBeforeSerialize has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetNativeSize(UnityEngine.UI.Image instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.SetNativeSize();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Image.SetNativeSize has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.Material get_defaultETC1GraphicMaterial(Type type, string name)
		{
			return UnityEngine.UI.Image.defaultETC1GraphicMaterial;
		}

		static private UnityEngine.Sprite get_sprite(UnityEngine.UI.Image instance, string name)
		{
			return instance.sprite;
		}

		static private void set_sprite(UnityEngine.UI.Image instance, string name, UnityEngine.Sprite value)
		{
			instance.sprite = value;
		}

		static private System.Single get_preferredHeight(UnityEngine.UI.Image instance, string name)
		{
			return instance.preferredHeight;
		}

		static private System.Single get_minHeight(UnityEngine.UI.Image instance, string name)
		{
			return instance.minHeight;
		}

		static private System.Single get_flexibleWidth(UnityEngine.UI.Image instance, string name)
		{
			return instance.flexibleWidth;
		}

		static private System.Single get_preferredWidth(UnityEngine.UI.Image instance, string name)
		{
			return instance.preferredWidth;
		}

		static private System.Single get_minWidth(UnityEngine.UI.Image instance, string name)
		{
			return instance.minWidth;
		}

		static private UnityEngine.Material get_material(UnityEngine.UI.Image instance, string name)
		{
			return instance.material;
		}

		static private void set_material(UnityEngine.UI.Image instance, string name, UnityEngine.Material value)
		{
			instance.material = value;
		}

		static private System.Single get_pixelsPerUnit(UnityEngine.UI.Image instance, string name)
		{
			return instance.pixelsPerUnit;
		}

		static private System.Boolean get_hasBorder(UnityEngine.UI.Image instance, string name)
		{
			return instance.hasBorder;
		}

		static private UnityEngine.Texture get_mainTexture(UnityEngine.UI.Image instance, string name)
		{
			return instance.mainTexture;
		}

		static private System.Boolean get_useSpriteMesh(UnityEngine.UI.Image instance, string name)
		{
			return instance.useSpriteMesh;
		}

		static private void set_useSpriteMesh(UnityEngine.UI.Image instance, string name, System.Boolean value)
		{
			instance.useSpriteMesh = value;
		}

		static private System.Single get_alphaHitTestMinimumThreshold(UnityEngine.UI.Image instance, string name)
		{
			return instance.alphaHitTestMinimumThreshold;
		}

		static private void set_alphaHitTestMinimumThreshold(UnityEngine.UI.Image instance, string name, System.Single value)
		{
			instance.alphaHitTestMinimumThreshold = value;
		}

		static private System.Int32 get_fillOrigin(UnityEngine.UI.Image instance, string name)
		{
			return instance.fillOrigin;
		}

		static private void set_fillOrigin(UnityEngine.UI.Image instance, string name, System.Int32 value)
		{
			instance.fillOrigin = value;
		}

		static private System.Boolean get_fillClockwise(UnityEngine.UI.Image instance, string name)
		{
			return instance.fillClockwise;
		}

		static private void set_fillClockwise(UnityEngine.UI.Image instance, string name, System.Boolean value)
		{
			instance.fillClockwise = value;
		}

		static private System.Single get_fillAmount(UnityEngine.UI.Image instance, string name)
		{
			return instance.fillAmount;
		}

		static private void set_fillAmount(UnityEngine.UI.Image instance, string name, System.Single value)
		{
			instance.fillAmount = value;
		}

		static private System.Boolean get_fillCenter(UnityEngine.UI.Image instance, string name)
		{
			return instance.fillCenter;
		}

		static private void set_fillCenter(UnityEngine.UI.Image instance, string name, System.Boolean value)
		{
			instance.fillCenter = value;
		}

		static private System.Boolean get_preserveAspect(UnityEngine.UI.Image instance, string name)
		{
			return instance.preserveAspect;
		}

		static private void set_preserveAspect(UnityEngine.UI.Image instance, string name, System.Boolean value)
		{
			instance.preserveAspect = value;
		}

		static private UnityEngine.Sprite get_overrideSprite(UnityEngine.UI.Image instance, string name)
		{
			return instance.overrideSprite;
		}

		static private void set_overrideSprite(UnityEngine.UI.Image instance, string name, UnityEngine.Sprite value)
		{
			instance.overrideSprite = value;
		}

		static private System.Single get_flexibleHeight(UnityEngine.UI.Image instance, string name)
		{
			return instance.flexibleHeight;
		}

		static private System.Int32 get_layoutPriority(UnityEngine.UI.Image instance, string name)
		{
			return instance.layoutPriority;
		}

	}
}
