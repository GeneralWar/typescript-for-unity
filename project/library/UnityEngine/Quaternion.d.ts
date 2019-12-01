declare namespace UnityEngine
{
	export namespace Quaternion
	{
		export function Angle(a: UnityEngine.Quaternion, b: UnityEngine.Quaternion): number;
		export function AngleAxis(angle: number, axis: UnityEngine.Vector3): UnityEngine.Quaternion;
		export function Dot(a: UnityEngine.Quaternion, b: UnityEngine.Quaternion): number;
		export function Euler(euler: UnityEngine.Vector3): UnityEngine.Quaternion;
		export function Euler(x: number, y: number, z: number): UnityEngine.Quaternion;
		export function FromToRotation(fromDirection: UnityEngine.Vector3, toDirection: UnityEngine.Vector3): UnityEngine.Quaternion;
		export function Inverse(rotation: UnityEngine.Quaternion): UnityEngine.Quaternion;
		export function Lerp(a: UnityEngine.Quaternion, b: UnityEngine.Quaternion, t: number): UnityEngine.Quaternion;
		export function LerpUnclamped(a: UnityEngine.Quaternion, b: UnityEngine.Quaternion, t: number): UnityEngine.Quaternion;
		export function LookRotation(forward: UnityEngine.Vector3): UnityEngine.Quaternion;
		export function LookRotation(forward: UnityEngine.Vector3, upwards: UnityEngine.Vector3): UnityEngine.Quaternion;
		export function Normalize(q: UnityEngine.Quaternion): UnityEngine.Quaternion;
		export function RotateTowards(from: UnityEngine.Quaternion, to: UnityEngine.Quaternion, maxDegreesDelta: number): UnityEngine.Quaternion;
		export function Slerp(a: UnityEngine.Quaternion, b: UnityEngine.Quaternion, t: number): UnityEngine.Quaternion;
		export function SlerpUnclamped(a: UnityEngine.Quaternion, b: UnityEngine.Quaternion, t: number): UnityEngine.Quaternion;
	}
	export class Quaternion extends System.ValueType
	{
		public constructor(x: number, y: number, z: number, w: number);
		static public get identity(): UnityEngine.Quaternion;
		public Equals(other: any): boolean;
		public Equals(other: UnityEngine.Quaternion): boolean;
		public GetHashCode(): number;
		public Normalize(): void;
		public Set(newX: number, newY: number, newZ: number, newW: number): void;
		public SetFromToRotation(fromDirection: UnityEngine.Vector3, toDirection: UnityEngine.Vector3): void;
		public SetLookRotation(view: UnityEngine.Vector3): void;
		public SetLookRotation(view: UnityEngine.Vector3, up: UnityEngine.Vector3): void;
		public ToString(): string;
		public ToString(format: string): string;
		public get eulerAngles(): UnityEngine.Vector3;
		public set eulerAngles(): UnityEngine.Vector3;
		public get normalized(): UnityEngine.Quaternion;
	}
}
