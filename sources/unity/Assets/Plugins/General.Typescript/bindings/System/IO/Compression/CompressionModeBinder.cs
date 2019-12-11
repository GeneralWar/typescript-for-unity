using UnityEngine;

namespace General.Typescript
{
	public class SystemIOCompressionCompressionMode
	{
		static public void Bind(Namespace space)
		{
			Enum<System.IO.Compression.CompressionMode> instance = space.DeclareEnum<System.IO.Compression.CompressionMode>();
			instance.SetValue("Decompress", (long)System.IO.Compression.CompressionMode.Decompress);
			instance.SetValue("Compress", (long)System.IO.Compression.CompressionMode.Compress);
		}
	}
}
