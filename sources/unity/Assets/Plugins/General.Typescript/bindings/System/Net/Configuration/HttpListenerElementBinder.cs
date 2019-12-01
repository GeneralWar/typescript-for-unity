using UnityEngine;

namespace General.Typescript
{
	public class SystemNetConfigurationHttpListenerElement
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Configuration.HttpListenerElement> self = space.DeclareClass<System.Net.Configuration.HttpListenerElement>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("Timeouts", get_Timeouts, null);
			self.BindInstanceProperty("UnescapeRequestUrl", get_UnescapeRequestUrl, null);
		}

		static private System.Net.Configuration.HttpListenerElement Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.Configuration.HttpListenerElement();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Configuration.HttpListenerElement.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.Configuration.HttpListenerElement);
		}

		static private System.Net.Configuration.HttpListenerTimeoutsElement get_Timeouts(System.Net.Configuration.HttpListenerElement instance)
		{
			return instance.Timeouts;
		}

		static private System.Boolean get_UnescapeRequestUrl(System.Net.Configuration.HttpListenerElement instance)
		{
			return instance.UnescapeRequestUrl;
		}

	}
}
