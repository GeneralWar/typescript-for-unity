using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace General.Typescript
{
	internal class CustomType : System.Type
	{
		public const string CUSTOM_PREFIX = "General.Typescript.Custom.Behaviour";

		public override Assembly Assembly { get { return Assembly.GetAssembly(typeof(Type)); } }

		public override string AssemblyQualifiedName { get { return "General.Typescript"; } }

		public override System.Type BaseType { get { return typeof(System.Type); } }

		public override string FullName { get { return mFullname; } }

		public override Guid GUID { get { return Guid.NewGuid(); } }

		public override Module Module { get { return typeof(Type).Module; } }

		public override string Namespace { get { return "General"; } }

		public override System.Type UnderlyingSystemType { get { return typeof(System.Type); } }

		public override string Name { get { return mName; } }

		private string mName = string.Empty;
		private string mFullname = string.Empty;

		public CustomType(string fullname)
		{
			if (!fullname.StartsWith(CUSTOM_PREFIX))
			{
				throw new ArgumentException("The type name does not start with General.Typescript.Custom.Behaviour!");
			}
			mFullname = fullname;
			mName = fullname.Substring(CUSTOM_PREFIX.Length + 1);
		}

		static public bool IsCustomType(string fullname)
		{
			return fullname.StartsWith(CUSTOM_PREFIX);
		}

		public override ConstructorInfo[] GetConstructors(BindingFlags bindingAttr)
		{
			return null;
		}

		public override object[] GetCustomAttributes(bool inherit)
		{
			return null;
		}

		public override object[] GetCustomAttributes(System.Type attributeType, bool inherit)
		{
			return null;
		}

		public override System.Type GetElementType()
		{
			return null;
		}

		public override EventInfo GetEvent(string name, BindingFlags bindingAttr)
		{
			return null;
		}

		public override EventInfo[] GetEvents(BindingFlags bindingAttr)
		{
			return null;
		}

		public override FieldInfo GetField(string name, BindingFlags bindingAttr)
		{
			return null;
		}

		public override FieldInfo[] GetFields(BindingFlags bindingAttr)
		{
			return null;
		}

		public override System.Type GetInterface(string name, bool ignoreCase)
		{
			return null;
		}

		public override System.Type[] GetInterfaces()
		{
			return null;
		}

		public override MemberInfo[] GetMembers(BindingFlags bindingAttr)
		{
			return null;
		}

		public override MethodInfo[] GetMethods(BindingFlags bindingAttr)
		{
			return null;
		}

		public override System.Type GetNestedType(string name, BindingFlags bindingAttr)
		{
			return null;
		}

		public override System.Type[] GetNestedTypes(BindingFlags bindingAttr)
		{
			return null;
		}

		public override PropertyInfo[] GetProperties(BindingFlags bindingAttr)
		{
			return null;
		}

		public override object InvokeMember(string name, BindingFlags invokeAttr, Binder binder, object target, object[] args, ParameterModifier[] modifiers, CultureInfo culture, string[] namedParameters)
		{
			return null;
		}

		public override bool IsDefined(System.Type attributeType, bool inherit)
		{
			return false;
		}

		protected override TypeAttributes GetAttributeFlagsImpl()
		{
			return TypeAttributes.Class;
		}

		protected override ConstructorInfo GetConstructorImpl(BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, System.Type[] types, ParameterModifier[] modifiers)
		{
			return null;
		}

		protected override MethodInfo GetMethodImpl(string name, BindingFlags bindingAttr, Binder binder, CallingConventions callConvention, System.Type[] types, ParameterModifier[] modifiers)
		{
			return null;
		}

		protected override PropertyInfo GetPropertyImpl(string name, BindingFlags bindingAttr, Binder binder, System.Type returnType, System.Type[] types, ParameterModifier[] modifiers)
		{
			return null;
		}

		protected override bool HasElementTypeImpl()
		{
			return false;
		}

		protected override bool IsArrayImpl()
		{
			return false;
		}

		protected override bool IsByRefImpl()
		{
			return true;
		}

		protected override bool IsCOMObjectImpl()
		{
			return false;
		}

		protected override bool IsPointerImpl()
		{
			return true;
		}

		protected override bool IsPrimitiveImpl()
		{
			return false;
		}
	}
}
