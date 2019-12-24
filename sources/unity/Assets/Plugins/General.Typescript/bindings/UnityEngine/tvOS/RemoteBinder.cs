#if UNITY_TVOS
using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginetvOSRemote
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.tvOS.Remote> self = space.DeclareClass<UnityEngine.tvOS.Remote>();
			self.BindConstructor(Constructor);
			self.BindStaticProperty("allowExitToHome", get_allowExitToHome, set_allowExitToHome);
			self.BindStaticProperty("allowRemoteRotation", get_allowRemoteRotation, set_allowRemoteRotation);
			self.BindStaticProperty("reportAbsoluteDpadValues", get_reportAbsoluteDpadValues, set_reportAbsoluteDpadValues);
			self.BindStaticProperty("touchesEnabled", get_touchesEnabled, set_touchesEnabled);
		}

		static private UnityEngine.tvOS.Remote Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.tvOS.Remote();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.tvOS.Remote.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.tvOS.Remote);
		}

		static private System.Boolean get_allowExitToHome(Type type, string name)
		{
			return UnityEngine.tvOS.Remote.allowExitToHome;
		}

		static private void set_allowExitToHome(Type type, string name, System.Boolean value)
		{
			UnityEngine.tvOS.Remote.allowExitToHome = value;
		}

		static private System.Boolean get_allowRemoteRotation(Type type, string name)
		{
			return UnityEngine.tvOS.Remote.allowRemoteRotation;
		}

		static private void set_allowRemoteRotation(Type type, string name, System.Boolean value)
		{
			UnityEngine.tvOS.Remote.allowRemoteRotation = value;
		}

		static private System.Boolean get_reportAbsoluteDpadValues(Type type, string name)
		{
			return UnityEngine.tvOS.Remote.reportAbsoluteDpadValues;
		}

		static private void set_reportAbsoluteDpadValues(Type type, string name, System.Boolean value)
		{
			UnityEngine.tvOS.Remote.reportAbsoluteDpadValues = value;
		}

		static private System.Boolean get_touchesEnabled(Type type, string name)
		{
			return UnityEngine.tvOS.Remote.touchesEnabled;
		}

		static private void set_touchesEnabled(Type type, string name, System.Boolean value)
		{
			UnityEngine.tvOS.Remote.touchesEnabled = value;
		}

	}
}
#endif
