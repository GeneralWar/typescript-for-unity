#if UNITY_ANDROID
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAndroidInput
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AndroidInput> self = space.DeclareClass<UnityEngine.AndroidInput>();
			self.BindConstructor();
			self.BindStaticFunction("GetSecondaryTouch", GetSecondaryTouch);
			self.BindStaticProperty("touchCountSecondary", get_touchCountSecondary, null);
			self.BindStaticProperty("secondaryTouchEnabled", get_secondaryTouchEnabled, null);
			self.BindStaticProperty("secondaryTouchWidth", get_secondaryTouchWidth, null);
			self.BindStaticProperty("secondaryTouchHeight", get_secondaryTouchHeight, null);
		}

		static private UnityEngine.Touch GetSecondaryTouch(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.AndroidInput.GetSecondaryTouch(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AndroidInput.GetSecondaryTouch has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AndroidInput.GetSecondaryTouch has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Touch);
		}

		static private System.Int32 get_touchCountSecondary()
		{
			return UnityEngine.AndroidInput.touchCountSecondary;
		}

		static private System.Boolean get_secondaryTouchEnabled()
		{
			return UnityEngine.AndroidInput.secondaryTouchEnabled;
		}

		static private System.Int32 get_secondaryTouchWidth()
		{
			return UnityEngine.AndroidInput.secondaryTouchWidth;
		}

		static private System.Int32 get_secondaryTouchHeight()
		{
			return UnityEngine.AndroidInput.secondaryTouchHeight;
		}

	}
}
#endif
