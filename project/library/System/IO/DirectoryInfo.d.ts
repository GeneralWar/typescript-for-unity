declare namespace System
{
	declare namespace IO
	{
		export class DirectoryInfo extends System.IO.FileSystemInfo
		{
			public constructor(path: string);
			public Create(): void;
			public Create(directorySecurity: System.Security.AccessControl.DirectorySecurity): void;
			public CreateSubdirectory(path: string): System.IO.DirectoryInfo;
			public CreateSubdirectory(path: string, directorySecurity: System.Security.AccessControl.DirectorySecurity): System.IO.DirectoryInfo;
			public Delete(): void;
			public Delete(recursive: boolean): void;
			public GetAccessControl(): System.Security.AccessControl.DirectorySecurity;
			public GetAccessControl(includeSections: System.Security.AccessControl.AccessControlSections): System.Security.AccessControl.DirectorySecurity;
			public GetDirectories(): System.IO.DirectoryInfo[];
			public GetDirectories(searchPattern: string): System.IO.DirectoryInfo[];
			public GetDirectories(searchPattern: string, searchOption: System.IO.SearchOption): System.IO.DirectoryInfo[];
			public GetFiles(): System.IO.FileInfo[];
			public GetFiles(searchPattern: string): System.IO.FileInfo[];
			public GetFiles(searchPattern: string, searchOption: System.IO.SearchOption): System.IO.FileInfo[];
			public GetFileSystemInfos(): System.IO.FileSystemInfo[];
			public GetFileSystemInfos(searchPattern: string): System.IO.FileSystemInfo[];
			public GetFileSystemInfos(searchPattern: string, searchOption: System.IO.SearchOption): System.IO.FileSystemInfo[];
			public MoveTo(destDirName: string): void;
			public SetAccessControl(directorySecurity: System.Security.AccessControl.DirectorySecurity): void;
			public ToString(): string;
			public get Exists(): boolean;
			public get Name(): string;
			public get Parent(): System.IO.DirectoryInfo;
			public get Root(): System.IO.DirectoryInfo;
		}
	}
}
