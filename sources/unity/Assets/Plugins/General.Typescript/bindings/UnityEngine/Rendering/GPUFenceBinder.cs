using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingGPUFence
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Rendering.GPUFence> self = space.DeclareClass<UnityEngine.Rendering.GPUFence>();
			self.BindConstructor();
			self.BindInstanceProperty("passed", get_passed, null);
		}

		static private System.Boolean get_passed(UnityEngine.Rendering.GPUFence instance)
		{
			return instance.passed;
		}

	}
}
