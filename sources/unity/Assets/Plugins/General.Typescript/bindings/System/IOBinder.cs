using System;

namespace General.Typescript
{
    public class IOBinder
    {
        static public void Bind(Namespace parent)
        {
            Namespace self = parent.DeclareNamespace("IO");

			CompressionBinder.Bind(self);
			SystemIOBinaryReader.Bind(self);
			SystemIOBinaryWriter.Bind(self);
			SystemIOBufferedStream.Bind(self);
			SystemIODirectoryInfo.Bind(self);
			SystemIOFileAccess.Bind(self);
			SystemIOFileAttributes.Bind(self);
			SystemIOFileInfo.Bind(self);
			SystemIOFileStream.Bind(self);
			SystemIOMemoryStream.Bind(self);
			SystemIOPathTooLongException.Bind(self);
			SystemIOSearchOption.Bind(self);
			SystemIOSeekOrigin.Bind(self);
			SystemIOStreamReader.Bind(self);
			SystemIOStreamWriter.Bind(self);
			SystemIOStringReader.Bind(self);
			SystemIOStringWriter.Bind(self);
        }
    }
}