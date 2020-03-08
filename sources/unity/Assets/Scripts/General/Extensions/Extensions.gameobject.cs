using System;
using System.Collections.Generic;
using UnityEngine;

namespace General.Typescript
{
	static public partial class Extensions
	{
		static public Component AddCustomComponent(this GameObject target, Type type)
		{
			if (type is ICustomSuperClass)
			{
				Behaviour behaviour = target.AddComponent<Behaviour>();
				//behaviour.SetType(type as CustomType);
				return behaviour;
			}
			else
			{
				return target.AddComponent(type);
			}
		}

		static public Component GetCustomComponent(this GameObject target, Type type)
		{
			if (type is ICustomSuperClass)
			{
				foreach (ICustomSuperClass behaviour in Array.FindAll(target.GetComponentsInParent<Component>(true), c => c is ICustomSuperClass))
				{
					if (behaviour.TypeFullName == type.Name)
					{
						return behaviour as Component;
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
			if (type is ICustomSuperClass)
			{
				foreach (ICustomSuperClass behaviour in Array.FindAll(target.GetComponentsInParent<Component>(true), c => c is ICustomSuperClass))
				{
					if (behaviour.TypeFullName == type.Name)
					{
						return behaviour as Component;
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
			if (type is ICustomSuperClass)
			{
				foreach (ICustomSuperClass behaviour in Array.FindAll(target.GetComponentsInParent<Component>(true), c => c is ICustomSuperClass))
				{
					if (behaviour.TypeFullName == type.Name)
					{
						return behaviour as Component;
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
			if (type is ICustomSuperClass)
			{
				List<Component> components = new List<Component>();
				foreach (ICustomSuperClass behaviour in Array.FindAll(target.GetComponentsInParent<Component>(true), c => c is ICustomSuperClass))
				{
					if (behaviour.TypeFullName == type.Name)
					{
						components.Add(behaviour as Component);
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
			if (type is ICustomSuperClass)
			{
				List<Component> components = new List<Component>();
				foreach (ICustomSuperClass behaviour in Array.FindAll(target.GetComponentsInParent<Component>(true), c => c is ICustomSuperClass))
				{
					if (behaviour.TypeFullName == type.Name)
					{
						components.Add(behaviour as Component);
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
			if (type is ICustomSuperClass)
			{
				List<Component> components = new List<Component>();
				foreach (ICustomSuperClass behaviour in Array.FindAll(target.GetComponentsInParent<Component>(true), c => c is ICustomSuperClass))
				{
					if (behaviour.TypeFullName == type.Name)
					{
						components.Add(behaviour as Component);
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
