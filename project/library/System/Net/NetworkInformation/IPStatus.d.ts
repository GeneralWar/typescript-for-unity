﻿declare namespace System
{
	declare namespace Net
	{
		declare namespace NetworkInformation
		{
			export enum IPStatus
			{
				Success = 0,
				DestinationNetworkUnreachable = 11002,
				DestinationHostUnreachable = 11003,
				DestinationProtocolUnreachable = 11004,
				DestinationProhibited = 11004,
				DestinationPortUnreachable = 11005,
				NoResources = 11006,
				BadOption = 11007,
				HardwareError = 11008,
				PacketTooBig = 11009,
				TimedOut = 11010,
				BadRoute = 11012,
				TtlExpired = 11013,
				TtlReassemblyTimeExceeded = 11014,
				ParameterProblem = 11015,
				SourceQuench = 11016,
				BadDestination = 11018,
				DestinationUnreachable = 11040,
				TimeExceeded = 11041,
				BadHeader = 11042,
				UnrecognizedNextHeader = 11043,
				IcmpError = 11044,
				DestinationScopeMismatch = 11045,
				Unknown = -1,
			}
		}
	}
}
