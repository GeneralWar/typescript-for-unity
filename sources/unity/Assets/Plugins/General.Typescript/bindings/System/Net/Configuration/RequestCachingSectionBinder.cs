using UnityEngine;

namespace General.Typescript
{
	public class SystemNetConfigurationRequestCachingSection
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Configuration.RequestCachingSection> self = space.DeclareClass<System.Net.Configuration.RequestCachingSection>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("DefaultFtpCachePolicy", get_DefaultFtpCachePolicy, null);
			self.BindInstanceProperty("DefaultHttpCachePolicy", get_DefaultHttpCachePolicy, null);
			self.BindInstanceProperty("DefaultPolicyLevel", get_DefaultPolicyLevel, set_DefaultPolicyLevel);
			self.BindInstanceProperty("DisableAllCaching", get_DisableAllCaching, set_DisableAllCaching);
			self.BindInstanceProperty("IsPrivateCache", get_IsPrivateCache, set_IsPrivateCache);
			self.BindInstanceProperty("UnspecifiedMaximumAge", get_UnspecifiedMaximumAge, set_UnspecifiedMaximumAge);
		}

		static private System.Net.Configuration.RequestCachingSection Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.Configuration.RequestCachingSection();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Configuration.RequestCachingSection.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.Configuration.RequestCachingSection);
		}

		static private System.Net.Configuration.FtpCachePolicyElement get_DefaultFtpCachePolicy(System.Net.Configuration.RequestCachingSection instance)
		{
			return instance.DefaultFtpCachePolicy;
		}

		static private System.Net.Configuration.HttpCachePolicyElement get_DefaultHttpCachePolicy(System.Net.Configuration.RequestCachingSection instance)
		{
			return instance.DefaultHttpCachePolicy;
		}

		static private System.Net.Cache.RequestCacheLevel get_DefaultPolicyLevel(System.Net.Configuration.RequestCachingSection instance)
		{
			return instance.DefaultPolicyLevel;
		}

		static private void set_DefaultPolicyLevel(System.Net.Configuration.RequestCachingSection instance, System.Net.Cache.RequestCacheLevel value)
		{
			instance.DefaultPolicyLevel = value;
		}

		static private System.Boolean get_DisableAllCaching(System.Net.Configuration.RequestCachingSection instance)
		{
			return instance.DisableAllCaching;
		}

		static private void set_DisableAllCaching(System.Net.Configuration.RequestCachingSection instance, System.Boolean value)
		{
			instance.DisableAllCaching = value;
		}

		static private System.Boolean get_IsPrivateCache(System.Net.Configuration.RequestCachingSection instance)
		{
			return instance.IsPrivateCache;
		}

		static private void set_IsPrivateCache(System.Net.Configuration.RequestCachingSection instance, System.Boolean value)
		{
			instance.IsPrivateCache = value;
		}

		static private System.TimeSpan get_UnspecifiedMaximumAge(System.Net.Configuration.RequestCachingSection instance)
		{
			return instance.UnspecifiedMaximumAge;
		}

		static private void set_UnspecifiedMaximumAge(System.Net.Configuration.RequestCachingSection instance, System.TimeSpan value)
		{
			instance.UnspecifiedMaximumAge = value;
		}

	}
}
