#if !UNITY_STANDALONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineTouchType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.TouchType> instance = space.DeclareEnum<UnityEngine.TouchType>();
			instance.SetValue("Direct", (long)UnityEngine.TouchType.Direct);
			instance.SetValue("Indirect", (long)UnityEngine.TouchType.Indirect);
			instance.SetValue("Stylus", (long)UnityEngine.TouchType.Stylus);
		}
	}
}
#endif
