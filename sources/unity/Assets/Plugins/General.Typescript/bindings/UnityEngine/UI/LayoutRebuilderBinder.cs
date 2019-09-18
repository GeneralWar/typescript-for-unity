using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUILayoutRebuilder
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.LayoutRebuilder> self = space.DeclareClass<UnityEngine.UI.LayoutRebuilder>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("ForceRebuildLayoutImmediate", ForceRebuildLayoutImmediate);
			self.BindStaticFunction("MarkLayoutForRebuild", MarkLayoutForRebuild);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("GraphicUpdateComplete", GraphicUpdateComplete);
			self.BindInstanceFunction("IsDestroyed", IsDestroyed);
			self.BindInstanceFunction("LayoutComplete", LayoutComplete);
			self.BindInstanceFunction("Rebuild", Rebuild);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("transform", get_transform, null);
		}

		static private UnityEngine.UI.LayoutRebuilder Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.UI.LayoutRebuilder();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.LayoutRebuilder.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.UI.LayoutRebuilder);
		}

		static private void ForceRebuildLayoutImmediate(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RectTransform>())
			{
				UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate(parameters[0].ToObject<UnityEngine.RectTransform>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.LayoutRebuilder.ForceRebuildLayoutImmediate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void MarkLayoutForRebuild(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.RectTransform>())
			{
				UnityEngine.UI.LayoutRebuilder.MarkLayoutForRebuild(parameters[0].ToObject<UnityEngine.RectTransform>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.LayoutRebuilder.MarkLayoutForRebuild has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.LayoutRebuilder.MarkLayoutForRebuild has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean Equals(UnityEngine.UI.LayoutRebuilder instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.LayoutRebuilder.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.LayoutRebuilder.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.UI.LayoutRebuilder instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetHashCode();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.LayoutRebuilder.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private void GraphicUpdateComplete(UnityEngine.UI.LayoutRebuilder instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.GraphicUpdateComplete();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.LayoutRebuilder.GraphicUpdateComplete has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean IsDestroyed(UnityEngine.UI.LayoutRebuilder instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsDestroyed();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.LayoutRebuilder.IsDestroyed has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private void LayoutComplete(UnityEngine.UI.LayoutRebuilder instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.LayoutComplete();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.LayoutRebuilder.LayoutComplete has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Rebuild(UnityEngine.UI.LayoutRebuilder instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.CanvasUpdate>())
			{
				instance.Rebuild(parameters[0].ToObject<UnityEngine.UI.CanvasUpdate>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.LayoutRebuilder.Rebuild has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.LayoutRebuilder.Rebuild has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.String ToString(UnityEngine.UI.LayoutRebuilder instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.LayoutRebuilder.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Transform get_transform(UnityEngine.UI.LayoutRebuilder instance)
		{
			return instance.transform;
		}

	}
}
