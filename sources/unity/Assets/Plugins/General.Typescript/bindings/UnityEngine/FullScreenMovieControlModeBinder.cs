#if !UNITY_STANDALONE_WIN && !UNITY_IPHONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineFullScreenMovieControlMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.FullScreenMovieControlMode> instance = space.DeclareEnum<UnityEngine.FullScreenMovieControlMode>();
			instance.SetValue("Full", (long)UnityEngine.FullScreenMovieControlMode.Full);
			instance.SetValue("Minimal", (long)UnityEngine.FullScreenMovieControlMode.Minimal);
			instance.SetValue("CancelOnInput", (long)UnityEngine.FullScreenMovieControlMode.CancelOnInput);
			instance.SetValue("Hidden", (long)UnityEngine.FullScreenMovieControlMode.Hidden);
		}
	}
}
#endif
