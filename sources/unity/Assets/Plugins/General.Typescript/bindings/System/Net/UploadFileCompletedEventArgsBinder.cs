using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemNetUploadFileCompletedEventArgs
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.UploadFileCompletedEventArgs> self = space.DeclareClass<System.Net.UploadFileCompletedEventArgs>();
			self.BindConstructor();
			self.BindInstanceProperty("Result", get_Result, null);
		}

		static private System.Byte[] get_Result(System.Net.UploadFileCompletedEventArgs instance, string name)
		{
			return instance.Result;
		}

	}
}
