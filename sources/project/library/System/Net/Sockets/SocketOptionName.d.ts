﻿declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export enum SocketOptionName
			{
				Debug = 1,
				NoChecksum = 1,
				NoDelay = 1,
				IPOptions = 1,
				Expedited = 2,
				BsdUrgent = 2,
				HeaderIncluded = 2,
				AcceptConnection = 2,
				TypeOfService = 3,
				ReuseAddress = 4,
				IpTimeToLive = 4,
				KeepAlive = 8,
				MulticastInterface = 9,
				MulticastTimeToLive = 10,
				MulticastLoopback = 11,
				AddMembership = 12,
				DropMembership = 13,
				DontFragment = 14,
				AddSourceMembership = 15,
				DropSourceMembership = 16,
				DontRoute = 16,
				BlockSource = 17,
				UnblockSource = 18,
				PacketInformation = 19,
				ChecksumCoverage = 20,
				HopLimit = 21,
				IPProtectionLevel = 23,
				IPv6Only = 27,
				Broadcast = 32,
				UseLoopback = 64,
				Linger = 128,
				OutOfBandInline = 256,
				SendBuffer = 4097,
				ReceiveBuffer = 4098,
				SendLowWater = 4099,
				ReceiveLowWater = 4100,
				SendTimeout = 4101,
				ReceiveTimeout = 4102,
				Error = 4103,
				Type = 4104,
				ReuseUnicastPort = 12295,
				UpdateAcceptContext = 28683,
				UpdateConnectContext = 28688,
				MaxConnections = 2147483647,
				DontLinger = -129,
				ExclusiveAddressUse = -5,
			}
		}
	}
}
