using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineVector2
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Vector2> self = space.DeclareClass<UnityEngine.Vector2>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("Angle", Angle);
			self.BindStaticFunction("ClampMagnitude", ClampMagnitude);
			self.BindStaticFunction("Distance", Distance);
			self.BindStaticFunction("Dot", Dot);
			self.BindStaticFunction("Lerp", Lerp);
			self.BindStaticFunction("LerpUnclamped", LerpUnclamped);
			self.BindStaticFunction("Max", Max);
			self.BindStaticFunction("Min", Min);
			self.BindStaticFunction("MoveTowards", MoveTowards);
			self.BindStaticFunction("Perpendicular", Perpendicular);
			self.BindStaticFunction("Reflect", Reflect);
			self.BindStaticFunction("Scale", Scale);
			self.BindStaticFunction("SignedAngle", SignedAngle);
			self.BindStaticFunction("SqrMagnitude", SqrMagnitude);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("Normalize", Normalize);
			self.BindInstanceFunction("Scale", Scale);
			self.BindInstanceFunction("Set", Set);
			self.BindInstanceFunction("SqrMagnitude", SqrMagnitude);
			self.BindInstanceFunction("ToString", ToString);
			self.BindStaticProperty("zero", get_zero, null);
			self.BindStaticProperty("one", get_one, null);
			self.BindStaticProperty("up", get_up, null);
			self.BindStaticProperty("down", get_down, null);
			self.BindStaticProperty("left", get_left, null);
			self.BindStaticProperty("right", get_right, null);
			self.BindStaticProperty("positiveInfinity", get_positiveInfinity, null);
			self.BindStaticProperty("negativeInfinity", get_negativeInfinity, null);
			self.BindInstanceProperty("normalized", get_normalized, null);
			self.BindInstanceProperty("magnitude", get_magnitude, null);
			self.BindInstanceProperty("sqrMagnitude", get_sqrMagnitude, null);
		}

		static private UnityEngine.Vector2 Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return new UnityEngine.Vector2(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private System.Single Angle(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Vector2>())
			{
				return UnityEngine.Vector2.Angle(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.Angle has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.Angle has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private UnityEngine.Vector2 ClampMagnitude(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, System.Single>())
			{
				return UnityEngine.Vector2.ClampMagnitude(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.ClampMagnitude has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.ClampMagnitude has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private System.Single Distance(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Vector2>())
			{
				return UnityEngine.Vector2.Distance(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.Distance has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.Distance has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single Dot(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Vector2>())
			{
				return UnityEngine.Vector2.Dot(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.Dot has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.Dot has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private UnityEngine.Vector2 Lerp(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Vector2, System.Single>())
			{
				return UnityEngine.Vector2.Lerp(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Vector2>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.Lerp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.Lerp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private UnityEngine.Vector2 LerpUnclamped(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Vector2, System.Single>())
			{
				return UnityEngine.Vector2.LerpUnclamped(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Vector2>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.LerpUnclamped has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.LerpUnclamped has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private UnityEngine.Vector2 Max(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Vector2>())
			{
				return UnityEngine.Vector2.Max(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.Max has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.Max has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private UnityEngine.Vector2 Min(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Vector2>())
			{
				return UnityEngine.Vector2.Min(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.Min has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.Min has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private UnityEngine.Vector2 MoveTowards(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Vector2, System.Single>())
			{
				return UnityEngine.Vector2.MoveTowards(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Vector2>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.MoveTowards has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.MoveTowards has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private UnityEngine.Vector2 Perpendicular(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2>())
			{
				return UnityEngine.Vector2.Perpendicular(parameters[0].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.Perpendicular has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.Perpendicular has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private UnityEngine.Vector2 Reflect(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Vector2>())
			{
				return UnityEngine.Vector2.Reflect(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.Reflect has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.Reflect has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private UnityEngine.Vector2 Scale(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Vector2>())
			{
				return UnityEngine.Vector2.Scale(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.Scale has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.Scale has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2);
		}

		static private System.Single SignedAngle(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2, UnityEngine.Vector2>())
			{
				return UnityEngine.Vector2.SignedAngle(parameters[0].ToObject<UnityEngine.Vector2>(), parameters[1].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.SignedAngle has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.SignedAngle has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single SqrMagnitude(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2>())
			{
				return UnityEngine.Vector2.SqrMagnitude(parameters[0].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.SqrMagnitude has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.SqrMagnitude has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Boolean Equals(UnityEngine.Vector2 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector2>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.Vector2 instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private void Normalize(UnityEngine.Vector2 instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				instance.Normalize();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.Normalize has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Scale(UnityEngine.Vector2 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2>())
			{
				instance.Scale(parameters[0].ToObject<UnityEngine.Vector2>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.Scale has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.Scale has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Set(UnityEngine.Vector2 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				instance.Set(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2.Set has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.Set has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Single SqrMagnitude(UnityEngine.Vector2 instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.SqrMagnitude();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.SqrMagnitude has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Single);
		}

		static private System.String ToString(UnityEngine.Vector2 instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Vector2 get_zero()
		{
			return UnityEngine.Vector2.zero;
		}

		static private UnityEngine.Vector2 get_one()
		{
			return UnityEngine.Vector2.one;
		}

		static private UnityEngine.Vector2 get_up()
		{
			return UnityEngine.Vector2.up;
		}

		static private UnityEngine.Vector2 get_down()
		{
			return UnityEngine.Vector2.down;
		}

		static private UnityEngine.Vector2 get_left()
		{
			return UnityEngine.Vector2.left;
		}

		static private UnityEngine.Vector2 get_right()
		{
			return UnityEngine.Vector2.right;
		}

		static private UnityEngine.Vector2 get_positiveInfinity()
		{
			return UnityEngine.Vector2.positiveInfinity;
		}

		static private UnityEngine.Vector2 get_negativeInfinity()
		{
			return UnityEngine.Vector2.negativeInfinity;
		}

		static private UnityEngine.Vector2 get_normalized(UnityEngine.Vector2 instance)
		{
			return instance.normalized;
		}

		static private System.Single get_magnitude(UnityEngine.Vector2 instance)
		{
			return instance.magnitude;
		}

		static private System.Single get_sqrMagnitude(UnityEngine.Vector2 instance)
		{
			return instance.sqrMagnitude;
		}

	}
}
