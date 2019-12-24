using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineResourceRequest
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.ResourceRequest> self = space.DeclareClass<UnityEngine.ResourceRequest>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("asset", get_asset, null);
		}

		static private UnityEngine.ResourceRequest Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.ResourceRequest();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.ResourceRequest.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.ResourceRequest);
		}

		static private UnityEngine.Object get_asset(UnityEngine.ResourceRequest instance, string name)
		{
			return instance.asset;
		}

	}
}
