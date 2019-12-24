using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemIOPathTooLongException
	{
		static public void Bind(Namespace space)
		{
			Class<System.IO.PathTooLongException> self = space.DeclareClass<System.IO.PathTooLongException>();
			self.BindConstructor(Constructor);
		}

		static private System.IO.PathTooLongException Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.IO.PathTooLongException();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return new System.IO.PathTooLongException(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Exception>())
			{
				return new System.IO.PathTooLongException(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Exception>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.IO.PathTooLongException.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.IO.PathTooLongException);
		}

	}
}
