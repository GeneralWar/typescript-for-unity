#if UNITY_IPHONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineiOSSystemGestureDeferMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.iOS.SystemGestureDeferMode> instance = space.DeclareEnum<UnityEngine.iOS.SystemGestureDeferMode>();
			instance.SetValue("None", (long)UnityEngine.iOS.SystemGestureDeferMode.None);
			instance.SetValue("TopEdge", (long)UnityEngine.iOS.SystemGestureDeferMode.TopEdge);
			instance.SetValue("LeftEdge", (long)UnityEngine.iOS.SystemGestureDeferMode.LeftEdge);
			instance.SetValue("BottomEdge", (long)UnityEngine.iOS.SystemGestureDeferMode.BottomEdge);
			instance.SetValue("RightEdge", (long)UnityEngine.iOS.SystemGestureDeferMode.RightEdge);
			instance.SetValue("All", (long)UnityEngine.iOS.SystemGestureDeferMode.All);
		}
	}
}
#endif
