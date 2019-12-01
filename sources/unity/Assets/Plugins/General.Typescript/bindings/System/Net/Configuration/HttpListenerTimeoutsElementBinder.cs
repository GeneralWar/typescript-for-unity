using UnityEngine;

namespace General.Typescript
{
	public class SystemNetConfigurationHttpListenerTimeoutsElement
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Configuration.HttpListenerTimeoutsElement> self = space.DeclareClass<System.Net.Configuration.HttpListenerTimeoutsElement>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("DrainEntityBody", get_DrainEntityBody, null);
			self.BindInstanceProperty("EntityBody", get_EntityBody, null);
			self.BindInstanceProperty("HeaderWait", get_HeaderWait, null);
			self.BindInstanceProperty("IdleConnection", get_IdleConnection, null);
			self.BindInstanceProperty("MinSendBytesPerSecond", get_MinSendBytesPerSecond, null);
			self.BindInstanceProperty("RequestQueue", get_RequestQueue, null);
		}

		static private System.Net.Configuration.HttpListenerTimeoutsElement Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.Configuration.HttpListenerTimeoutsElement();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Configuration.HttpListenerTimeoutsElement.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.Configuration.HttpListenerTimeoutsElement);
		}

		static private System.TimeSpan get_DrainEntityBody(System.Net.Configuration.HttpListenerTimeoutsElement instance)
		{
			return instance.DrainEntityBody;
		}

		static private System.TimeSpan get_EntityBody(System.Net.Configuration.HttpListenerTimeoutsElement instance)
		{
			return instance.EntityBody;
		}

		static private System.TimeSpan get_HeaderWait(System.Net.Configuration.HttpListenerTimeoutsElement instance)
		{
			return instance.HeaderWait;
		}

		static private System.TimeSpan get_IdleConnection(System.Net.Configuration.HttpListenerTimeoutsElement instance)
		{
			return instance.IdleConnection;
		}

		static private System.Int64 get_MinSendBytesPerSecond(System.Net.Configuration.HttpListenerTimeoutsElement instance)
		{
			return instance.MinSendBytesPerSecond;
		}

		static private System.TimeSpan get_RequestQueue(System.Net.Configuration.HttpListenerTimeoutsElement instance)
		{
			return instance.RequestQueue;
		}

	}
}
