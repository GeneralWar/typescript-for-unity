declare namespace System
{
	declare namespace IO
	{
		export class FileInfo extends System.IO.FileSystemInfo
		{
			public constructor(fileName: string);
			public AppendText(): System.IO.StreamWriter;
			public CopyTo(destFileName: string): System.IO.FileInfo;
			public CopyTo(destFileName: string, overwrite: boolean): System.IO.FileInfo;
			public Create(): System.IO.FileStream;
			public CreateText(): System.IO.StreamWriter;
			public Decrypt(): void;
			public Delete(): void;
			public Encrypt(): void;
			public GetAccessControl(): System.Security.AccessControl.FileSecurity;
			public GetAccessControl(includeSections: System.Security.AccessControl.AccessControlSections): System.Security.AccessControl.FileSecurity;
			public MoveTo(destFileName: string): void;
			public Open(mode: System.IO.FileMode): System.IO.FileStream;
			public Open(mode: System.IO.FileMode, access: System.IO.FileAccess): System.IO.FileStream;
			public Open(mode: System.IO.FileMode, access: System.IO.FileAccess, share: System.IO.FileShare): System.IO.FileStream;
			public OpenRead(): System.IO.FileStream;
			public OpenText(): System.IO.StreamReader;
			public OpenWrite(): System.IO.FileStream;
			public Replace(destinationFileName: string, destinationBackupFileName: string): System.IO.FileInfo;
			public Replace(destinationFileName: string, destinationBackupFileName: string, ignoreMetadataErrors: boolean): System.IO.FileInfo;
			public SetAccessControl(fileSecurity: System.Security.AccessControl.FileSecurity): void;
			public ToString(): string;
			public get Name(): string;
			public get Length(): number;
			public get DirectoryName(): string;
			public get Directory(): System.IO.DirectoryInfo;
			public get IsReadOnly(): boolean;
			public set IsReadOnly(): boolean;
			public get Exists(): boolean;
		}
	}
}
