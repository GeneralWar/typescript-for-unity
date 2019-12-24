using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUIRawImage
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UI.RawImage> self = space.DeclareClass<UnityEngine.UI.RawImage, UnityEngine.UI.MaskableGraphic>();
			self.BindConstructor();
			self.BindInstanceFunction("SetNativeSize", SetNativeSize);
			self.BindInstanceProperty("mainTexture", get_mainTexture, null);
			self.BindInstanceProperty("texture", get_texture, set_texture);
			self.BindInstanceProperty("uvRect", get_uvRect, set_uvRect);
		}

		static private void SetNativeSize(UnityEngine.UI.RawImage instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.SetNativeSize();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UI.RawImage.SetNativeSize has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private UnityEngine.Texture get_mainTexture(UnityEngine.UI.RawImage instance, string name)
		{
			return instance.mainTexture;
		}

		static private UnityEngine.Texture get_texture(UnityEngine.UI.RawImage instance, string name)
		{
			return instance.texture;
		}

		static private void set_texture(UnityEngine.UI.RawImage instance, string name, UnityEngine.Texture value)
		{
			instance.texture = value;
		}

		static private UnityEngine.Rect get_uvRect(UnityEngine.UI.RawImage instance, string name)
		{
			return instance.uvRect;
		}

		static private void set_uvRect(UnityEngine.UI.RawImage instance, string name, UnityEngine.Rect value)
		{
			instance.uvRect = value;
		}

	}
}
