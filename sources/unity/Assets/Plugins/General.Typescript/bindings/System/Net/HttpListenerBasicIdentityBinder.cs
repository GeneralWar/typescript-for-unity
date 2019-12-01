using UnityEngine;

namespace General.Typescript
{
	public class SystemNetHttpListenerBasicIdentity
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.HttpListenerBasicIdentity> self = space.DeclareClass<System.Net.HttpListenerBasicIdentity>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("Password", get_Password, null);
		}

		static private System.Net.HttpListenerBasicIdentity Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.String>())
			{
				return new System.Net.HttpListenerBasicIdentity(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("System.Net.HttpListenerBasicIdentity.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("System.Net.HttpListenerBasicIdentity.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Net.HttpListenerBasicIdentity);
		}

		static private System.String get_Password(System.Net.HttpListenerBasicIdentity instance)
		{
			return instance.Password;
		}

	}
}
