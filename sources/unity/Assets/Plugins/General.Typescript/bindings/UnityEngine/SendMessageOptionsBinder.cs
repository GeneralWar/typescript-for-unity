using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSendMessageOptions
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.SendMessageOptions> instance = space.DeclareEnum<UnityEngine.SendMessageOptions>();
			instance.SetValue("RequireReceiver", (long)UnityEngine.SendMessageOptions.RequireReceiver);
			instance.SetValue("DontRequireReceiver", (long)UnityEngine.SendMessageOptions.DontRequireReceiver);
		}
	}
}
