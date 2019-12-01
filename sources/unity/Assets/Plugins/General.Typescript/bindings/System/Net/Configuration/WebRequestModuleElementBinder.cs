using UnityEngine;

namespace General.Typescript
{
	public class SystemNetConfigurationWebRequestModuleElement
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Configuration.WebRequestModuleElement> self = space.DeclareClass<System.Net.Configuration.WebRequestModuleElement>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("Prefix", get_Prefix, set_Prefix);
			self.BindInstanceProperty("Type", get_Type, set_Type);
		}

		static private System.Net.Configuration.WebRequestModuleElement Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.Configuration.WebRequestModuleElement();
			}
			if (parameters.CheckTypes<System.String, System.String>())
			{
				return new System.Net.Configuration.WebRequestModuleElement(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.String>());
			}
			if (parameters.CheckTypes<System.String, System.Type>())
			{
				return new System.Net.Configuration.WebRequestModuleElement(parameters[0].ToObject<System.String>(), parameters[1].ToObject<System.Type>());
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Configuration.WebRequestModuleElement.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.Configuration.WebRequestModuleElement);
		}

		static private System.String get_Prefix(System.Net.Configuration.WebRequestModuleElement instance)
		{
			return instance.Prefix;
		}

		static private void set_Prefix(System.Net.Configuration.WebRequestModuleElement instance, System.String value)
		{
			instance.Prefix = value;
		}

		static private System.Type get_Type(System.Net.Configuration.WebRequestModuleElement instance)
		{
			return instance.Type;
		}

		static private void set_Type(System.Net.Configuration.WebRequestModuleElement instance, System.Type value)
		{
			instance.Type = value;
		}

	}
}
