using UnityEngine;

namespace General.Typescript
{
	public class SystemNetConfigurationHttpCachePolicyElement
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Configuration.HttpCachePolicyElement> self = space.DeclareClass<System.Net.Configuration.HttpCachePolicyElement>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("MaximumAge", get_MaximumAge, set_MaximumAge);
			self.BindInstanceProperty("MaximumStale", get_MaximumStale, set_MaximumStale);
			self.BindInstanceProperty("MinimumFresh", get_MinimumFresh, set_MinimumFresh);
			self.BindInstanceProperty("PolicyLevel", get_PolicyLevel, set_PolicyLevel);
		}

		static private System.Net.Configuration.HttpCachePolicyElement Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.Configuration.HttpCachePolicyElement();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Configuration.HttpCachePolicyElement.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.Configuration.HttpCachePolicyElement);
		}

		static private System.TimeSpan get_MaximumAge(System.Net.Configuration.HttpCachePolicyElement instance)
		{
			return instance.MaximumAge;
		}

		static private void set_MaximumAge(System.Net.Configuration.HttpCachePolicyElement instance, System.TimeSpan value)
		{
			instance.MaximumAge = value;
		}

		static private System.TimeSpan get_MaximumStale(System.Net.Configuration.HttpCachePolicyElement instance)
		{
			return instance.MaximumStale;
		}

		static private void set_MaximumStale(System.Net.Configuration.HttpCachePolicyElement instance, System.TimeSpan value)
		{
			instance.MaximumStale = value;
		}

		static private System.TimeSpan get_MinimumFresh(System.Net.Configuration.HttpCachePolicyElement instance)
		{
			return instance.MinimumFresh;
		}

		static private void set_MinimumFresh(System.Net.Configuration.HttpCachePolicyElement instance, System.TimeSpan value)
		{
			instance.MinimumFresh = value;
		}

		static private System.Net.Cache.HttpRequestCacheLevel get_PolicyLevel(System.Net.Configuration.HttpCachePolicyElement instance)
		{
			return instance.PolicyLevel;
		}

		static private void set_PolicyLevel(System.Net.Configuration.HttpCachePolicyElement instance, System.Net.Cache.HttpRequestCacheLevel value)
		{
			instance.PolicyLevel = value;
		}

	}
}
