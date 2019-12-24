using System;
using UnityEngine;

namespace General.Typescript
{
	public class UnityEngineCollision
	{
		static public void Bind(Namespace space)
		{
			Class<UnityEngine.Collision> self = space.DeclareClass<UnityEngine.Collision>();
			self.BindConstructor(Constructor);
			self.BindInstanceFunction("GetContact", GetContact);
			self.BindInstanceFunction("GetContacts", GetContacts);
			self.BindInstanceFunction("GetEnumerator", GetEnumerator);
			self.BindInstanceProperty("relativeVelocity", get_relativeVelocity, null);
			self.BindInstanceProperty("rigidbody", get_rigidbody, null);
			self.BindInstanceProperty("collider", get_collider, null);
			self.BindInstanceProperty("transform", get_transform, null);
			self.BindInstanceProperty("gameObject", get_gameObject, null);
			self.BindInstanceProperty("contactCount", get_contactCount, null);
			self.BindInstanceProperty("contacts", get_contacts, null);
			self.BindInstanceProperty("impulse", get_impulse, null);
		}

		static private UnityEngine.Collision Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new UnityEngine.Collision();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Collision.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(UnityEngine.Collision);
		}

		static private UnityEngine.ContactPoint GetContact(UnityEngine.Collision instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<System.Int32>())
			{
				return instance.GetContact(parameters[0].ToObject<System.Int32>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Collision.GetContact has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Collision.GetContact has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(UnityEngine.ContactPoint);
		}

		static private System.Int32 GetContacts(UnityEngine.Collision instance, string methodName, Parameters parameters)
		{
			if (parameters.CheckTypes<UnityEngine.ContactPoint[]>())
			{
				return instance.GetContacts(parameters[0].ToObject<UnityEngine.ContactPoint[]>());
			}
			if (0 == parameters.Count)
			{
				UnityEngine.Debug.LogError("UnityEngine.Collision.GetContacts has no implemention without arguments!");
			}
			else
			{
				string[] types = new string[parameters.Count];
				for (int i = parameters.Count - 1; i >= 0; --i)
				{
					types[i] = parameters[i].GetParameterType();
				}
				UnityEngine.Debug.LogErrorFormat("UnityEngine.Collision.GetContacts has no implemention with arguments ({0})!", string.Join(", ", types));
			}
			return default(System.Int32);
		}

		static private System.Collections.IEnumerator GetEnumerator(UnityEngine.Collision instance, string methodName, Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return instance.GetEnumerator();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("UnityEngine.Collision.GetEnumerator has no implemention with arguments ({0})!", string.Join(", ", types));
			return null;
		}

		static private UnityEngine.Vector3 get_relativeVelocity(UnityEngine.Collision instance, string name)
		{
			return instance.relativeVelocity;
		}

		static private UnityEngine.Rigidbody get_rigidbody(UnityEngine.Collision instance, string name)
		{
			return instance.rigidbody;
		}

		static private UnityEngine.Collider get_collider(UnityEngine.Collision instance, string name)
		{
			return instance.collider;
		}

		static private UnityEngine.Transform get_transform(UnityEngine.Collision instance, string name)
		{
			return instance.transform;
		}

		static private UnityEngine.GameObject get_gameObject(UnityEngine.Collision instance, string name)
		{
			return instance.gameObject;
		}

		static private System.Int32 get_contactCount(UnityEngine.Collision instance, string name)
		{
			return instance.contactCount;
		}

		static private UnityEngine.ContactPoint[] get_contacts(UnityEngine.Collision instance, string name)
		{
			return instance.contacts;
		}

		static private UnityEngine.Vector3 get_impulse(UnityEngine.Collision instance, string name)
		{
			return instance.impulse;
		}

	}
}
