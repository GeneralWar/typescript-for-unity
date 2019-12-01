declare namespace UnityEngine
{
	declare namespace iOS
	{
		export namespace NotificationServices
		{
			export function CancelAllLocalNotifications(): void;
			export function CancelLocalNotification(notification: UnityEngine.iOS.LocalNotification): void;
			export function ClearLocalNotifications(): void;
			export function ClearRemoteNotifications(): void;
			export function GetLocalNotification(index: number): UnityEngine.iOS.LocalNotification;
			export function GetRemoteNotification(index: number): UnityEngine.iOS.RemoteNotification;
			export function PresentLocalNotificationNow(notification: UnityEngine.iOS.LocalNotification): void;
			export function RegisterForNotifications(notificationTypes: UnityEngine.iOS.NotificationType): void;
			export function RegisterForNotifications(notificationTypes: UnityEngine.iOS.NotificationType, registerForRemote: boolean): void;
			export function ScheduleLocalNotification(notification: UnityEngine.iOS.LocalNotification): void;
			export function UnregisterForRemoteNotifications(): void;
		}
		export class NotificationServices
		{
			public constructor();
			static public get localNotificationCount(): number;
			static public get remoteNotificationCount(): number;
			static public get enabledNotificationTypes(): UnityEngine.iOS.NotificationType;
			static public get registrationError(): string;
			static public get deviceToken(): number[];
			static public get localNotifications(): UnityEngine.iOS.LocalNotification[];
			static public get remoteNotifications(): UnityEngine.iOS.RemoteNotification[];
			static public get scheduledLocalNotifications(): UnityEngine.iOS.LocalNotification[];
		}
	}
}
