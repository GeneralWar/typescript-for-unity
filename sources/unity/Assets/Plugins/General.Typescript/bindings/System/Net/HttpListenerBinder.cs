using UnityEngine;

namespace General.Typescript
{
	public class SystemNetHttpListener
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.HttpListener> self = space.DeclareClass<System.Net.HttpListener>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Abort", Abort);
			self.BindInstanceFunction("Close", Close);
			self.BindInstanceFunction("EndGetContext", EndGetContext);
			self.BindInstanceFunction("GetContext", GetContext);
			self.BindInstanceFunction("Start", Start);
			self.BindInstanceFunction("Stop", Stop);
			self.BindStaticProperty("IsSupported", get_IsSupported, null);
			self.BindInstanceProperty("AuthenticationSchemes", get_AuthenticationSchemes, set_AuthenticationSchemes);
			self.BindInstanceProperty("AuthenticationSchemeSelectorDelegate", get_AuthenticationSchemeSelectorDelegate, set_AuthenticationSchemeSelectorDelegate);
			self.BindInstanceProperty("IgnoreWriteExceptions", get_IgnoreWriteExceptions, set_IgnoreWriteExceptions);
			self.BindInstanceProperty("IsListening", get_IsListening, null);
			self.BindInstanceProperty("Prefixes", get_Prefixes, null);
			self.BindInstanceProperty("TimeoutManager", get_TimeoutManager, null);
			self.BindInstanceProperty("ExtendedProtectionPolicy", get_ExtendedProtectionPolicy, set_ExtendedProtectionPolicy);
			self.BindInstanceProperty("DefaultServiceNames", get_DefaultServiceNames, null);
			self.BindInstanceProperty("Realm", get_Realm, set_Realm);
			self.BindInstanceProperty("UnsafeConnectionNtlmAuthentication", get_UnsafeConnectionNtlmAuthentication, set_UnsafeConnectionNtlmAuthentication);
		}

		static private System.Net.HttpListener Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.HttpListener();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.HttpListener.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.HttpListener);
		}

		static private void Abort(System.Net.HttpListener instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Abort();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.HttpListener.Abort has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Close(System.Net.HttpListener instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Close();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.HttpListener.Close has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Net.HttpListenerContext EndGetContext(System.Net.HttpListener instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.IAsyncResult>())
			{
				return instance.EndGetContext(parameters[0].ToObject<System.IAsyncResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.HttpListener.EndGetContext has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.HttpListener.EndGetContext has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Net.HttpListenerContext GetContext(System.Net.HttpListener instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetContext();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.HttpListener.GetContext has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private void Start(System.Net.HttpListener instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Start();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.HttpListener.Start has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Stop(System.Net.HttpListener instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Stop();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.HttpListener.Stop has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean get_IsSupported()
		{
			return System.Net.HttpListener.IsSupported;
		}

		static private System.Net.AuthenticationSchemes get_AuthenticationSchemes(System.Net.HttpListener instance)
		{
			return instance.AuthenticationSchemes;
		}

		static private void set_AuthenticationSchemes(System.Net.HttpListener instance, System.Net.AuthenticationSchemes value)
		{
			instance.AuthenticationSchemes = value;
		}

		static private System.Net.AuthenticationSchemeSelector get_AuthenticationSchemeSelectorDelegate(System.Net.HttpListener instance)
		{
			return instance.AuthenticationSchemeSelectorDelegate;
		}

		static private void set_AuthenticationSchemeSelectorDelegate(System.Net.HttpListener instance, System.Net.AuthenticationSchemeSelector value)
		{
			instance.AuthenticationSchemeSelectorDelegate = value;
		}

		static private System.Boolean get_IgnoreWriteExceptions(System.Net.HttpListener instance)
		{
			return instance.IgnoreWriteExceptions;
		}

		static private void set_IgnoreWriteExceptions(System.Net.HttpListener instance, System.Boolean value)
		{
			instance.IgnoreWriteExceptions = value;
		}

		static private System.Boolean get_IsListening(System.Net.HttpListener instance)
		{
			return instance.IsListening;
		}

		static private System.Net.HttpListenerPrefixCollection get_Prefixes(System.Net.HttpListener instance)
		{
			return instance.Prefixes;
		}

		static private System.Net.HttpListenerTimeoutManager get_TimeoutManager(System.Net.HttpListener instance)
		{
			return instance.TimeoutManager;
		}

		static private System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy get_ExtendedProtectionPolicy(System.Net.HttpListener instance)
		{
			return instance.ExtendedProtectionPolicy;
		}

		static private void set_ExtendedProtectionPolicy(System.Net.HttpListener instance, System.Security.Authentication.ExtendedProtection.ExtendedProtectionPolicy value)
		{
			instance.ExtendedProtectionPolicy = value;
		}

		static private System.Security.Authentication.ExtendedProtection.ServiceNameCollection get_DefaultServiceNames(System.Net.HttpListener instance)
		{
			return instance.DefaultServiceNames;
		}

		static private System.String get_Realm(System.Net.HttpListener instance)
		{
			return instance.Realm;
		}

		static private void set_Realm(System.Net.HttpListener instance, System.String value)
		{
			instance.Realm = value;
		}

		static private System.Boolean get_UnsafeConnectionNtlmAuthentication(System.Net.HttpListener instance)
		{
			return instance.UnsafeConnectionNtlmAuthentication;
		}

		static private void set_UnsafeConnectionNtlmAuthentication(System.Net.HttpListener instance, System.Boolean value)
		{
			instance.UnsafeConnectionNtlmAuthentication = value;
		}

	}
}
