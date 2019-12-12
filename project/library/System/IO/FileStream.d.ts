declare namespace System
{
	declare namespace IO
	{
		export class FileStream extends System.IO.Stream
		{
			public constructor(path: string, mode: System.IO.FileMode);
			public constructor(handle: Microsoft.Win32.SafeHandles.SafeFileHandle, access: System.IO.FileAccess);
			public constructor(path: string, mode: System.IO.FileMode, access: System.IO.FileAccess);
			public constructor(handle: Microsoft.Win32.SafeHandles.SafeFileHandle, access: System.IO.FileAccess, bufferSize: number);
			public constructor(path: string, mode: System.IO.FileMode, access: System.IO.FileAccess, share: System.IO.FileShare);
			public constructor(handle: Microsoft.Win32.SafeHandles.SafeFileHandle, access: System.IO.FileAccess, bufferSize: number, isAsync: boolean);
			public constructor(path: string, mode: System.IO.FileMode, access: System.IO.FileAccess, share: System.IO.FileShare, bufferSize: number);
			public constructor(path: string, mode: System.IO.FileMode, access: System.IO.FileAccess, share: System.IO.FileShare, bufferSize: number, useAsync: boolean);
			public constructor(path: string, mode: System.IO.FileMode, access: System.IO.FileAccess, share: System.IO.FileShare, bufferSize: number, options: System.IO.FileOptions);
			public constructor(path: string, mode: System.IO.FileMode, rights: System.Security.AccessControl.FileSystemRights, share: System.IO.FileShare, bufferSize: number, options: System.IO.FileOptions);
			public constructor(path: string, mode: System.IO.FileMode, rights: System.Security.AccessControl.FileSystemRights, share: System.IO.FileShare, bufferSize: number, options: System.IO.FileOptions, fileSecurity: System.Security.AccessControl.FileSecurity);
			public EndRead(asyncResult: any): number;
			public EndWrite(asyncResult: any): void;
			public Flush(): void;
			public Flush(flushToDisk: boolean): void;
			public FlushAsync(cancellationToken: System.Threading.CancellationToken): System.Threading.Tasks.Task;
			public GetAccessControl(): System.Security.AccessControl.FileSecurity;
			public Lock(position: number, length: number): void;
			public Read(array: number[], offset: number, count: number): number;
			public ReadByte(): number;
			public Seek(offset: number, origin: System.IO.SeekOrigin): number;
			public SetAccessControl(fileSecurity: System.Security.AccessControl.FileSecurity): void;
			public SetLength(value: number): void;
			public Unlock(position: number, length: number): void;
			public Write(array: number[], offset: number, count: number): void;
			public WriteAsync(buffer: number[], offset: number, count: number, cancellationToken: System.Threading.CancellationToken): System.Threading.Tasks.Task;
			public WriteByte(value: number): void;
			public get CanRead(): boolean;
			public get CanWrite(): boolean;
			public get CanSeek(): boolean;
			public get IsAsync(): boolean;
			public get Name(): string;
			public get Length(): number;
			public get Position(): number;
			public set Position(): number;
			public get SafeFileHandle(): Microsoft.Win32.SafeHandles.SafeFileHandle;
		}
	}
}
