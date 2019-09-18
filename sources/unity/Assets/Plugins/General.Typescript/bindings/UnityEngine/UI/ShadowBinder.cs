using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIShadow
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.Shadow> self = space.DeclareClass<UnityEngine.UI.Shadow, UnityEngine.UI.BaseMeshEffect>();
			self.BindConstructor();
			self.BindInstanceFunction("ModifyMesh", ModifyMesh);
			self.BindInstanceProperty("effectColor", get_effectColor, set_effectColor);
			self.BindInstanceProperty("effectDistance", get_effectDistance, set_effectDistance);
			self.BindInstanceProperty("useGraphicAlpha", get_useGraphicAlpha, set_useGraphicAlpha);
		}

		static private void ModifyMesh(UnityEngine.UI.Shadow instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.VertexHelper>())
			{
				instance.ModifyMesh(parameters[0].ToObject<UnityEngine.UI.VertexHelper>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.Shadow.ModifyMesh has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.Shadow.ModifyMesh has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Color get_effectColor(UnityEngine.UI.Shadow instance)
		{
			return instance.effectColor;
		}

		static private void set_effectColor(UnityEngine.UI.Shadow instance, UnityEngine.Color value)
		{
			instance.effectColor = value;
		}

		static private UnityEngine.Vector2 get_effectDistance(UnityEngine.UI.Shadow instance)
		{
			return instance.effectDistance;
		}

		static private void set_effectDistance(UnityEngine.UI.Shadow instance, UnityEngine.Vector2 value)
		{
			instance.effectDistance = value;
		}

		static private System.Boolean get_useGraphicAlpha(UnityEngine.UI.Shadow instance)
		{
			return instance.useGraphicAlpha;
		}

		static private void set_useGraphicAlpha(UnityEngine.UI.Shadow instance, System.Boolean value)
		{
			instance.useGraphicAlpha = value;
		}

	}
}
