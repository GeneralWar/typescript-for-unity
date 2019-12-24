using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUserAuthorization
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.UserAuthorization> instance = space.DeclareEnum<UnityEngine.UserAuthorization>();
			instance.SetValue("WebCam", (long)UnityEngine.UserAuthorization.WebCam);
			instance.SetValue("Microphone", (long)UnityEngine.UserAuthorization.Microphone);
		}
	}
}
