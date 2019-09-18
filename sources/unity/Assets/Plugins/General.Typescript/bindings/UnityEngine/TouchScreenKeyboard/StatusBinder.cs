#if !UNITY_STANDALONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTouchScreenKeyboardStatus
	{
		static public void Bind(Class space)
		{
			Enum<UnityEngine.TouchScreenKeyboard.Status> instance = space.DeclareEnum<UnityEngine.TouchScreenKeyboard.Status>();
			instance.SetValue("Visible", (long)UnityEngine.TouchScreenKeyboard.Status.Visible);
			instance.SetValue("Done", (long)UnityEngine.TouchScreenKeyboard.Status.Done);
			instance.SetValue("Canceled", (long)UnityEngine.TouchScreenKeyboard.Status.Canceled);
			instance.SetValue("LostFocus", (long)UnityEngine.TouchScreenKeyboard.Status.LostFocus);
		}
	}
}
#endif
