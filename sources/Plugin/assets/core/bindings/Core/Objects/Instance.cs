using System;

namespace General.Typescript
{
	public class Instance : Object
	{
		private IntPtr mPersistentHandle = IntPtr.Zero;

		internal Instance(IntPtr persistent)
		{
			mPersistentHandle = persistent;
		}

		public bool HasFunction(string name)
		{
			return Entry.HasFunction(mPersistentHandle, name);
		}

		public void CallFunction(string name, params object[] arguments)
		{
			Entry.CallFunction(mPersistentHandle, name, arguments);
		}

		public Result CallFunctionWithResult(string name, params object[] arguments)
		{
			return Entry.CallFunctionWithResult(mPersistentHandle, name, arguments);
		}

		protected override void Release()
		{
			UnityEngine.Debug.Log("Dispose " + mPersistentHandle);
			if (IntPtr.Zero != mPersistentHandle)
			{
				Entry.ReleaseHandle(mPersistentHandle);
				mPersistentHandle = IntPtr.Zero;
			}
		}
	}
}
