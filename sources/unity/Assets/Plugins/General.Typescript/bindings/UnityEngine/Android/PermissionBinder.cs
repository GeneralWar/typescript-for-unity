#if UNITY_ANDROID
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAndroidPermission
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Android.Permission> self = space.DeclareClass<UnityEngine.Android.Permission>();
			self.BindConstructor();
			self.BindStaticFunction("HasUserAuthorizedPermission", HasUserAuthorizedPermission);
			self.BindStaticFunction("RequestUserPermission", RequestUserPermission);
		}

		static private System.Boolean HasUserAuthorizedPermission(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Android.Permission.HasUserAuthorizedPermission(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Android.Permission.HasUserAuthorizedPermission has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Android.Permission.HasUserAuthorizedPermission has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void RequestUserPermission(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				UnityEngine.Android.Permission.RequestUserPermission(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Android.Permission.RequestUserPermission has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Android.Permission.RequestUserPermission has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

	}
}
#endif
