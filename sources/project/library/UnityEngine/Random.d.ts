declare namespace UnityEngine
{
	export namespace Random
	{
		export function ColorHSV(): UnityEngine.Color;
		export function ColorHSV(hueMin: number, hueMax: number): UnityEngine.Color;
		export function ColorHSV(hueMin: number, hueMax: number, saturationMin: number, saturationMax: number): UnityEngine.Color;
		export function ColorHSV(hueMin: number, hueMax: number, saturationMin: number, saturationMax: number, valueMin: number, valueMax: number): UnityEngine.Color;
		export function ColorHSV(hueMin: number, hueMax: number, saturationMin: number, saturationMax: number, valueMin: number, valueMax: number, alphaMin: number, alphaMax: number): UnityEngine.Color;
		export function InitState(seed: number): void;
		export function Range(min: number, max: number): number;
		export function Range(min: number, max: number): number;
	}
	export class Random
	{
		public constructor();
		static public get value(): number;
		static public get insideUnitSphere(): UnityEngine.Vector3;
		static public get insideUnitCircle(): UnityEngine.Vector2;
		static public get onUnitSphere(): UnityEngine.Vector3;
		static public get rotation(): UnityEngine.Quaternion;
		static public get rotationUniform(): UnityEngine.Quaternion;
	}
}
