using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineQueryTriggerInteraction
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.QueryTriggerInteraction> instance = space.DeclareEnum<UnityEngine.QueryTriggerInteraction>();
			instance.SetValue("UseGlobal", (long)UnityEngine.QueryTriggerInteraction.UseGlobal);
			instance.SetValue("Ignore", (long)UnityEngine.QueryTriggerInteraction.Ignore);
			instance.SetValue("Collide", (long)UnityEngine.QueryTriggerInteraction.Collide);
		}
	}
}
