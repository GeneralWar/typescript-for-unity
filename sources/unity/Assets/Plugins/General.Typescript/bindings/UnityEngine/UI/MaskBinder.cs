using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIMask
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.Mask> self = space.DeclareClass<UnityEngine.UI.Mask, UnityEngine.EventSystems.UIBehaviour>();
			self.BindConstructor();
			self.BindInstanceFunction("GetModifiedMaterial", GetModifiedMaterial);
			self.BindInstanceFunction("IsRaycastLocationValid", IsRaycastLocationValid);
			self.BindInstanceFunction("MaskEnabled", MaskEnabled);
			self.BindInstanceProperty("rectTransform", get_rectTransform, null);
			self.BindInstanceProperty("showMaskGraphic", get_showMaskGraphic, set_showMaskGraphic);
			self.BindInstanceProperty("graphic", get_graphic, null);
		}

		static private UnityEngine.Material GetModifiedMaterial(UnityEngine.UI.Mask instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Material>())
			{
				return instance.GetModifiedMaterial(parameters[0].ToObject<UnityEngine.Material>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Mask.GetModifiedMaterial has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Mask.GetModifiedMaterial has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean IsRaycastLocationValid(UnityEngine.UI.Mask instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Camera>())
			{
				return instance.IsRaycastLocationValid(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Camera>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Mask.IsRaycastLocationValid has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Mask.IsRaycastLocationValid has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean MaskEnabled(UnityEngine.UI.Mask instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.MaskEnabled();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Mask.MaskEnabled has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private UnityEngine.RectTransform get_rectTransform(UnityEngine.UI.Mask instance, string name)
		{
			return instance.rectTransform;
		}

		static private System.Boolean get_showMaskGraphic(UnityEngine.UI.Mask instance, string name)
		{
			return instance.showMaskGraphic;
		}

		static private void set_showMaskGraphic(UnityEngine.UI.Mask instance, string name, System.Boolean value)
		{
			instance.showMaskGraphic = value;
		}

		static private UnityEngine.UI.Graphic get_graphic(UnityEngine.UI.Mask instance, string name)
		{
			return instance.graphic;
		}

	}
}
