using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineGradient
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Gradient> self = space.DeclareClass<UnityEngine.Gradient>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("Evaluate", Evaluate);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("SetKeys", SetKeys);
			self.BindInstanceProperty("colorKeys", get_colorKeys, set_colorKeys);
			self.BindInstanceProperty("alphaKeys", get_alphaKeys, set_alphaKeys);
			self.BindInstanceProperty("mode", get_mode, set_mode);
		}

		static private UnityEngine.Gradient Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Gradient();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Gradient.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Gradient);
		}

		static private System.Boolean Equals(UnityEngine.Gradient instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.Gradient>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Gradient>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Gradient.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Gradient.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.Color Evaluate(UnityEngine.Gradient instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return instance.Evaluate(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Gradient.Evaluate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Gradient.Evaluate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Color);
		}

		static private System.Int32 GetHashCode(UnityEngine.Gradient instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetHashCode();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Gradient.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private void SetKeys(UnityEngine.Gradient instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.GradientColorKey[], UnityEngine.GradientAlphaKey[]>())
			{
				instance.SetKeys(parameters[0].ToObject<UnityEngine.GradientColorKey[]>(), parameters[1].ToObject<UnityEngine.GradientAlphaKey[]>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Gradient.SetKeys has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Gradient.SetKeys has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.GradientColorKey[] get_colorKeys(UnityEngine.Gradient instance, string name)
		{
			return instance.colorKeys;
		}

		static private void set_colorKeys(UnityEngine.Gradient instance, string name, UnityEngine.GradientColorKey[] value)
		{
			instance.colorKeys = value;
		}

		static private UnityEngine.GradientAlphaKey[] get_alphaKeys(UnityEngine.Gradient instance, string name)
		{
			return instance.alphaKeys;
		}

		static private void set_alphaKeys(UnityEngine.Gradient instance, string name, UnityEngine.GradientAlphaKey[] value)
		{
			instance.alphaKeys = value;
		}

		static private UnityEngine.GradientMode get_mode(UnityEngine.Gradient instance, string name)
		{
			return instance.mode;
		}

		static private void set_mode(UnityEngine.Gradient instance, string name, UnityEngine.GradientMode value)
		{
			instance.mode = value;
		}

	}
}
