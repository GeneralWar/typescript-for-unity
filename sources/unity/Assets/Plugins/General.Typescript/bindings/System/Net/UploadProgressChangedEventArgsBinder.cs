using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemNetUploadProgressChangedEventArgs
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.UploadProgressChangedEventArgs> self = space.DeclareClass<System.Net.UploadProgressChangedEventArgs>();
			self.BindConstructor();
			self.BindInstanceProperty("BytesReceived", get_BytesReceived, null);
			self.BindInstanceProperty("TotalBytesToReceive", get_TotalBytesToReceive, null);
			self.BindInstanceProperty("BytesSent", get_BytesSent, null);
			self.BindInstanceProperty("TotalBytesToSend", get_TotalBytesToSend, null);
		}

		static private System.Int64 get_BytesReceived(System.Net.UploadProgressChangedEventArgs instance, string name)
		{
			return instance.BytesReceived;
		}

		static private System.Int64 get_TotalBytesToReceive(System.Net.UploadProgressChangedEventArgs instance, string name)
		{
			return instance.TotalBytesToReceive;
		}

		static private System.Int64 get_BytesSent(System.Net.UploadProgressChangedEventArgs instance, string name)
		{
			return instance.BytesSent;
		}

		static private System.Int64 get_TotalBytesToSend(System.Net.UploadProgressChangedEventArgs instance, string name)
		{
			return instance.TotalBytesToSend;
		}

	}
}
