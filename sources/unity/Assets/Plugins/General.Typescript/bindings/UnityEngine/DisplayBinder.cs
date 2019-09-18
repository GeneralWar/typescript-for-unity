using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineDisplay
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Display> self = space.DeclareClass<UnityEngine.Display>();
			self.BindConstructor();
			self.BindStaticFunction("RelativeMouseAt", RelativeMouseAt);
			self.BindInstanceFunction("Activate", Activate);
			self.BindInstanceFunction("SetParams", SetParams);
			self.BindInstanceFunction("SetRenderingResolution", SetRenderingResolution);
			self.BindStaticProperty("main", get_main, null);
			self.BindInstanceProperty("renderingWidth", get_renderingWidth, null);
			self.BindInstanceProperty("renderingHeight", get_renderingHeight, null);
			self.BindInstanceProperty("systemWidth", get_systemWidth, null);
			self.BindInstanceProperty("systemHeight", get_systemHeight, null);
			self.BindInstanceProperty("colorBuffer", get_colorBuffer, null);
			self.BindInstanceProperty("depthBuffer", get_depthBuffer, null);
			self.BindInstanceProperty("active", get_active, null);
		}

		static private UnityEngine.Vector3 RelativeMouseAt(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return UnityEngine.Display.RelativeMouseAt(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Display.RelativeMouseAt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Display.RelativeMouseAt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector3);
		}

		static private void Activate(UnityEngine.Display instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Activate();
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32>())
			{
				instance.Activate(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Display.Activate has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetParams(UnityEngine.Display instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32, System.Int32>())
			{
				instance.SetParams(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Display.SetParams has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Display.SetParams has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetRenderingResolution(UnityEngine.Display instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				instance.SetRenderingResolution(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Display.SetRenderingResolution has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Display.SetRenderingResolution has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Display get_main()
		{
			return UnityEngine.Display.main;
		}

		static private System.Int32 get_renderingWidth(UnityEngine.Display instance)
		{
			return instance.renderingWidth;
		}

		static private System.Int32 get_renderingHeight(UnityEngine.Display instance)
		{
			return instance.renderingHeight;
		}

		static private System.Int32 get_systemWidth(UnityEngine.Display instance)
		{
			return instance.systemWidth;
		}

		static private System.Int32 get_systemHeight(UnityEngine.Display instance)
		{
			return instance.systemHeight;
		}

		static private UnityEngine.RenderBuffer get_colorBuffer(UnityEngine.Display instance)
		{
			return instance.colorBuffer;
		}

		static private UnityEngine.RenderBuffer get_depthBuffer(UnityEngine.Display instance)
		{
			return instance.depthBuffer;
		}

		static private System.Boolean get_active(UnityEngine.Display instance)
		{
			return instance.active;
		}

	}
}
