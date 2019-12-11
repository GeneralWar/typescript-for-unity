using UnityEngine;

namespace General.Typescript
{
	public class SystemNetUploadStringCompletedEventArgs
	{
		static public void Bind(Namespace space)
		{
			Class<System.Net.UploadStringCompletedEventArgs> self = space.DeclareClass<System.Net.UploadStringCompletedEventArgs>();
			self.BindConstructor();
			self.BindInstanceProperty("Result", get_Result, null);
		}

		static private System.String get_Result(System.Net.UploadStringCompletedEventArgs instance)
		{
			return instance.Result;
		}

	}
}
