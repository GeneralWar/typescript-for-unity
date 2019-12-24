using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWrapMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.WrapMode> instance = space.DeclareEnum<UnityEngine.WrapMode>();
			instance.SetValue("Default", (long)UnityEngine.WrapMode.Default);
			instance.SetValue("Once", (long)UnityEngine.WrapMode.Once);
			instance.SetValue("Clamp", (long)UnityEngine.WrapMode.Clamp);
			instance.SetValue("Loop", (long)UnityEngine.WrapMode.Loop);
			instance.SetValue("PingPong", (long)UnityEngine.WrapMode.PingPong);
			instance.SetValue("ClampForever", (long)UnityEngine.WrapMode.ClampForever);
		}
	}
}
