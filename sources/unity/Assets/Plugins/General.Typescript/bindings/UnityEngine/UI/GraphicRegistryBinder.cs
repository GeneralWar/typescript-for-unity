using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIGraphicRegistry
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.GraphicRegistry> self = space.DeclareClass<UnityEngine.UI.GraphicRegistry>();
			self.BindConstructor();
			self.BindStaticFunction("RegisterGraphicForCanvas", RegisterGraphicForCanvas);
			self.BindStaticFunction("UnregisterGraphicForCanvas", UnregisterGraphicForCanvas);
			self.BindStaticProperty("instance", get_instance, null);
		}

		static private void RegisterGraphicForCanvas(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Canvas, UnityEngine.UI.Graphic>())
			{
				UnityEngine.UI.GraphicRegistry.RegisterGraphicForCanvas(parameters[0].ToObject<UnityEngine.Canvas>(), parameters[1].ToObject<UnityEngine.UI.Graphic>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.GraphicRegistry.RegisterGraphicForCanvas has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.GraphicRegistry.RegisterGraphicForCanvas has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void UnregisterGraphicForCanvas(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Canvas, UnityEngine.UI.Graphic>())
			{
				UnityEngine.UI.GraphicRegistry.UnregisterGraphicForCanvas(parameters[0].ToObject<UnityEngine.Canvas>(), parameters[1].ToObject<UnityEngine.UI.Graphic>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.GraphicRegistry.UnregisterGraphicForCanvas has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.GraphicRegistry.UnregisterGraphicForCanvas has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.UI.GraphicRegistry get_instance()
		{
			return UnityEngine.UI.GraphicRegistry.instance;
		}

	}
}
