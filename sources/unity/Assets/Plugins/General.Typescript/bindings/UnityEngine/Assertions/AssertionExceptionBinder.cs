using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAssertionsAssertionException
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Assertions.AssertionException> self = space.DeclareClass<UnityEngine.Assertions.AssertionException>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("Message", get_Message, null);
		}

		static private UnityEngine.Assertions.AssertionException Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.String>())
			{
				return new UnityEngine.Assertions.AssertionException(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Assertions.AssertionException.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Assertions.AssertionException.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Assertions.AssertionException);
		}

		static private System.String get_Message(UnityEngine.Assertions.AssertionException instance)
		{
			return instance.Message;
		}

	}
}
