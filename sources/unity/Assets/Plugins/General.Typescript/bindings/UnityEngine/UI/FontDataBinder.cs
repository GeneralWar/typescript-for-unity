using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIFontData
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.FontData> self = space.DeclareClass<UnityEngine.UI.FontData>();
			self.BindConstructor(Constructor);
			self.BindStaticProperty("defaultFontData", get_defaultFontData, null);
			self.BindInstanceProperty("font", get_font, set_font);
			self.BindInstanceProperty("fontSize", get_fontSize, set_fontSize);
			self.BindInstanceProperty("fontStyle", get_fontStyle, set_fontStyle);
			self.BindInstanceProperty("bestFit", get_bestFit, set_bestFit);
			self.BindInstanceProperty("minSize", get_minSize, set_minSize);
			self.BindInstanceProperty("maxSize", get_maxSize, set_maxSize);
			self.BindInstanceProperty("alignment", get_alignment, set_alignment);
			self.BindInstanceProperty("alignByGeometry", get_alignByGeometry, set_alignByGeometry);
			self.BindInstanceProperty("richText", get_richText, set_richText);
			self.BindInstanceProperty("horizontalOverflow", get_horizontalOverflow, set_horizontalOverflow);
			self.BindInstanceProperty("verticalOverflow", get_verticalOverflow, set_verticalOverflow);
			self.BindInstanceProperty("lineSpacing", get_lineSpacing, set_lineSpacing);
		}

		static private UnityEngine.UI.FontData Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.UI.FontData();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.FontData.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.UI.FontData);
		}

		static private UnityEngine.UI.FontData get_defaultFontData()
		{
			return UnityEngine.UI.FontData.defaultFontData;
		}

		static private UnityEngine.Font get_font(UnityEngine.UI.FontData instance)
		{
			return instance.font;
		}

		static private void set_font(UnityEngine.UI.FontData instance, UnityEngine.Font value)
		{
			instance.font = value;
		}

		static private System.Int32 get_fontSize(UnityEngine.UI.FontData instance)
		{
			return instance.fontSize;
		}

		static private void set_fontSize(UnityEngine.UI.FontData instance, System.Int32 value)
		{
			instance.fontSize = value;
		}

		static private UnityEngine.FontStyle get_fontStyle(UnityEngine.UI.FontData instance)
		{
			return instance.fontStyle;
		}

		static private void set_fontStyle(UnityEngine.UI.FontData instance, UnityEngine.FontStyle value)
		{
			instance.fontStyle = value;
		}

		static private System.Boolean get_bestFit(UnityEngine.UI.FontData instance)
		{
			return instance.bestFit;
		}

		static private void set_bestFit(UnityEngine.UI.FontData instance, System.Boolean value)
		{
			instance.bestFit = value;
		}

		static private System.Int32 get_minSize(UnityEngine.UI.FontData instance)
		{
			return instance.minSize;
		}

		static private void set_minSize(UnityEngine.UI.FontData instance, System.Int32 value)
		{
			instance.minSize = value;
		}

		static private System.Int32 get_maxSize(UnityEngine.UI.FontData instance)
		{
			return instance.maxSize;
		}

		static private void set_maxSize(UnityEngine.UI.FontData instance, System.Int32 value)
		{
			instance.maxSize = value;
		}

		static private UnityEngine.TextAnchor get_alignment(UnityEngine.UI.FontData instance)
		{
			return instance.alignment;
		}

		static private void set_alignment(UnityEngine.UI.FontData instance, UnityEngine.TextAnchor value)
		{
			instance.alignment = value;
		}

		static private System.Boolean get_alignByGeometry(UnityEngine.UI.FontData instance)
		{
			return instance.alignByGeometry;
		}

		static private void set_alignByGeometry(UnityEngine.UI.FontData instance, System.Boolean value)
		{
			instance.alignByGeometry = value;
		}

		static private System.Boolean get_richText(UnityEngine.UI.FontData instance)
		{
			return instance.richText;
		}

		static private void set_richText(UnityEngine.UI.FontData instance, System.Boolean value)
		{
			instance.richText = value;
		}

		static private UnityEngine.HorizontalWrapMode get_horizontalOverflow(UnityEngine.UI.FontData instance)
		{
			return instance.horizontalOverflow;
		}

		static private void set_horizontalOverflow(UnityEngine.UI.FontData instance, UnityEngine.HorizontalWrapMode value)
		{
			instance.horizontalOverflow = value;
		}

		static private UnityEngine.VerticalWrapMode get_verticalOverflow(UnityEngine.UI.FontData instance)
		{
			return instance.verticalOverflow;
		}

		static private void set_verticalOverflow(UnityEngine.UI.FontData instance, UnityEngine.VerticalWrapMode value)
		{
			instance.verticalOverflow = value;
		}

		static private System.Single get_lineSpacing(UnityEngine.UI.FontData instance)
		{
			return instance.lineSpacing;
		}

		static private void set_lineSpacing(UnityEngine.UI.FontData instance, System.Single value)
		{
			instance.lineSpacing = value;
		}

	}
}
