using UnityEngine;

namespace General.Typescript
{
	public class UnityEnginePlayerPrefs
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.PlayerPrefs> self = space.DeclareClass<UnityEngine.PlayerPrefs>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("DeleteAll", DeleteAll);
			self.BindStaticFunction("DeleteKey", DeleteKey);
			self.BindStaticFunction("GetFloat", GetFloat);
			self.BindStaticFunction("GetInt", GetInt);
			self.BindStaticFunction("GetString", GetString);
			self.BindStaticFunction("HasKey", HasKey);
			self.BindStaticFunction("Save", Save);
			self.BindStaticFunction("SetFloat", SetFloat);
			self.BindStaticFunction("SetInt", SetInt);
			self.BindStaticFunction("SetString", SetString);
		}

		static private UnityEngine.PlayerPrefs Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.PlayerPrefs();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.PlayerPrefs.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.PlayerPrefs);
		}

		static private void DeleteAll(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.PlayerPrefs.DeleteAll();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.PlayerPrefs.DeleteAll has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void DeleteKey(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				UnityEngine.PlayerPrefs.DeleteKey(parameters[0].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.PlayerPrefs.DeleteKey has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.PlayerPrefs.DeleteKey has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Single GetFloat(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.PlayerPrefs.GetFloat(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Single>())
			{
				return UnityEngine.PlayerPrefs.GetFloat(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.PlayerPrefs.GetFloat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.PlayerPrefs.GetFloat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Single);
		}

		static private System.Int32 GetInt(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.PlayerPrefs.GetInt(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Int32>())
			{
				return UnityEngine.PlayerPrefs.GetInt(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.PlayerPrefs.GetInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.PlayerPrefs.GetInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.String GetString(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.PlayerPrefs.GetString(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.String>())
			{
				return UnityEngine.PlayerPrefs.GetString(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.PlayerPrefs.GetString has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.PlayerPrefs.GetString has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Boolean HasKey(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.PlayerPrefs.HasKey(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.PlayerPrefs.HasKey has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.PlayerPrefs.HasKey has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private void Save(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				UnityEngine.PlayerPrefs.Save();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.PlayerPrefs.Save has no implemention with arguments ({0})!", string.Join(", ", types));
		}

		static private void SetFloat(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Single>())
			{
				UnityEngine.PlayerPrefs.SetFloat(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Single>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.PlayerPrefs.SetFloat has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.PlayerPrefs.SetFloat has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetInt(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.Int32>())
			{
				UnityEngine.PlayerPrefs.SetInt(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Int32>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.PlayerPrefs.SetInt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.PlayerPrefs.SetInt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetString(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String, System.String>())
			{
				UnityEngine.PlayerPrefs.SetString(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.PlayerPrefs.SetString has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.PlayerPrefs.SetString has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

	}
}
