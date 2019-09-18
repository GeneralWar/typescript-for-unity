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
			public get isValid(): number;
			public get enabled(): number;
			public set enabled(): number;
			public get elapsedNanoseconds(): number;
			public get sampleBlockCount(): number;
		}
	}
}
