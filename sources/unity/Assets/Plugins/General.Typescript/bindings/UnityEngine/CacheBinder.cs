using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCache
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Cache> self = space.DeclareClass<UnityEngine.Cache>();
			self.BindConstructor();
			self.BindInstanceFunction("ClearCache", ClearCache);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceProperty("valid", get_valid, null);
			self.BindInstanceProperty("ready", get_ready, null);
			self.BindInstanceProperty("readOnly", get_readOnly, null);
			self.BindInstanceProperty("path", get_path, null);
			self.BindInstanceProperty("index", get_index, null);
			self.BindInstanceProperty("spaceFree", get_spaceFree, null);
			self.BindInstanceProperty("maximumAvailableStorageSpace", get_maximumAvailableStorageSpace, set_maximumAvailableStorageSpace);
			self.BindInstanceProperty("spaceOccupied", get_spaceOccupied, null);
			self.BindInstanceProperty("expirationDelay", get_expirationDelay, set_expirationDelay);
		}

		static private System.Boolean ClearCache(UnityEngine.Cache instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ClearCache();
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.ClearCache(parameters[0].ToObject<System.Int32>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Cache.ClearCache has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.Boolean Equals(UnityEngine.Cache instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.Cache>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Cache>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Cache.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Cache.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.Cache instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetHashCode();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Cache.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Boolean get_valid(UnityEngine.Cache instance)
		{
			return instance.valid;
		}

		static private System.Boolean get_ready(UnityEngine.Cache instance)
		{
			return instance.ready;
		}

		static private System.Boolean get_readOnly(UnityEngine.Cache instance)
		{
			return instance.readOnly;
		}

		static private System.String get_path(UnityEngine.Cache instance)
		{
			return instance.path;
		}

		static private System.Int32 get_index(UnityEngine.Cache instance)
		{
			return instance.index;
		}

		static private System.Int64 get_spaceFree(UnityEngine.Cache instance)
		{
			return instance.spaceFree;
		}

		static private System.Int64 get_maximumAvailableStorageSpace(UnityEngine.Cache instance)
		{
			return instance.maximumAvailableStorageSpace;
		}

		static private void set_maximumAvailableStorageSpace(UnityEngine.Cache instance, System.Int64 value)
		{
			instance.maximumAvailableStorageSpace = value;
		}

		static private System.Int64 get_spaceOccupied(UnityEngine.Cache instance)
		{
			return instance.spaceOccupied;
		}

		static private System.Int32 get_expirationDelay(UnityEngine.Cache instance)
		{
			return instance.expirationDelay;
		}

		static private void set_expirationDelay(UnityEngine.Cache instance, System.Int32 value)
		{
			instance.expirationDelay = value;
		}

	}
}
