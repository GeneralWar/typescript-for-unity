using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineQuaternion
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Quaternion> self = space.DeclareClass<UnityEngine.Quaternion>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("Angle", Angle);
			self.BindStaticFunction("AngleAxis", AngleAxis);
			self.BindStaticFunction("Dot", Dot);
			self.BindStaticFunction("Euler", Euler);
			self.BindStaticFunction("FromToRotation", FromToRotation);
			self.BindStaticFunction("Inverse", Inverse);
			self.BindStaticFunction("Lerp", Lerp);
			self.BindStaticFunction("LerpUnclamped", LerpUnclamped);
			self.BindStaticFunction("LookRotation", LookRotation);
			self.BindStaticFunction("Normalize", Normalize);
			self.BindStaticFunction("RotateTowards", RotateTowards);
			self.BindStaticFunction("Slerp", Slerp);
			self.BindStaticFunction("SlerpUnclamped", SlerpUnclamped);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("Normalize", Normalize);
			self.BindInstanceFunction("Set", Set);
			self.BindInstanceFunction("SetFromToRotation", SetFromToRotation);
			self.BindInstanceFunction("SetLookRotation", SetLookRotation);
			self.BindInstanceFunction("ToString", ToString);
			self.BindStaticProperty("identity", get_identity, null);
			self.BindInstanceProperty("eulerAngles", get_eulerAngles, set_eulerAngles);
			self.BindInstanceProperty("normalized", get_normalized, null);
		}

		static private UnityEngine.Quaternion Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single>())
			{
				return new UnityEngine.Quaternion(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Quaternion);
		}

		static private System.Single Angle(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Quaternion, UnityEngine.Quaternion>())
			{
				return UnityEngine.Quaternion.Angle(parameters[0].ToObject<UnityEngine.Quaternion>(), parameters[1].ToObject<UnityEngine.Quaternion>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.Angle has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.Angle has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private UnityEngine.Quaternion AngleAxis(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, UnityEngine.Vector3>())
			{
				return UnityEngine.Quaternion.AngleAxis(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.AngleAxis has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.AngleAxis has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Quaternion);
		}

		static private System.Single Dot(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Quaternion, UnityEngine.Quaternion>())
			{
				return UnityEngine.Quaternion.Dot(parameters[0].ToObject<UnityEngine.Quaternion>(), parameters[1].ToObject<UnityEngine.Quaternion>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.Dot has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.Dot has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private UnityEngine.Quaternion Euler(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return UnityEngine.Quaternion.Euler(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return UnityEngine.Quaternion.Euler(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.Euler has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.Euler has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Quaternion);
		}

		static private UnityEngine.Quaternion FromToRotation(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				return UnityEngine.Quaternion.FromToRotation(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.FromToRotation has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.FromToRotation has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Quaternion);
		}

		static private UnityEngine.Quaternion Inverse(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Quaternion>())
			{
				return UnityEngine.Quaternion.Inverse(parameters[0].ToObject<UnityEngine.Quaternion>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.Inverse has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.Inverse has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Quaternion);
		}

		static private UnityEngine.Quaternion Lerp(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Quaternion, UnityEngine.Quaternion, System.Single>())
			{
				return UnityEngine.Quaternion.Lerp(parameters[0].ToObject<UnityEngine.Quaternion>(), parameters[1].ToObject<UnityEngine.Quaternion>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.Lerp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.Lerp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Quaternion);
		}

		static private UnityEngine.Quaternion LerpUnclamped(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Quaternion, UnityEngine.Quaternion, System.Single>())
			{
				return UnityEngine.Quaternion.LerpUnclamped(parameters[0].ToObject<UnityEngine.Quaternion>(), parameters[1].ToObject<UnityEngine.Quaternion>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.LerpUnclamped has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.LerpUnclamped has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Quaternion);
		}

		static private UnityEngine.Quaternion LookRotation(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				return UnityEngine.Quaternion.LookRotation(parameters[0].ToObject<UnityEngine.Vector3>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				return UnityEngine.Quaternion.LookRotation(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.LookRotation has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.LookRotation has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Quaternion);
		}

		static private UnityEngine.Quaternion Normalize(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Quaternion>())
			{
				return UnityEngine.Quaternion.Normalize(parameters[0].ToObject<UnityEngine.Quaternion>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.Normalize has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.Normalize has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Quaternion);
		}

		static private UnityEngine.Quaternion RotateTowards(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Quaternion, UnityEngine.Quaternion, System.Single>())
			{
				return UnityEngine.Quaternion.RotateTowards(parameters[0].ToObject<UnityEngine.Quaternion>(), parameters[1].ToObject<UnityEngine.Quaternion>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.RotateTowards has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.RotateTowards has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Quaternion);
		}

		static private UnityEngine.Quaternion Slerp(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Quaternion, UnityEngine.Quaternion, System.Single>())
			{
				return UnityEngine.Quaternion.Slerp(parameters[0].ToObject<UnityEngine.Quaternion>(), parameters[1].ToObject<UnityEngine.Quaternion>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.Slerp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.Slerp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Quaternion);
		}

		static private UnityEngine.Quaternion SlerpUnclamped(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Quaternion, UnityEngine.Quaternion, System.Single>())
			{
				return UnityEngine.Quaternion.SlerpUnclamped(parameters[0].ToObject<UnityEngine.Quaternion>(), parameters[1].ToObject<UnityEngine.Quaternion>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.SlerpUnclamped has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.SlerpUnclamped has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Quaternion);
		}

		static private System.Boolean Equals(UnityEngine.Quaternion instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.Quaternion>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Quaternion>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.Quaternion instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private void Normalize(UnityEngine.Quaternion instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.Normalize has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void Set(UnityEngine.Quaternion instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single>())
			{
				instance.Set(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.Set has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.Set has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetFromToRotation(UnityEngine.Quaternion instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				instance.SetFromToRotation(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.SetFromToRotation has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.SetFromToRotation has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetLookRotation(UnityEngine.Quaternion instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector3>())
			{
				instance.SetLookRotation(parameters[0].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Vector3, UnityEngine.Vector3>())
			{
				instance.SetLookRotation(parameters[0].ToObject<UnityEngine.Vector3>(), parameters[1].ToObject<UnityEngine.Vector3>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Quaternion.SetLookRotation has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.SetLookRotation has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.String ToString(UnityEngine.Quaternion instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Quaternion.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Quaternion get_identity()
		{
			return UnityEngine.Quaternion.identity;
		}

		static private UnityEngine.Vector3 get_eulerAngles(UnityEngine.Quaternion instance)
		{
			return instance.eulerAngles;
		}

		static private void set_eulerAngles(UnityEngine.Quaternion instance, UnityEngine.Vector3 value)
		{
			instance.eulerAngles = value;
		}

		static private UnityEngine.Quaternion get_normalized(UnityEngine.Quaternion instance)
		{
			return instance.normalized;
		}

	}
}
