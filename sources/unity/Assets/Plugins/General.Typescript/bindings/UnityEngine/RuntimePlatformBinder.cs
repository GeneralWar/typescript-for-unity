using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRuntimePlatform
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.RuntimePlatform> instance = space.DeclareEnum<UnityEngine.RuntimePlatform>();
			instance.SetValue("OSXEditor", (long)UnityEngine.RuntimePlatform.OSXEditor);
			instance.SetValue("OSXPlayer", (long)UnityEngine.RuntimePlatform.OSXPlayer);
			instance.SetValue("WindowsPlayer", (long)UnityEngine.RuntimePlatform.WindowsPlayer);
			instance.SetValue("WindowsEditor", (long)UnityEngine.RuntimePlatform.WindowsEditor);
			instance.SetValue("IPhonePlayer", (long)UnityEngine.RuntimePlatform.IPhonePlayer);
			instance.SetValue("Android", (long)UnityEngine.RuntimePlatform.Android);
			instance.SetValue("LinuxPlayer", (long)UnityEngine.RuntimePlatform.LinuxPlayer);
			instance.SetValue("LinuxEditor", (long)UnityEngine.RuntimePlatform.LinuxEditor);
			instance.SetValue("WebGLPlayer", (long)UnityEngine.RuntimePlatform.WebGLPlayer);
			instance.SetValue("WSAPlayerX86", (long)UnityEngine.RuntimePlatform.WSAPlayerX86);
			instance.SetValue("WSAPlayerX64", (long)UnityEngine.RuntimePlatform.WSAPlayerX64);
			instance.SetValue("WSAPlayerARM", (long)UnityEngine.RuntimePlatform.WSAPlayerARM);
			instance.SetValue("PS4", (long)UnityEngine.RuntimePlatform.PS4);
			instance.SetValue("XboxOne", (long)UnityEngine.RuntimePlatform.XboxOne);
			instance.SetValue("tvOS", (long)UnityEngine.RuntimePlatform.tvOS);
			instance.SetValue("Switch", (long)UnityEngine.RuntimePlatform.Switch);
			instance.SetValue("Lumin", (long)UnityEngine.RuntimePlatform.Lumin);
		}
	}
}
