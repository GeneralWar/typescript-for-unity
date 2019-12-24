using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineApplicationInstallMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.ApplicationInstallMode> instance = space.DeclareEnum<UnityEngine.ApplicationInstallMode>();
			instance.SetValue("Unknown", (long)UnityEngine.ApplicationInstallMode.Unknown);
			instance.SetValue("Store", (long)UnityEngine.ApplicationInstallMode.Store);
			instance.SetValue("DeveloperBuild", (long)UnityEngine.ApplicationInstallMode.DeveloperBuild);
			instance.SetValue("Adhoc", (long)UnityEngine.ApplicationInstallMode.Adhoc);
			instance.SetValue("Enterprise", (long)UnityEngine.ApplicationInstallMode.Enterprise);
			instance.SetValue("Editor", (long)UnityEngine.ApplicationInstallMode.Editor);
		}
	}
}
