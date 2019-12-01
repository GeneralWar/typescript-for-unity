declare namespace UnityEngine
{
	export namespace DynamicGI
	{
		export function SetEmissive(renderer: UnityEngine.Renderer, color: UnityEngine.Color): void;
		export function SetEnvironmentData(input: number[]): void;
		export function UpdateEnvironment(): void;
	}
	export class DynamicGI
	{
		public constructor();
		static public get indirectScale(): number;
		static public set indirectScale(): number;
		static public get updateThreshold(): number;
		static public set updateThreshold(): number;
		static public get materialUpdateTimeSlice(): number;
		static public set materialUpdateTimeSlice(): number;
		static public get synchronousMode(): boolean;
		static public set synchronousMode(): boolean;
		static public get isConverged(): boolean;
	}
}
