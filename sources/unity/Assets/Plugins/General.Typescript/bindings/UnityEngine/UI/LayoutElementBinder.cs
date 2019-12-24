using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUILayoutElement
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.LayoutElement> self = space.DeclareClass<UnityEngine.UI.LayoutElement, UnityEngine.EventSystems.UIBehaviour>();
			self.BindConstructor();
			self.BindInstanceFunction("CalculateLayoutInputHorizontal", CalculateLayoutInputHorizontal);
			self.BindInstanceFunction("CalculateLayoutInputVertical", CalculateLayoutInputVertical);
			self.BindInstanceProperty("ignoreLayout", get_ignoreLayout, set_ignoreLayout);
			self.BindInstanceProperty("minWidth", get_minWidth, set_minWidth);
			self.BindInstanceProperty("minHeight", get_minHeight, set_minHeight);
			self.BindInstanceProperty("preferredWidth", get_preferredWidth, set_preferredWidth);
			self.BindInstanceProperty("preferredHeight", get_preferredHeight, set_preferredHeight);
			self.BindInstanceProperty("flexibleWidth", get_flexibleWidth, set_flexibleWidth);
			self.BindInstanceProperty("flexibleHeight", get_flexibleHeight, set_flexibleHeight);
			self.BindInstanceProperty("layoutPriority", get_layoutPriority, set_layoutPriority);
		}

		static private void CalculateLayoutInputHorizontal(UnityEngine.UI.LayoutElement instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.LayoutElement.CalculateLayoutInputHorizontal has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void CalculateLayoutInputVertical(UnityEngine.UI.LayoutElement instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.LayoutElement.CalculateLayoutInputVertical has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean get_ignoreLayout(UnityEngine.UI.LayoutElement instance, string name)
		{
			return instance.ignoreLayout;
		}

		static private void set_ignoreLayout(UnityEngine.UI.LayoutElement instance, string name, System.Boolean value)
		{
			instance.ignoreLayout = value;
		}

		static private System.Single get_minWidth(UnityEngine.UI.LayoutElement instance, string name)
		{
			return instance.minWidth;
		}

		static private void set_minWidth(UnityEngine.UI.LayoutElement instance, string name, System.Single value)
		{
			instance.minWidth = value;
		}

		static private System.Single get_minHeight(UnityEngine.UI.LayoutElement instance, string name)
		{
			return instance.minHeight;
		}

		static private void set_minHeight(UnityEngine.UI.LayoutElement instance, string name, System.Single value)
		{
			instance.minHeight = value;
		}

		static private System.Single get_preferredWidth(UnityEngine.UI.LayoutElement instance, string name)
		{
			return instance.preferredWidth;
		}

		static private void set_preferredWidth(UnityEngine.UI.LayoutElement instance, string name, System.Single value)
		{
			instance.preferredWidth = value;
		}

		static private System.Single get_preferredHeight(UnityEngine.UI.LayoutElement instance, string name)
		{
			return instance.preferredHeight;
		}

		static private void set_preferredHeight(UnityEngine.UI.LayoutElement instance, string name, System.Single value)
		{
			instance.preferredHeight = value;
		}

		static private System.Single get_flexibleWidth(UnityEngine.UI.LayoutElement instance, string name)
		{
			return instance.flexibleWidth;
		}

		static private void set_flexibleWidth(UnityEngine.UI.LayoutElement instance, string name, System.Single value)
		{
			instance.flexibleWidth = value;
		}

		static private System.Single get_flexibleHeight(UnityEngine.UI.LayoutElement instance, string name)
		{
			return instance.flexibleHeight;
		}

		static private void set_flexibleHeight(UnityEngine.UI.LayoutElement instance, string name, System.Single value)
		{
			instance.flexibleHeight = value;
		}

		static private System.Int32 get_layoutPriority(UnityEngine.UI.LayoutElement instance, string name)
		{
			return instance.layoutPriority;
		}

		static private void set_layoutPriority(UnityEngine.UI.LayoutElement instance, string name, System.Int32 value)
		{
			instance.layoutPriority = value;
		}

	}
}
