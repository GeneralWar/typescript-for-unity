using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineResources
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Resources> self = space.DeclareClass<UnityEngine.Resources>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("FindObjectsOfTypeAll", FindObjectsOfTypeAll);
			self.BindStaticFunction("GetBuiltinResource", GetBuiltinResource);
			self.BindStaticFunction("Load", Load);
			self.BindStaticFunction("LoadAll", LoadAll);
			self.BindStaticFunction("LoadAsync", LoadAsync);
			self.BindStaticFunction("UnloadAsset", UnloadAsset);
			self.BindStaticFunction("UnloadUnusedAssets", UnloadUnusedAssets);
		}

		static private UnityEngine.Resources Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Resources();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Resources.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Resources);
		}

		static private System.Object FindObjectsOfTypeAll(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type>())
			{
				return UnityEngine.Resources.FindObjectsOfTypeAll(parameters[0].ToObject<System.Type>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Resources.FindObjectsOfTypeAll has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Resources.FindObjectsOfTypeAll has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Object GetBuiltinResource(Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type, System.String>())
			{
				return UnityEngine.Resources.GetBuiltinResource(parameters[0].ToObject<System.Type>(), parameters[1].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Resources.GetBuiltinResource has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Resources.GetBuiltinResource has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Object Load(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Resources.Load(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Type>())
			{
				return UnityEngine.Resources.Load(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Type>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Resources.Load has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Resources.Load has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Object LoadAll(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Resources.LoadAll(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Type>())
			{
				return UnityEngine.Resources.LoadAll(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Type>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Resources.LoadAll has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Resources.LoadAll has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.ResourceRequest LoadAsync(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.Resources.LoadAsync(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Type>())
			{
				return UnityEngine.Resources.LoadAsync(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Type>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Resources.LoadAsync has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Resources.LoadAsync has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void UnloadAsset(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.Object>())
			{
				UnityEngine.Resources.UnloadAsset(parameters[0].ToObject<UnityEngine.Object>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Resources.UnloadAsset has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Resources.UnloadAsset has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.AsyncOperation UnloadUnusedAssets(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return UnityEngine.Resources.UnloadUnusedAssets();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Resources.UnloadUnusedAssets has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

	}
}
