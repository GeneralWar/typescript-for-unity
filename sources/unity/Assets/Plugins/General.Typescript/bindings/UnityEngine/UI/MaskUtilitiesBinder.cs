using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIMaskUtilities
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.MaskUtilities> self = space.DeclareClass<UnityEngine.UI.MaskUtilities>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("FindRootSortOverrideCanvas", FindRootSortOverrideCanvas);
			self.BindStaticFunction("GetRectMaskForClippable", GetRectMaskForClippable);
			self.BindStaticFunction("GetStencilDepth", GetStencilDepth);
			self.BindStaticFunction("IsDescendantOrSelf", IsDescendantOrSelf);
			self.BindStaticFunction("Notify2DMaskStateChanged", Notify2DMaskStateChanged);
			self.BindStaticFunction("NotifyStencilStateChanged", NotifyStencilStateChanged);
		}

		static private UnityEngine.UI.MaskUtilities Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.UI.MaskUtilities();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.MaskUtilities.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.UI.MaskUtilities);
		}

		static private UnityEngine.Transform FindRootSortOverrideCanvas(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Transform>())
			{
				return UnityEngine.UI.MaskUtilities.FindRootSortOverrideCanvas(parameters[0].ToObject<UnityEngine.Transform>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.MaskUtilities.FindRootSortOverrideCanvas has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.MaskUtilities.FindRootSortOverrideCanvas has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.UI.RectMask2D GetRectMaskForClippable(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.IClippable>())
			{
				return UnityEngine.UI.MaskUtilities.GetRectMaskForClippable(parameters[0].ToObject<UnityEngine.UI.IClippable>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.MaskUtilities.GetRectMaskForClippable has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.MaskUtilities.GetRectMaskForClippable has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 GetStencilDepth(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Transform, UnityEngine.Transform>())
			{
				return UnityEngine.UI.MaskUtilities.GetStencilDepth(parameters[0].ToObject<UnityEngine.Transform>(), parameters[1].ToObject<UnityEngine.Transform>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.MaskUtilities.GetStencilDepth has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.MaskUtilities.GetStencilDepth has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Boolean IsDescendantOrSelf(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Transform, UnityEngine.Transform>())
			{
				return UnityEngine.UI.MaskUtilities.IsDescendantOrSelf(parameters[0].ToObject<UnityEngine.Transform>(), parameters[1].ToObject<UnityEngine.Transform>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.MaskUtilities.IsDescendantOrSelf has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.MaskUtilities.IsDescendantOrSelf has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void Notify2DMaskStateChanged(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Component>())
			{
				UnityEngine.UI.MaskUtilities.Notify2DMaskStateChanged(parameters[0].ToObject<UnityEngine.Component>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.MaskUtilities.Notify2DMaskStateChanged has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.MaskUtilities.Notify2DMaskStateChanged has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void NotifyStencilStateChanged(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Component>())
			{
				UnityEngine.UI.MaskUtilities.NotifyStencilStateChanged(parameters[0].ToObject<UnityEngine.Component>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.MaskUtilities.NotifyStencilStateChanged has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.MaskUtilities.NotifyStencilStateChanged has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

	}
}
