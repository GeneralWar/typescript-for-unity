using UnityEngine;

namespace General.Typescript
{
	public class SystemNetNetworkInformationIPStatus
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.NetworkInformation.IPStatus> instance = space.DeclareEnum<System.Net.NetworkInformation.IPStatus>();
			instance.SetValue("Success", (long)System.Net.NetworkInformation.IPStatus.Success);
			instance.SetValue("DestinationNetworkUnreachable", (long)System.Net.NetworkInformation.IPStatus.DestinationNetworkUnreachable);
			instance.SetValue("DestinationHostUnreachable", (long)System.Net.NetworkInformation.IPStatus.DestinationHostUnreachable);
			instance.SetValue("DestinationProtocolUnreachable", (long)System.Net.NetworkInformation.IPStatus.DestinationProtocolUnreachable);
			instance.SetValue("DestinationProhibited", (long)System.Net.NetworkInformation.IPStatus.DestinationProhibited);
			instance.SetValue("DestinationPortUnreachable", (long)System.Net.NetworkInformation.IPStatus.DestinationPortUnreachable);
			instance.SetValue("NoResources", (long)System.Net.NetworkInformation.IPStatus.NoResources);
			instance.SetValue("BadOption", (long)System.Net.NetworkInformation.IPStatus.BadOption);
			instance.SetValue("HardwareError", (long)System.Net.NetworkInformation.IPStatus.HardwareError);
			instance.SetValue("PacketTooBig", (long)System.Net.NetworkInformation.IPStatus.PacketTooBig);
			instance.SetValue("TimedOut", (long)System.Net.NetworkInformation.IPStatus.TimedOut);
			instance.SetValue("BadRoute", (long)System.Net.NetworkInformation.IPStatus.BadRoute);
			instance.SetValue("TtlExpired", (long)System.Net.NetworkInformation.IPStatus.TtlExpired);
			instance.SetValue("TtlReassemblyTimeExceeded", (long)System.Net.NetworkInformation.IPStatus.TtlReassemblyTimeExceeded);
			instance.SetValue("ParameterProblem", (long)System.Net.NetworkInformation.IPStatus.ParameterProblem);
			instance.SetValue("SourceQuench", (long)System.Net.NetworkInformation.IPStatus.SourceQuench);
			instance.SetValue("BadDestination", (long)System.Net.NetworkInformation.IPStatus.BadDestination);
			instance.SetValue("DestinationUnreachable", (long)System.Net.NetworkInformation.IPStatus.DestinationUnreachable);
			instance.SetValue("TimeExceeded", (long)System.Net.NetworkInformation.IPStatus.TimeExceeded);
			instance.SetValue("BadHeader", (long)System.Net.NetworkInformation.IPStatus.BadHeader);
			instance.SetValue("UnrecognizedNextHeader", (long)System.Net.NetworkInformation.IPStatus.UnrecognizedNextHeader);
			instance.SetValue("IcmpError", (long)System.Net.NetworkInformation.IPStatus.IcmpError);
			instance.SetValue("DestinationScopeMismatch", (long)System.Net.NetworkInformation.IPStatus.DestinationScopeMismatch);
			instance.SetValue("Unknown", (long)System.Net.NetworkInformation.IPStatus.Unknown);
		}
	}
}
