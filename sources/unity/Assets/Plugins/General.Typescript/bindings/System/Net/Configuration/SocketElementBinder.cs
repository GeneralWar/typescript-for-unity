using UnityEngine;

namespace General.Typescript
{
	public class SystemNetConfigurationSocketElement
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Configuration.SocketElement> self = space.DeclareClass<System.Net.Configuration.SocketElement>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("AlwaysUseCompletionPortsForAccept", get_AlwaysUseCompletionPortsForAccept, set_AlwaysUseCompletionPortsForAccept);
			self.BindInstanceProperty("AlwaysUseCompletionPortsForConnect", get_AlwaysUseCompletionPortsForConnect, set_AlwaysUseCompletionPortsForConnect);
			self.BindInstanceProperty("IPProtectionLevel", get_IPProtectionLevel, set_IPProtectionLevel);
		}

		static private System.Net.Configuration.SocketElement Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.Configuration.SocketElement();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Configuration.SocketElement.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.Configuration.SocketElement);
		}

		static private System.Boolean get_AlwaysUseCompletionPortsForAccept(System.Net.Configuration.SocketElement instance)
		{
			return instance.AlwaysUseCompletionPortsForAccept;
		}

		static private void set_AlwaysUseCompletionPortsForAccept(System.Net.Configuration.SocketElement instance, System.Boolean value)
		{
			instance.AlwaysUseCompletionPortsForAccept = value;
		}

		static private System.Boolean get_AlwaysUseCompletionPortsForConnect(System.Net.Configuration.SocketElement instance)
		{
			return instance.AlwaysUseCompletionPortsForConnect;
		}

		static private void set_AlwaysUseCompletionPortsForConnect(System.Net.Configuration.SocketElement instance, System.Boolean value)
		{
			instance.AlwaysUseCompletionPortsForConnect = value;
		}

		static private System.Net.Sockets.IPProtectionLevel get_IPProtectionLevel(System.Net.Configuration.SocketElement instance)
		{
			return instance.IPProtectionLevel;
		}

		static private void set_IPProtectionLevel(System.Net.Configuration.SocketElement instance, System.Net.Sockets.IPProtectionLevel value)
		{
			instance.IPProtectionLevel = value;
		}

	}
}
