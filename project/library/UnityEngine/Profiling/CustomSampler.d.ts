declare namespace UnityEngine
{
	declare namespace Profiling
	{
		export namespace CustomSampler
		{
			export function Create(name: string): UnityEngine.Profiling.CustomSampler;
		}
		export class CustomSampler extends UnityEngine.Profiling.Sampler
		{
			public Begin(): void;
			public Begin(targetObject: UnityEngine.Object): void;
			public End(): void;
		}
	}
}
