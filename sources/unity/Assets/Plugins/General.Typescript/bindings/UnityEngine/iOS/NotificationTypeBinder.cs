#if UNITY_IPHONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineiOSNotificationType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.iOS.NotificationType> instance = space.DeclareEnum<UnityEngine.iOS.NotificationType>();
			instance.SetValue("None", (long)UnityEngine.iOS.NotificationType.None);
			instance.SetValue("Badge", (long)UnityEngine.iOS.NotificationType.Badge);
			instance.SetValue("Sound", (long)UnityEngine.iOS.NotificationType.Sound);
			instance.SetValue("Alert", (long)UnityEngine.iOS.NotificationType.Alert);
		}
	}
}
#endif
