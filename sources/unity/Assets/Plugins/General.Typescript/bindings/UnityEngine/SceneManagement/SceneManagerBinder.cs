using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSceneManagementSceneManager
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.SceneManagement.SceneManager> self = space.DeclareClass<UnityEngine.SceneManagement.SceneManager>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("CreateScene", CreateScene);
			self.BindStaticFunction("GetActiveScene", GetActiveScene);
			self.BindStaticFunction("GetSceneAt", GetSceneAt);
			self.BindStaticFunction("GetSceneByBuildIndex", GetSceneByBuildIndex);
			self.BindStaticFunction("GetSceneByName", GetSceneByName);
			self.BindStaticFunction("GetSceneByPath", GetSceneByPath);
			self.BindStaticFunction("LoadScene", LoadScene);
			self.BindStaticFunction("LoadSceneAsync", LoadSceneAsync);
			self.BindStaticFunction("MergeScenes", MergeScenes);
			self.BindStaticFunction("MoveGameObjectToScene", MoveGameObjectToScene);
			self.BindStaticFunction("SetActiveScene", SetActiveScene);
			self.BindStaticFunction("UnloadSceneAsync", UnloadSceneAsync);
			self.BindStaticProperty("sceneCount", get_sceneCount, null);
			self.BindStaticProperty("sceneCountInBuildSettings", get_sceneCountInBuildSettings, null);
		}

		static private UnityEngine.SceneManagement.SceneManager Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.SceneManagement.SceneManager();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.SceneManager.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.SceneManagement.SceneManager);
		}

		static private UnityEngine.SceneManagement.Scene CreateScene(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.SceneManagement.SceneManager.CreateScene(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.SceneManagement.CreateSceneParameters>())
			{
				return UnityEngine.SceneManagement.SceneManager.CreateScene(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.SceneManagement.CreateSceneParameters>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SceneManagement.SceneManager.CreateScene has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.SceneManager.CreateScene has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.SceneManagement.Scene);
		}

		static private UnityEngine.SceneManagement.Scene GetActiveScene(Type type, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.SceneManagement.SceneManager.GetActiveScene();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.SceneManager.GetActiveScene has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.SceneManagement.Scene);
		}

		static private UnityEngine.SceneManagement.Scene GetSceneAt(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.SceneManagement.SceneManager.GetSceneAt(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SceneManagement.SceneManager.GetSceneAt has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.SceneManager.GetSceneAt has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.SceneManagement.Scene);
		}

		static private UnityEngine.SceneManagement.Scene GetSceneByBuildIndex(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.SceneManagement.SceneManager.GetSceneByBuildIndex(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SceneManagement.SceneManager.GetSceneByBuildIndex has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.SceneManager.GetSceneByBuildIndex has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.SceneManagement.Scene);
		}

		static private UnityEngine.SceneManagement.Scene GetSceneByName(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.SceneManagement.SceneManager.GetSceneByName(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SceneManagement.SceneManager.GetSceneByName has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.SceneManager.GetSceneByName has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.SceneManagement.Scene);
		}

		static private UnityEngine.SceneManagement.Scene GetSceneByPath(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.SceneManagement.SceneManager.GetSceneByPath(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SceneManagement.SceneManager.GetSceneByPath has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.SceneManager.GetSceneByPath has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.SceneManagement.Scene);
		}

		static private System.Object LoadScene(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				UnityEngine.SceneManagement.SceneManager.LoadScene(parameters[0].ToObject<System.String>());
				return default(System.Object);
			}
			if (parameters.CheckTypes<System.Int32>())
			{
				UnityEngine.SceneManagement.SceneManager.LoadScene(parameters[0].ToObject<System.Int32>());
				return default(System.Object);
			}
			if (parameters.CheckTypes<System.String, UnityEngine.SceneManagement.LoadSceneMode>())
			{
				UnityEngine.SceneManagement.SceneManager.LoadScene(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.SceneManagement.LoadSceneMode>());
				return default(System.Object);
			}
			if (parameters.CheckTypes<System.String, UnityEngine.SceneManagement.LoadSceneParameters>())
			{
				return UnityEngine.SceneManagement.SceneManager.LoadScene(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.SceneManagement.LoadSceneParameters>());
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.SceneManagement.LoadSceneMode>())
			{
				UnityEngine.SceneManagement.SceneManager.LoadScene(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.SceneManagement.LoadSceneMode>());
				return default(System.Object);
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.SceneManagement.LoadSceneParameters>())
			{
				return UnityEngine.SceneManagement.SceneManager.LoadScene(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.SceneManagement.LoadSceneParameters>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SceneManagement.SceneManager.LoadScene has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.SceneManager.LoadScene has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.AsyncOperation LoadSceneAsync(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(parameters[0].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.SceneManagement.LoadSceneMode>())
			{
				return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.SceneManagement.LoadSceneMode>());
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.SceneManagement.LoadSceneParameters>())
			{
				return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.SceneManagement.LoadSceneParameters>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.SceneManagement.LoadSceneMode>())
			{
				return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.SceneManagement.LoadSceneMode>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.SceneManagement.LoadSceneParameters>())
			{
				return UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.SceneManagement.LoadSceneParameters>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SceneManagement.SceneManager.LoadSceneAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.SceneManager.LoadSceneAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void MergeScenes(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.Scene>())
			{
				UnityEngine.SceneManagement.SceneManager.MergeScenes(parameters[0].ToObject<UnityEngine.SceneManagement.Scene>(), parameters[1].ToObject<UnityEngine.SceneManagement.Scene>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SceneManagement.SceneManager.MergeScenes has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.SceneManager.MergeScenes has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void MoveGameObjectToScene(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.GameObject, UnityEngine.SceneManagement.Scene>())
			{
				UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene(parameters[0].ToObject<UnityEngine.GameObject>(), parameters[1].ToObject<UnityEngine.SceneManagement.Scene>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.SceneManager.MoveGameObjectToScene has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean SetActiveScene(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.SceneManagement.Scene>())
			{
				return UnityEngine.SceneManagement.SceneManager.SetActiveScene(parameters[0].ToObject<UnityEngine.SceneManagement.Scene>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SceneManagement.SceneManager.SetActiveScene has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.SceneManager.SetActiveScene has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private UnityEngine.AsyncOperation UnloadSceneAsync(Type type, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(parameters[0].ToObject<System.Int32>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<UnityEngine.SceneManagement.Scene>())
			{
				return UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(parameters[0].ToObject<UnityEngine.SceneManagement.Scene>());
			}
			if (parameters.CheckTypes<System.Int32, UnityEngine.SceneManagement.UnloadSceneOptions>())
			{
				return UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(parameters[0].ToObject<System.Int32>(), parameters[1].ToObject<UnityEngine.SceneManagement.UnloadSceneOptions>());
			}
			if (parameters.CheckTypes<System.String, UnityEngine.SceneManagement.UnloadSceneOptions>())
			{
				return UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.SceneManagement.UnloadSceneOptions>());
			}
			if (parameters.CheckTypes<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.UnloadSceneOptions>())
			{
				return UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(parameters[0].ToObject<UnityEngine.SceneManagement.Scene>(), parameters[1].ToObject<UnityEngine.SceneManagement.UnloadSceneOptions>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Int32 get_sceneCount(Type type, string name)
		{
			return UnityEngine.SceneManagement.SceneManager.sceneCount;
		}

		static private System.Int32 get_sceneCountInBuildSettings(Type type, string name)
		{
			return UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
		}

	}
}
