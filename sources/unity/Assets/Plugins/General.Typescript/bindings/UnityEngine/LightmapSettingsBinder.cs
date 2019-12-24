using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLightmapSettings
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.LightmapSettings> self = space.DeclareClass<UnityEngine.LightmapSettings, UnityEngine.Object>();
			self.BindConstructor();
			self.BindStaticProperty("lightmaps", get_lightmaps, set_lightmaps);
			self.BindStaticProperty("lightmapsMode", get_lightmapsMode, set_lightmapsMode);
			self.BindStaticProperty("lightProbes", get_lightProbes, set_lightProbes);
		}

		static private UnityEngine.LightmapData[] get_lightmaps(Type type, string name)
		{
			return UnityEngine.LightmapSettings.lightmaps;
		}

		static private void set_lightmaps(Type type, string name, UnityEngine.LightmapData[] value)
		{
			UnityEngine.LightmapSettings.lightmaps = value;
		}

		static private UnityEngine.LightmapsMode get_lightmapsMode(Type type, string name)
		{
			return UnityEngine.LightmapSettings.lightmapsMode;
		}

		static private void set_lightmapsMode(Type type, string name, UnityEngine.LightmapsMode value)
		{
			UnityEngine.LightmapSettings.lightmapsMode = value;
		}

		static private UnityEngine.LightProbes get_lightProbes(Type type, string name)
		{
			return UnityEngine.LightmapSettings.lightProbes;
		}

		static private void set_lightProbes(Type type, string name, UnityEngine.LightProbes value)
		{
			UnityEngine.LightmapSettings.lightProbes = value;
		}

	}
}
