declare namespace UnityEngine
{
	export namespace CrashReport
	{
		export function RemoveAll(): void;
	}
	export class CrashReport
	{
		static public get reports(): UnityEngine.CrashReport[];
		static public get lastReport(): UnityEngine.CrashReport;
		public Remove(): void;
	}
}
