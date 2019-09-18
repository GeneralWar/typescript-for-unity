using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMissingReferenceException
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.MissingReferenceException> self = space.DeclareClass<UnityEngine.MissingReferenceException>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.MissingReferenceException Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.MissingReferenceException();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return new UnityEngine.MissingReferenceException(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Exception>())
			{
				return new UnityEngine.MissingReferenceException(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Exception>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.MissingReferenceException.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.MissingReferenceException);
		}

	}
}
