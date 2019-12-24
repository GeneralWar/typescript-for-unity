using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsSocketException
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Sockets.SocketException> self = space.DeclareClass<System.Net.Sockets.SocketException>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("ErrorCode", get_ErrorCode, null);
			self.BindInstanceProperty("Message", get_Message, null);
			self.BindInstanceProperty("SocketErrorCode", get_SocketErrorCode, null);
		}

		static private System.Net.Sockets.SocketException Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.Sockets.SocketException();
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return new System.Net.Sockets.SocketException(parameters[0].ToObject<System.Int32>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.SocketException.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.Sockets.SocketException);
		}

		static private System.Int32 get_ErrorCode(System.Net.Sockets.SocketException instance, string name)
		{
			return instance.ErrorCode;
		}

		static private System.String get_Message(System.Net.Sockets.SocketException instance, string name)
		{
			return instance.Message;
		}

		static private System.Net.Sockets.SocketError get_SocketErrorCode(System.Net.Sockets.SocketException instance, string name)
		{
			return instance.SocketErrorCode;
		}

	}
}
