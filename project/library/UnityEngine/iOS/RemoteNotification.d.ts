declare namespace UnityEngine
{
	declare namespace iOS
	{
		export class RemoteNotification
		{
			public get alertBody(): string;
			public get alertTitle(): string;
			public get soundName(): string;
			public get applicationIconBadgeNumber(): number;
			public get userInfo(): any;
			public get hasAction(): number;
		}
	}
}
