using System;
using UnityEngine;

namespace General.Typescript
{
	public class SystemNetUploadValuesCompletedEventArgs
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.UploadValuesCompletedEventArgs> self = space.DeclareClass<System.Net.UploadValuesCompletedEventArgs>();
			self.BindConstructor();
			self.BindInstanceProperty("Result", get_Result, null);
		}

		static private System.Byte[] get_Result(System.Net.UploadValuesCompletedEventArgs instance, string name)
		{
			return instance.Result;
		}

	}
}
