using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRectTransformUtility
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.RectTransformUtility> self = space.DeclareClass<UnityEngine.RectTransformUtility>();
			self.BindConstructor();
			self.BindStaticFunction("CalculateRelativeRectTransformBounds", CalculateRelativeRectTransformBounds);
			self.BindStaticFunction("FlipLayoutAxes", FlipLayoutAxes);
			self.BindStaticFunction("FlipLayoutOnAxis", FlipLayoutOnAxis);
			self.BindStaticFunction("PixelAdjustPoint", PixelAdjustPoint);
			self.BindStaticFunction("PixelAdjustRect", PixelAdjustRect);
			self.BindStaticFunction("RectangleContainsScreenPoint", RectangleContainsScreenPoint);
			self.BindStaticFunction("ScreenPointToRay", ScreenPointToRay);
			self.BindStaticFunction("WorldToScreenPoint", WorldToScreenPoint);
		}

		static private UnityEngine.Bounds CalculateRelativeRectTransformBounds(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Transform>())
			{
				return UnityEngine.RectTransformUtility.CalculateRelativeRectTransformBounds(parameters[0].ToObject<UnityEngine.Transform>());
			}
			if (parameters.CheckTypes<UnityEngine.Transform, UnityEngine.Transform>())
			{
				return UnityEngine.RectTransformUtility.CalculateRelativeRectTransformBounds(parameters[0].ToObject<UnityEngine.Transform>(), parameters[1].ToObject<UnityEngine.Transform>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectTransformUtility.CalculateRelativeRectTransformBounds has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectTransformUtility.CalculateRelativeRectTransformBounds has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Bounds);
		}

		static private void FlipLayoutAxes(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RectTransform, System.Boolean, System.Boolean>())
			{
				UnityEngine.RectTransformUtility.FlipLayoutAxes(parameters[0].ToObject<UnityEngine.RectTransform>(), parameters[1].ToObject<System.Boolean>(), parameters[2].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectTransformUtility.FlipLayoutAxes has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectTransformUtility.FlipLayoutAxes has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void FlipLayoutOnAxis(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RectTransform, System.Int32, System.Boolean, System.Boolean>())
			{
				UnityEngine.RectTransformUtility.FlipLayoutOnAxis(parameters[0].ToObject<UnityEngine.RectTransform>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Boolean>(), parameters[3].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectTransformUtility.FlipLayoutOnAxis has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectTransformUtility.FlipLayoutOnAxis has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Vector2 PixelAdjustPoint(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Transform, UnityEngine.Canvas>())
			{
				return UnityEngine.RectTransformUtility.PixelAdjustPoint(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Transform>(), parameters[2].ToObject<UnityEngine.Canvas>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectTransformUtility.PixelAdjustPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectTransformUtility.PixelAdjustPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private UnityEngine.Rect PixelAdjustRect(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RectTransform, UnityEngine.Canvas>())
			{
				return UnityEngine.RectTransformUtility.PixelAdjustRect(parameters[0].ToObject<UnityEngine.RectTransform>(), parameters[1].ToObject<UnityEngine.Canvas>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectTransformUtility.PixelAdjustRect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectTransformUtility.PixelAdjustRect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Rect);
		}

		static private System.Boolean RectangleContainsScreenPoint(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RectTransform, UnityEngine.Vector2>())
			{
				return UnityEngine.RectTransformUtility.RectangleContainsScreenPoint(parameters[0].ToObject<UnityEngine.RectTransform>(), parameters[1].ToObject<UnityEngine.Vector2>());
			}
			if (parameters.CheckTypes<UnityEngine.RectTransform, UnityEngine.Vector2, UnityEngine.Camera>())
			{
				return UnityEngine.RectTransformUtility.RectangleContainsScreenPoint(parameters[0].ToObject<UnityEngine.RectTransform>(), parameters[1].ToObject<UnityEngine.Vector2>(), parameters[2].ToObject<UnityEngine.Camera>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectTransformUtility.RectangleContainsScreenPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectTransformUtility.RectangleContainsScreenPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.Ray ScreenPointToRay(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Camera, UnityEngine.Vector2>())
			{
				return UnityEngine.RectTransformUtility.ScreenPointToRay(parameters[0].ToObject<UnityEngine.Camera>(), parameters[1].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectTransformUtility.ScreenPointToRay has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectTransformUtility.ScreenPointToRay has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Ray);
		}

		static private UnityEngine.Vector2 WorldToScreenPoint(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Camera, UnityEngine.Vector3>())
			{
				return UnityEngine.RectTransformUtility.WorldToScreenPoint(parameters[0].ToObject<UnityEngine.Camera>(), parameters[1].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.RectTransformUtility.WorldToScreenPoint has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.RectTransformUtility.WorldToScreenPoint has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

	}
}
