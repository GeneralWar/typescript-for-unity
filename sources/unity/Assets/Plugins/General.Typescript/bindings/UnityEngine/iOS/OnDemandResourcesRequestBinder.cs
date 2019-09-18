#if UNITY_IPHONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineiOSOnDemandResourcesRequest
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.iOS.OnDemandResourcesRequest> self = space.DeclareClass<UnityEngine.iOS.OnDemandResourcesRequest>();
			self.BindConstructor();
			self.BindInstanceFunction("Dispose", Dispose);
			self.BindInstanceFunction("GetResourcePath", GetResourcePath);
			self.BindInstanceProperty("error", get_error, null);
			self.BindInstanceProperty("loadingPriority", get_loadingPriority, set_loadingPriority);
		}

		static private void Dispose(UnityEngine.iOS.OnDemandResourcesRequest instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Dispose();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.iOS.OnDemandResourcesRequest.Dispose has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.String GetResourcePath(UnityEngine.iOS.OnDemandResourcesRequest instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetResourcePath(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.iOS.OnDemandResourcesRequest.GetResourcePath has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.iOS.OnDemandResourcesRequest.GetResourcePath has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.String get_error(UnityEngine.iOS.OnDemandResourcesRequest instance)
		{
			return instance.error;
		}

		static private System.Single get_loadingPriority(UnityEngine.iOS.OnDemandResourcesRequest instance)
		{
			return instance.loadingPriority;
		}

		static private void set_loadingPriority(UnityEngine.iOS.OnDemandResourcesRequest instance, System.Single value)
		{
			instance.loadingPriority = value;
		}

	}
}
#endif
