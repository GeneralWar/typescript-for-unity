using System;
using System.IO;
using System.Runtime.InteropServices;
using UnityEngine;

namespace General.Typescript
{
#if UNITY_STANDALONE_WIN || UNITY_ANDROID
    public class V8Entry : Entry
	{
        override public bool initialize()
        {
            string directory = Path.Combine(Application.streamingAssetsPath, "typescript");
#if !UNITY_ANDROID || UNITY_EDITOR
            byte[] nativeData = File.ReadAllBytes(Path.Combine(directory, "natives_blob.bin"));
			byte[] snapshotData = File.ReadAllBytes(Path.Combine(directory, "snapshot_blob.bin"));
			Entry.SetNativeDataBlob(nativeData);
			Entry.SetSnapshotDataBlob(snapshotData);
#endif
            mContext = Entry.InitializeContext();
			if (IntPtr.Zero == mContext)
			{
				Entry.LogError("Initialize typescript failed!");
				return false;
			}
			return true;
		}

		//public override IntPtr toJSObject<T>(T value)
		//{
		//	throw new NotImplementedException();
		//}
	}
#endif
}