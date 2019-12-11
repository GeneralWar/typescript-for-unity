using System;
using System.IO;
using System.Runtime.InteropServices;
using UnityEngine;

namespace General.Typescript
{
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
    public class WindowsEntry : Entry
	{
        override public bool initialize()
        {
            string directory = Path.Combine(Application.streamingAssetsPath, "typescript");
#if !UNITY_ANDROID || UNITY_EDITOR
            byte[] nativeData = File.ReadAllBytes(Path.Combine(directory, "natives_blob.bin"));
			byte[] snapshotData = File.ReadAllBytes(Path.Combine(directory, "snapshot_blob.bin"));
			General_Typescript_SetNativeDataBlob(GCHandle.Alloc(nativeData, GCHandleType.Pinned).AddrOfPinnedObject(), nativeData.Length);
			General_Typescript_SetSnapshotDataBlob(GCHandle.Alloc(snapshotData, GCHandleType.Pinned).AddrOfPinnedObject(), snapshotData.Length);
#endif
            mContext = General_Typescript_Initialize();
			if (IntPtr.Zero == mContext)
			{
				Debug.LogError("Initialize typescript failed!");
				return false;
			}

			Entry.Bind();
			return true;
		}

		//public override IntPtr toJSObject<T>(T value)
		//{
		//	throw new NotImplementedException();
		//}
	}
#endif
}