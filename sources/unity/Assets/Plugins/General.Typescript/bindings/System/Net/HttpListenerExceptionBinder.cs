using UnityEngine;

namespace General.Typescript
{
	public class SystemNetHttpListenerException
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.HttpListenerException> self = space.DeclareClass<System.Net.HttpListenerException>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("ErrorCode", get_ErrorCode, null);
		}

		static private System.Net.HttpListenerException Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.HttpListenerException();
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return new System.Net.HttpListenerException(parameters[0].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.Int32, System.String>())
			{
				return new System.Net.HttpListenerException(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.String>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.HttpListenerException.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.HttpListenerException);
		}

		static private System.Int32 get_ErrorCode(System.Net.HttpListenerException instance)
		{
			return instance.ErrorCode;
		}

	}
}
