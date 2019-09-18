using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSceneManagementLoadSceneParameters
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.SceneManagement.LoadSceneParameters> self = space.DeclareClass<UnityEngine.SceneManagement.LoadSceneParameters>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("loadSceneMode", get_loadSceneMode, set_loadSceneMode);
			self.BindInstanceProperty("localPhysicsMode", get_localPhysicsMode, set_localPhysicsMode);
		}

		static private UnityEngine.SceneManagement.LoadSceneParameters Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.SceneManagement.LoadSceneMode>())
			{
				return new UnityEngine.SceneManagement.LoadSceneParameters(parameters[0].ToObject<UnityEngine.SceneManagement.LoadSceneMode>());
			}
			if (parameters.CheckTypes<UnityEngine.SceneManagement.LoadSceneMode, UnityEngine.SceneManagement.LocalPhysicsMode>())
			{
				return new UnityEngine.SceneManagement.LoadSceneParameters(parameters[0].ToObject<UnityEngine.SceneManagement.LoadSceneMode>(), parameters[1].ToObject<UnityEngine.SceneManagement.LocalPhysicsMode>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SceneManagement.LoadSceneParameters.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.LoadSceneParameters.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.SceneManagement.LoadSceneParameters);
		}

		static private UnityEngine.SceneManagement.LoadSceneMode get_loadSceneMode(UnityEngine.SceneManagement.LoadSceneParameters instance)
		{
			return instance.loadSceneMode;
		}

		static private void set_loadSceneMode(UnityEngine.SceneManagement.LoadSceneParameters instance, UnityEngine.SceneManagement.LoadSceneMode value)
		{
			instance.loadSceneMode = value;
		}

		static private UnityEngine.SceneManagement.LocalPhysicsMode get_localPhysicsMode(UnityEngine.SceneManagement.LoadSceneParameters instance)
		{
			return instance.localPhysicsMode;
		}

		static private void set_localPhysicsMode(UnityEngine.SceneManagement.LoadSceneParameters instance, UnityEngine.SceneManagement.LocalPhysicsMode value)
		{
			instance.localPhysicsMode = value;
		}

	}
}
