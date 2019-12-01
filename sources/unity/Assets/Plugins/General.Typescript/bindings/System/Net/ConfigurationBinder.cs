using System;

namespace General.Typescript
{
    public class ConfigurationBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Configuration");

			SystemNetConfigurationHttpCachePolicyElement.Bind(self);
			SystemNetConfigurationHttpListenerElement.Bind(self);
			SystemNetConfigurationHttpListenerTimeoutsElement.Bind(self);
			SystemNetConfigurationHttpWebRequestElement.Bind(self);
			SystemNetConfigurationRequestCachingSection.Bind(self);
			SystemNetConfigurationWebRequestModuleElement.Bind(self);
			SystemNetConfigurationWebRequestModulesSection.Bind(self);
			SystemNetConfigurationWebUtilityElement.Bind(self);
        }
    }
}