declare namespace UnityEngine
{
	declare namespace Profiling
	{
		export namespace Profiler
		{
			export function AddFramesFromFile(file: string): void;
			export function BeginSample(name: string): void;
			export function BeginSample(name: string, targetObject: UnityEngine.Object): void;
			export function BeginThreadProfiling(threadGroupName: string, threadName: string): void;
			export function EndSample(): void;
			export function EndThreadProfiling(): void;
			export function GetAllocatedMemoryForGraphicsDriver(): number;
			export function GetAreaEnabled(area: UnityEngine.Profiling.ProfilerArea): boolean;
			export function GetMonoHeapSizeLong(): number;
			export function GetMonoUsedSizeLong(): number;
			export function GetRuntimeMemorySizeLong(o: UnityEngine.Object): number;
			export function GetTempAllocatorSize(): number;
			export function GetTotalAllocatedMemoryLong(): number;
			export function GetTotalReservedMemoryLong(): number;
			export function GetTotalUnusedReservedMemoryLong(): number;
			export function SetAreaEnabled(area: UnityEngine.Profiling.ProfilerArea, enabled: boolean): void;
			export function SetTempAllocatorRequestedSize(size: number): boolean;
		}
		export class Profiler
		{
			static public get supported(): boolean;
			static public get logFile(): string;
			static public set logFile(): string;
			static public get enableBinaryLog(): boolean;
			static public set enableBinaryLog(): boolean;
			static public get maxUsedMemory(): number;
			static public set maxUsedMemory(): number;
			static public get enabled(): boolean;
			static public set enabled(): boolean;
			static public get areaCount(): number;
			static public get usedHeapSizeLong(): number;
		}
	}
}
