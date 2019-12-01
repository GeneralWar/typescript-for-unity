using UnityEngine;

namespace General.Typescript
{
	public class SystemNetConfigurationWebRequestModulesSection
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.Configuration.WebRequestModulesSection> self = space.DeclareClass<System.Net.Configuration.WebRequestModulesSection>();
			self.BindConstructor(Constructor);
			self.BindInstanceProperty("WebRequestModules", get_WebRequestModules, null);
		}

		static private System.Net.Configuration.WebRequestModulesSection Constructor(Parameters parameters)
		{
			if (0 == parameters.Count)
			{
				return new System.Net.Configuration.WebRequestModulesSection();
			}
			string[] types = new string[parameters.Count];
			for (int i = parameters.Count - 1; i >= 0; --i)
			{
				types[i] = parameters[i].GetParameterType();
			}
			UnityEngine.Debug.LogErrorFormat("System.Net.Configuration.WebRequestModulesSection.constructor has no implemention with arguments ({0})!", string.Join(", ", types));
			return default(System.Net.Configuration.WebRequestModulesSection);
		}

		static private System.Net.Configuration.WebRequestModuleElementCollection get_WebRequestModules(System.Net.Configuration.WebRequestModulesSection instance)
		{
			return instance.WebRequestModules;
		}

	}
}
