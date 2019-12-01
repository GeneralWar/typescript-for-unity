declare namespace UnityEngine
{
	declare namespace Profiling
	{
		export namespace Sampler
		{
			export function Get(name: string): UnityEngine.Profiling.Sampler;
		}
		export class Sampler
		{
			public GetRecorder(): UnityEngine.Profiling.Recorder;
			public get isValid(): boolean;
			public get name(): string;
		}
	}
}
