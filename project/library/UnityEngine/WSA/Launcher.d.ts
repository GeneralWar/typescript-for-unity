declare namespace UnityEngine
{
	declare namespace WSA
	{
		export namespace Launcher
		{
			export function LaunchFile(folder: UnityEngine.WSA.Folder, relativeFilePath: string, showWarning: number): void;
			export function LaunchFileWithPicker(fileExtension: string): void;
			export function LaunchUri(uri: string, showWarning: number): void;
		}
		export class Launcher
		{
			public constructor();
		}
	}
}
