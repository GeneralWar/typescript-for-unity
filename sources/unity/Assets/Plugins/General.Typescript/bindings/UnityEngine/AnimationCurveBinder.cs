using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineAnimationCurve
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.AnimationCurve> self = space.DeclareClass<UnityEngine.AnimationCurve>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("Constant", Constant);
			self.BindStaticFunction("EaseInOut", EaseInOut);
			self.BindStaticFunction("Linear", Linear);
			self.BindInstanceFunction("AddKey", AddKey);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("Evaluate", Evaluate);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("MoveKey", MoveKey);
			self.BindInstanceFunction("RemoveKey", RemoveKey);
			self.BindInstanceFunction("SmoothTangents", SmoothTangents);
			self.BindInstanceProperty("keys", get_keys, set_keys);
			self.BindInstanceProperty("length", get_length, null);
			self.BindInstanceProperty("preWrapMode", get_preWrapMode, set_preWrapMode);
			self.BindInstanceProperty("postWrapMode", get_postWrapMode, set_postWrapMode);
		}

		static private UnityEngine.AnimationCurve Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.AnimationCurve();
			}
			if (parameters.CheckTypes<UnityEngine.Keyframe[]>())
			{
				return new UnityEngine.AnimationCurve(parameters[0].ToObject<UnityEngine.Keyframe[]>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationCurve.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.AnimationCurve);
		}

		static private UnityEngine.AnimationCurve Constant(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single>())
			{
				return UnityEngine.AnimationCurve.Constant(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimationCurve.Constant has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationCurve.Constant has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.AnimationCurve EaseInOut(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single>())
			{
				return UnityEngine.AnimationCurve.EaseInOut(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimationCurve.EaseInOut has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationCurve.EaseInOut has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.AnimationCurve Linear(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single, System.Single, System.Single, System.Single>())
			{
				return UnityEngine.AnimationCurve.Linear(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>(), parameters[2].ToObject<System.Single>(), parameters[3].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimationCurve.Linear has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationCurve.Linear has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 AddKey(UnityEngine.AnimationCurve instance, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Keyframe>())
			{
				return instance.AddKey(parameters[0].ToObject<UnityEngine.Keyframe>());
			}
			if (parameters.CheckTypes<System.Single, System.Single>())
			{
				return instance.AddKey(parameters[0].ToObject<System.Single>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimationCurve.AddKey has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationCurve.AddKey has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Boolean Equals(UnityEngine.AnimationCurve instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.AnimationCurve>())
			{
				return instance.Equals(parameters[0].ToObject<UnityEngine.AnimationCurve>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimationCurve.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationCurve.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Single Evaluate(UnityEngine.AnimationCurve instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Single>())
			{
				return instance.Evaluate(parameters[0].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimationCurve.Evaluate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationCurve.Evaluate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Int32 GetHashCode(UnityEngine.AnimationCurve instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationCurve.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Int32 MoveKey(UnityEngine.AnimationCurve instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, UnityEngine.Keyframe>())
			{
				return instance.MoveKey(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.Keyframe>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimationCurve.MoveKey has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationCurve.MoveKey has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private void RemoveKey(UnityEngine.AnimationCurve instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				instance.RemoveKey(parameters[0].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimationCurve.RemoveKey has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationCurve.RemoveKey has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SmoothTangents(UnityEngine.AnimationCurve instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32, System.Single>())
			{
				instance.SmoothTangents(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.AnimationCurve.SmoothTangents has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.AnimationCurve.SmoothTangents has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Keyframe[] get_keys(UnityEngine.AnimationCurve instance)
		{
			return instance.keys;
		}

		static private void set_keys(UnityEngine.AnimationCurve instance, UnityEngine.Keyframe[] value)
		{
			instance.keys = value;
		}

		static private System.Int32 get_length(UnityEngine.AnimationCurve instance)
		{
			return instance.length;
		}

		static private UnityEngine.WrapMode get_preWrapMode(UnityEngine.AnimationCurve instance)
		{
			return instance.preWrapMode;
		}

		static private void set_preWrapMode(UnityEngine.AnimationCurve instance, UnityEngine.WrapMode value)
		{
			instance.preWrapMode = value;
		}

		static private UnityEngine.WrapMode get_postWrapMode(UnityEngine.AnimationCurve instance)
		{
			return instance.postWrapMode;
		}

		static private void set_postWrapMode(UnityEngine.AnimationCurve instance, UnityEngine.WrapMode value)
		{
			instance.postWrapMode = value;
		}

	}
}
