#if UNITY_IPHONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineiOSLocalNotification
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.iOS.LocalNotification> self = space.DeclareClass<UnityEngine.iOS.LocalNotification>();
			self.BindConstructor(Constructor);
			self.BindStaticProperty("defaultSoundName", get_defaultSoundName, null);
			self.BindInstanceProperty("timeZone", get_timeZone, set_timeZone);
			self.BindInstanceProperty("repeatCalendar", get_repeatCalendar, set_repeatCalendar);
			self.BindInstanceProperty("repeatInterval", get_repeatInterval, set_repeatInterval);
			self.BindInstanceProperty("fireDate", get_fireDate, set_fireDate);
			self.BindInstanceProperty("alertBody", get_alertBody, set_alertBody);
			self.BindInstanceProperty("alertTitle", get_alertTitle, set_alertTitle);
			self.BindInstanceProperty("alertAction", get_alertAction, set_alertAction);
			self.BindInstanceProperty("alertLaunchImage", get_alertLaunchImage, set_alertLaunchImage);
			self.BindInstanceProperty("soundName", get_soundName, set_soundName);
			self.BindInstanceProperty("applicationIconBadgeNumber", get_applicationIconBadgeNumber, set_applicationIconBadgeNumber);
			self.BindInstanceProperty("userInfo", get_userInfo, set_userInfo);
			self.BindInstanceProperty("hasAction", get_hasAction, set_hasAction);
		}

		static private UnityEngine.iOS.LocalNotification Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.iOS.LocalNotification();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.iOS.LocalNotification.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.iOS.LocalNotification);
		}

		static private System.String get_defaultSoundName()
		{
			return UnityEngine.iOS.LocalNotification.defaultSoundName;
		}

		static private System.String get_timeZone(UnityEngine.iOS.LocalNotification instance)
		{
			return instance.timeZone;
		}

		static private void set_timeZone(UnityEngine.iOS.LocalNotification instance, System.String value)
		{
			instance.timeZone = value;
		}

		static private UnityEngine.iOS.CalendarIdentifier get_repeatCalendar(UnityEngine.iOS.LocalNotification instance)
		{
			return instance.repeatCalendar;
		}

		static private void set_repeatCalendar(UnityEngine.iOS.LocalNotification instance, UnityEngine.iOS.CalendarIdentifier value)
		{
			instance.repeatCalendar = value;
		}

		static private UnityEngine.iOS.CalendarUnit get_repeatInterval(UnityEngine.iOS.LocalNotification instance)
		{
			return instance.repeatInterval;
		}

		static private void set_repeatInterval(UnityEngine.iOS.LocalNotification instance, UnityEngine.iOS.CalendarUnit value)
		{
			instance.repeatInterval = value;
		}

		static private System.DateTime get_fireDate(UnityEngine.iOS.LocalNotification instance)
		{
			return instance.fireDate;
		}

		static private void set_fireDate(UnityEngine.iOS.LocalNotification instance, System.DateTime value)
		{
			instance.fireDate = value;
		}

		static private System.String get_alertBody(UnityEngine.iOS.LocalNotification instance)
		{
			return instance.alertBody;
		}

		static private void set_alertBody(UnityEngine.iOS.LocalNotification instance, System.String value)
		{
			instance.alertBody = value;
		}

		static private System.String get_alertTitle(UnityEngine.iOS.LocalNotification instance)
		{
			return instance.alertTitle;
		}

		static private void set_alertTitle(UnityEngine.iOS.LocalNotification instance, System.String value)
		{
			instance.alertTitle = value;
		}

		static private System.String get_alertAction(UnityEngine.iOS.LocalNotification instance)
		{
			return instance.alertAction;
		}

		static private void set_alertAction(UnityEngine.iOS.LocalNotification instance, System.String value)
		{
			instance.alertAction = value;
		}

		static private System.String get_alertLaunchImage(UnityEngine.iOS.LocalNotification instance)
		{
			return instance.alertLaunchImage;
		}

		static private void set_alertLaunchImage(UnityEngine.iOS.LocalNotification instance, System.String value)
		{
			instance.alertLaunchImage = value;
		}

		static private System.String get_soundName(UnityEngine.iOS.LocalNotification instance)
		{
			return instance.soundName;
		}

		static private void set_soundName(UnityEngine.iOS.LocalNotification instance, System.String value)
		{
			instance.soundName = value;
		}

		static private System.Int32 get_applicationIconBadgeNumber(UnityEngine.iOS.LocalNotification instance)
		{
			return instance.applicationIconBadgeNumber;
		}

		static private void set_applicationIconBadgeNumber(UnityEngine.iOS.LocalNotification instance, System.Int32 value)
		{
			instance.applicationIconBadgeNumber = value;
		}

		static private System.Collections.IDictionary get_userInfo(UnityEngine.iOS.LocalNotification instance)
		{
			return instance.userInfo;
		}

		static private void set_userInfo(UnityEngine.iOS.LocalNotification instance, System.Collections.IDictionary value)
		{
			instance.userInfo = value;
		}

		static private System.Boolean get_hasAction(UnityEngine.iOS.LocalNotification instance)
		{
			return instance.hasAction;
		}

		static private void set_hasAction(UnityEngine.iOS.LocalNotification instance, System.Boolean value)
		{
			instance.hasAction = value;
		}

	}
}
#endif
