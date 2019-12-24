using UnityEngine;

namespace General.Typescript
{
	public class SystemIOCompressionCompressionLevel
	{
		static public void Bind(Namespace space)
		{
			Enum<System.IO.Compression.CompressionLevel> instance = space.DeclareEnum<System.IO.Compression.CompressionLevel>();
			instance.SetValue("Optimal", (long)System.IO.Compression.CompressionLevel.Optimal);
			instance.SetValue("Fastest", (long)System.IO.Compression.CompressionLevel.Fastest);
			instance.SetValue("NoCompression", (long)System.IO.Compression.CompressionLevel.NoCompression);
		}
	}
}
