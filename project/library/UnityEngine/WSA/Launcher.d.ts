declare namespace UnityEngine
{
	declare namespace WSA
	{
		export namespace Launcher
		{
			export function LaunchFile(folder: UnityEngine.WSA.Folder, relativeFilePath: string, showWarning: boolean): void;
			export function LaunchFileWithPicker(fileExtension: string): void;
			export function LaunchUri(uri: string, showWarning: boolean): void;
		}
		export class Launcher
		{
			public constructor();
		}
	}
}
