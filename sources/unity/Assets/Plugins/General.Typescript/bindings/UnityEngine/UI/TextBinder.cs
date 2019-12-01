using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIText
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.Text> self = space.DeclareClass<UnityEngine.UI.Text, UnityEngine.UI.MaskableGraphic>();
			self.BindConstructor();
			self.BindStaticFunction("GetTextAnchorPivot", GetTextAnchorPivot);
			self.BindInstanceFunction("CalculateLayoutInputHorizontal", CalculateLayoutInputHorizontal);
			self.BindInstanceFunction("CalculateLayoutInputVertical", CalculateLayoutInputVertical);
			self.BindInstanceFunction("FontTextureChanged", FontTextureChanged);
			self.BindInstanceFunction("GetGenerationSettings", GetGenerationSettings);
			self.BindInstanceProperty("cachedTextGenerator", get_cachedTextGenerator, null);
			self.BindInstanceProperty("preferredHeight", get_preferredHeight, null);
			self.BindInstanceProperty("minHeight", get_minHeight, null);
			self.BindInstanceProperty("flexibleWidth", get_flexibleWidth, null);
			self.BindInstanceProperty("preferredWidth", get_preferredWidth, null);
			self.BindInstanceProperty("minWidth", get_minWidth, null);
			self.BindInstanceProperty("pixelsPerUnit", get_pixelsPerUnit, null);
			self.BindInstanceProperty("fontStyle", get_fontStyle, set_fontStyle);
			self.BindInstanceProperty("lineSpacing", get_lineSpacing, set_lineSpacing);
			self.BindInstanceProperty("verticalOverflow", get_verticalOverflow, set_verticalOverflow);
			self.BindInstanceProperty("horizontalOverflow", get_horizontalOverflow, set_horizontalOverflow);
			self.BindInstanceProperty("fontSize", get_fontSize, set_fontSize);
			self.BindInstanceProperty("alignByGeometry", get_alignByGeometry, set_alignByGeometry);
			self.BindInstanceProperty("alignment", get_alignment, set_alignment);
			self.BindInstanceProperty("resizeTextMaxSize", get_resizeTextMaxSize, set_resizeTextMaxSize);
			self.BindInstanceProperty("resizeTextMinSize", get_resizeTextMinSize, set_resizeTextMinSize);
			self.BindInstanceProperty("resizeTextForBestFit", get_resizeTextForBestFit, set_resizeTextForBestFit);
			self.BindInstanceProperty("supportRichText", get_supportRichText, set_supportRichText);
			self.BindInstanceProperty("text", get_text, set_text);
			self.BindInstanceProperty("font", get_font, set_font);
			self.BindInstanceProperty("mainTexture", get_mainTexture, null);
			self.BindInstanceProperty("cachedTextGeneratorForLayout", get_cachedTextGeneratorForLayout, null);
			self.BindInstanceProperty("flexibleHeight", get_flexibleHeight, null);
			self.BindInstanceProperty("layoutPriority", get_layoutPriority, null);
		}

		static private UnityEngine.Vector2 GetTextAnchorPivot(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.TextAnchor>())
			{
				return UnityEngine.UI.Text.GetTextAnchorPivot(parameters[0].ToObject<UnityEngine.TextAnchor>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Text.GetTextAnchorPivot has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Text.GetTextAnchorPivot has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private void CalculateLayoutInputHorizontal(UnityEngine.UI.Text instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Text.CalculateLayoutInputHorizontal has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void CalculateLayoutInputVertical(UnityEngine.UI.Text instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Text.CalculateLayoutInputVertical has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void FontTextureChanged(UnityEngine.UI.Text instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.FontTextureChanged();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Text.FontTextureChanged has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.TextGenerationSettings GetGenerationSettings(UnityEngine.UI.Text instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2>())
			{
				return instance.GetGenerationSettings(parameters[0].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Text.GetGenerationSettings has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Text.GetGenerationSettings has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.TextGenerationSettings);
		}

		static private UnityEngine.TextGenerator get_cachedTextGenerator(UnityEngine.UI.Text instance)
		{
			return instance.cachedTextGenerator;
		}

		static private System.Single get_preferredHeight(UnityEngine.UI.Text instance)
		{
			return instance.preferredHeight;
		}

		static private System.Single get_minHeight(UnityEngine.UI.Text instance)
		{
			return instance.minHeight;
		}

		static private System.Single get_flexibleWidth(UnityEngine.UI.Text instance)
		{
			return instance.flexibleWidth;
		}

		static private System.Single get_preferredWidth(UnityEngine.UI.Text instance)
		{
			return instance.preferredWidth;
		}

		static private System.Single get_minWidth(UnityEngine.UI.Text instance)
		{
			return instance.minWidth;
		}

		static private System.Single get_pixelsPerUnit(UnityEngine.UI.Text instance)
		{
			return instance.pixelsPerUnit;
		}

		static private UnityEngine.FontStyle get_fontStyle(UnityEngine.UI.Text instance)
		{
			return instance.fontStyle;
		}

		static private void set_fontStyle(UnityEngine.UI.Text instance, UnityEngine.FontStyle value)
		{
			instance.fontStyle = value;
		}

		static private System.Single get_lineSpacing(UnityEngine.UI.Text instance)
		{
			return instance.lineSpacing;
		}

		static private void set_lineSpacing(UnityEngine.UI.Text instance, System.Single value)
		{
			instance.lineSpacing = value;
		}

		static private UnityEngine.VerticalWrapMode get_verticalOverflow(UnityEngine.UI.Text instance)
		{
			return instance.verticalOverflow;
		}

		static private void set_verticalOverflow(UnityEngine.UI.Text instance, UnityEngine.VerticalWrapMode value)
		{
			instance.verticalOverflow = value;
		}

		static private UnityEngine.HorizontalWrapMode get_horizontalOverflow(UnityEngine.UI.Text instance)
		{
			return instance.horizontalOverflow;
		}

		static private void set_horizontalOverflow(UnityEngine.UI.Text instance, UnityEngine.HorizontalWrapMode value)
		{
			instance.horizontalOverflow = value;
		}

		static private System.Int32 get_fontSize(UnityEngine.UI.Text instance)
		{
			return instance.fontSize;
		}

		static private void set_fontSize(UnityEngine.UI.Text instance, System.Int32 value)
		{
			instance.fontSize = value;
		}

		static private System.Boolean get_alignByGeometry(UnityEngine.UI.Text instance)
		{
			return instance.alignByGeometry;
		}

		static private void set_alignByGeometry(UnityEngine.UI.Text instance, System.Boolean value)
		{
			instance.alignByGeometry = value;
		}

		static private UnityEngine.TextAnchor get_alignment(UnityEngine.UI.Text instance)
		{
			return instance.alignment;
		}

		static private void set_alignment(UnityEngine.UI.Text instance, UnityEngine.TextAnchor value)
		{
			instance.alignment = value;
		}

		static private System.Int32 get_resizeTextMaxSize(UnityEngine.UI.Text instance)
		{
			return instance.resizeTextMaxSize;
		}

		static private void set_resizeTextMaxSize(UnityEngine.UI.Text instance, System.Int32 value)
		{
			instance.resizeTextMaxSize = value;
		}

		static private System.Int32 get_resizeTextMinSize(UnityEngine.UI.Text instance)
		{
			return instance.resizeTextMinSize;
		}

		static private void set_resizeTextMinSize(UnityEngine.UI.Text instance, System.Int32 value)
		{
			instance.resizeTextMinSize = value;
		}

		static private System.Boolean get_resizeTextForBestFit(UnityEngine.UI.Text instance)
		{
			return instance.resizeTextForBestFit;
		}

		static private void set_resizeTextForBestFit(UnityEngine.UI.Text instance, System.Boolean value)
		{
			instance.resizeTextForBestFit = value;
		}

		static private System.Boolean get_supportRichText(UnityEngine.UI.Text instance)
		{
			return instance.supportRichText;
		}

		static private void set_supportRichText(UnityEngine.UI.Text instance, System.Boolean value)
		{
			instance.supportRichText = value;
		}

		static private System.String get_text(UnityEngine.UI.Text instance)
		{
			return instance.text;
		}

		static private void set_text(UnityEngine.UI.Text instance, System.String value)
		{
			instance.text = value;
		}

		static private UnityEngine.Font get_font(UnityEngine.UI.Text instance)
		{
			return instance.font;
		}

		static private void set_font(UnityEngine.UI.Text instance, UnityEngine.Font value)
		{
			instance.font = value;
		}

		static private UnityEngine.Texture get_mainTexture(UnityEngine.UI.Text instance)
		{
			return instance.mainTexture;
		}

		static private UnityEngine.TextGenerator get_cachedTextGeneratorForLayout(UnityEngine.UI.Text instance)
		{
			return instance.cachedTextGeneratorForLayout;
		}

		static private System.Single get_flexibleHeight(UnityEngine.UI.Text instance)
		{
			return instance.flexibleHeight;
		}

		static private System.Int32 get_layoutPriority(UnityEngine.UI.Text instance)
		{
			return instance.layoutPriority;
		}

	}
}
