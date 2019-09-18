using System;
using System.Collections.Generic;
using UnityEngine;

namespace General.Typescript
{
	static public partial class Extensions
	{
		static public Component AddCustomComponent(this GameObject target, Type type)
		{
			if (type is CustomType)
			{
				Behaviour behaviour = target.AddComponent<Behaviour>();
				behaviour.SetType(type as CustomType);
				return behaviour;
			}
			else
			{
				return target.AddComponent(type);
			}
		}

		static public Component GetCustomComponent(this GameObject target, Type type)
		{
			if (type is CustomType)
			{
				foreach (Behaviour behaviour in target.GetComponents<Behaviour>())
				{
					if (behaviour.Name == type.Name)
					{
						return behaviour;
					}
				}
			}
			else
			{
				return target.GetComponent(type);
			}
			return null;
		}

		static public Component GetCustomComponentInChildren(this GameObject target, Type type)
		{
			if (type is CustomType)
			{
				foreach (Behaviour behaviour in target.GetComponentsInChildren<Behaviour>())
				{
					if (behaviour.Name == type.Name)
					{
						return behaviour;
					}
				}
			}
			else
			{
				return target.GetComponentInChildren(type);
			}
			return null;
		}

		static public Component GetCustomComponentInParent(this GameObject target, Type type)
		{
			if (type is CustomType)
			{
				foreach (Behaviour behaviour in target.GetComponentsInParent<Behaviour>())
				{
					if (behaviour.Name == type.Name)
					{
						return behaviour;
					}
				}
			}
			else
			{
				return target.GetComponentInParent(type);
			}
			return null;
		}

		static public Component[] GetCustomComponents(this GameObject target, Type type)
		{
			if (type is CustomType)
			{
				List<Component> components = new List<Component>();
				foreach (Behaviour behaviour in target.GetComponents<Behaviour>())
				{
					if (behaviour.Name == type.Name)
					{
						components.Add(behaviour);
					}
				}
				return components.ToArray();
			}
			else
			{
				return target.GetComponents(type);
			}
		}

		static public Component[] GetCustomComponentsInChildren(this GameObject target, Type type)
		{
			if (type is CustomType)
			{
				List<Component> components = new List<Component>();
				foreach (Behaviour behaviour in target.GetComponentsInChildren<Behaviour>())
				{
					if (behaviour.Name == type.Name)
					{
						components.Add(behaviour);
					}
				}
				return components.ToArray();
			}
			else
			{
				return target.GetComponentsInChildren(type);
			}
		}

		static public Component[] GetCustomComponentsInParent(this GameObject target, Type type)
		{
			if (type is CustomType)
			{
				List<Component> components = new List<Component>();
				foreach (Behaviour behaviour in target.GetComponentsInParent<Behaviour>())
				{
					if (behaviour.Name == type.Name)
					{
						components.Add(behaviour);
					}
				}
				return components.ToArray();
			}
			else
			{
				return target.GetComponentsInParent(type);
			}
		}
	}
}
