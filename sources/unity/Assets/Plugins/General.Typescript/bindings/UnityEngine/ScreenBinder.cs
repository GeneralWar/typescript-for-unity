using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineScreen
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Screen> self = space.DeclareClass<UnityEngine.Screen>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("SetResolution", SetResolution);
			self.BindStaticProperty("width", get_width, null);
			self.BindStaticProperty("height", get_height, null);
			self.BindStaticProperty("dpi", get_dpi, null);
			self.BindStaticProperty("orientation", get_orientation, set_orientation);
			self.BindStaticProperty("sleepTimeout", get_sleepTimeout, set_sleepTimeout);
			self.BindStaticProperty("autorotateToPortrait", get_autorotateToPortrait, set_autorotateToPortrait);
			self.BindStaticProperty("autorotateToPortraitUpsideDown", get_autorotateToPortraitUpsideDown, set_autorotateToPortraitUpsideDown);
			self.BindStaticProperty("autorotateToLandscapeLeft", get_autorotateToLandscapeLeft, set_autorotateToLandscapeLeft);
			self.BindStaticProperty("autorotateToLandscapeRight", get_autorotateToLandscapeRight, set_autorotateToLandscapeRight);
			self.BindStaticProperty("currentResolution", get_currentResolution, null);
			self.BindStaticProperty("fullScreen", get_fullScreen, set_fullScreen);
			self.BindStaticProperty("fullScreenMode", get_fullScreenMode, set_fullScreenMode);
			self.BindStaticProperty("safeArea", get_safeArea, null);
			self.BindStaticProperty("resolutions", get_resolutions, null);
		}

		static private UnityEngine.Screen Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Screen();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Screen.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Screen);
		}

		static private void SetResolution(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.FullScreenMode>())
			{
				UnityEngine.Screen.SetResolution(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.FullScreenMode>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Boolean>())
			{
				UnityEngine.Screen.SetResolution(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Boolean>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, UnityEngine.FullScreenMode, System.Int32>())
			{
				UnityEngine.Screen.SetResolution(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<UnityEngine.FullScreenMode>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Boolean, System.Int32>())
			{
				UnityEngine.Screen.SetResolution(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Boolean>(), parameters[3].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Screen.SetResolution has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Screen.SetResolution has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 get_width()
		{
			return UnityEngine.Screen.width;
		}

		static private System.Int32 get_height()
		{
			return UnityEngine.Screen.height;
		}

		static private System.Single get_dpi()
		{
			return UnityEngine.Screen.dpi;
		}

		static private UnityEngine.ScreenOrientation get_orientation()
		{
			return UnityEngine.Screen.orientation;
		}

		static private void set_orientation(UnityEngine.ScreenOrientation value)
		{
			UnityEngine.Screen.orientation = value;
		}

		static private System.Int32 get_sleepTimeout()
		{
			return UnityEngine.Screen.sleepTimeout;
		}

		static private void set_sleepTimeout(System.Int32 value)
		{
			UnityEngine.Screen.sleepTimeout = value;
		}

		static private System.Boolean get_autorotateToPortrait()
		{
			return UnityEngine.Screen.autorotateToPortrait;
		}

		static private void set_autorotateToPortrait(System.Boolean value)
		{
			UnityEngine.Screen.autorotateToPortrait = value;
		}

		static private System.Boolean get_autorotateToPortraitUpsideDown()
		{
			return UnityEngine.Screen.autorotateToPortraitUpsideDown;
		}

		static private void set_autorotateToPortraitUpsideDown(System.Boolean value)
		{
			UnityEngine.Screen.autorotateToPortraitUpsideDown = value;
		}

		static private System.Boolean get_autorotateToLandscapeLeft()
		{
			return UnityEngine.Screen.autorotateToLandscapeLeft;
		}

		static private void set_autorotateToLandscapeLeft(System.Boolean value)
		{
			UnityEngine.Screen.autorotateToLandscapeLeft = value;
		}

		static private System.Boolean get_autorotateToLandscapeRight()
		{
			return UnityEngine.Screen.autorotateToLandscapeRight;
		}

		static private void set_autorotateToLandscapeRight(System.Boolean value)
		{
			UnityEngine.Screen.autorotateToLandscapeRight = value;
		}

		static private UnityEngine.Resolution get_currentResolution()
		{
			return UnityEngine.Screen.currentResolution;
		}

		static private System.Boolean get_fullScreen()
		{
			return UnityEngine.Screen.fullScreen;
		}

		static private void set_fullScreen(System.Boolean value)
		{
			UnityEngine.Screen.fullScreen = value;
		}

		static private UnityEngine.FullScreenMode get_fullScreenMode()
		{
			return UnityEngine.Screen.fullScreenMode;
		}

		static private void set_fullScreenMode(UnityEngine.FullScreenMode value)
		{
			UnityEngine.Screen.fullScreenMode = value;
		}

		static private UnityEngine.Rect get_safeArea()
		{
			return UnityEngine.Screen.safeArea;
		}

		static private UnityEngine.Resolution[] get_resolutions()
		{
			return UnityEngine.Screen.resolutions;
		}

	}
}
