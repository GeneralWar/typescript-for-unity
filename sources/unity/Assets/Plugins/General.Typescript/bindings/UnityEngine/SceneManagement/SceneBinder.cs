using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSceneManagementScene
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.SceneManagement.Scene> self = space.DeclareClass<UnityEngine.SceneManagement.Scene>();
			self.BindConstructor();
			self.BindInstanceFunction("Equals", Equals);
			self.BindInstanceFunction("GetHashCode", GetHashCode);
			self.BindInstanceFunction("GetRootGameObjects", GetRootGameObjects);
			self.BindInstanceFunction("IsValid", IsValid);
			self.BindInstanceProperty("handle", get_handle, null);
			self.BindInstanceProperty("path", get_path, null);
			self.BindInstanceProperty("name", get_name, set_name);
			self.BindInstanceProperty("isLoaded", get_isLoaded, null);
			self.BindInstanceProperty("buildIndex", get_buildIndex, null);
			self.BindInstanceProperty("isDirty", get_isDirty, null);
			self.BindInstanceProperty("rootCount", get_rootCount, null);
		}

		static private System.Boolean Equals(UnityEngine.SceneManagement.Scene instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Object>())
			{
				return instance.Equals(parameters[0].ToObject<System.Object>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SceneManagement.Scene.Equals has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.Scene.Equals has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Int32 GetHashCode(UnityEngine.SceneManagement.Scene instance, Parameters parameters)
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
			UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.Scene.GetHashCode has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Int32);
		}

		static private UnityEngine.GameObject[] GetRootGameObjects(UnityEngine.SceneManagement.Scene instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetRootGameObjects();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.Scene.GetRootGameObjects has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private System.Boolean IsValid(UnityEngine.SceneManagement.Scene instance, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.IsValid();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.Scene.IsValid has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Boolean);
		}

		static private System.Int32 get_handle(UnityEngine.SceneManagement.Scene instance)
		{
			return instance.handle;
		}

		static private System.String get_path(UnityEngine.SceneManagement.Scene instance)
		{
			return instance.path;
		}

		static private System.String get_name(UnityEngine.SceneManagement.Scene instance)
		{
			return instance.name;
		}

		static private void set_name(UnityEngine.SceneManagement.Scene instance, System.String value)
		{
			instance.name = value;
		}

		static private System.Boolean get_isLoaded(UnityEngine.SceneManagement.Scene instance)
		{
			return instance.isLoaded;
		}

		static private System.Int32 get_buildIndex(UnityEngine.SceneManagement.Scene instance)
		{
			return instance.buildIndex;
		}

		static private System.Boolean get_isDirty(UnityEngine.SceneManagement.Scene instance)
		{
			return instance.isDirty;
		}

		static private System.Int32 get_rootCount(UnityEngine.SceneManagement.Scene instance)
		{
			return instance.rootCount;
		}

	}
}
