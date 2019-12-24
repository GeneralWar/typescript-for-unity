using UnityEngine;

namespace General.Typescript
{
	public class SystemIOFileAttributes
	{
		static public void Bind(Namespace space)
		{
			Enum<System.IO.FileAttributes> instance = space.DeclareEnum<System.IO.FileAttributes>();
			instance.SetValue("ReadOnly", (long)System.IO.FileAttributes.ReadOnly);
			instance.SetValue("Hidden", (long)System.IO.FileAttributes.Hidden);
			instance.SetValue("System", (long)System.IO.FileAttributes.System);
			instance.SetValue("Directory", (long)System.IO.FileAttributes.Directory);
			instance.SetValue("Archive", (long)System.IO.FileAttributes.Archive);
			instance.SetValue("Device", (long)System.IO.FileAttributes.Device);
			instance.SetValue("Normal", (long)System.IO.FileAttributes.Normal);
			instance.SetValue("Temporary", (long)System.IO.FileAttributes.Temporary);
			instance.SetValue("SparseFile", (long)System.IO.FileAttributes.SparseFile);
			instance.SetValue("ReparsePoint", (long)System.IO.FileAttributes.ReparsePoint);
			instance.SetValue("Compressed", (long)System.IO.FileAttributes.Compressed);
			instance.SetValue("Offline", (long)System.IO.FileAttributes.Offline);
			instance.SetValue("NotContentIndexed", (long)System.IO.FileAttributes.NotContentIndexed);
			instance.SetValue("Encrypted", (long)System.IO.FileAttributes.Encrypted);
			instance.SetValue("IntegrityStream", (long)System.IO.FileAttributes.IntegrityStream);
			instance.SetValue("NoScrubData", (long)System.IO.FileAttributes.NoScrubData);
		}
	}
}
