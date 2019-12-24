using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCachedAssetBundle
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.CachedAssetBundle> self = space.DeclareClass<UnityEngine.CachedAssetBundle>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("name", get_name, set_name);
			self.BindInstanceProperty("hash", get_hash, set_hash);
		}

		static private UnityEngine.CachedAssetBundle Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, UnityEngine.Hash128>())
			{
				return new UnityEngine.CachedAssetBundle(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.Hash128>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.CachedAssetBundle.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.CachedAssetBundle.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.CachedAssetBundle);
		}

		static private System.String get_name(UnityEngine.CachedAssetBundle instance, string name)
		{
			return instance.name;
		}

		static private void set_name(UnityEngine.CachedAssetBundle instance, string name, System.String value)
		{
			instance.name = value;
		}

		static private UnityEngine.Hash128 get_hash(UnityEngine.CachedAssetBundle instance, string name)
		{
			return instance.hash;
		}

		static private void set_hash(UnityEngine.CachedAssetBundle instance, string name, UnityEngine.Hash128 value)
		{
			instance.hash = value;
		}

	}
}
