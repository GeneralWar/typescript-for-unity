using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineMathf
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Mathf> self = space.DeclareClass<UnityEngine.Mathf>();
			self.BindConstructor();
			self.BindStaticFunction("Abs", Abs);
			self.BindStaticFunction("Acos", Acos);
			self.BindStaticFunction("Approximately", Approximately);
			self.BindStaticFunction("Asin", Asin);
			self.BindStaticFunction("Atan", Atan);
			self.BindStaticFunction("Atan2", Atan2);
			self.BindStaticFunction("Ceil", Ceil);
			self.BindStaticFunction("CeilToInt", CeilToInt);
			self.BindStaticFunction("Clamp", Clamp);
			self.BindStaticFunction("Clamp01", Clamp01);
			self.BindStaticFunction("ClosestPowerOfTwo", ClosestPowerOfTwo);
			self.BindStaticFunction("CorrelatedColorTemperatureToRGB", CorrelatedColorTemperatureToRGB);
			self.BindStaticFunction("Cos", Cos);
			self.BindStaticFunction("DeltaAngle", DeltaAngle);
			self.BindStaticFunction("Exp", Exp);
			self.BindStaticFunction("FloatToHalf", FloatToHalf);
			self.BindStaticFunction("Floor", Floor);
			self.BindStaticFunction("FloorToInt", FloorToInt);
			self.BindStaticFunction("Gamma", Gamma);
			self.BindStaticFunction("GammaToLinearSpace", GammaToLinearSpace);
			self.BindStaticFunction("HalfToFloat", HalfToFloat);
			self.BindStaticFunction("InverseLerp", InverseLerp);
			self.BindStaticFunction("IsPowerOfTwo", IsPowerOfTwo);
			self.BindStaticFunction("Lerp", Lerp);
			self.BindStaticFunction("LerpAngle", LerpAngle);
			self.BindStaticFunction("LerpUnclamped", LerpUnclamped);
			self.BindStaticFunction("LinearToGammaSpace", LinearToGammaSpace);
			self.BindStaticFunction("Log", Log);
			self.BindStaticFunction("Log10", Log10);
			self.BindStaticFunction("Max", Max);
			self.BindStaticFunction("Min", Min);
			self.BindStaticFunction("MoveTowards", MoveTowards);
			self.BindStaticFunction("MoveTowardsAngle", MoveTowardsAngle);
			self.BindStaticFunction("NextPowerOfTwo", NextPowerOfTwo);
			self.BindStaticFunction("PerlinNoise", PerlinNoise);
			self.BindStaticFunction("PingPong", PingPong);
			self.BindStaticFunction("Pow", Pow);
			self.BindStaticFunction("Repeat", Repeat);
			self.BindStaticFunction("Round", Round);
			self.BindStaticFunction("RoundToInt", RoundToInt);
			self.BindStaticFunction("Sign", Sign);
			self.BindStaticFunction("Sin", Sin);
			self.BindStaticFunction("SmoothStep", SmoothStep);
			self.BindStaticFunction("Sqrt", Sqrt);
			self.BindStaticFunction("Tan", Tan);
		}

		static private System.Object Abs(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.Abs(parameters[0].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Mathf.Abs(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Abs has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Abs has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Single Acos(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.Acos(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Acos has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Acos has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Boolean Approximately(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return UnityEngine.Mathf.Approximately(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Approximately has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Approximately has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Single Asin(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.Asin(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Asin has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Asin has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single Atan(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.Atan(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Atan has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Atan has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single Atan2(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return UnityEngine.Mathf.Atan2(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Atan2 has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Atan2 has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single Ceil(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.Ceil(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Ceil has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Ceil has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Int32 CeilToInt(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.CeilToInt(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.CeilToInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.CeilToInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Object Clamp(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Mathf.Clamp(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32, System.Int32>())
			{
				return UnityEngine.Mathf.Clamp(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>(), parameters[2].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Clamp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Clamp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Single Clamp01(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.Clamp01(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Clamp01 has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Clamp01 has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Int32 ClosestPowerOfTwo(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Mathf.ClosestPowerOfTwo(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.ClosestPowerOfTwo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.ClosestPowerOfTwo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private UnityEngine.Color CorrelatedColorTemperatureToRGB(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.CorrelatedColorTemperatureToRGB(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.CorrelatedColorTemperatureToRGB has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.CorrelatedColorTemperatureToRGB has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Color);
		}

		static private System.Single Cos(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.Cos(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Cos has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Cos has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single DeltaAngle(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return UnityEngine.Mathf.DeltaAngle(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.DeltaAngle has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.DeltaAngle has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single Exp(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.Exp(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Exp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Exp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.UInt16 FloatToHalf(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.FloatToHalf(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.FloatToHalf has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.FloatToHalf has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.UInt16);
		}

		static private System.Single Floor(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.Floor(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Floor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Floor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Int32 FloorToInt(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.FloorToInt(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.FloorToInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.FloorToInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Single Gamma(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Mathf.Gamma(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Gamma has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Gamma has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single GammaToLinearSpace(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.GammaToLinearSpace(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.GammaToLinearSpace has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.GammaToLinearSpace has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single HalfToFloat(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.UInt16>())
			{
				return UnityEngine.Mathf.HalfToFloat(parameters[0].ToObject<System.UInt16>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.HalfToFloat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.HalfToFloat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single InverseLerp(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Mathf.InverseLerp(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.InverseLerp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.InverseLerp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Boolean IsPowerOfTwo(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Mathf.IsPowerOfTwo(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.IsPowerOfTwo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.IsPowerOfTwo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Single Lerp(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Mathf.Lerp(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Lerp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Lerp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single LerpAngle(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Mathf.LerpAngle(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.LerpAngle has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.LerpAngle has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single LerpUnclamped(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Mathf.LerpUnclamped(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.LerpUnclamped has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.LerpUnclamped has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single LinearToGammaSpace(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.LinearToGammaSpace(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.LinearToGammaSpace has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.LinearToGammaSpace has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single Log(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.Log(parameters[0].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return UnityEngine.Mathf.Log(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Log has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Log has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single Log10(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.Log10(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Log10 has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Log10 has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Object Max(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single[]>())
			{
				return UnityEngine.Mathf.Max(parameters[0].ToObject<System.Single[]>());
			}
			if (parameters.CheckTypes<System.Int32[]>())
			{
				return UnityEngine.Mathf.Max(parameters[0].ToObject<System.Int32[]>());
			}
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return UnityEngine.Mathf.Max(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return UnityEngine.Mathf.Max(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Max has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Max has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Object Min(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single[]>())
			{
				return UnityEngine.Mathf.Min(parameters[0].ToObject<System.Single[]>());
			}
			if (parameters.CheckTypes<System.Int32[]>())
			{
				return UnityEngine.Mathf.Min(parameters[0].ToObject<System.Int32[]>());
			}
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return UnityEngine.Mathf.Min(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return UnityEngine.Mathf.Min(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Min has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Min has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Single MoveTowards(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Mathf.MoveTowards(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.MoveTowards has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.MoveTowards has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single MoveTowardsAngle(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Mathf.MoveTowardsAngle(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.MoveTowardsAngle has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.MoveTowardsAngle has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Int32 NextPowerOfTwo(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.Mathf.NextPowerOfTwo(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.NextPowerOfTwo has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.NextPowerOfTwo has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Single PerlinNoise(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return UnityEngine.Mathf.PerlinNoise(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.PerlinNoise has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.PerlinNoise has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single PingPong(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return UnityEngine.Mathf.PingPong(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.PingPong has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.PingPong has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single Pow(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return UnityEngine.Mathf.Pow(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Pow has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Pow has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single Repeat(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return UnityEngine.Mathf.Repeat(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Repeat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Repeat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single Round(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.Round(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Round has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Round has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Int32 RoundToInt(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.RoundToInt(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.RoundToInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.RoundToInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Single Sign(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.Sign(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Sign has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Sign has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single Sin(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.Sin(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Sin has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Sin has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single SmoothStep(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Mathf.SmoothStep(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.SmoothStep has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.SmoothStep has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single Sqrt(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.Sqrt(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Sqrt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Sqrt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single Tan(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return UnityEngine.Mathf.Tan(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Mathf.Tan has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Mathf.Tan has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

	}
}
