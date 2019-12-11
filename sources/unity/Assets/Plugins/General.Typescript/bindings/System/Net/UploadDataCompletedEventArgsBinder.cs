using UnityEngine;

namespace General.Typescript
{
	public class SystemNetUploadDataCompletedEventArgs
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.UploadDataCompletedEventArgs> self = space.DeclareClass<System.Net.UploadDataCompletedEventArgs>();
			self.BindConstructor();
			self.BindInstanceProperty("Result", get_Result, null);
		}

		static private System.Byte[] get_Result(System.Net.UploadDataCompletedEventArgs instance)
		{
			return instance.Result;
		}

	}
}
