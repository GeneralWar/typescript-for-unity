using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;
using System;
using AOT;

namespace General.Typescript
{
#if UNITY_STANDALONE
    public class StandaloneEntry : Entry
    {
        override public bool initialize()
        {
            string directory = Path.Combine(Application.streamingAssetsPath, "typescript");
            byte[] nativeData = File.ReadAllBytes(Path.Combine(directory, "natives_blob.bin"));
            byte[] snapshotData = File.ReadAllBytes(Path.Combine(directory, "snapshot_blob.bin"));
            //General_Typescript_SetNativeDataBlob(GCHandle.Alloc(nativeData, GCHandleType.Pinned).AddrOfPinnedObject(), nativeData.Length);
            //General_Typescript_SetSnapshotDataBlob(GCHandle.Alloc(snapshotData, GCHandleType.Pinned).AddrOfPinnedObject(), snapshotData.Length);
            mContext = General_Typescript_Initialize();
            if (IntPtr.Zero == mContext)
            {
                Debug.LogError("Initialize typescript failed!");
                return false;
            }
            return true;
        }
    }
#endif
}