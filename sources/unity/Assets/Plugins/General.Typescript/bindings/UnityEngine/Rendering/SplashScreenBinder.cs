using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRenderingSplashScreen
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Rendering.SplashScreen> self = space.DeclareClass<UnityEngine.Rendering.SplashScreen>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("Begin", Begin);
			self.BindStaticFunction("Draw", Draw);
			self.BindStaticProperty("isFinished", get_isFinished, null);
		}

		static private UnityEngine.Rendering.SplashScreen Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Rendering.SplashScreen();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.SplashScreen.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Rendering.SplashScreen);
		}

		static private void Begin(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.Rendering.SplashScreen.Begin();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.SplashScreen.Begin has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Draw(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.Rendering.SplashScreen.Draw();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Rendering.SplashScreen.Draw has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Boolean get_isFinished(Type type, string name)
		{
			return UnityEngine.Rendering.SplashScreen.isFinished;
		}

	}
}
