using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineVector4
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Vector4> self = space.DeclareClass<UnityEngine.Vector4>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("Distance", Distance);
			self.BindStaticFunction("Dot", Dot);
			self.BindStaticFunction("Lerp", Lerp);
			self.BindStaticFunction("LerpUnclamped", LerpUnclamped);
			self.BindStaticFunction("Magnitude", Magnitude);
			self.BindStaticFunction("Max", Max);
			self.BindStaticFunction("Min", Min);
			self.BindStaticFunction("MoveTowards", MoveTowards);
			self.BindStaticFunction("Normalize", Normalize);
			self.BindStaticFunction("Project", Project);
			self.BindStaticFunction("Scale", Scale);
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
			self.BindStaticProperty("positiveInfinity", get_positiveInfinity, null);
			self.BindStaticProperty("negativeInfinity", get_negativeInfinity, null);
			self.BindInstanceProperty("normalized", get_normalized, null);
			self.BindInstanceProperty("magnitude", get_magnitude, null);
			self.BindInstanceProperty("sqrMagnitude", get_sqrMagnitude, null);
		}

		static private UnityEngine.Vector4 Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return new UnityEngine.Vector4(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return new UnityEngine.Vector4(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single>())
			{
				return new UnityEngine.Vector4(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector4.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector4);
		}

		static private System.Single Distance(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4, UnityEngine.Vector4>())
			{
				return UnityEngine.Vector4.Distance(parameters[0].ToObject<UnityEngine.Vector4>(), parameters[1].ToObject<UnityEngine.Vector4>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector4.Distance has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.Distance has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Single Dot(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4, UnityEngine.Vector4>())
			{
				return UnityEngine.Vector4.Dot(parameters[0].ToObject<UnityEngine.Vector4>(), parameters[1].ToObject<UnityEngine.Vector4>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector4.Dot has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.Dot has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private UnityEngine.Vector4 Lerp(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4, UnityEngine.Vector4, System.Single>())
			{
				return UnityEngine.Vector4.Lerp(parameters[0].ToObject<UnityEngine.Vector4>(), parameters[1].ToObject<UnityEngine.Vector4>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector4.Lerp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.Lerp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector4);
		}

		static private UnityEngine.Vector4 LerpUnclamped(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4, UnityEngine.Vector4, System.Single>())
			{
				return UnityEngine.Vector4.LerpUnclamped(parameters[0].ToObject<UnityEngine.Vector4>(), parameters[1].ToObject<UnityEngine.Vector4>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector4.LerpUnclamped has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.LerpUnclamped has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector4);
		}

		static private System.Single Magnitude(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4>())
			{
				return UnityEngine.Vector4.Magnitude(parameters[0].ToObject<UnityEngine.Vector4>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector4.Magnitude has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.Magnitude has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private UnityEngine.Vector4 Max(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4, UnityEngine.Vector4>())
			{
				return UnityEngine.Vector4.Max(parameters[0].ToObject<UnityEngine.Vector4>(), parameters[1].ToObject<UnityEngine.Vector4>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector4.Max has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.Max has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector4);
		}

		static private UnityEngine.Vector4 Min(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4, UnityEngine.Vector4>())
			{
				return UnityEngine.Vector4.Min(parameters[0].ToObject<UnityEngine.Vector4>(), parameters[1].ToObject<UnityEngine.Vector4>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector4.Min has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.Min has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector4);
		}

		static private UnityEngine.Vector4 MoveTowards(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4, UnityEngine.Vector4, System.Single>())
			{
				return UnityEngine.Vector4.MoveTowards(parameters[0].ToObject<UnityEngine.Vector4>(), parameters[1].ToObject<UnityEngine.Vector4>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector4.MoveTowards has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.MoveTowards has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector4);
		}

		static private UnityEngine.Vector4 Normalize(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4>())
			{
				return UnityEngine.Vector4.Normalize(parameters[0].ToObject<UnityEngine.Vector4>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector4.Normalize has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.Normalize has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector4);
		}

		static private UnityEngine.Vector4 Project(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4, UnityEngine.Vector4>())
			{
				return UnityEngine.Vector4.Project(parameters[0].ToObject<UnityEngine.Vector4>(), parameters[1].ToObject<UnityEngine.Vector4>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector4.Project has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.Project has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector4);
		}

		static private UnityEngine.Vector4 Scale(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4, UnityEngine.Vector4>())
			{
				return UnityEngine.Vector4.Scale(parameters[0].ToObject<UnityEngine.Vector4>(), parameters[1].ToObject<UnityEngine.Vector4>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector4.Scale has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.Scale has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector4);
		}

		static private System.Single SqrMagnitude(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4>())
			{
				return UnityEngine.Vector4.SqrMagnitude(parameters[0].ToObject<UnityEngine.Vector4>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector4.SqrMagnitude has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.SqrMagnitude has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Boolean Equals(UnityEngine.Vector4 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector4>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Vector4>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector4.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.Vector4 instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private void Normalize(UnityEngine.Vector4 instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.Normalize has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Scale(UnityEngine.Vector4 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector4>())
			{
				instance.Scale(parameters[0].ToObject<UnityEngine.Vector4>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector4.Scale has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.Scale has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Set(UnityEngine.Vector4 instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single>())
			{
				instance.Set(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector4.Set has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.Set has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Single SqrMagnitude(UnityEngine.Vector4 instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.SqrMagnitude has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Single);
		}

		static private System.String ToString(UnityEngine.Vector4 instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector4.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Vector4 get_zero()
		{
			return UnityEngine.Vector4.zero;
		}

		static private UnityEngine.Vector4 get_one()
		{
			return UnityEngine.Vector4.one;
		}

		static private UnityEngine.Vector4 get_positiveInfinity()
		{
			return UnityEngine.Vector4.positiveInfinity;
		}

		static private UnityEngine.Vector4 get_negativeInfinity()
		{
			return UnityEngine.Vector4.negativeInfinity;
		}

		static private UnityEngine.Vector4 get_normalized(UnityEngine.Vector4 instance)
		{
			return instance.normalized;
		}

		static private System.Single get_magnitude(UnityEngine.Vector4 instance)
		{
			return instance.magnitude;
		}

		static private System.Single get_sqrMagnitude(UnityEngine.Vector4 instance)
		{
			return instance.sqrMagnitude;
		}

	}
}
