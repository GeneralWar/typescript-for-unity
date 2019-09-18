using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUICanvasUpdateRegistry
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.CanvasUpdateRegistry> self = space.DeclareClass<UnityEngine.UI.CanvasUpdateRegistry>();
			self.BindConstructor();
			self.BindStaticFunction("IsRebuildingGraphics", IsRebuildingGraphics);
			self.BindStaticFunction("IsRebuildingLayout", IsRebuildingLayout);
			self.BindStaticFunction("RegisterCanvasElementForGraphicRebuild", RegisterCanvasElementForGraphicRebuild);
			self.BindStaticFunction("RegisterCanvasElementForLayoutRebuild", RegisterCanvasElementForLayoutRebuild);
			self.BindStaticFunction("TryRegisterCanvasElementForGraphicRebuild", TryRegisterCanvasElementForGraphicRebuild);
			self.BindStaticFunction("TryRegisterCanvasElementForLayoutRebuild", TryRegisterCanvasElementForLayoutRebuild);
			self.BindStaticFunction("UnRegisterCanvasElementForRebuild", UnRegisterCanvasElementForRebuild);
			self.BindStaticProperty("instance", get_instance, null);
		}

		static private System.Boolean IsRebuildingGraphics(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.UI.CanvasUpdateRegistry.IsRebuildingGraphics();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.CanvasUpdateRegistry.IsRebuildingGraphics has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.Boolean IsRebuildingLayout(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.UI.CanvasUpdateRegistry.IsRebuildingLayout();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.CanvasUpdateRegistry.IsRebuildingLayout has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private void RegisterCanvasElementForGraphicRebuild(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.ICanvasElement>())
			{
				UnityEngine.UI.CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild(parameters[0].ToObject<UnityEngine.UI.ICanvasElement>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.CanvasUpdateRegistry.RegisterCanvasElementForGraphicRebuild has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void RegisterCanvasElementForLayoutRebuild(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.ICanvasElement>())
			{
				UnityEngine.UI.CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild(parameters[0].ToObject<UnityEngine.UI.ICanvasElement>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.CanvasUpdateRegistry.RegisterCanvasElementForLayoutRebuild has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean TryRegisterCanvasElementForGraphicRebuild(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.ICanvasElement>())
			{
				return UnityEngine.UI.CanvasUpdateRegistry.TryRegisterCanvasElementForGraphicRebuild(parameters[0].ToObject<UnityEngine.UI.ICanvasElement>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.CanvasUpdateRegistry.TryRegisterCanvasElementForGraphicRebuild has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.CanvasUpdateRegistry.TryRegisterCanvasElementForGraphicRebuild has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean TryRegisterCanvasElementForLayoutRebuild(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.ICanvasElement>())
			{
				return UnityEngine.UI.CanvasUpdateRegistry.TryRegisterCanvasElementForLayoutRebuild(parameters[0].ToObject<UnityEngine.UI.ICanvasElement>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.CanvasUpdateRegistry.TryRegisterCanvasElementForLayoutRebuild has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.CanvasUpdateRegistry.TryRegisterCanvasElementForLayoutRebuild has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void UnRegisterCanvasElementForRebuild(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.ICanvasElement>())
			{
				UnityEngine.UI.CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild(parameters[0].ToObject<UnityEngine.UI.ICanvasElement>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.CanvasUpdateRegistry.UnRegisterCanvasElementForRebuild has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.UI.CanvasUpdateRegistry get_instance()
		{
			return UnityEngine.UI.CanvasUpdateRegistry.instance;
		}

	}
}
