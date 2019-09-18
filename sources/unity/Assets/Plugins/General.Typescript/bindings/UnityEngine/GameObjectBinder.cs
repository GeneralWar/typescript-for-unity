using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineGameObject
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.GameObject> self = space.DeclareClass<UnityEngine.GameObject, UnityEngine.Object>();
			self.BindConstructor(Constructor);
			self.BindStaticFunction("CreatePrimitive", CreatePrimitive);
			self.BindStaticFunction("Find", Find);
			self.BindStaticFunction("FindGameObjectsWithTag", FindGameObjectsWithTag);
			self.BindStaticFunction("FindGameObjectWithTag", FindGameObjectWithTag);
			self.BindStaticFunction("FindWithTag", FindWithTag);
			self.BindInstanceFunction("AddComponent", AddComponent);
			self.BindInstanceFunction("BroadcastMessage", BroadcastMessage);
			self.BindInstanceFunction("CompareTag", CompareTag);
			self.BindInstanceFunction("GetComponent", GetComponent);
			self.BindInstanceFunction("GetComponentInChildren", GetComponentInChildren);
			self.BindInstanceFunction("GetComponentInParent", GetComponentInParent);
			self.BindInstanceFunction("GetComponents", GetComponents);
			self.BindInstanceFunction("GetComponentsInChildren", GetComponentsInChildren);
			self.BindInstanceFunction("GetComponentsInParent", GetComponentsInParent);
			self.BindInstanceFunction("SendMessage", SendMessage);
			self.BindInstanceFunction("SendMessageUpwards", SendMessageUpwards);
			self.BindInstanceFunction("SetActive", SetActive);
			self.BindInstanceProperty("transform", get_transform, null);
			self.BindInstanceProperty("layer", get_layer, set_layer);
			self.BindInstanceProperty("activeSelf", get_activeSelf, null);
			self.BindInstanceProperty("activeInHierarchy", get_activeInHierarchy, null);
			self.BindInstanceProperty("isStatic", get_isStatic, set_isStatic);
			self.BindInstanceProperty("tag", get_tag, set_tag);
			self.BindInstanceProperty("scene", get_scene, null);
			self.BindInstanceProperty("gameObject", get_gameObject, null);
		}

		static private UnityEngine.GameObject Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.GameObject();
			}
			if (parameters.CheckTypes<System.String>())
			{
				return new UnityEngine.GameObject(parameters[0].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Type[]>())
			{
				return new UnityEngine.GameObject(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Type[]>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.GameObject);
		}

		static private UnityEngine.GameObject CreatePrimitive(Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.PrimitiveType>())
			{
				return UnityEngine.GameObject.CreatePrimitive(parameters[0].ToObject<UnityEngine.PrimitiveType>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GameObject.CreatePrimitive has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.CreatePrimitive has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.GameObject Find(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.GameObject.Find(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GameObject.Find has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.Find has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.GameObject[] FindGameObjectsWithTag(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.GameObject.FindGameObjectsWithTag(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GameObject.FindGameObjectsWithTag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.FindGameObjectsWithTag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.GameObject FindGameObjectWithTag(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.GameObject.FindGameObjectWithTag(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GameObject.FindGameObjectWithTag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.FindGameObjectWithTag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private UnityEngine.GameObject FindWithTag(Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return UnityEngine.GameObject.FindWithTag(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GameObject.FindWithTag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.FindWithTag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Object AddComponent(UnityEngine.GameObject instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type>())
			{
				return instance.AddCustomComponent(parameters[0].ToObject<System.Type>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GameObject.AddComponent has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.AddComponent has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void BroadcastMessage(UnityEngine.GameObject instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.BroadcastMessage(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.SendMessageOptions>())
			{
				instance.BroadcastMessage(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.SendMessageOptions>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Object>())
			{
				instance.BroadcastMessage(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Object, UnityEngine.SendMessageOptions>())
			{
				instance.BroadcastMessage(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>(), parameters[2].ToObject<UnityEngine.SendMessageOptions>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GameObject.BroadcastMessage has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.BroadcastMessage has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean CompareTag(UnityEngine.GameObject instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.CompareTag(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GameObject.CompareTag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.CompareTag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Object GetComponent(UnityEngine.GameObject instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type>())
			{
				return instance.GetCustomComponent(parameters[0].ToObject<System.Type>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetComponent(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GameObject.GetComponent has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.GetComponent has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Object GetComponentInChildren(UnityEngine.GameObject instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type>())
			{
				return instance.GetCustomComponentInChildren(parameters[0].ToObject<System.Type>());
			}
			if (parameters.CheckTypes<System.Type, System.Boolean>())
			{
				return instance.GetComponentInChildren(parameters[0].ToObject<System.Type>(), parameters[1].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GameObject.GetComponentInChildren has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.GetComponentInChildren has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Object GetComponentInParent(UnityEngine.GameObject instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type>())
			{
				return instance.GetCustomComponentInParent(parameters[0].ToObject<System.Type>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GameObject.GetComponentInParent has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.GetComponentInParent has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Object GetComponents(UnityEngine.GameObject instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type>())
			{
				return instance.GetCustomComponents(parameters[0].ToObject<System.Type>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GameObject.GetComponents has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.GetComponents has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Object GetComponentsInChildren(UnityEngine.GameObject instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type>())
			{
				return instance.GetCustomComponentsInChildren(parameters[0].ToObject<System.Type>());
			}
			if (parameters.CheckTypes<System.Type, System.Boolean>())
			{
				return instance.GetComponentsInChildren(parameters[0].ToObject<System.Type>(), parameters[1].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GameObject.GetComponentsInChildren has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.GetComponentsInChildren has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Object GetComponentsInParent(UnityEngine.GameObject instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type>())
			{
				return instance.GetCustomComponentsInParent(parameters[0].ToObject<System.Type>());
			}
			if (parameters.CheckTypes<System.Type, System.Boolean>())
			{
				return instance.GetComponentsInParent(parameters[0].ToObject<System.Type>(), parameters[1].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GameObject.GetComponentsInParent has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.GetComponentsInParent has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void SendMessage(UnityEngine.GameObject instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.SendMessage(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.SendMessageOptions>())
			{
				instance.SendMessage(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.SendMessageOptions>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Object>())
			{
				instance.SendMessage(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Object, UnityEngine.SendMessageOptions>())
			{
				instance.SendMessage(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>(), parameters[2].ToObject<UnityEngine.SendMessageOptions>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GameObject.SendMessage has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.SendMessage has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SendMessageUpwards(UnityEngine.GameObject instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.SendMessageUpwards(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.SendMessageOptions>())
			{
				instance.SendMessageUpwards(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.SendMessageOptions>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Object>())
			{
				instance.SendMessageUpwards(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Object, UnityEngine.SendMessageOptions>())
			{
				instance.SendMessageUpwards(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>(), parameters[2].ToObject<UnityEngine.SendMessageOptions>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GameObject.SendMessageUpwards has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.SendMessageUpwards has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SetActive(UnityEngine.GameObject instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Boolean>())
			{
				instance.SetActive(parameters[0].ToObject<System.Boolean>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.GameObject.SetActive has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.GameObject.SetActive has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Transform get_transform(UnityEngine.GameObject instance)
		{
			return instance.transform;
		}

		static private System.Int32 get_layer(UnityEngine.GameObject instance)
		{
			return instance.layer;
		}

		static private void set_layer(UnityEngine.GameObject instance, System.Int32 value)
		{
			instance.layer = value;
		}

		static private System.Boolean get_activeSelf(UnityEngine.GameObject instance)
		{
			return instance.activeSelf;
		}

		static private System.Boolean get_activeInHierarchy(UnityEngine.GameObject instance)
		{
			return instance.activeInHierarchy;
		}

		static private System.Boolean get_isStatic(UnityEngine.GameObject instance)
		{
			return instance.isStatic;
		}

		static private void set_isStatic(UnityEngine.GameObject instance, System.Boolean value)
		{
			instance.isStatic = value;
		}

		static private System.String get_tag(UnityEngine.GameObject instance)
		{
			return instance.tag;
		}

		static private void set_tag(UnityEngine.GameObject instance, System.String value)
		{
			instance.tag = value;
		}

		static private UnityEngine.SceneManagement.Scene get_scene(UnityEngine.GameObject instance)
		{
			return instance.scene;
		}

		static private UnityEngine.GameObject get_gameObject(UnityEngine.GameObject instance)
		{
			return instance.gameObject;
		}

	}
}
