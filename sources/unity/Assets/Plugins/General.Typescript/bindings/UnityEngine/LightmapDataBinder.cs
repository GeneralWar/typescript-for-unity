using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineLightmapData
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.LightmapData> self = space.DeclareClass<UnityEngine.LightmapData>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("lightmapColor", get_lightmapColor, set_lightmapColor);
			self.BindInstanceProperty("lightmapDir", get_lightmapDir, set_lightmapDir);
			self.BindInstanceProperty("shadowMask", get_shadowMask, set_shadowMask);
		}

		static private UnityEngine.LightmapData Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.LightmapData();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.LightmapData.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.LightmapData);
		}

		static private UnityEngine.Texture2D get_lightmapColor(UnityEngine.LightmapData instance)
		{
			return instance.lightmapColor;
		}

		static private void set_lightmapColor(UnityEngine.LightmapData instance, UnityEngine.Texture2D value)
		{
			instance.lightmapColor = value;
		}

		static private UnityEngine.Texture2D get_lightmapDir(UnityEngine.LightmapData instance)
		{
			return instance.lightmapDir;
		}

		static private void set_lightmapDir(UnityEngine.LightmapData instance, UnityEngine.Texture2D value)
		{
			instance.lightmapDir = value;
		}

		static private UnityEngine.Texture2D get_shadowMask(UnityEngine.LightmapData instance)
		{
			return instance.shadowMask;
		}

		static private void set_shadowMask(UnityEngine.LightmapData instance, UnityEngine.Texture2D value)
		{
			instance.shadowMask = value;
		}

	}
}
