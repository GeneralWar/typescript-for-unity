using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineObject
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Object> self = space.DeclareClass<UnityEngine.Object>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("Destroy", Destroy);
			self.BindStaticFunction("DestroyImmediate", DestroyImmediate);
			self.BindStaticFunction("DontDestroyOnLoad", DontDestroyOnLoad);
			self.BindStaticFunction("FindObjectOfType", FindObjectOfType);
			self.BindStaticFunction("FindObjectsOfType", FindObjectsOfType);
			self.BindStaticFunction("Instantiate", Instantiate);
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("GetInstanceID", GetInstanceID);
			self.BindInstanceFunction("ToString", ToString);
			self.BindInstanceProperty("name", get_name, set_name);
			self.BindInstanceProperty("hideFlags", get_hideFlags, set_hideFlags);
		}

		static private UnityEngine.Object Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Object();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Object.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Object);
		}

		static private void Destroy(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Object>())
			{
				UnityEngine.Object.Destroy(parameters[0].ToObject<UnityEngine.Object>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Object, System.Single>())
			{
				UnityEngine.Object.Destroy(parameters[0].ToObject<UnityEngine.Object>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Object.Destroy has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Object.Destroy has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DestroyImmediate(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Object>())
			{
				UnityEngine.Object.DestroyImmediate(parameters[0].ToObject<UnityEngine.Object>());
				return;
			}
			if (parameters.CheckTypes<UnityEngine.Object, System.Boolean>())
			{
				UnityEngine.Object.DestroyImmediate(parameters[0].ToObject<UnityEngine.Object>(), parameters[1].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Object.DestroyImmediate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Object.DestroyImmediate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void DontDestroyOnLoad(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Object>())
			{
				UnityEngine.Object.DontDestroyOnLoad(parameters[0].ToObject<UnityEngine.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Object.DontDestroyOnLoad has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Object.DontDestroyOnLoad has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Object FindObjectOfType(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type>())
			{
				return UnityEngine.Object.FindObjectOfType(parameters[0].ToObject<System.Type>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Object.FindObjectOfType has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Object.FindObjectOfType has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Object FindObjectsOfType(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type>())
			{
				return UnityEngine.Object.FindObjectsOfType(parameters[0].ToObject<System.Type>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Object.FindObjectsOfType has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Object.FindObjectsOfType has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.Object Instantiate(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Object>())
			{
				return UnityEngine.Object.Instantiate(parameters[0].ToObject<UnityEngine.Object>());
			}
			if (parameters.CheckTypes<UnityEngine.Object, UnityEngine.Transform>())
			{
				return UnityEngine.Object.Instantiate(parameters[0].ToObject<UnityEngine.Object>(), parameters[1].ToObject<UnityEngine.Transform>());
			}
			if (parameters.CheckTypes<UnityEngine.Object, UnityEngine.Vector3, UnityEngine.Quaternion>())
			{
				return UnityEngine.Object.Instantiate(parameters[0].ToObject<UnityEngine.Object>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>());
			}
			if (parameters.CheckTypes<UnityEngine.Object, UnityEngine.Transform, System.Boolean>())
			{
				return UnityEngine.Object.Instantiate(parameters[0].ToObject<UnityEngine.Object>(), parameters[1].ToObject<UnityEngine.Transform>(), parameters[2].ToObject<System.Boolean>());
			}
			if (parameters.CheckTypes<UnityEngine.Object, UnityEngine.Vector3, UnityEngine.Quaternion, UnityEngine.Transform>())
			{
				return UnityEngine.Object.Instantiate(parameters[0].ToObject<UnityEngine.Object>(), parameters[1].ToObject<UnityEngine.Vector3>(), parameters[2].ToObject<UnityEngine.Quaternion>(), parameters[3].ToObject<UnityEngine.Transform>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Object.Instantiate has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Object.Instantiate has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean Equals(UnityEngine.Object instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Object.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Object.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.Object instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Object.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.Int32 GetInstanceID(UnityEngine.Object instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetInstanceID();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Object.GetInstanceID has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private System.String ToString(UnityEngine.Object instance, string methodName, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Object.ToString has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.String get_name(UnityEngine.Object instance, string name)
		{
			return instance.name;
		}

		static private void set_name(UnityEngine.Object instance, string name, System.String value)
		{
			instance.name = value;
		}

		static private UnityEngine.HideFlags get_hideFlags(UnityEngine.Object instance, string name)
		{
			return instance.hideFlags;
		}

		static private void set_hideFlags(UnityEngine.Object instance, string name, UnityEngine.HideFlags value)
		{
			instance.hideFlags = value;
		}

	}
}
