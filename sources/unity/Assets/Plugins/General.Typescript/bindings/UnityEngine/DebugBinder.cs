using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineDebug
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Debug> self = space.DeclareClass<UnityEngine.Debug>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("Assert", Assert);
			self.BindStaticFunction("AssertFormat", AssertFormat);
			self.BindStaticFunction("Break", Break);
			self.BindStaticFunction("ClearDeveloperConsole", ClearDeveloperConsole);
			self.BindStaticFunction("DebugBreak", DebugBreak);
			self.BindStaticFunction("DrawLine", DrawLine);
			self.BindStaticFunction("DrawRay", DrawRay);
			self.BindStaticFunction("Log", Log);
			self.BindStaticFunction("LogAssertion", LogAssertion);
			self.BindStaticFunction("LogAssertionFormat", LogAssertionFormat);
			self.BindStaticFunction("LogError", LogError);
			self.BindStaticFunction("LogErrorFormat", LogErrorFormat);
			self.BindStaticFunction("LogException", LogException);
			self.BindStaticFunction("LogFormat", LogFormat);
			self.BindStaticFunction("LogWarning", LogWarning);
			self.BindStaticFunction("LogWarningFormat", LogWarningFormat);
			self.BindStaticProperty("unityLogger", get_unityLogger, null);
			self.BindStaticProperty("developerConsoleVisible", get_developerConsoleVisible, set_developerConsoleVisible);
			self.BindStaticProperty("isDebugBuild", get_isDebugBuild, null);
		}

		static private UnityEngine.Debug Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Debug();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Debug.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Debug);
		}

		static private void Assert(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean>())
			{
				UnityEngine.Debug.Assert(parameters[0].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<System.Boolean, UnityEngine.Object>())
			{
				UnityEngine.Debug.Assert(parameters[0].ToObject<System.Boolean>(), parameters[1].ToObject<UnityEngine.Object>());
				return;
			}
			if (parameters.CheckTypes<System.Boolean, System.Object>())
			{
				UnityEngine.Debug.Assert(parameters[0].ToObject<System.Boolean>(), parameters[1].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<System.Boolean, System.String>())
			{
				UnityEngine.Debug.Assert(parameters[0].ToObject<System.Boolean>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.Boolean, System.Object, UnityEngine.Object>())
			{
				UnityEngine.Debug.Assert(parameters[0].ToObject<System.Boolean>(), parameters[1].ToObject<System.Object>(), parameters[2].ToObject<UnityEngine.Object>());
				return;
			}
			if (parameters.CheckTypes<System.Boolean, System.String, UnityEngine.Object>())
			{
				UnityEngine.Debug.Assert(parameters[0].ToObject<System.Boolean>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<UnityEngine.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Debug.Assert has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Debug.Assert has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void AssertFormat(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean, System.String, System.Object[]>())
			{
				UnityEngine.Debug.AssertFormat(parameters[0].ToObject<System.Boolean>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Object[]>());
				return;
			}
			if (parameters.CheckTypes<System.Boolean, UnityEngine.Object, System.String, System.Object[]>())
			{
				UnityEngine.Debug.AssertFormat(parameters[0].ToObject<System.Boolean>(), parameters[1].ToObject<UnityEngine.Object>(), parameters[2].ToObject<System.String>(), parameters[3].ToObject<System.Object[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Debug.AssertFormat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Debug.AssertFormat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Break(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.Break();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Debug.Break has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ClearDeveloperConsole(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.ClearDeveloperConsole();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Debug.ClearDeveloperConsole has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void DebugBreak(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.DebugBreak();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Debug.DebugBreak has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void DrawLine(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				UnityEngine.Debug.DrawLine(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Color>())
			{
				UnityEngine.Debug.DrawLine(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Color>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Color, System.Single>())
			{
				UnityEngine.Debug.DrawLine(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Color>(), parameters[3].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Color, System.Single, System.Boolean>())
			{
				UnityEngine.Debug.DrawLine(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Color>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Debug.DrawLine has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Debug.DrawLine has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DrawRay(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				UnityEngine.Debug.DrawRay(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Color>())
			{
				UnityEngine.Debug.DrawRay(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Color>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Color, System.Single>())
			{
				UnityEngine.Debug.DrawRay(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Color>(), parameters[3].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3, UnityEngine.Color, System.Single, System.Boolean>())
			{
				UnityEngine.Debug.DrawRay(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Color>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Debug.DrawRay has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Debug.DrawRay has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Log(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				UnityEngine.Debug.Log(parameters[0].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<System.Object, UnityEngine.Object>())
			{
				UnityEngine.Debug.Log(parameters[0].ToObject<System.Object>(), parameters[1].ToObject<UnityEngine.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Debug.Log has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Debug.Log has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void LogAssertion(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				UnityEngine.Debug.LogAssertion(parameters[0].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<System.Object, UnityEngine.Object>())
			{
				UnityEngine.Debug.LogAssertion(parameters[0].ToObject<System.Object>(), parameters[1].ToObject<UnityEngine.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Debug.LogAssertion has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Debug.LogAssertion has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void LogAssertionFormat(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Object[]>())
			{
				UnityEngine.Debug.LogAssertionFormat(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object[]>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Object, System.String, System.Object[]>())
			{
				UnityEngine.Debug.LogAssertionFormat(parameters[0].ToObject<UnityEngine.Object>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Object[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Debug.LogAssertionFormat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Debug.LogAssertionFormat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void LogError(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				UnityEngine.Debug.LogError(parameters[0].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<System.Object, UnityEngine.Object>())
			{
				UnityEngine.Debug.LogError(parameters[0].ToObject<System.Object>(), parameters[1].ToObject<UnityEngine.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Debug.LogError has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Debug.LogError has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void LogErrorFormat(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Object[]>())
			{
				UnityEngine.Debug.LogErrorFormat(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object[]>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Object, System.String, System.Object[]>())
			{
				UnityEngine.Debug.LogErrorFormat(parameters[0].ToObject<UnityEngine.Object>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Object[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Debug.LogErrorFormat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Debug.LogErrorFormat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void LogException(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Exception>())
			{
				UnityEngine.Debug.LogException(parameters[0].ToObject<System.Exception>());
				return;
			}
			if (parameters.CheckTypes<System.Exception, UnityEngine.Object>())
			{
				UnityEngine.Debug.LogException(parameters[0].ToObject<System.Exception>(), parameters[1].ToObject<UnityEngine.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Debug.LogException has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Debug.LogException has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void LogFormat(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Object[]>())
			{
				UnityEngine.Debug.LogFormat(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object[]>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Object, System.String, System.Object[]>())
			{
				UnityEngine.Debug.LogFormat(parameters[0].ToObject<UnityEngine.Object>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Object[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Debug.LogFormat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Debug.LogFormat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void LogWarning(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				UnityEngine.Debug.LogWarning(parameters[0].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<System.Object, UnityEngine.Object>())
			{
				UnityEngine.Debug.LogWarning(parameters[0].ToObject<System.Object>(), parameters[1].ToObject<UnityEngine.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Debug.LogWarning has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Debug.LogWarning has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void LogWarningFormat(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Object[]>())
			{
				UnityEngine.Debug.LogWarningFormat(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object[]>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Object, System.String, System.Object[]>())
			{
				UnityEngine.Debug.LogWarningFormat(parameters[0].ToObject<UnityEngine.Object>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Object[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Debug.LogWarningFormat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Debug.LogWarningFormat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.ILogger get_unityLogger()
		{
			return UnityEngine.Debug.unityLogger;
		}

		static private System.Boolean get_developerConsoleVisible()
		{
			return UnityEngine.Debug.developerConsoleVisible;
		}

		static private void set_developerConsoleVisible(System.Boolean value)
		{
			UnityEngine.Debug.developerConsoleVisible = value;
		}

		static private System.Boolean get_isDebugBuild()
		{
			return UnityEngine.Debug.isDebugBuild;
		}

	}
}
