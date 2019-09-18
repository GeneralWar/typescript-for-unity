using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCaching
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Caching> self = space.DeclareClass<UnityEngine.Caching>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("AddCache", AddCache);
			self.BindStaticFunction("ClearAllCachedVersions", ClearAllCachedVersions);
			self.BindStaticFunction("ClearCache", ClearCache);
			self.BindStaticFunction("ClearCachedVersion", ClearCachedVersion);
			self.BindStaticFunction("ClearOtherCachedVersions", ClearOtherCachedVersions);
			self.BindStaticFunction("GetCacheAt", GetCacheAt);
			self.BindStaticFunction("GetCacheByPath", GetCacheByPath);
			self.BindStaticFunction("IsVersionCached", IsVersionCached);
			self.BindStaticFunction("MarkAsUsed", MarkAsUsed);
			self.BindStaticFunction("MoveCacheAfter", MoveCacheAfter);
			self.BindStaticFunction("MoveCacheBefore", MoveCacheBefore);
			self.BindStaticFunction("RemoveCache", RemoveCache);
			self.BindStaticProperty("compressionEnabled", get_compressionEnabled, set_compressionEnabled);
			self.BindStaticProperty("ready", get_ready, null);
			self.BindStaticProperty("cacheCount", get_cacheCount, null);
			self.BindStaticProperty("defaultCache", get_defaultCache, null);
			self.BindStaticProperty("currentCacheForWriting", get_currentCacheForWriting, set_currentCacheForWriting);
		}

		static private UnityEngine.Caching Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Caching();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Caching.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Caching);
		}

		static private UnityEngine.Cache AddCache(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Caching.AddCache(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Caching.AddCache has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Caching.AddCache has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Cache);
		}

		static private System.Boolean ClearAllCachedVersions(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Caching.ClearAllCachedVersions(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Caching.ClearAllCachedVersions has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Caching.ClearAllCachedVersions has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean ClearCache(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.Caching.ClearCache();
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Caching.ClearCache(parameters[0].ToObject<System.Int32>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Caching.ClearCache has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.Boolean ClearCachedVersion(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Hash128>())
			{
				return UnityEngine.Caching.ClearCachedVersion(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Hash128>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Caching.ClearCachedVersion has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Caching.ClearCachedVersion has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean ClearOtherCachedVersions(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Hash128>())
			{
				return UnityEngine.Caching.ClearOtherCachedVersions(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Hash128>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Caching.ClearOtherCachedVersions has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Caching.ClearOtherCachedVersions has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.Cache GetCacheAt(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Caching.GetCacheAt(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Caching.GetCacheAt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Caching.GetCacheAt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Cache);
		}

		static private UnityEngine.Cache GetCacheByPath(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Caching.GetCacheByPath(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Caching.GetCacheByPath has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Caching.GetCacheByPath has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Cache);
		}

		static private System.Boolean IsVersionCached(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.CachedAssetBundle>())
			{
				return UnityEngine.Caching.IsVersionCached(parameters[0].ToObject<UnityEngine.CachedAssetBundle>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.Hash128>())
			{
				return UnityEngine.Caching.IsVersionCached(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Hash128>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Caching.IsVersionCached has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Caching.IsVersionCached has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean MarkAsUsed(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.CachedAssetBundle>())
			{
				return UnityEngine.Caching.MarkAsUsed(parameters[0].ToObject<UnityEngine.CachedAssetBundle>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.Hash128>())
			{
				return UnityEngine.Caching.MarkAsUsed(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Hash128>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Caching.MarkAsUsed has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Caching.MarkAsUsed has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void MoveCacheAfter(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Cache, UnityEngine.Cache>())
			{
				UnityEngine.Caching.MoveCacheAfter(parameters[0].ToObject<UnityEngine.Cache>(), parameters[1].ToObject<UnityEngine.Cache>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Caching.MoveCacheAfter has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Caching.MoveCacheAfter has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void MoveCacheBefore(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Cache, UnityEngine.Cache>())
			{
				UnityEngine.Caching.MoveCacheBefore(parameters[0].ToObject<UnityEngine.Cache>(), parameters[1].ToObject<UnityEngine.Cache>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Caching.MoveCacheBefore has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Caching.MoveCacheBefore has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean RemoveCache(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Cache>())
			{
				return UnityEngine.Caching.RemoveCache(parameters[0].ToObject<UnityEngine.Cache>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Caching.RemoveCache has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Caching.RemoveCache has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Boolean get_compressionEnabled()
		{
			return UnityEngine.Caching.compressionEnabled;
		}

		static private void set_compressionEnabled(System.Boolean value)
		{
			UnityEngine.Caching.compressionEnabled = value;
		}

		static private System.Boolean get_ready()
		{
			return UnityEngine.Caching.ready;
		}

		static private System.Int32 get_cacheCount()
		{
			return UnityEngine.Caching.cacheCount;
		}

		static private UnityEngine.Cache get_defaultCache()
		{
			return UnityEngine.Caching.defaultCache;
		}

		static private UnityEngine.Cache get_currentCacheForWriting()
		{
			return UnityEngine.Caching.currentCacheForWriting;
		}

		static private void set_currentCacheForWriting(UnityEngine.Cache value)
		{
			UnityEngine.Caching.currentCacheForWriting = value;
		}

	}
}
