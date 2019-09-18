#if UNITY_IPHONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineiOSNotificationServices
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.iOS.NotificationServices> self = space.DeclareClass<UnityEngine.iOS.NotificationServices>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("CancelAllLocalNotifications", CancelAllLocalNotifications);
			self.BindStaticFunction("CancelLocalNotification", CancelLocalNotification);
			self.BindStaticFunction("ClearLocalNotifications", ClearLocalNotifications);
			self.BindStaticFunction("ClearRemoteNotifications", ClearRemoteNotifications);
			self.BindStaticFunction("GetLocalNotification", GetLocalNotification);
			self.BindStaticFunction("GetRemoteNotification", GetRemoteNotification);
			self.BindStaticFunction("PresentLocalNotificationNow", PresentLocalNotificationNow);
			self.BindStaticFunction("RegisterForNotifications", RegisterForNotifications);
			self.BindStaticFunction("ScheduleLocalNotification", ScheduleLocalNotification);
			self.BindStaticFunction("UnregisterForRemoteNotifications", UnregisterForRemoteNotifications);
			self.BindStaticProperty("localNotificationCount", get_localNotificationCount, null);
			self.BindStaticProperty("remoteNotificationCount", get_remoteNotificationCount, null);
			self.BindStaticProperty("enabledNotificationTypes", get_enabledNotificationTypes, null);
			self.BindStaticProperty("registrationError", get_registrationError, null);
			self.BindStaticProperty("deviceToken", get_deviceToken, null);
			self.BindStaticProperty("localNotifications", get_localNotifications, null);
			self.BindStaticProperty("remoteNotifications", get_remoteNotifications, null);
			self.BindStaticProperty("scheduledLocalNotifications", get_scheduledLocalNotifications, null);
		}

		static private UnityEngine.iOS.NotificationServices Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.iOS.NotificationServices();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.iOS.NotificationServices.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.iOS.NotificationServices);
		}

		static private void CancelAllLocalNotifications(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.iOS.NotificationServices.CancelAllLocalNotifications();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.iOS.NotificationServices.CancelAllLocalNotifications has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void CancelLocalNotification(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.iOS.LocalNotification>())
			{
				UnityEngine.iOS.NotificationServices.CancelLocalNotification(parameters[0].ToObject<UnityEngine.iOS.LocalNotification>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.iOS.NotificationServices.CancelLocalNotification has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.iOS.NotificationServices.CancelLocalNotification has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void ClearLocalNotifications(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.iOS.NotificationServices.ClearLocalNotifications();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.iOS.NotificationServices.ClearLocalNotifications has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void ClearRemoteNotifications(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.iOS.NotificationServices.ClearRemoteNotifications();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.iOS.NotificationServices.ClearRemoteNotifications has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.iOS.LocalNotification GetLocalNotification(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.iOS.NotificationServices.GetLocalNotification(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.iOS.NotificationServices.GetLocalNotification has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.iOS.NotificationServices.GetLocalNotification has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.iOS.RemoteNotification GetRemoteNotification(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.iOS.NotificationServices.GetRemoteNotification(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.iOS.NotificationServices.GetRemoteNotification has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.iOS.NotificationServices.GetRemoteNotification has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void PresentLocalNotificationNow(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.iOS.LocalNotification>())
			{
				UnityEngine.iOS.NotificationServices.PresentLocalNotificationNow(parameters[0].ToObject<UnityEngine.iOS.LocalNotification>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.iOS.NotificationServices.PresentLocalNotificationNow has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.iOS.NotificationServices.PresentLocalNotificationNow has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void RegisterForNotifications(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.iOS.NotificationType>())
			{
				UnityEngine.iOS.NotificationServices.RegisterForNotifications(parameters[0].ToObject<UnityEngine.iOS.NotificationType>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.iOS.NotificationType, System.Boolean>())
			{
				UnityEngine.iOS.NotificationServices.RegisterForNotifications(parameters[0].ToObject<UnityEngine.iOS.NotificationType>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.iOS.NotificationServices.RegisterForNotifications has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.iOS.NotificationServices.RegisterForNotifications has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void ScheduleLocalNotification(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.iOS.LocalNotification>())
			{
				UnityEngine.iOS.NotificationServices.ScheduleLocalNotification(parameters[0].ToObject<UnityEngine.iOS.LocalNotification>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.iOS.NotificationServices.ScheduleLocalNotification has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.iOS.NotificationServices.ScheduleLocalNotification has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void UnregisterForRemoteNotifications(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.iOS.NotificationServices.UnregisterForRemoteNotifications();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.iOS.NotificationServices.UnregisterForRemoteNotifications has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Int32 get_localNotificationCount()
		{
			return UnityEngine.iOS.NotificationServices.localNotificationCount;
		}

		static private System.Int32 get_remoteNotificationCount()
		{
			return UnityEngine.iOS.NotificationServices.remoteNotificationCount;
		}

		static private UnityEngine.iOS.NotificationType get_enabledNotificationTypes()
		{
			return UnityEngine.iOS.NotificationServices.enabledNotificationTypes;
		}

		static private System.String get_registrationError()
		{
			return UnityEngine.iOS.NotificationServices.registrationError;
		}

		static private System.Byte[] get_deviceToken()
		{
			return UnityEngine.iOS.NotificationServices.deviceToken;
		}

		static private UnityEngine.iOS.LocalNotification[] get_localNotifications()
		{
			return UnityEngine.iOS.NotificationServices.localNotifications;
		}

		static private UnityEngine.iOS.RemoteNotification[] get_remoteNotifications()
		{
			return UnityEngine.iOS.NotificationServices.remoteNotifications;
		}

		static private UnityEngine.iOS.LocalNotification[] get_scheduledLocalNotifications()
		{
			return UnityEngine.iOS.NotificationServices.scheduledLocalNotifications;
		}

	}
}
#endif
