#if !UNITY_STANDALONE_WIN && !UNITY_IPHONE
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineFullScreenMovieScalingMode
	{
		static public void Bind(Namespace space)
		{
			Enum<UnityEngine.FullScreenMovieScalingMode> instance = space.DeclareEnum<UnityEngine.FullScreenMovieScalingMode>();
			instance.SetValue("None", (long)UnityEngine.FullScreenMovieScalingMode.None);
			instance.SetValue("AspectFit", (long)UnityEngine.FullScreenMovieScalingMode.AspectFit);
			instance.SetValue("AspectFill", (long)UnityEngine.FullScreenMovieScalingMode.AspectFill);
			instance.SetValue("Fill", (long)UnityEngine.FullScreenMovieScalingMode.Fill);
		}
	}
}
#endif
