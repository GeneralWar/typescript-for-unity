using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingComputeQueueType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Rendering.ComputeQueueType> instance = space.DeclareEnum<UnityEngine.Rendering.ComputeQueueType>();
			instance.SetValue("Default", (long)UnityEngine.Rendering.ComputeQueueType.Default);
			instance.SetValue("Background", (long)UnityEngine.Rendering.ComputeQueueType.Background);
			instance.SetValue("Urgent", (long)UnityEngine.Rendering.ComputeQueueType.Urgent);
		}
	}
}
