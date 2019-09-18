using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineApplicationSandboxType
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.ApplicationSandboxType> instance = space.DeclareEnum<UnityEngine.ApplicationSandboxType>();
			instance.SetValue("Unknown", (long)UnityEngine.ApplicationSandboxType.Unknown);
			instance.SetValue("NotSandboxed", (long)UnityEngine.ApplicationSandboxType.NotSandboxed);
			instance.SetValue("Sandboxed", (long)UnityEngine.ApplicationSandboxType.Sandboxed);
			instance.SetValue("SandboxBroken", (long)UnityEngine.ApplicationSandboxType.SandboxBroken);
		}
	}
}
