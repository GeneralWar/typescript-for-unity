declare namespace UnityEngine
{
	declare namespace iOS
	{
		export class LocalNotification
		{
			public constructor();
			static public get defaultSoundName(): string;
			public get timeZone(): string;
			public set timeZone(): string;
			public get repeatCalendar(): UnityEngine.iOS.CalendarIdentifier;
			public set repeatCalendar(): UnityEngine.iOS.CalendarIdentifier;
			public get repeatInterval(): UnityEngine.iOS.CalendarUnit;
			public set repeatInterval(): UnityEngine.iOS.CalendarUnit;
			public get fireDate(): number;
			public set fireDate(): number;
			public get alertBody(): string;
			public set alertBody(): string;
			public get alertTitle(): string;
			public set alertTitle(): string;
			public get alertAction(): string;
			public set alertAction(): string;
			public get alertLaunchImage(): string;
			public set alertLaunchImage(): string;
			public get soundName(): string;
			public set soundName(): string;
			public get applicationIconBadgeNumber(): number;
			public set applicationIconBadgeNumber(): number;
			public get userInfo(): any;
			public set userInfo(): any;
			public get hasAction(): number;
			public set hasAction(): number;
		}
	}
}
