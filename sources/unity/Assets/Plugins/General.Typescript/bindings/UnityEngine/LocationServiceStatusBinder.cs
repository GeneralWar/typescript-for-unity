using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLocationServiceStatus
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.LocationServiceStatus> instance = space.DeclareEnum<UnityEngine.LocationServiceStatus>();
			instance.SetValue("Stopped", (long)UnityEngine.LocationServiceStatus.Stopped);
			instance.SetValue("Initializing", (long)UnityEngine.LocationServiceStatus.Initializing);
			instance.SetValue("Running", (long)UnityEngine.LocationServiceStatus.Running);
			instance.SetValue("Failed", (long)UnityEngine.LocationServiceStatus.Failed);
		}
	}
}
