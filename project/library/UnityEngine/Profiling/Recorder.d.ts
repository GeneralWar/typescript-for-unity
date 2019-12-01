declare namespace UnityEngine
{
	declare namespace Profiling
	{
		export namespace Recorder
		{
			export function Get(samplerName: string): UnityEngine.Profiling.Recorder;
		}
		export class Recorder
		{
			public CollectFromAllThreads(): void;
			public FilterToCurrentThread(): void;
			public get isValid(): boolean;
			public get enabled(): boolean;
			public set enabled(): boolean;
			public get elapsedNanoseconds(): number;
			public get sampleBlockCount(): number;
		}
	}
}
