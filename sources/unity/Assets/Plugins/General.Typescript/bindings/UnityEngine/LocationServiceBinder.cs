using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLocationService
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.LocationService> self = space.DeclareClass<UnityEngine.LocationService>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Start", Start);
			self.BindInstanceFunction("Stop", Stop);
			self.BindInstanceProperty("isEnabledByUser", get_isEnabledByUser, null);
			self.BindInstanceProperty("status", get_status, null);
			self.BindInstanceProperty("lastData", get_lastData, null);
		}

		static private UnityEngine.LocationService Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.LocationService();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.LocationService.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.LocationService);
		}

		static private void Start(UnityEngine.LocationService instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Start();
			}
			if (parameters.CheckTypes<System.Single>())
			{
				instance.Start(parameters[0].ToObject<System.Single>());
				return;
			}
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				instance.Start(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
				return;
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.LocationService.Start has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Stop(UnityEngine.LocationService instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.LocationService.Stop has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean get_isEnabledByUser(UnityEngine.LocationService instance)
		{
			return instance.isEnabledByUser;
		}

		static private UnityEngine.LocationServiceStatus get_status(UnityEngine.LocationService instance)
		{
			return instance.status;
		}

		static private UnityEngine.LocationInfo get_lastData(UnityEngine.LocationService instance)
		{
			return instance.lastData;
		}

	}
}
