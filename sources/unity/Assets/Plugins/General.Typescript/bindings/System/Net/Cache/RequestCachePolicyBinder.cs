using UnityEngine;

namespace General.Typescript
{
	public class SystemNetCacheRequestCachePolicy
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Cache.RequestCachePolicy> self = space.DeclareClass<System.Net.Cache.RequestCachePolicy>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("Level", get_Level, null);
		}

		static private System.Net.Cache.RequestCachePolicy Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.Cache.RequestCachePolicy();
			}
			if (parameters.CheckTypes<System.Net.Cache.RequestCacheLevel>())
			{
				return new System.Net.Cache.RequestCachePolicy(parameters[0].ToObject<System.Net.Cache.RequestCacheLevel>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Cache.RequestCachePolicy.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.Cache.RequestCachePolicy);
		}

		static private System.String ToString(System.Net.Cache.RequestCachePolicy instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("System.Net.Cache.RequestCachePolicy.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Net.Cache.RequestCacheLevel get_Level(System.Net.Cache.RequestCachePolicy instance)
		{
			return instance.Level;
		}

	}
}
