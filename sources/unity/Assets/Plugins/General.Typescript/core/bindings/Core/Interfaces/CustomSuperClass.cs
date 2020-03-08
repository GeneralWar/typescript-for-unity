using System;

namespace General.Typescript
{
	public interface ICustomSuperClass
	{
		string TypeFullName { get; set; }

		void Initialize();
		void SetJsHandle(IntPtr handle);
	}
}
