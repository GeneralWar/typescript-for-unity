using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineColor32
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Color32> self = space.DeclareClass<UnityEngine.Color32>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("Lerp", Lerp);
			self.BindStaticFunction("LerpUnclamped", LerpUnclamped);
			self.BindInstanceFunction("ToString", ToString);
		}

		static private UnityEngine.Color32 Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Byte, System.Byte, System.Byte, System.Byte>())
			{
				return new UnityEngine.Color32(parameters[0].ToObject<System.Byte>(), parameters[1].ToObject<System.Byte>(), parameters[2].ToObject<System.Byte>(), parameters[3].ToObject<System.Byte>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Color32.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Color32.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Color32);
		}

		static private UnityEngine.Color32 Lerp(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Color32, UnityEngine.Color32, System.Single>())
			{
				return UnityEngine.Color32.Lerp(parameters[0].ToObject<UnityEngine.Color32>(), parameters[1].ToObject<UnityEngine.Color32>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Color32.Lerp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Color32.Lerp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Color32);
		}

		static private UnityEngine.Color32 LerpUnclamped(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Color32, UnityEngine.Color32, System.Single>())
			{
				return UnityEngine.Color32.LerpUnclamped(parameters[0].ToObject<UnityEngine.Color32>(), parameters[1].ToObject<UnityEngine.Color32>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Color32.LerpUnclamped has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Color32.LerpUnclamped has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Color32);
		}

		static private System.String ToString(UnityEngine.Color32 instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return instance.ToString(parameters[0].ToObject<System.String>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Color32.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

	}
}
