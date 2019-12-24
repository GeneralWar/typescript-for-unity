using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineRandom
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Random> self = space.DeclareClass<UnityEngine.Random>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("ColorHSV", ColorHSV);
			self.BindStaticFunction("InitState", InitState);
			self.BindStaticFunction("Range", Range);
			self.BindStaticProperty("value", get_value, null);
			self.BindStaticProperty("insideUnitSphere", get_insideUnitSphere, null);
			self.BindStaticProperty("insideUnitCircle", get_insideUnitCircle, null);
			self.BindStaticProperty("onUnitSphere", get_onUnitSphere, null);
			self.BindStaticProperty("rotation", get_rotation, null);
			self.BindStaticProperty("rotationUniform", get_rotationUniform, null);
		}

		static private UnityEngine.Random Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Random();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Random.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Random);
		}

		static private UnityEngine.Color ColorHSV(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.Random.ColorHSV();
			}
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return UnityEngine.Random.ColorHSV(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Random.ColorHSV(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Random.ColorHSV(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single, System.Single, System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Random.ColorHSV(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>(), parameters[4].ToObject<System.Single>(), parameters[5].ToObject<System.Single>(), parameters[6].ToObject<System.Single>(), parameters[7].ToObject<System.Single>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Random.ColorHSV has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Color);
		}

		static private void InitState(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				UnityEngine.Random.InitState(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Random.InitState has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Random.InitState has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Object Range(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return UnityEngine.Random.Range(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return UnityEngine.Random.Range(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Random.Range has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Random.Range has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Single get_value(Type type, string name)
		{
			return UnityEngine.Random.value;
		}

		static private UnityEngine.Vector3 get_insideUnitSphere(Type type, string name)
		{
			return UnityEngine.Random.insideUnitSphere;
		}

		static private UnityEngine.Vector2 get_insideUnitCircle(Type type, string name)
		{
			return UnityEngine.Random.insideUnitCircle;
		}

		static private UnityEngine.Vector3 get_onUnitSphere(Type type, string name)
		{
			return UnityEngine.Random.onUnitSphere;
		}

		static private UnityEngine.Quaternion get_rotation(Type type, string name)
		{
			return UnityEngine.Random.rotation;
		}

		static private UnityEngine.Quaternion get_rotationUniform(Type type, string name)
		{
			return UnityEngine.Random.rotationUniform;
		}

	}
}
