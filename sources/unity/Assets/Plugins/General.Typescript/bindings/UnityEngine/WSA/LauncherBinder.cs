#if UNITY_WSA
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWSALauncher
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.WSA.Launcher> self = space.DeclareClass<UnityEngine.WSA.Launcher>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("LaunchFile", LaunchFile);
			self.BindStaticFunction("LaunchFileWithPicker", LaunchFileWithPicker);
			self.BindStaticFunction("LaunchUri", LaunchUri);
		}

		static private UnityEngine.WSA.Launcher Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.WSA.Launcher();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Launcher.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.WSA.Launcher);
		}

		static private void LaunchFile(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.WSA.Folder, System.String, System.Boolean>())
			{
				UnityEngine.WSA.Launcher.LaunchFile(parameters[0].ToObject<UnityEngine.WSA.Folder>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WSA.Launcher.LaunchFile has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Launcher.LaunchFile has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void LaunchFileWithPicker(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				UnityEngine.WSA.Launcher.LaunchFileWithPicker(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WSA.Launcher.LaunchFileWithPicker has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Launcher.LaunchFileWithPicker has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void LaunchUri(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Boolean>())
			{
				UnityEngine.WSA.Launcher.LaunchUri(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WSA.Launcher.LaunchUri has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Launcher.LaunchUri has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

	}
}
#endif
