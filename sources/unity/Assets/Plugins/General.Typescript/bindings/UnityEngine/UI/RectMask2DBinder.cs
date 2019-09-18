using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIRectMask2D
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.RectMask2D> self = space.DeclareClass<UnityEngine.UI.RectMask2D, UnityEngine.EventSystems.UIBehaviour>();
			self.BindConstructor();
			self.BindInstanceFunction("AddClippable", AddClippable);
			self.BindInstanceFunction("IsRaycastLocationValid", IsRaycastLocationValid);
			self.BindInstanceFunction("PerformClipping", PerformClipping);
			self.BindInstanceFunction("RemoveClippable", RemoveClippable);
			self.BindInstanceProperty("canvasRect", get_canvasRect, null);
			self.BindInstanceProperty("rectTransform", get_rectTransform, null);
		}

		static private void AddClippable(UnityEngine.UI.RectMask2D instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.IClippable>())
			{
				instance.AddClippable(parameters[0].ToObject<UnityEngine.UI.IClippable>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.RectMask2D.AddClippable has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.RectMask2D.AddClippable has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean IsRaycastLocationValid(UnityEngine.UI.RectMask2D instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Camera>())
			{
				return instance.IsRaycastLocationValid(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Camera>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.RectMask2D.IsRaycastLocationValid has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.RectMask2D.IsRaycastLocationValid has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void PerformClipping(UnityEngine.UI.RectMask2D instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.PerformClipping();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.RectMask2D.PerformClipping has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void RemoveClippable(UnityEngine.UI.RectMask2D instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.IClippable>())
			{
				instance.RemoveClippable(parameters[0].ToObject<UnityEngine.UI.IClippable>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.RectMask2D.RemoveClippable has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.RectMask2D.RemoveClippable has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Rect get_canvasRect(UnityEngine.UI.RectMask2D instance)
		{
			return instance.canvasRect;
		}

		static private UnityEngine.RectTransform get_rectTransform(UnityEngine.UI.RectMask2D instance)
		{
			return instance.rectTransform;
		}

	}
}
