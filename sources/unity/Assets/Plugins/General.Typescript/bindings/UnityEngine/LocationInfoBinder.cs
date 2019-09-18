using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLocationInfo
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.LocationInfo> self = space.DeclareClass<UnityEngine.LocationInfo>();
			self.BindConstructor();
			self.BindInstanceProperty("latitude", get_latitude, null);
			self.BindInstanceProperty("longitude", get_longitude, null);
			self.BindInstanceProperty("altitude", get_altitude, null);
			self.BindInstanceProperty("horizontalAccuracy", get_horizontalAccuracy, null);
			self.BindInstanceProperty("verticalAccuracy", get_verticalAccuracy, null);
			self.BindInstanceProperty("timestamp", get_timestamp, null);
		}

		static private System.Single get_latitude(UnityEngine.LocationInfo instance)
		{
			return instance.latitude;
		}

		static private System.Single get_longitude(UnityEngine.LocationInfo instance)
		{
			return instance.longitude;
		}

		static private System.Single get_altitude(UnityEngine.LocationInfo instance)
		{
			return instance.altitude;
		}

		static private System.Single get_horizontalAccuracy(UnityEngine.LocationInfo instance)
		{
			return instance.horizontalAccuracy;
		}

		static private System.Single get_verticalAccuracy(UnityEngine.LocationInfo instance)
		{
			return instance.verticalAccuracy;
		}

		static private System.Double get_timestamp(UnityEngine.LocationInfo instance)
		{
			return instance.timestamp;
		}

	}
}
