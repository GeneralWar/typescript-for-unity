#if UNITY_IPHONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineiOSRemoteNotification
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.iOS.RemoteNotification> self = space.DeclareClass<UnityEngine.iOS.RemoteNotification>();
			self.BindConstructor();
			self.BindInstanceProperty("alertBody", get_alertBody, null);
			self.BindInstanceProperty("alertTitle", get_alertTitle, null);
			self.BindInstanceProperty("soundName", get_soundName, null);
			self.BindInstanceProperty("applicationIconBadgeNumber", get_applicationIconBadgeNumber, null);
			self.BindInstanceProperty("userInfo", get_userInfo, null);
			self.BindInstanceProperty("hasAction", get_hasAction, null);
		}

		static private System.String get_alertBody(UnityEngine.iOS.RemoteNotification instance)
		{
			return instance.alertBody;
		}

		static private System.String get_alertTitle(UnityEngine.iOS.RemoteNotification instance)
		{
			return instance.alertTitle;
		}

		static private System.String get_soundName(UnityEngine.iOS.RemoteNotification instance)
		{
			return instance.soundName;
		}

		static private System.Int32 get_applicationIconBadgeNumber(UnityEngine.iOS.RemoteNotification instance)
		{
			return instance.applicationIconBadgeNumber;
		}

		static private System.Collections.IDictionary get_userInfo(UnityEngine.iOS.RemoteNotification instance)
		{
			return instance.userInfo;
		}

		static private System.Boolean get_hasAction(UnityEngine.iOS.RemoteNotification instance)
		{
			return instance.hasAction;
		}

	}
}
#endif
