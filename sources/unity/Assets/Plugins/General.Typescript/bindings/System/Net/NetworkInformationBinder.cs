using System;

namespace General.Typescript
{
    public class NetworkInformationBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("NetworkInformation");

			SystemNetNetworkInformationGatewayIPAddressInformationCollection.Bind(self);
			SystemNetNetworkInformationIPAddressCollection.Bind(self);
			SystemNetNetworkInformationIPAddressInformationCollection.Bind(self);
			SystemNetNetworkInformationIPStatus.Bind(self);
			SystemNetNetworkInformationMulticastIPAddressInformationCollection.Bind(self);
			SystemNetNetworkInformationUnicastIPAddressInformationCollection.Bind(self);
        }
    }
}