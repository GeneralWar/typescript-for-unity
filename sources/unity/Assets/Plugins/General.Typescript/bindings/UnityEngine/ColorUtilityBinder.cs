using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineColorUtility
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.ColorUtility> self = space.DeclareClass<UnityEngine.ColorUtility>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("ToHtmlStringRGB", ToHtmlStringRGB);
			self.BindStaticFunction("ToHtmlStringRGBA", ToHtmlStringRGBA);
		}

		static private UnityEngine.ColorUtility Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.ColorUtility();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.ColorUtility.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.ColorUtility);
		}

		static private System.String ToHtmlStringRGB(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Color>())
			{
				return UnityEngine.ColorUtility.ToHtmlStringRGB(parameters[0].ToObject<UnityEngine.Color>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ColorUtility.ToHtmlStringRGB has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ColorUtility.ToHtmlStringRGB has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.String ToHtmlStringRGBA(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Color>())
			{
				return UnityEngine.ColorUtility.ToHtmlStringRGBA(parameters[0].ToObject<UnityEngine.Color>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.ColorUtility.ToHtmlStringRGBA has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.ColorUtility.ToHtmlStringRGBA has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

	}
}
