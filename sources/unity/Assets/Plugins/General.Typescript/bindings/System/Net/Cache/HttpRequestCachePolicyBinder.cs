using UnityEngine;

namespace General.Typescript
{
	public class SystemNetCacheHttpRequestCachePolicy
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Cache.HttpRequestCachePolicy> self = space.DeclareClass<System.Net.Cache.HttpRequestCachePolicy>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("Level", get_Level, null);
			self.BindInstanceProperty("CacheSyncDate", get_CacheSyncDate, null);
			self.BindInstanceProperty("MaxAge", get_MaxAge, null);
			self.BindInstanceProperty("MinFresh", get_MinFresh, null);
			self.BindInstanceProperty("MaxStale", get_MaxStale, null);
		}

		static private System.Net.Cache.HttpRequestCachePolicy Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.Cache.HttpRequestCachePolicy();
			}
			if (parameters.CheckTypes<System.Net.Cache.HttpRequestCacheLevel>())
			{
				return new System.Net.Cache.HttpRequestCachePolicy(parameters[0].ToObject<System.Net.Cache.HttpRequestCacheLevel>());
			}
			if (parameters.CheckTypes<System.DateTime>())
			{
				return new System.Net.Cache.HttpRequestCachePolicy(parameters[0].ToObject<System.DateTime>());
			}
			if (parameters.CheckTypes<System.Net.Cache.HttpCacheAgeControl, System.TimeSpan>())
			{
				return new System.Net.Cache.HttpRequestCachePolicy(parameters[0].ToObject<System.Net.Cache.HttpCacheAgeControl>(), parameters[1].ToObject<System.TimeSpan>());
			}
			if (parameters.CheckTypes<System.Net.Cache.HttpCacheAgeControl, System.TimeSpan, System.TimeSpan>())
			{
				return new System.Net.Cache.HttpRequestCachePolicy(parameters[0].ToObject<System.Net.Cache.HttpCacheAgeControl>(), parameters[1].ToObject<System.TimeSpan>(), parameters[2].ToObject<System.TimeSpan>());
			}
			if (parameters.CheckTypes<System.Net.Cache.HttpCacheAgeControl, System.TimeSpan, System.TimeSpan, System.DateTime>())
			{
				return new System.Net.Cache.HttpRequestCachePolicy(parameters[0].ToObject<System.Net.Cache.HttpCacheAgeControl>(), parameters[1].ToObject<System.TimeSpan>(), parameters[2].ToObject<System.TimeSpan>(), parameters[3].ToObject<System.DateTime>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Cache.HttpRequestCachePolicy.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.Cache.HttpRequestCachePolicy);
		}

		static private System.String ToString(System.Net.Cache.HttpRequestCachePolicy instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Cache.HttpRequestCachePolicy.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Net.Cache.HttpRequestCacheLevel get_Level(System.Net.Cache.HttpRequestCachePolicy instance)
		{
			return instance.Level;
		}

		static private System.DateTime get_CacheSyncDate(System.Net.Cache.HttpRequestCachePolicy instance)
		{
			return instance.CacheSyncDate;
		}

		static private System.TimeSpan get_MaxAge(System.Net.Cache.HttpRequestCachePolicy instance)
		{
			return instance.MaxAge;
		}

		static private System.TimeSpan get_MinFresh(System.Net.Cache.HttpRequestCachePolicy instance)
		{
			return instance.MinFresh;
		}

		static private System.TimeSpan get_MaxStale(System.Net.Cache.HttpRequestCachePolicy instance)
		{
			return instance.MaxStale;
		}

	}
}
