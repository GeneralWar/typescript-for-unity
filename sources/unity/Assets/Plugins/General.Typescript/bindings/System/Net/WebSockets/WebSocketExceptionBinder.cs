using UnityEngine;

namespace General.Typescript
{
	public class SystemNetWebSocketsWebSocketException
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.WebSockets.WebSocketException> self = space.DeclareClass<System.Net.WebSockets.WebSocketException>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("GetObjectData", GetObjectData);
			self.BindInstanceProperty("ErrorCode", get_ErrorCode, null);
			self.BindInstanceProperty("WebSocketErrorCode", get_WebSocketErrorCode, null);
		}

		static private System.Net.WebSockets.WebSocketException Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.WebSockets.WebSocketException();
			}
			if (parameters.CheckTypes<System.Net.WebSockets.WebSocketError>())
			{
				return new System.Net.WebSockets.WebSocketException(parameters[0].ToObject<System.Net.WebSockets.WebSocketError>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return new System.Net.WebSockets.WebSocketException(parameters[0].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return new System.Net.WebSockets.WebSocketException(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Net.WebSockets.WebSocketError, System.String>())
			{
				return new System.Net.WebSockets.WebSocketException(parameters[0].ToObject<System.Net.WebSockets.WebSocketError>(), parameters[1].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Net.WebSockets.WebSocketError, System.Exception>())
			{
				return new System.Net.WebSockets.WebSocketException(parameters[0].ToObject<System.Net.WebSockets.WebSocketError>(), parameters[1].ToObject<System.Exception>());
			}
			if (parameters.CheckTypes<System.Int32, System.String>())
			{
				return new System.Net.WebSockets.WebSocketException(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32, System.Exception>())
			{
				return new System.Net.WebSockets.WebSocketException(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Exception>());
			}
			if (parameters.CheckTypes<System.Net.WebSockets.WebSocketError, System.Int32>())
			{
				return new System.Net.WebSockets.WebSocketException(parameters[0].ToObject<System.Net.WebSockets.WebSocketError>(), parameters[1].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.String, System.Exception>())
			{
				return new System.Net.WebSockets.WebSocketException(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Exception>());
			}
			if (parameters.CheckTypes<System.Net.WebSockets.WebSocketError, System.String, System.Exception>())
			{
				return new System.Net.WebSockets.WebSocketException(parameters[0].ToObject<System.Net.WebSockets.WebSocketError>(), parameters[1].ToObject<System.String>(), parameters[2].ToObject<System.Exception>());
			}
			if (parameters.CheckTypes<System.Net.WebSockets.WebSocketError, System.Int32, System.String>())
			{
				return new System.Net.WebSockets.WebSocketException(parameters[0].ToObject<System.Net.WebSockets.WebSocketError>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Net.WebSockets.WebSocketError, System.Int32, System.Exception>())
			{
				return new System.Net.WebSockets.WebSocketException(parameters[0].ToObject<System.Net.WebSockets.WebSocketError>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Exception>());
			}
			if (parameters.CheckTypes<System.Net.WebSockets.WebSocketError, System.Int32, System.String, System.Exception>())
			{
				return new System.Net.WebSockets.WebSocketException(parameters[0].ToObject<System.Net.WebSockets.WebSocketError>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.String>(), parameters[3].ToObject<System.Exception>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.WebSockets.WebSocketException.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.WebSockets.WebSocketException);
		}

		static private void GetObjectData(System.Net.WebSockets.WebSocketException instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Runtime.Serialization.SerializationInfo, System.Runtime.Serialization.StreamingContext>())
			{
				instance.GetObjectData(parameters[0].ToObject<System.Runtime.Serialization.SerializationInfo>(), parameters[1].ToObject<System.Runtime.Serialization.StreamingContext>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.WebSockets.WebSocketException.GetObjectData has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.WebSockets.WebSocketException.GetObjectData has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Int32 get_ErrorCode(System.Net.WebSockets.WebSocketException instance)
		{
			return instance.ErrorCode;
		}

		static private System.Net.WebSockets.WebSocketError get_WebSocketErrorCode(System.Net.WebSockets.WebSocketException instance)
		{
			return instance.WebSocketErrorCode;
		}

	}
}
