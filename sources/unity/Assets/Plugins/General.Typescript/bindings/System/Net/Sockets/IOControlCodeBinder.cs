using UnityEngine;

namespace General.Typescript
{
	public class SystemNetSocketsIOControlCode
	{
		static public void Bind(Namespace space)
		{
			Enum<System.Net.Sockets.IOControlCode> instance = space.DeclareEnum<System.Net.Sockets.IOControlCode>();
			instance.SetValue("EnableCircularQueuing", (long)System.Net.Sockets.IOControlCode.EnableCircularQueuing);
			instance.SetValue("Flush", (long)System.Net.Sockets.IOControlCode.Flush);
			instance.SetValue("AddressListChange", (long)System.Net.Sockets.IOControlCode.AddressListChange);
			instance.SetValue("DataToRead", (long)System.Net.Sockets.IOControlCode.DataToRead);
			instance.SetValue("OobDataRead", (long)System.Net.Sockets.IOControlCode.OobDataRead);
			instance.SetValue("GetBroadcastAddress", (long)System.Net.Sockets.IOControlCode.GetBroadcastAddress);
			instance.SetValue("AddressListQuery", (long)System.Net.Sockets.IOControlCode.AddressListQuery);
			instance.SetValue("QueryTargetPnpHandle", (long)System.Net.Sockets.IOControlCode.QueryTargetPnpHandle);
			instance.SetValue("AsyncIO", (long)System.Net.Sockets.IOControlCode.AsyncIO);
			instance.SetValue("NonBlockingIO", (long)System.Net.Sockets.IOControlCode.NonBlockingIO);
			instance.SetValue("AssociateHandle", (long)System.Net.Sockets.IOControlCode.AssociateHandle);
			instance.SetValue("MultipointLoopback", (long)System.Net.Sockets.IOControlCode.MultipointLoopback);
			instance.SetValue("MulticastScope", (long)System.Net.Sockets.IOControlCode.MulticastScope);
			instance.SetValue("SetQos", (long)System.Net.Sockets.IOControlCode.SetQos);
			instance.SetValue("SetGroupQos", (long)System.Net.Sockets.IOControlCode.SetGroupQos);
			instance.SetValue("RoutingInterfaceChange", (long)System.Net.Sockets.IOControlCode.RoutingInterfaceChange);
			instance.SetValue("NamespaceChange", (long)System.Net.Sockets.IOControlCode.NamespaceChange);
			instance.SetValue("ReceiveAll", (long)System.Net.Sockets.IOControlCode.ReceiveAll);
			instance.SetValue("ReceiveAllMulticast", (long)System.Net.Sockets.IOControlCode.ReceiveAllMulticast);
			instance.SetValue("ReceiveAllIgmpMulticast", (long)System.Net.Sockets.IOControlCode.ReceiveAllIgmpMulticast);
			instance.SetValue("KeepAliveValues", (long)System.Net.Sockets.IOControlCode.KeepAliveValues);
			instance.SetValue("AbsorbRouterAlert", (long)System.Net.Sockets.IOControlCode.AbsorbRouterAlert);
			instance.SetValue("UnicastInterface", (long)System.Net.Sockets.IOControlCode.UnicastInterface);
			instance.SetValue("LimitBroadcasts", (long)System.Net.Sockets.IOControlCode.LimitBroadcasts);
			instance.SetValue("BindToInterface", (long)System.Net.Sockets.IOControlCode.BindToInterface);
			instance.SetValue("MulticastInterface", (long)System.Net.Sockets.IOControlCode.MulticastInterface);
			instance.SetValue("AddMulticastGroupOnInterface", (long)System.Net.Sockets.IOControlCode.AddMulticastGroupOnInterface);
			instance.SetValue("DeleteMulticastGroupFromInterface", (long)System.Net.Sockets.IOControlCode.DeleteMulticastGroupFromInterface);
			instance.SetValue("GetExtensionFunctionPointer", (long)System.Net.Sockets.IOControlCode.GetExtensionFunctionPointer);
			instance.SetValue("GetQos", (long)System.Net.Sockets.IOControlCode.GetQos);
			instance.SetValue("GetGroupQos", (long)System.Net.Sockets.IOControlCode.GetGroupQos);
			instance.SetValue("TranslateHandle", (long)System.Net.Sockets.IOControlCode.TranslateHandle);
			instance.SetValue("RoutingInterfaceQuery", (long)System.Net.Sockets.IOControlCode.RoutingInterfaceQuery);
			instance.SetValue("AddressListSort", (long)System.Net.Sockets.IOControlCode.AddressListSort);
		}
	}
}
