using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineUnassignedReferenceException
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.UnassignedReferenceException> self = space.DeclareClass<UnityEngine.UnassignedReferenceException>();
			self.BindConstructor(Constructor);
		}

		static private UnityEngine.UnassignedReferenceException Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.UnassignedReferenceException();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return new UnityEngine.UnassignedReferenceException(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Exception>())
			{
				return new UnityEngine.UnassignedReferenceException(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Exception>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.UnassignedReferenceException.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.UnassignedReferenceException);
		}

	}
}
