using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineDiagnosticsForcedCrashCategory
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.Diagnostics.ForcedCrashCategory> instance = space.DeclareEnum<UnityEngine.Diagnostics.ForcedCrashCategory>();
			instance.SetValue("AccessViolation", (long)UnityEngine.Diagnostics.ForcedCrashCategory.AccessViolation);
			instance.SetValue("FatalError", (long)UnityEngine.Diagnostics.ForcedCrashCategory.FatalError);
			instance.SetValue("Abort", (long)UnityEngine.Diagnostics.ForcedCrashCategory.Abort);
			instance.SetValue("PureVirtualFunction", (long)UnityEngine.Diagnostics.ForcedCrashCategory.PureVirtualFunction);
		}
	}
}
