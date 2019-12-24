using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLensFlare
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.LensFlare> self = space.DeclareClass<UnityEngine.LensFlare, UnityEngine.Behaviour>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("brightness", get_brightness, set_brightness);
			self.BindInstanceProperty("fadeSpeed", get_fadeSpeed, set_fadeSpeed);
			self.BindInstanceProperty("color", get_color, set_color);
			self.BindInstanceProperty("flare", get_flare, set_flare);
		}

		static private UnityEngine.LensFlare Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.LensFlare();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.LensFlare.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.LensFlare);
		}

		static private System.Single get_brightness(UnityEngine.LensFlare instance, string name)
		{
			return instance.brightness;
		}

		static private void set_brightness(UnityEngine.LensFlare instance, string name, System.Single value)
		{
			instance.brightness = value;
		}

		static private System.Single get_fadeSpeed(UnityEngine.LensFlare instance, string name)
		{
			return instance.fadeSpeed;
		}

		static private void set_fadeSpeed(UnityEngine.LensFlare instance, string name, System.Single value)
		{
			instance.fadeSpeed = value;
		}

		static private UnityEngine.Color get_color(UnityEngine.LensFlare instance, string name)
		{
			return instance.color;
		}

		static private void set_color(UnityEngine.LensFlare instance, string name, UnityEngine.Color value)
		{
			instance.color = value;
		}

		static private UnityEngine.Flare get_flare(UnityEngine.LensFlare instance, string name)
		{
			return instance.flare;
		}

		static private void set_flare(UnityEngine.LensFlare instance, string name, UnityEngine.Flare value)
		{
			instance.flare = value;
		}

	}
}
