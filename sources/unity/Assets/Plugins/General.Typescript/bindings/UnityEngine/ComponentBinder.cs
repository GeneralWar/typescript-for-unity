using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineComponent
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Component> self = space.DeclareClass<UnityEngine.Component, UnityEngine.Object>();
			self.BindConstructor(Constructor);
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
			self.BindInstanceProperty("transform", get_transform, null);
			self.BindInstanceProperty("gameObject", get_gameObject, null);
			self.BindInstanceProperty("tag", get_tag, set_tag);
		}

		static private UnityEngine.Component Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Component();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Component.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Component);
		}

		static private void BroadcastMessage(UnityEngine.Component instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.BroadcastMessage(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Object>())
			{
				instance.BroadcastMessage(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.SendMessageOptions>())
			{
				instance.BroadcastMessage(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.SendMessageOptions>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Object, UnityEngine.SendMessageOptions>())
			{
				instance.BroadcastMessage(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>(), parameters[2].ToObject<UnityEngine.SendMessageOptions>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Component.BroadcastMessage has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Component.BroadcastMessage has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private System.Boolean CompareTag(UnityEngine.Component instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				return instance.CompareTag(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Component.CompareTag has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Component.CompareTag has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Boolean);
		}

		static private System.Object GetComponent(UnityEngine.Component instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type>())
			{
				return instance.GetComponent(parameters[0].ToObject<System.Type>());
			}
			if (parameters.CheckTypes<System.String>())
			{
				return instance.GetComponent(parameters[0].ToObject<System.String>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Component.GetComponent has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Component.GetComponent has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Object GetComponentInChildren(UnityEngine.Component instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type>())
			{
				return instance.GetComponentInChildren(parameters[0].ToObject<System.Type>());
			}
			if (parameters.CheckTypes<System.Type, System.Boolean>())
			{
				return instance.GetComponentInChildren(parameters[0].ToObject<System.Type>(), parameters[1].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Component.GetComponentInChildren has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Component.GetComponentInChildren has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Object GetComponentInParent(UnityEngine.Component instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type>())
			{
				return instance.GetComponentInParent(parameters[0].ToObject<System.Type>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Component.GetComponentInParent has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Component.GetComponentInParent has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Object GetComponents(UnityEngine.Component instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type>())
			{
				return instance.GetComponents(parameters[0].ToObject<System.Type>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Component.GetComponents has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Component.GetComponents has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Object GetComponentsInChildren(UnityEngine.Component instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type>())
			{
				return instance.GetComponentsInChildren(parameters[0].ToObject<System.Type>());
			}
			if (parameters.CheckTypes<System.Type, System.Boolean>())
			{
				return instance.GetComponentsInChildren(parameters[0].ToObject<System.Type>(), parameters[1].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Component.GetComponentsInChildren has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Component.GetComponentsInChildren has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private System.Object GetComponentsInParent(UnityEngine.Component instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Type>())
			{
				return instance.GetComponentsInParent(parameters[0].ToObject<System.Type>());
			}
			if (parameters.CheckTypes<System.Type, System.Boolean>())
			{
				return instance.GetComponentsInParent(parameters[0].ToObject<System.Type>(), parameters[1].ToObject<System.Boolean>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Component.GetComponentsInParent has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Component.GetComponentsInParent has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return null;
		}

		static private void SendMessage(UnityEngine.Component instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.SendMessage(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Object>())
			{
				instance.SendMessage(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.SendMessageOptions>())
			{
				instance.SendMessage(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.SendMessageOptions>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Object, UnityEngine.SendMessageOptions>())
			{
				instance.SendMessage(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>(), parameters[2].ToObject<UnityEngine.SendMessageOptions>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Component.SendMessage has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Component.SendMessage has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private void SendMessageUpwards(UnityEngine.Component instance, Parameters parameters)
		{
			if (parameters.CheckTypes<System.String>())
			{
				instance.SendMessageUpwards(parameters[0].ToObject<System.String>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Object>())
			{
				instance.SendMessageUpwards(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>());
				return;
			}
			if (parameters.CheckTypes<System.String, UnityEngine.SendMessageOptions>())
			{
				instance.SendMessageUpwards(parameters[0].ToObject<System.String>(), parameters[1].ToObject<UnityEngine.SendMessageOptions>());
				return;
			}
			if (parameters.CheckTypes<System.String, System.Object, UnityEngine.SendMessageOptions>())
			{
				instance.SendMessageUpwards(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Object>(), parameters[2].ToObject<UnityEngine.SendMessageOptions>());
				return;
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Component.SendMessageUpwards has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Component.SendMessageUpwards has no implemention with arguments ({0})!", string.Join(", ", types));
			}
		}

		static private UnityEngine.Transform get_transform(UnityEngine.Component instance)
		{
			return instance.transform;
		}

		static private UnityEngine.GameObject get_gameObject(UnityEngine.Component instance)
		{
			return instance.gameObject;
		}

		static private System.String get_tag(UnityEngine.Component instance)
		{
			return instance.tag;
		}

		static private void set_tag(UnityEngine.Component instance, System.String value)
		{
			instance.tag = value;
		}

	}
}
