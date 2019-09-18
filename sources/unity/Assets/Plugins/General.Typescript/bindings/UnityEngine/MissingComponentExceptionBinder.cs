using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMissingComponentException
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.MissingComponentException> self = space.DeclareClass<UnityEngine.MissingComponentException>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.MissingComponentException Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.MissingComponentException();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return new UnityEngine.MissingComponentException(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Exception>())
			{
				return new UnityEngine.MissingComponentException(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Exception>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.MissingComponentException.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.MissingComponentException);
		}

	}
}
