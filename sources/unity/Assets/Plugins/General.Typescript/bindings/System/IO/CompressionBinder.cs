using System;

namespace General.Typescript
{
    public class CompressionBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("Compression");

			SystemIOCompressionCompressionLevel.Bind(self);
			SystemIOCompressionCompressionMode.Bind(self);
			SystemIOCompressionDeflateStream.Bind(self);
			SystemIOCompressionGZipStream.Bind(self);
        }
    }
}