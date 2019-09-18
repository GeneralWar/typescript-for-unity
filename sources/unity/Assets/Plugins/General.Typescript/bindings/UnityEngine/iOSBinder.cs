using System;

namespace General.Typescript
{
    public class iOSBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("iOS");


#if UNITY_IPHONE
			UnityEngineiOSActivityIndicatorStyle.Bind(self);
			UnityEngineiOSCalendarIdentifier.Bind(self);
			UnityEngineiOSCalendarUnit.Bind(self);
			UnityEngineiOSDevice.Bind(self);
			UnityEngineiOSDeviceGeneration.Bind(self);
			UnityEngineiOSLocalNotification.Bind(self);
			UnityEngineiOSNotificationServices.Bind(self);
			UnityEngineiOSNotificationType.Bind(self);
			UnityEngineiOSOnDemandResourcesRequest.Bind(self);
			UnityEngineiOSRemoteNotification.Bind(self);
			UnityEngineiOSSystemGestureDeferMode.Bind(self);
#endif
        }
    }
}