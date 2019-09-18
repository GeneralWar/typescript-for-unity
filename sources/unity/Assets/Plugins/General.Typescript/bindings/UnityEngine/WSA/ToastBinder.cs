#if UNITY_WSA
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineWSAToast
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.WSA.Toast> self = space.DeclareClass<UnityEngine.WSA.Toast>();
			self.BindConstructor();
			self.BindStaticFunction("Create", Create);
			self.BindStaticFunction("GetTemplate", GetTemplate);
			self.BindInstanceFunction("Hide", Hide);
			self.BindInstanceFunction("Show", Show);
			self.BindInstanceProperty("arguments", get_arguments, set_arguments);
			self.BindInstanceProperty("activated", get_activated, null);
			self.BindInstanceProperty("dismissed", get_dismissed, null);
			self.BindInstanceProperty("dismissedByUser", get_dismissedByUser, null);
		}

		static private UnityEngine.WSA.Toast Create(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.WSA.Toast.Create(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.String>())
			{
				return UnityEngine.WSA.Toast.Create(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WSA.Toast.Create has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Toast.Create has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.String GetTemplate(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.WSA.ToastTemplate>())
			{
				return UnityEngine.WSA.Toast.GetTemplate(parameters[0].ToObject<UnityEngine.WSA.ToastTemplate>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.WSA.Toast.GetTemplate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Toast.GetTemplate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void Hide(UnityEngine.WSA.Toast instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Hide();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Toast.Hide has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Show(UnityEngine.WSA.Toast instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Show();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.WSA.Toast.Show has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.String get_arguments(UnityEngine.WSA.Toast instance)
		{
			return instance.arguments;
		}

		static private void set_arguments(UnityEngine.WSA.Toast instance, System.String value)
		{
			instance.arguments = value;
		}

		static private System.Boolean get_activated(UnityEngine.WSA.Toast instance)
		{
			return instance.activated;
		}

		static private System.Boolean get_dismissed(UnityEngine.WSA.Toast instance)
		{
			return instance.dismissed;
		}

		static private System.Boolean get_dismissedByUser(UnityEngine.WSA.Toast instance)
		{
			return instance.dismissedByUser;
		}

	}
}
#endif
