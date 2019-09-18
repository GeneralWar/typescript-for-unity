using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRectTransform
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.RectTransform> self = space.DeclareClass<UnityEngine.RectTransform, UnityEngine.Transform>();
			UnityEngineRectTransformAxis.Bind(self);
			UnityEngineRectTransformEdge.Bind(self);
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("ForceUpdateRectTransforms", ForceUpdateRectTransforms);
			self.BindInstanceFunction("GetLocalCorners", GetLocalCorners);
			self.BindInstanceFunction("GetWorldCorners", GetWorldCorners);
			self.BindInstanceFunction("SetInsetAndSizeFromParentEdge", SetInsetAndSizeFromParentEdge);
			self.BindInstanceFunction("SetSizeWithCurrentAnchors", SetSizeWithCurrentAnchors);
			self.BindInstanceProperty("rect", get_rect, null);
			self.BindInstanceProperty("anchorMin", get_anchorMin, set_anchorMin);
			self.BindInstanceProperty("anchorMax", get_anchorMax, set_anchorMax);
			self.BindInstanceProperty("anchoredPosition", get_anchoredPosition, set_anchoredPosition);
			self.BindInstanceProperty("sizeDelta", get_sizeDelta, set_sizeDelta);
			self.BindInstanceProperty("pivot", get_pivot, set_pivot);
			self.BindInstanceProperty("anchoredPosition3D", get_anchoredPosition3D, set_anchoredPosition3D);
			self.BindInstanceProperty("offsetMin", get_offsetMin, set_offsetMin);
			self.BindInstanceProperty("offsetMax", get_offsetMax, set_offsetMax);
		}

		static private UnityEngine.RectTransform Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.RectTransform();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.RectTransform.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.RectTransform);
		}

		static private void ForceUpdateRectTransforms(UnityEngine.RectTransform instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.ForceUpdateRectTransforms();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.RectTransform.ForceUpdateRectTransforms has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void GetLocalCorners(UnityEngine.RectTransform instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3[]>())
			{
				instance.GetLocalCorners(parameters[0].ToObject<UnityEngine.Vector3[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectTransform.GetLocalCorners has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectTransform.GetLocalCorners has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void GetWorldCorners(UnityEngine.RectTransform instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3[]>())
			{
				instance.GetWorldCorners(parameters[0].ToObject<UnityEngine.Vector3[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectTransform.GetWorldCorners has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectTransform.GetWorldCorners has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetInsetAndSizeFromParentEdge(UnityEngine.RectTransform instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RectTransform.Edge, System.Single, System.Single>())
			{
				instance.SetInsetAndSizeFromParentEdge(parameters[0].ToObject<UnityEngine.RectTransform.Edge>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectTransform.SetInsetAndSizeFromParentEdge has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectTransform.SetInsetAndSizeFromParentEdge has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetSizeWithCurrentAnchors(UnityEngine.RectTransform instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RectTransform.Axis, System.Single>())
			{
				instance.SetSizeWithCurrentAnchors(parameters[0].ToObject<UnityEngine.RectTransform.Axis>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectTransform.SetSizeWithCurrentAnchors has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectTransform.SetSizeWithCurrentAnchors has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Rect get_rect(UnityEngine.RectTransform instance)
		{
			return instance.rect;
		}

		static private UnityEngine.Vector2 get_anchorMin(UnityEngine.RectTransform instance)
		{
			return instance.anchorMin;
		}

		static private void set_anchorMin(UnityEngine.RectTransform instance, UnityEngine.Vector2 value)
		{
			instance.anchorMin = value;
		}

		static private UnityEngine.Vector2 get_anchorMax(UnityEngine.RectTransform instance)
		{
			return instance.anchorMax;
		}

		static private void set_anchorMax(UnityEngine.RectTransform instance, UnityEngine.Vector2 value)
		{
			instance.anchorMax = value;
		}

		static private UnityEngine.Vector2 get_anchoredPosition(UnityEngine.RectTransform instance)
		{
			return instance.anchoredPosition;
		}

		static private void set_anchoredPosition(UnityEngine.RectTransform instance, UnityEngine.Vector2 value)
		{
			instance.anchoredPosition = value;
		}

		static private UnityEngine.Vector2 get_sizeDelta(UnityEngine.RectTransform instance)
		{
			return instance.sizeDelta;
		}

		static private void set_sizeDelta(UnityEngine.RectTransform instance, UnityEngine.Vector2 value)
		{
			instance.sizeDelta = value;
		}

		static private UnityEngine.Vector2 get_pivot(UnityEngine.RectTransform instance)
		{
			return instance.pivot;
		}

		static private void set_pivot(UnityEngine.RectTransform instance, UnityEngine.Vector2 value)
		{
			instance.pivot = value;
		}

		static private UnityEngine.Vector3 get_anchoredPosition3D(UnityEngine.RectTransform instance)
		{
			return instance.anchoredPosition3D;
		}

		static private void set_anchoredPosition3D(UnityEngine.RectTransform instance, UnityEngine.Vector3 value)
		{
			instance.anchoredPosition3D = value;
		}

		static private UnityEngine.Vector2 get_offsetMin(UnityEngine.RectTransform instance)
		{
			return instance.offsetMin;
		}

		static private void set_offsetMin(UnityEngine.RectTransform instance, UnityEngine.Vector2 value)
		{
			instance.offsetMin = value;
		}

		static private UnityEngine.Vector2 get_offsetMax(UnityEngine.RectTransform instance)
		{
			return instance.offsetMax;
		}

		static private void set_offsetMax(UnityEngine.RectTransform instance, UnityEngine.Vector2 value)
		{
			instance.offsetMax = value;
		}

	}
}
