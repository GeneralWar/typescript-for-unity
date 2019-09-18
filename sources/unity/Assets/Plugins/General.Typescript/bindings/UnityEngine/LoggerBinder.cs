using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLogger
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Logger> self = space.DeclareClass<UnityEngine.Logger>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("IsLogTypeAllowed", IsLogTypeAllowed);
			self.BindInstanceFunction("Log", Log);
			self.BindInstanceFunction("LogError", LogError);
			self.BindInstanceFunction("LogException", LogException);
			self.BindInstanceFunction("LogFormat", LogFormat);
			self.BindInstanceFunction("LogWarning", LogWarning);
			self.BindInstanceProperty("logHandler", get_logHandler, set_logHandler);
			self.BindInstanceProperty("logEnabled", get_logEnabled, set_logEnabled);
			self.BindInstanceProperty("filterLogType", get_filterLogType, set_filterLogType);
		}

		static private UnityEngine.Logger Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ILogHandler>())
			{
				return new UnityEngine.Logger(parameters[0].ToObject<UnityEngine.ILogHandler>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Logger.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Logger.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Logger);
		}

		static private System.Boolean IsLogTypeAllowed(UnityEngine.Logger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.LogType>())
			{
				return instance.IsLogTypeAllowed(parameters[0].ToObject<UnityEngine.LogType>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Logger.IsLogTypeAllowed has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Logger.IsLogTypeAllowed has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void Log(UnityEngine.Logger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				instance.Log(parameters[0].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.LogType, System.Object>())
			{
				instance.Log(parameters[0].ToObject<UnityEngine.LogType>(), parameters[1].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Object>())
			{
				instance.Log(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.LogType, System.Object, UnityEngine.Object>())
			{
				instance.Log(parameters[0].ToObject<UnityEngine.LogType>(), parameters[1].ToObject<System.Object>(), parameters[2].ToObject<UnityEngine.Object>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.LogType, System.String, System.Object>())
			{
				instance.Log(parameters[0].ToObject<UnityEngine.LogType>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Object, UnityEngine.Object>())
			{
				instance.Log(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>(), parameters[2].ToObject<UnityEngine.Object>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.LogType, System.String, System.Object, UnityEngine.Object>())
			{
				instance.Log(parameters[0].ToObject<UnityEngine.LogType>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Object>(), parameters[3].ToObject<UnityEngine.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Logger.Log has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Logger.Log has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void LogError(UnityEngine.Logger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Object>())
			{
				instance.LogError(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Object, UnityEngine.Object>())
			{
				instance.LogError(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>(), parameters[2].ToObject<UnityEngine.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Logger.LogError has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Logger.LogError has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void LogException(UnityEngine.Logger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Exception>())
			{
				instance.LogException(parameters[0].ToObject<System.Exception>());
				return;
			}
			if (parameters.CheckTypes<System.Exception, UnityEngine.Object>())
			{
				instance.LogException(parameters[0].ToObject<System.Exception>(), parameters[1].ToObject<UnityEngine.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Logger.LogException has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Logger.LogException has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void LogFormat(UnityEngine.Logger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.LogType, System.String, System.Object[]>())
			{
				instance.LogFormat(parameters[0].ToObject<UnityEngine.LogType>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Object[]>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.LogType, UnityEngine.Object, System.String, System.Object[]>())
			{
				instance.LogFormat(parameters[0].ToObject<UnityEngine.LogType>(), parameters[1].ToObject<UnityEngine.Object>(), parameters[2].ToObject<System.String>(), parameters[3].ToObject<System.Object[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Logger.LogFormat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Logger.LogFormat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void LogWarning(UnityEngine.Logger instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Object>())
			{
				instance.LogWarning(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Object, UnityEngine.Object>())
			{
				instance.LogWarning(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>(), parameters[2].ToObject<UnityEngine.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Logger.LogWarning has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Logger.LogWarning has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.ILogHandler get_logHandler(UnityEngine.Logger instance)
		{
			return instance.logHandler;
		}

		static private void set_logHandler(UnityEngine.Logger instance, UnityEngine.ILogHandler value)
		{
			instance.logHandler = value;
		}

		static private System.Boolean get_logEnabled(UnityEngine.Logger instance)
		{
			return instance.logEnabled;
		}

		static private void set_logEnabled(UnityEngine.Logger instance, System.Boolean value)
		{
			instance.logEnabled = value;
		}

		static private UnityEngine.LogType get_filterLogType(UnityEngine.Logger instance)
		{
			return instance.filterLogType;
		}

		static private void set_filterLogType(UnityEngine.Logger instance, UnityEngine.LogType value)
		{
			instance.filterLogType = value;
		}

	}
}
