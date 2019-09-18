declare namespace UnityEngine
{
	export namespace Matrix4x4
	{
		export function Determinant(m: UnityEngine.Matrix4x4): number;
		export function Frustum(fp: UnityEngine.FrustumPlanes): UnityEngine.Matrix4x4;
		export function Frustum(left: number, right: number, bottom: number, top: number, zNear: number, zFar: number): UnityEngine.Matrix4x4;
		export function Inverse(m: UnityEngine.Matrix4x4): UnityEngine.Matrix4x4;
		export function LookAt(from: UnityEngine.Vector3, to: UnityEngine.Vector3, up: UnityEngine.Vector3): UnityEngine.Matrix4x4;
		export function Ortho(left: number, right: number, bottom: number, top: number, zNear: number, zFar: number): UnityEngine.Matrix4x4;
		export function Perspective(fov: number, aspect: number, zNear: number, zFar: number): UnityEngine.Matrix4x4;
		export function Rotate(q: UnityEngine.Quaternion): UnityEngine.Matrix4x4;
		export function Scale(vector: UnityEngine.Vector3): UnityEngine.Matrix4x4;
		export function Translate(vector: UnityEngine.Vector3): UnityEngine.Matrix4x4;
		export function Transpose(m: UnityEngine.Matrix4x4): UnityEngine.Matrix4x4;
		export function TRS(pos: UnityEngine.Vector3, q: UnityEngine.Quaternion, s: UnityEngine.Vector3): UnityEngine.Matrix4x4;
	}
	export class Matrix4x4 extends System.ValueType
	{
		public constructor(column0: UnityEngine.Vector4, column1: UnityEngine.Vector4, column2: UnityEngine.Vector4, column3: UnityEngine.Vector4);
		static public get zero(): UnityEngine.Matrix4x4;
		static public get identity(): UnityEngine.Matrix4x4;
		public Equals(other: any): number;
		public Equals(other: UnityEngine.Matrix4x4): number;
		public GetColumn(index: number): UnityEngine.Vector4;
		public GetHashCode(): number;
		public GetRow(index: number): UnityEngine.Vector4;
		public MultiplyPoint(point: UnityEngine.Vector3): UnityEngine.Vector3;
		public MultiplyPoint3x4(point: UnityEngine.Vector3): UnityEngine.Vector3;
		public MultiplyVector(vector: UnityEngine.Vector3): UnityEngine.Vector3;
		public SetColumn(index: number, column: UnityEngine.Vector4): void;
		public SetRow(index: number, row: UnityEngine.Vector4): void;
		public SetTRS(pos: UnityEngine.Vector3, q: UnityEngine.Quaternion, s: UnityEngine.Vector3): void;
		public ToString(): string;
		public ToString(format: string): string;
		public TransformPlane(plane: UnityEngine.Plane): UnityEngine.Plane;
		public ValidTRS(): number;
		public get rotation(): UnityEngine.Quaternion;
		public get lossyScale(): UnityEngine.Vector3;
		public get isIdentity(): number;
		public get determinant(): number;
		public get decomposeProjection(): UnityEngine.FrustumPlanes;
		public get inverse(): UnityEngine.Matrix4x4;
		public get transpose(): UnityEngine.Matrix4x4;
	}
}
