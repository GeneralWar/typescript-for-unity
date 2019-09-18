using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineSceneManagementCreateSceneParameters
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.SceneManagement.CreateSceneParameters> self = space.DeclareClass<UnityEngine.SceneManagement.CreateSceneParameters>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("localPhysicsMode", get_localPhysicsMode, set_localPhysicsMode);
		}

		static private UnityEngine.SceneManagement.CreateSceneParameters Constructor(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.SceneManagement.LocalPhysicsMode>())
			{
				return new UnityEngine.SceneManagement.CreateSceneParameters(parameters[0].ToObject<UnityEngine.SceneManagement.LocalPhysicsMode>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.SceneManagement.CreateSceneParameters.constructor has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.SceneManagement.CreateSceneParameters.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.SceneManagement.CreateSceneParameters);
		}

		static private UnityEngine.SceneManagement.LocalPhysicsMode get_localPhysicsMode(UnityEngine.SceneManagement.CreateSceneParameters instance)
		{
			return instance.localPhysicsMode;
		}

		static private void set_localPhysicsMode(UnityEngine.SceneManagement.CreateSceneParameters instance, UnityEngine.SceneManagement.LocalPhysicsMode value)
		{
			instance.localPhysicsMode = value;
		}

	}
}
