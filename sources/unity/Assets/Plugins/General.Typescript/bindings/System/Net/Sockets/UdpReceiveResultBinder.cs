using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsUdpReceiveResult
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Sockets.UdpReceiveResult> self = space.DeclareClass<System.Net.Sockets.UdpReceiveResult>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceProperty("Buffer", get_Buffer, null);
			self.BindInstanceProperty("RemoteEndPoint", get_RemoteEndPoint, null);
		}

		static private System.Net.Sockets.UdpReceiveResult Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte[], System.Net.IPEndPoint>())
			{
				return new System.Net.Sockets.UdpReceiveResult(parameters[0].ToObject<System.Byte[]>(), parameters[1].ToObject<System.Net.IPEndPoint>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.UdpReceiveResult.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.UdpReceiveResult.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Net.Sockets.UdpReceiveResult);
		}

		static private System.Boolean Equals(System.Net.Sockets.UdpReceiveResult instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<System.Net.Sockets.UdpReceiveResult>())
			{
				return instance.Equals(parameters[0].ToObject<System.Net.Sockets.UdpReceiveResult>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.Sockets.UdpReceiveResult.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.UdpReceiveResult.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(System.Net.Sockets.UdpReceiveResult instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetHashCode();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Sockets.UdpReceiveResult.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Byte[] get_Buffer(System.Net.Sockets.UdpReceiveResult instance)
		{
			return instance.Buffer;
		}

		static private System.Net.IPEndPoint get_RemoteEndPoint(System.Net.Sockets.UdpReceiveResult instance)
		{
			return instance.RemoteEndPoint;
		}

	}
}
