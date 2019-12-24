using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSpace
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Space> instance = space.DeclareEnum<UnityEngine.Space>();
			instance.SetValue("World", (long)UnityEngine.Space.World);
			instance.SetValue("Self", (long)UnityEngine.Space.Self);
		}
	}
}
