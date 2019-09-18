using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineApplication
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Application> self = space.DeclareClass<UnityEngine.Application>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("CanStreamedLevelBeLoaded", CanStreamedLevelBeLoaded);
			self.BindStaticFunction("GetBuildTags", GetBuildTags);
			self.BindStaticFunction("GetStackTraceLogType", GetStackTraceLogType);
			self.BindStaticFunction("HasProLicense", HasProLicense);
			self.BindStaticFunction("HasUserAuthorization", HasUserAuthorization);
			self.BindStaticFunction("IsPlaying", IsPlaying);
			self.BindStaticFunction("OpenURL", OpenURL);
			self.BindStaticFunction("Quit", Quit);
			self.BindStaticFunction("RequestUserAuthorization", RequestUserAuthorization);
			self.BindStaticFunction("SetBuildTags", SetBuildTags);
			self.BindStaticFunction("SetStackTraceLogType", SetStackTraceLogType);
			self.BindStaticFunction("Unload", Unload);
			self.BindStaticProperty("isPlaying", get_isPlaying, null);
			self.BindStaticProperty("genuine", get_genuine, null);
			self.BindStaticProperty("internetReachability", get_internetReachability, null);
			self.BindStaticProperty("backgroundLoadingPriority", get_backgroundLoadingPriority, set_backgroundLoadingPriority);
			self.BindStaticProperty("consoleLogPath", get_consoleLogPath, null);
			self.BindStaticProperty("systemLanguage", get_systemLanguage, null);
			self.BindStaticProperty("targetFrameRate", get_targetFrameRate, set_targetFrameRate);
			self.BindStaticProperty("cloudProjectId", get_cloudProjectId, null);
			self.BindStaticProperty("companyName", get_companyName, null);
			self.BindStaticProperty("productName", get_productName, null);
			self.BindStaticProperty("sandboxType", get_sandboxType, null);
			self.BindStaticProperty("installMode", get_installMode, null);
			self.BindStaticProperty("identifier", get_identifier, null);
			self.BindStaticProperty("installerName", get_installerName, null);
			self.BindStaticProperty("version", get_version, null);
			self.BindStaticProperty("unityVersion", get_unityVersion, null);
			self.BindStaticProperty("absoluteURL", get_absoluteURL, null);
			self.BindStaticProperty("temporaryCachePath", get_temporaryCachePath, null);
			self.BindStaticProperty("persistentDataPath", get_persistentDataPath, null);
			self.BindStaticProperty("streamingAssetsPath", get_streamingAssetsPath, null);
			self.BindStaticProperty("dataPath", get_dataPath, null);
			self.BindStaticProperty("isBatchMode", get_isBatchMode, null);
			self.BindStaticProperty("runInBackground", get_runInBackground, set_runInBackground);
			self.BindStaticProperty("isConsolePlatform", get_isConsolePlatform, null);
			self.BindStaticProperty("isMobilePlatform", get_isMobilePlatform, null);
			self.BindStaticProperty("buildGUID", get_buildGUID, null);
			self.BindStaticProperty("platform", get_platform, null);
			self.BindStaticProperty("isFocused", get_isFocused, null);
			self.BindStaticProperty("genuineCheckAvailable", get_genuineCheckAvailable, null);
			self.BindStaticProperty("isEditor", get_isEditor, null);
		}

		static private UnityEngine.Application Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Application();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Application.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Application);
		}

		static private System.Boolean CanStreamedLevelBeLoaded(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Application.CanStreamedLevelBeLoaded(parameters[0].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Application.CanStreamedLevelBeLoaded(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Application.CanStreamedLevelBeLoaded has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Application.CanStreamedLevelBeLoaded has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.String[] GetBuildTags(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.Application.GetBuildTags();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Application.GetBuildTags has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.StackTraceLogType GetStackTraceLogType(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.LogType>())
			{
				return UnityEngine.Application.GetStackTraceLogType(parameters[0].ToObject<UnityEngine.LogType>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Application.GetStackTraceLogType has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Application.GetStackTraceLogType has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.StackTraceLogType);
		}

		static private System.Boolean HasProLicense(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.Application.HasProLicense();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Application.HasProLicense has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.Boolean HasUserAuthorization(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UserAuthorization>())
			{
				return UnityEngine.Application.HasUserAuthorization(parameters[0].ToObject<UnityEngine.UserAuthorization>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Application.HasUserAuthorization has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Application.HasUserAuthorization has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean IsPlaying(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Object>())
			{
				return UnityEngine.Application.IsPlaying(parameters[0].ToObject<UnityEngine.Object>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Application.IsPlaying has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Application.IsPlaying has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void OpenURL(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				UnityEngine.Application.OpenURL(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Application.OpenURL has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Application.OpenURL has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Quit(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.Application.Quit();
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				UnityEngine.Application.Quit(parameters[0].ToObject<System.Int32>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Application.Quit has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.AsyncOperation RequestUserAuthorization(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.UserAuthorization>())
			{
				return UnityEngine.Application.RequestUserAuthorization(parameters[0].ToObject<UnityEngine.UserAuthorization>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Application.RequestUserAuthorization has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Application.RequestUserAuthorization has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void SetBuildTags(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String[]>())
			{
				UnityEngine.Application.SetBuildTags(parameters[0].ToObject<System.String[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Application.SetBuildTags has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Application.SetBuildTags has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetStackTraceLogType(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.LogType, UnityEngine.StackTraceLogType>())
			{
				UnityEngine.Application.SetStackTraceLogType(parameters[0].ToObject<UnityEngine.LogType>(), parameters[1].ToObject<UnityEngine.StackTraceLogType>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Application.SetStackTraceLogType has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Application.SetStackTraceLogType has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Unload(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.Application.Unload();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Application.Unload has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean get_isPlaying()
		{
			return UnityEngine.Application.isPlaying;
		}

		static private System.Boolean get_genuine()
		{
			return UnityEngine.Application.genuine;
		}

		static private UnityEngine.NetworkReachability get_internetReachability()
		{
			return UnityEngine.Application.internetReachability;
		}

		static private UnityEngine.ThreadPriority get_backgroundLoadingPriority()
		{
			return UnityEngine.Application.backgroundLoadingPriority;
		}

		static private void set_backgroundLoadingPriority(UnityEngine.ThreadPriority value)
		{
			UnityEngine.Application.backgroundLoadingPriority = value;
		}

		static private System.String get_consoleLogPath()
		{
			return UnityEngine.Application.consoleLogPath;
		}

		static private UnityEngine.SystemLanguage get_systemLanguage()
		{
			return UnityEngine.Application.systemLanguage;
		}

		static private System.Int32 get_targetFrameRate()
		{
			return UnityEngine.Application.targetFrameRate;
		}

		static private void set_targetFrameRate(System.Int32 value)
		{
			UnityEngine.Application.targetFrameRate = value;
		}

		static private System.String get_cloudProjectId()
		{
			return UnityEngine.Application.cloudProjectId;
		}

		static private System.String get_companyName()
		{
			return UnityEngine.Application.companyName;
		}

		static private System.String get_productName()
		{
			return UnityEngine.Application.productName;
		}

		static private UnityEngine.ApplicationSandboxType get_sandboxType()
		{
			return UnityEngine.Application.sandboxType;
		}

		static private UnityEngine.ApplicationInstallMode get_installMode()
		{
			return UnityEngine.Application.installMode;
		}

		static private System.String get_identifier()
		{
			return UnityEngine.Application.identifier;
		}

		static private System.String get_installerName()
		{
			return UnityEngine.Application.installerName;
		}

		static private System.String get_version()
		{
			return UnityEngine.Application.version;
		}

		static private System.String get_unityVersion()
		{
			return UnityEngine.Application.unityVersion;
		}

		static private System.String get_absoluteURL()
		{
			return UnityEngine.Application.absoluteURL;
		}

		static private System.String get_temporaryCachePath()
		{
			return UnityEngine.Application.temporaryCachePath;
		}

		static private System.String get_persistentDataPath()
		{
			return UnityEngine.Application.persistentDataPath;
		}

		static private System.String get_streamingAssetsPath()
		{
			return UnityEngine.Application.streamingAssetsPath;
		}

		static private System.String get_dataPath()
		{
			return UnityEngine.Application.dataPath;
		}

		static private System.Boolean get_isBatchMode()
		{
			return UnityEngine.Application.isBatchMode;
		}

		static private System.Boolean get_runInBackground()
		{
			return UnityEngine.Application.runInBackground;
		}

		static private void set_runInBackground(System.Boolean value)
		{
			UnityEngine.Application.runInBackground = value;
		}

		static private System.Boolean get_isConsolePlatform()
		{
			return UnityEngine.Application.isConsolePlatform;
		}

		static private System.Boolean get_isMobilePlatform()
		{
			return UnityEngine.Application.isMobilePlatform;
		}

		static private System.String get_buildGUID()
		{
			return UnityEngine.Application.buildGUID;
		}

		static private UnityEngine.RuntimePlatform get_platform()
		{
			return UnityEngine.Application.platform;
		}

		static private System.Boolean get_isFocused()
		{
			return UnityEngine.Application.isFocused;
		}

		static private System.Boolean get_genuineCheckAvailable()
		{
			return UnityEngine.Application.genuineCheckAvailable;
		}

		static private System.Boolean get_isEditor()
		{
			return UnityEngine.Application.isEditor;
		}

	}
}
