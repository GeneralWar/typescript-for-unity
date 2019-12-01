﻿declare namespace System
{
	declare namespace Net
	{
		declare namespace Sockets
		{
			export enum IOControlCode
			{
				EnableCircularQueuing = 671088642,
				Flush = 671088644,
				AddressListChange = 671088663,
				DataToRead = 1074030207,
				OobDataRead = 1074033415,
				GetBroadcastAddress = 1207959557,
				AddressListQuery = 1207959574,
				QueryTargetPnpHandle = 1207959576,
				AsyncIO = 2147772029,
				NonBlockingIO = 2147772030,
				AssociateHandle = 2281701377,
				MultipointLoopback = 2281701385,
				MulticastScope = 2281701386,
				SetQos = 2281701387,
				SetGroupQos = 2281701388,
				RoutingInterfaceChange = 2281701397,
				NamespaceChange = 2281701401,
				ReceiveAll = 2550136833,
				ReceiveAllMulticast = 2550136834,
				ReceiveAllIgmpMulticast = 2550136835,
				KeepAliveValues = 2550136836,
				AbsorbRouterAlert = 2550136837,
				UnicastInterface = 2550136838,
				LimitBroadcasts = 2550136839,
				BindToInterface = 2550136840,
				MulticastInterface = 2550136841,
				AddMulticastGroupOnInterface = 2550136842,
				DeleteMulticastGroupFromInterface = 2550136843,
				GetExtensionFunctionPointer = 3355443206,
				GetQos = 3355443207,
				GetGroupQos = 3355443208,
				TranslateHandle = 3355443213,
				RoutingInterfaceQuery = 3355443220,
				AddressListSort = 3355443225,
			}
		}
	}
}
