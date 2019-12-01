using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsSocketInformation
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Sockets.SocketInformation> self = space.DeclareClass<System.Net.Sockets.SocketInformation>();
			self.BindConstructor();
			self.BindInstanceProperty("ProtocolInformation", get_ProtocolInformation, set_ProtocolInformation);
			self.BindInstanceProperty("Options", get_Options, set_Options);
		}

		static private System.Byte[] get_ProtocolInformation(System.Net.Sockets.SocketInformation instance)
		{
			return instance.ProtocolInformation;
		}

		static private void set_ProtocolInformation(System.Net.Sockets.SocketInformation instance, System.Byte[] value)
		{
			instance.ProtocolInformation = value;
		}

		static private System.Net.Sockets.SocketInformationOptions get_Options(System.Net.Sockets.SocketInformation instance)
		{
			return instance.Options;
		}

		static private void set_Options(System.Net.Sockets.SocketInformation instance, System.Net.Sockets.SocketInformationOptions value)
		{
			instance.Options = value;
		}

	}
}
