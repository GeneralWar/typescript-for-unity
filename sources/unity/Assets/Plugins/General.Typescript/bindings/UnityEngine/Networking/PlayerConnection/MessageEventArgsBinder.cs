using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineNetworkingPlayerConnectionMessageEventArgs
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Networking.PlayerConnection.MessageEventArgs> self = space.DeclareClass<UnityEngine.Networking.PlayerConnection.MessageEventArgs>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.Networking.PlayerConnection.MessageEventArgs Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Networking.PlayerConnection.MessageEventArgs();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Networking.PlayerConnection.MessageEventArgs.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Networking.PlayerConnection.MessageEventArgs);
		}

	}
}
