declare namespace UnityEngine
{
	export namespace Mathf
	{
		export function Abs(f: number): number;
		export function Abs(value: number): number;
		export function Acos(f: number): number;
		export function Approximately(a: number, b: number): number;
		export function Asin(f: number): number;
		export function Atan(f: number): number;
		export function Atan2(y: number, x: number): number;
		export function Ceil(f: number): number;
		export function CeilToInt(f: number): number;
		export function Clamp(value: number, min: number, max: number): number;
		export function Clamp(value: number, min: number, max: number): number;
		export function Clamp01(value: number): number;
		export function ClosestPowerOfTwo(value: number): number;
		export function CorrelatedColorTemperatureToRGB(kelvin: number): UnityEngine.Color;
		export function Cos(f: number): number;
		export function DeltaAngle(current: number, target: number): number;
		export function Exp(power: number): number;
		export function FloatToHalf(val: number): number;
		export function Floor(f: number): number;
		export function FloorToInt(f: number): number;
		export function Gamma(value: number, absmax: number, gamma: number): number;
		export function GammaToLinearSpace(value: number): number;
		export function HalfToFloat(val: number): number;
		export function InverseLerp(a: number, b: number, value: number): number;
		export function IsPowerOfTwo(value: number): number;
		export function Lerp(a: number, b: number, t: number): number;
		export function LerpAngle(a: number, b: number, t: number): number;
		export function LerpUnclamped(a: number, b: number, t: number): number;
		export function LinearToGammaSpace(value: number): number;
		export function Log(f: number): number;
		export function Log(f: number, p: number): number;
		export function Log10(f: number): number;
		export function Max(values: number[]): number;
		export function Max(values: number[]): number;
		export function Max(a: number, b: number): number;
		export function Max(a: number, b: number): number;
		export function Min(values: number[]): number;
		export function Min(values: number[]): number;
		export function Min(a: number, b: number): number;
		export function Min(a: number, b: number): number;
		export function MoveTowards(current: number, target: number, maxDelta: number): number;
		export function MoveTowardsAngle(current: number, target: number, maxDelta: number): number;
		export function NextPowerOfTwo(value: number): number;
		export function PerlinNoise(x: number, y: number): number;
		export function PingPong(t: number, length: number): number;
		export function Pow(f: number, p: number): number;
		export function Repeat(t: number, length: number): number;
		export function Round(f: number): number;
		export function RoundToInt(f: number): number;
		export function Sign(f: number): number;
		export function Sin(f: number): number;
		export function SmoothStep(from: number, to: number, t: number): number;
		export function Sqrt(f: number): number;
		export function Tan(f: number): number;
	}
	export class Mathf extends System.ValueType
	{
	}
}
