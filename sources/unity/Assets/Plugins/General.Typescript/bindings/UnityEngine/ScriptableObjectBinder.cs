using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineScriptableObject
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.ScriptableObject> self = space.DeclareClass<UnityEngine.ScriptableObject, UnityEngine.Object>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("CreateInstance", CreateInstance);
		}

		static private UnityEngine.ScriptableObject Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.ScriptableObject();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.ScriptableObject.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.ScriptableObject);
		}

		static private System.Object CreateInstance(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type>())
			{
				return UnityEngine.ScriptableObject.CreateInstance(parameters[0].ToObject<System.Type>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.ScriptableObject.CreateInstance(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ScriptableObject.CreateInstance has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ScriptableObject.CreateInstance has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

	}
}
