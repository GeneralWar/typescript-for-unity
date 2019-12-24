using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemNetWebSocketsClientWebSocket
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.WebSockets.ClientWebSocket> self = space.DeclareClass<System.Net.WebSockets.ClientWebSocket>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Abort", Abort);
			self.BindInstanceFunction("CloseAsync", CloseAsync);
			self.BindInstanceFunction("CloseOutputAsync", CloseOutputAsync);
			self.BindInstanceFunction("ConnectAsync", ConnectAsync);
			self.BindInstanceFunction("Dispose", Dispose);
			self.BindInstanceProperty("Options", get_Options, null);
			self.BindInstanceProperty("CloseStatusDescription", get_CloseStatusDescription, null);
			self.BindInstanceProperty("SubProtocol", get_SubProtocol, null);
			self.BindInstanceProperty("State", get_State, null);
		}

		static private System.Net.WebSockets.ClientWebSocket Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.WebSockets.ClientWebSocket();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.WebSockets.ClientWebSocket.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.WebSockets.ClientWebSocket);
		}

		static private void Abort(System.Net.WebSockets.ClientWebSocket instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Abort();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.WebSockets.ClientWebSocket.Abort has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Threading.Tasks.Task CloseAsync(System.Net.WebSockets.ClientWebSocket instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.WebSockets.WebSocketCloseStatus, System.String, System.Threading.CancellationToken>())
			{
				return instance.CloseAsync(parameters[0].ToObject<System.Net.WebSockets.WebSocketCloseStatus>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Threading.CancellationToken>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebSockets.ClientWebSocket.CloseAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebSockets.ClientWebSocket.CloseAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Threading.Tasks.Task CloseOutputAsync(System.Net.WebSockets.ClientWebSocket instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Net.WebSockets.WebSocketCloseStatus, System.String, System.Threading.CancellationToken>())
			{
				return instance.CloseOutputAsync(parameters[0].ToObject<System.Net.WebSockets.WebSocketCloseStatus>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Threading.CancellationToken>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebSockets.ClientWebSocket.CloseOutputAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebSockets.ClientWebSocket.CloseOutputAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Threading.Tasks.Task ConnectAsync(System.Net.WebSockets.ClientWebSocket instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Uri, System.Threading.CancellationToken>())
			{
				return instance.ConnectAsync(parameters[0].ToObject<System.Uri>(), parameters[1].ToObject<System.Threading.CancellationToken>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebSockets.ClientWebSocket.ConnectAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebSockets.ClientWebSocket.ConnectAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void Dispose(System.Net.WebSockets.ClientWebSocket instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Dispose();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.WebSockets.ClientWebSocket.Dispose has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private System.Net.WebSockets.ClientWebSocketOptions get_Options(System.Net.WebSockets.ClientWebSocket instance, string name)
		{
			return instance.Options;
		}

		static private System.String get_CloseStatusDescription(System.Net.WebSockets.ClientWebSocket instance, string name)
		{
			return instance.CloseStatusDescription;
		}

		static private System.String get_SubProtocol(System.Net.WebSockets.ClientWebSocket instance, string name)
		{
			return instance.SubProtocol;
		}

		static private System.Net.WebSockets.WebSocketState get_State(System.Net.WebSockets.ClientWebSocket instance, string name)
		{
			return instance.State;
		}

	}
}
