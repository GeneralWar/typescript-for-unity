#if UNITY_IPHONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineiOSDeviceGeneration
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.iOS.DeviceGeneration> instance = space.DeclareEnum<UnityEngine.iOS.DeviceGeneration>();
			instance.SetValue("Unknown", (long)UnityEngine.iOS.DeviceGeneration.Unknown);
			instance.SetValue("iPhone", (long)UnityEngine.iOS.DeviceGeneration.iPhone);
			instance.SetValue("iPhone3G", (long)UnityEngine.iOS.DeviceGeneration.iPhone3G);
			instance.SetValue("iPhone3GS", (long)UnityEngine.iOS.DeviceGeneration.iPhone3GS);
			instance.SetValue("iPodTouch1Gen", (long)UnityEngine.iOS.DeviceGeneration.iPodTouch1Gen);
			instance.SetValue("iPodTouch2Gen", (long)UnityEngine.iOS.DeviceGeneration.iPodTouch2Gen);
			instance.SetValue("iPodTouch3Gen", (long)UnityEngine.iOS.DeviceGeneration.iPodTouch3Gen);
			instance.SetValue("iPad1Gen", (long)UnityEngine.iOS.DeviceGeneration.iPad1Gen);
			instance.SetValue("iPhone4", (long)UnityEngine.iOS.DeviceGeneration.iPhone4);
			instance.SetValue("iPodTouch4Gen", (long)UnityEngine.iOS.DeviceGeneration.iPodTouch4Gen);
			instance.SetValue("iPad2Gen", (long)UnityEngine.iOS.DeviceGeneration.iPad2Gen);
			instance.SetValue("iPhone4S", (long)UnityEngine.iOS.DeviceGeneration.iPhone4S);
			instance.SetValue("iPad3Gen", (long)UnityEngine.iOS.DeviceGeneration.iPad3Gen);
			instance.SetValue("iPhone5", (long)UnityEngine.iOS.DeviceGeneration.iPhone5);
			instance.SetValue("iPodTouch5Gen", (long)UnityEngine.iOS.DeviceGeneration.iPodTouch5Gen);
			instance.SetValue("iPadMini1Gen", (long)UnityEngine.iOS.DeviceGeneration.iPadMini1Gen);
			instance.SetValue("iPad4Gen", (long)UnityEngine.iOS.DeviceGeneration.iPad4Gen);
			instance.SetValue("iPhone5C", (long)UnityEngine.iOS.DeviceGeneration.iPhone5C);
			instance.SetValue("iPhone5S", (long)UnityEngine.iOS.DeviceGeneration.iPhone5S);
			instance.SetValue("iPadAir1", (long)UnityEngine.iOS.DeviceGeneration.iPadAir1);
			instance.SetValue("iPadMini2Gen", (long)UnityEngine.iOS.DeviceGeneration.iPadMini2Gen);
			instance.SetValue("iPhone6", (long)UnityEngine.iOS.DeviceGeneration.iPhone6);
			instance.SetValue("iPhone6Plus", (long)UnityEngine.iOS.DeviceGeneration.iPhone6Plus);
			instance.SetValue("iPadMini3Gen", (long)UnityEngine.iOS.DeviceGeneration.iPadMini3Gen);
			instance.SetValue("iPadAir2", (long)UnityEngine.iOS.DeviceGeneration.iPadAir2);
			instance.SetValue("iPhone6S", (long)UnityEngine.iOS.DeviceGeneration.iPhone6S);
			instance.SetValue("iPhone6SPlus", (long)UnityEngine.iOS.DeviceGeneration.iPhone6SPlus);
			instance.SetValue("iPadPro1Gen", (long)UnityEngine.iOS.DeviceGeneration.iPadPro1Gen);
			instance.SetValue("iPadMini4Gen", (long)UnityEngine.iOS.DeviceGeneration.iPadMini4Gen);
			instance.SetValue("iPhoneSE1Gen", (long)UnityEngine.iOS.DeviceGeneration.iPhoneSE1Gen);
			instance.SetValue("iPadPro10Inch1Gen", (long)UnityEngine.iOS.DeviceGeneration.iPadPro10Inch1Gen);
			instance.SetValue("iPhone7", (long)UnityEngine.iOS.DeviceGeneration.iPhone7);
			instance.SetValue("iPhone7Plus", (long)UnityEngine.iOS.DeviceGeneration.iPhone7Plus);
			instance.SetValue("iPodTouch6Gen", (long)UnityEngine.iOS.DeviceGeneration.iPodTouch6Gen);
			instance.SetValue("iPad5Gen", (long)UnityEngine.iOS.DeviceGeneration.iPad5Gen);
			instance.SetValue("iPadPro2Gen", (long)UnityEngine.iOS.DeviceGeneration.iPadPro2Gen);
			instance.SetValue("iPadPro10Inch2Gen", (long)UnityEngine.iOS.DeviceGeneration.iPadPro10Inch2Gen);
			instance.SetValue("iPhone8", (long)UnityEngine.iOS.DeviceGeneration.iPhone8);
			instance.SetValue("iPhone8Plus", (long)UnityEngine.iOS.DeviceGeneration.iPhone8Plus);
			instance.SetValue("iPhoneX", (long)UnityEngine.iOS.DeviceGeneration.iPhoneX);
			instance.SetValue("iPhoneXS", (long)UnityEngine.iOS.DeviceGeneration.iPhoneXS);
			instance.SetValue("iPhoneXSMax", (long)UnityEngine.iOS.DeviceGeneration.iPhoneXSMax);
			instance.SetValue("iPhoneXR", (long)UnityEngine.iOS.DeviceGeneration.iPhoneXR);
			instance.SetValue("iPadPro11Inch", (long)UnityEngine.iOS.DeviceGeneration.iPadPro11Inch);
			instance.SetValue("iPadPro3Gen", (long)UnityEngine.iOS.DeviceGeneration.iPadPro3Gen);
			instance.SetValue("iPhoneUnknown", (long)UnityEngine.iOS.DeviceGeneration.iPhoneUnknown);
			instance.SetValue("iPadUnknown", (long)UnityEngine.iOS.DeviceGeneration.iPadUnknown);
			instance.SetValue("iPodTouchUnknown", (long)UnityEngine.iOS.DeviceGeneration.iPodTouchUnknown);
		}
	}
}
#endif
