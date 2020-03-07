using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace General.Typescript
{
	internal partial class TypeClassBinder : ClassBinder
	{
		struct IgnoredProperty
		{
			public PropertyInfo info;
			public bool getter;
			public bool setter;

			public IgnoredProperty(PropertyInfo info, bool getter, bool setter)
			{
				this.info = info;
				this.getter = getter;
				this.setter = setter;
			}
		}

		//static private Dictionary<MethodInfo, string> sReplacedMethods = new Dictionary<MethodInfo, string>();
		static private List<MethodInfo> sIgnoredMethods = new List<MethodInfo>();

		static private List<IgnoredProperty> sIgnoredProperties = new List<IgnoredProperty>();

		static TypeClassBinder()
		{
			//Type type = typeof(UnityEngine.GameObject);
			//MethodInfo origin = type.GetMethod("AddComponent", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(Type) }, null);
			//sReplacedMethods.Add(origin, "AddCustomComponent");
			//origin = type.GetMethod("GetComponent", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(Type) }, null);
			//sReplacedMethods.Add(origin, "GetCustomComponent");
			//origin = type.GetMethod("GetComponentInChildren", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(Type) }, null);
			//sReplacedMethods.Add(origin, "GetCustomComponentInChildren");
			//origin = type.GetMethod("GetComponentInParent", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(Type) }, null);
			//sReplacedMethods.Add(origin, "GetCustomComponentInParent");
			//origin = type.GetMethod("GetComponents", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(Type) }, null);
			//sReplacedMethods.Add(origin, "GetCustomComponents");
			//origin = type.GetMethod("GetComponentsInChildren", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(Type) }, null);
			//sReplacedMethods.Add(origin, "GetCustomComponentsInChildren");
			//origin = type.GetMethod("GetComponentsInParent", BindingFlags.Instance | BindingFlags.Public, null, new Type[] { typeof(Type) }, null);
			//sReplacedMethods.Add(origin, "GetCustomComponentsInParent");

			Type type = typeof(UnityEngine.Light);
			MethodInfo origin = type.GetMethod("SetLightDirty", BindingFlags.Instance | BindingFlags.Public);
			sIgnoredMethods.Add(origin);
			type = typeof(UnityEngine.UI.Text);
			origin = type.GetMethod("OnRebuildRequested", BindingFlags.Instance | BindingFlags.Public);
			sIgnoredMethods.Add(origin);

			type = typeof(UnityEngine.AnimatorControllerParameter);
			sIgnoredProperties.Add(new IgnoredProperty(type.GetProperty("name"), false, true));
		}

		static private bool IsGetterIgnored(PropertyInfo info)
		{
			if (!info.CanRead || null == info.GetMethod || !info.GetMethod.IsPublic)
			{
				return true; 
   			}
			int index = sIgnoredProperties.FindIndex(i => i.info == info);
			return -1 == index ? false : sIgnoredProperties[index].getter;
		}

		static private bool IsSetterIgnored(PropertyInfo info)
		{
			if (!info.CanWrite || null == info.SetMethod || !info.SetMethod.IsPublic)
			{
				return true;
			}
			int index = sIgnoredProperties.FindIndex(i => i.info == info);
			return -1 == index ? false : sIgnoredProperties[index].setter;
		}

		static private bool IsSetterIgnored(MemberInfo info)
		{
			if (info is PropertyInfo)
			{
				return IsSetterIgnored(info as PropertyInfo);
			}
			if (info is FieldInfo)
			{
				FieldInfo field = info as FieldInfo;
				return FieldAttributes.InitOnly == (field.Attributes & FieldAttributes.InitOnly);
			}
			return true;
		}

		static private Type checkReturnType(List<MethodInfo> methods)
		{
			Type returnType = methods[0].ReturnType;
			if (methods.Count > 1 && methods.Any(m => m.ReturnType != returnType))
			{
				returnType = typeof(object);
			}
			return returnType;
		}
	}
}
