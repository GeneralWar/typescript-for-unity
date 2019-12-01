declare namespace UnityEngine
{
	export namespace GeometryUtility
	{
		export function CalculateBounds(positions: UnityEngine.Vector3[], transform: UnityEngine.Matrix4x4): UnityEngine.Bounds;
		export function CalculateFrustumPlanes(camera: UnityEngine.Camera): UnityEngine.Plane[];
		export function CalculateFrustumPlanes(worldToProjectionMatrix: UnityEngine.Matrix4x4): UnityEngine.Plane[];
		export function CalculateFrustumPlanes(camera: UnityEngine.Camera, planes: UnityEngine.Plane[]): void;
		export function CalculateFrustumPlanes(worldToProjectionMatrix: UnityEngine.Matrix4x4, planes: UnityEngine.Plane[]): void;
		export function TestPlanesAABB(planes: UnityEngine.Plane[], bounds: UnityEngine.Bounds): boolean;
	}
	export class GeometryUtility
	{
		public constructor();
	}
}
