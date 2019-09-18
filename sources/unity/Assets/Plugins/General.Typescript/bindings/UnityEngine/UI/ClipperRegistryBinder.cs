using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIClipperRegistry
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.ClipperRegistry> self = space.DeclareClass<UnityEngine.UI.ClipperRegistry>();
			self.BindConstructor();
			self.BindStaticFunction("Register", Register);
			self.BindStaticFunction("Unregister", Unregister);
			self.BindInstanceFunction("Cull", Cull);
			self.BindStaticProperty("instance", get_instance, null);
		}

		static private void Register(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.IClipper>())
			{
				UnityEngine.UI.ClipperRegistry.Register(parameters[0].ToObject<UnityEngine.UI.IClipper>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.ClipperRegistry.Register has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ClipperRegistry.Register has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Unregister(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UI.IClipper>())
			{
				UnityEngine.UI.ClipperRegistry.Unregister(parameters[0].ToObject<UnityEngine.UI.IClipper>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.UI.ClipperRegistry.Unregister has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ClipperRegistry.Unregister has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Cull(UnityEngine.UI.ClipperRegistry instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Cull();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.ClipperRegistry.Cull has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.UI.ClipperRegistry get_instance()
		{
			return UnityEngine.UI.ClipperRegistry.instance;
		}

	}
}
