#if UNITY_WSA
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWSAApplication
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.WSA.Application> self = space.DeclareClass<UnityEngine.WSA.Application>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("RunningOnAppThread", RunningOnAppThread);
			self.BindStaticFunction("RunningOnUIThread", RunningOnUIThread);
			self.BindStaticProperty("arguments", get_arguments, null);
			self.BindStaticProperty("advertisingIdentifier", get_advertisingIdentifier, null);
		}

		static private UnityEngine.WSA.Application Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.WSA.Application();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Application.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.WSA.Application);
		}

		static private System.Boolean RunningOnAppThread(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.WSA.Application.RunningOnAppThread();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Application.RunningOnAppThread has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.Boolean RunningOnUIThread(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.WSA.Application.RunningOnUIThread();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Application.RunningOnUIThread has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.String get_arguments()
		{
			return UnityEngine.WSA.Application.arguments;
		}

		static private System.String get_advertisingIdentifier()
		{
			return UnityEngine.WSA.Application.advertisingIdentifier;
		}

	}
}
#endif
