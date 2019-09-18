using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineNPOTSupport
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.NPOTSupport> instance = space.DeclareEnum<UnityEngine.NPOTSupport>();
			instance.SetValue("None", (long)UnityEngine.NPOTSupport.None);
			instance.SetValue("Restricted", (long)UnityEngine.NPOTSupport.Restricted);
			instance.SetValue("Full", (long)UnityEngine.NPOTSupport.Full);
		}
	}
}
