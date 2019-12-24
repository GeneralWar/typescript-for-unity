using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineColor
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Color> self = space.DeclareClass<UnityEngine.Color>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("HSVToRGB", HSVToRGB);
			self.BindStaticFunction("Lerp", Lerp);
			self.BindStaticFunction("LerpUnclamped", LerpUnclamped);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("ToString", ToString);
			self.BindStaticProperty("red", get_red, null);
			self.BindStaticProperty("green", get_green, null);
			self.BindStaticProperty("blue", get_blue, null);
			self.BindStaticProperty("white", get_white, null);
			self.BindStaticProperty("black", get_black, null);
			self.BindStaticProperty("yellow", get_yellow, null);
			self.BindStaticProperty("cyan", get_cyan, null);
			self.BindStaticProperty("magenta", get_magenta, null);
			self.BindStaticProperty("gray", get_gray, null);
			self.BindStaticProperty("grey", get_grey, null);
			self.BindStaticProperty("clear", get_clear, null);
			self.BindInstanceProperty("grayscale", get_grayscale, null);
			self.BindInstanceProperty("linear", get_linear, null);
			self.BindInstanceProperty("gamma", get_gamma, null);
			self.BindInstanceProperty("maxColorComponent", get_maxColorComponent, null);
		}

		static private UnityEngine.Color Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return new UnityEngine.Color(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single>())
			{
				return new UnityEngine.Color(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Color.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Color.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Color);
		}

		static private UnityEngine.Color HSVToRGB(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Color.HSVToRGB(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Boolean>())
			{
				return UnityEngine.Color.HSVToRGB(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Color.HSVToRGB has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Color.HSVToRGB has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Color);
		}

		static private UnityEngine.Color Lerp(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Color, UnityEngine.Color, System.Single>())
			{
				return UnityEngine.Color.Lerp(parameters[0].ToObject<UnityEngine.Color>(), parameters[1].ToObject<UnityEngine.Color>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Color.Lerp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Color.Lerp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Color);
		}

		static private UnityEngine.Color LerpUnclamped(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Color, UnityEngine.Color, System.Single>())
			{
				return UnityEngine.Color.LerpUnclamped(parameters[0].ToObject<UnityEngine.Color>(), parameters[1].ToObject<UnityEngine.Color>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Color.LerpUnclamped has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Color.LerpUnclamped has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Color);
		}

		static private System.Boolean Equals(UnityEngine.Color instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.Color>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Color>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Color.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Color.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.Color instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Color.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.String ToString(UnityEngine.Color instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Color.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Color get_red(Type type, string name)
		{
			return UnityEngine.Color.red;
		}

		static private UnityEngine.Color get_green(Type type, string name)
		{
			return UnityEngine.Color.green;
		}

		static private UnityEngine.Color get_blue(Type type, string name)
		{
			return UnityEngine.Color.blue;
		}

		static private UnityEngine.Color get_white(Type type, string name)
		{
			return UnityEngine.Color.white;
		}

		static private UnityEngine.Color get_black(Type type, string name)
		{
			return UnityEngine.Color.black;
		}

		static private UnityEngine.Color get_yellow(Type type, string name)
		{
			return UnityEngine.Color.yellow;
		}

		static private UnityEngine.Color get_cyan(Type type, string name)
		{
			return UnityEngine.Color.cyan;
		}

		static private UnityEngine.Color get_magenta(Type type, string name)
		{
			return UnityEngine.Color.magenta;
		}

		static private UnityEngine.Color get_gray(Type type, string name)
		{
			return UnityEngine.Color.gray;
		}

		static private UnityEngine.Color get_grey(Type type, string name)
		{
			return UnityEngine.Color.grey;
		}

		static private UnityEngine.Color get_clear(Type type, string name)
		{
			return UnityEngine.Color.clear;
		}

		static private System.Single get_grayscale(UnityEngine.Color instance, string name)
		{
			return instance.grayscale;
		}

		static private UnityEngine.Color get_linear(UnityEngine.Color instance, string name)
		{
			return instance.linear;
		}

		static private UnityEngine.Color get_gamma(UnityEngine.Color instance, string name)
		{
			return instance.gamma;
		}

		static private System.Single get_maxColorComponent(UnityEngine.Color instance, string name)
		{
			return instance.maxColorComponent;
		}

	}
}
