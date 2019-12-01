using UnityEngine;

namespace General.Typescript
{
	public class SystemNetWebSocketsWebSocketReceiveResult
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.WebSockets.WebSocketReceiveResult> self = space.DeclareClass<System.Net.WebSockets.WebSocketReceiveResult>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("Count", get_Count, null);
			self.BindInstanceProperty("EndOfMessage", get_EndOfMessage, null);
			self.BindInstanceProperty("MessageType", get_MessageType, null);
			self.BindInstanceProperty("CloseStatusDescription", get_CloseStatusDescription, null);
		}

		static private System.Net.WebSockets.WebSocketReceiveResult Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Net.WebSockets.WebSocketMessageType, System.Boolean>())
			{
				return new System.Net.WebSockets.WebSocketReceiveResult(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Net.WebSockets.WebSocketMessageType>(), parameters[2].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebSockets.WebSocketReceiveResult.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebSockets.WebSocketReceiveResult.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Net.WebSockets.WebSocketReceiveResult);
		}

		static private System.Int32 get_Count(System.Net.WebSockets.WebSocketReceiveResult instance)
		{
			return instance.Count;
		}

		static private System.Boolean get_EndOfMessage(System.Net.WebSockets.WebSocketReceiveResult instance)
		{
			return instance.EndOfMessage;
		}

		static private System.Net.WebSockets.WebSocketMessageType get_MessageType(System.Net.WebSockets.WebSocketReceiveResult instance)
		{
			return instance.MessageType;
		}

		static private System.String get_CloseStatusDescription(System.Net.WebSockets.WebSocketReceiveResult instance)
		{
			return instance.CloseStatusDescription;
		}

	}
}
