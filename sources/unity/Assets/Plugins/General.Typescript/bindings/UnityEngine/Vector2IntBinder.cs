using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineVector2Int
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Vector2Int> self = space.DeclareClass<UnityEngine.Vector2Int>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("CeilToInt", CeilToInt);
			self.BindStaticFunction("Distance", Distance);
			self.BindStaticFunction("FloorToInt", FloorToInt);
			self.BindStaticFunction("Max", Max);
			self.BindStaticFunction("Min", Min);
			self.BindStaticFunction("RoundToInt", RoundToInt);
			self.BindStaticFunction("Scale", Scale);
			self.BindInstanceFunction("Clamp", Clamp);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("Scale", Scale);
			self.BindInstanceFunction("Set", Set);
			self.BindInstanceFunction("ToString", ToString);
			self.BindStaticProperty("zero", get_zero, null);
			self.BindStaticProperty("one", get_one, null);
			self.BindStaticProperty("up", get_up, null);
			self.BindStaticProperty("down", get_down, null);
			self.BindStaticProperty("left", get_left, null);
			self.BindStaticProperty("right", get_right, null);
			self.BindInstanceProperty("x", get_x, set_x);
			self.BindInstanceProperty("y", get_y, set_y);
			self.BindInstanceProperty("magnitude", get_magnitude, null);
			self.BindInstanceProperty("sqrMagnitude", get_sqrMagnitude, null);
		}

		static private UnityEngine.Vector2Int Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				return new UnityEngine.Vector2Int(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2Int.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2Int.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2Int);
		}

		static private UnityEngine.Vector2Int CeilToInt(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2>())
			{
				return UnityEngine.Vector2Int.CeilToInt(parameters[0].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2Int.CeilToInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2Int.CeilToInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2Int);
		}

		static private System.Single Distance(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2Int, UnityEngine.Vector2Int>())
			{
				return UnityEngine.Vector2Int.Distance(parameters[0].ToObject<UnityEngine.Vector2Int>(), parameters[1].ToObject<UnityEngine.Vector2Int>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2Int.Distance has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2Int.Distance has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private UnityEngine.Vector2Int FloorToInt(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2>())
			{
				return UnityEngine.Vector2Int.FloorToInt(parameters[0].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2Int.FloorToInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2Int.FloorToInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2Int);
		}

		static private UnityEngine.Vector2Int Max(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2Int, UnityEngine.Vector2Int>())
			{
				return UnityEngine.Vector2Int.Max(parameters[0].ToObject<UnityEngine.Vector2Int>(), parameters[1].ToObject<UnityEngine.Vector2Int>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2Int.Max has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2Int.Max has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2Int);
		}

		static private UnityEngine.Vector2Int Min(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2Int, UnityEngine.Vector2Int>())
			{
				return UnityEngine.Vector2Int.Min(parameters[0].ToObject<UnityEngine.Vector2Int>(), parameters[1].ToObject<UnityEngine.Vector2Int>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2Int.Min has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2Int.Min has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2Int);
		}

		static private UnityEngine.Vector2Int RoundToInt(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2>())
			{
				return UnityEngine.Vector2Int.RoundToInt(parameters[0].ToObject<UnityEngine.Vector2>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2Int.RoundToInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2Int.RoundToInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2Int);
		}

		static private UnityEngine.Vector2Int Scale(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2Int, UnityEngine.Vector2Int>())
			{
				return UnityEngine.Vector2Int.Scale(parameters[0].ToObject<UnityEngine.Vector2Int>(), parameters[1].ToObject<UnityEngine.Vector2Int>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2Int.Scale has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2Int.Scale has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.Vector2Int);
		}

		static private void Clamp(UnityEngine.Vector2Int instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2Int, UnityEngine.Vector2Int>())
			{
				instance.Clamp(parameters[0].ToObject<UnityEngine.Vector2Int>(), parameters[1].ToObject<UnityEngine.Vector2Int>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2Int.Clamp has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2Int.Clamp has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean Equals(UnityEngine.Vector2Int instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.Vector2Int>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.Vector2Int>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2Int.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2Int.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.Vector2Int instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2Int.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private void Scale(UnityEngine.Vector2Int instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Vector2Int>())
			{
				instance.Scale(parameters[0].ToObject<UnityEngine.Vector2Int>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2Int.Scale has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2Int.Scale has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void Set(UnityEngine.Vector2Int instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Int32>())
			{
				instance.Set(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Vector2Int.Set has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2Int.Set has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.String ToString(UnityEngine.Vector2Int instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.ToString();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Vector2Int.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Vector2Int get_zero(Type type, string name)
		{
			return UnityEngine.Vector2Int.zero;
		}

		static private UnityEngine.Vector2Int get_one(Type type, string name)
		{
			return UnityEngine.Vector2Int.one;
		}

		static private UnityEngine.Vector2Int get_up(Type type, string name)
		{
			return UnityEngine.Vector2Int.up;
		}

		static private UnityEngine.Vector2Int get_down(Type type, string name)
		{
			return UnityEngine.Vector2Int.down;
		}

		static private UnityEngine.Vector2Int get_left(Type type, string name)
		{
			return UnityEngine.Vector2Int.left;
		}

		static private UnityEngine.Vector2Int get_right(Type type, string name)
		{
			return UnityEngine.Vector2Int.right;
		}

		static private System.Int32 get_x(UnityEngine.Vector2Int instance, string name)
		{
			return instance.x;
		}

		static private void set_x(UnityEngine.Vector2Int instance, string name, System.Int32 value)
		{
			instance.x = value;
		}

		static private System.Int32 get_y(UnityEngine.Vector2Int instance, string name)
		{
			return instance.y;
		}

		static private void set_y(UnityEngine.Vector2Int instance, string name, System.Int32 value)
		{
			instance.y = value;
		}

		static private System.Single get_magnitude(UnityEngine.Vector2Int instance, string name)
		{
			return instance.magnitude;
		}

		static private System.Int32 get_sqrMagnitude(UnityEngine.Vector2Int instance, string name)
		{
			return instance.sqrMagnitude;
		}

	}
}
