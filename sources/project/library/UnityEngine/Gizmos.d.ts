declare namespace UnityEngine
{
	export namespace Gizmos
	{
		export function DrawCube(center: UnityEngine.Vector3, size: UnityEngine.Vector3): void;
		export function DrawFrustum(center: UnityEngine.Vector3, fov: number, maxRange: number, minRange: number, aspect: number): void;
		export function DrawGUITexture(screenRect: UnityEngine.Rect, texture: UnityEngine.Texture): void;
		export function DrawGUITexture(screenRect: UnityEngine.Rect, texture: UnityEngine.Texture, mat: UnityEngine.Material): void;
		export function DrawGUITexture(screenRect: UnityEngine.Rect, texture: UnityEngine.Texture, leftBorder: number, rightBorder: number, topBorder: number, bottomBorder: number): void;
		export function DrawGUITexture(screenRect: UnityEngine.Rect, texture: UnityEngine.Texture, leftBorder: number, rightBorder: number, topBorder: number, bottomBorder: number, mat: UnityEngine.Material): void;
		export function DrawIcon(center: UnityEngine.Vector3, name: string): void;
		export function DrawIcon(center: UnityEngine.Vector3, name: string, allowScaling: boolean): void;
		export function DrawLine(from: UnityEngine.Vector3, to: UnityEngine.Vector3): void;
		export function DrawMesh(mesh: UnityEngine.Mesh): void;
		export function DrawMesh(mesh: UnityEngine.Mesh, position: UnityEngine.Vector3): void;
		export function DrawMesh(mesh: UnityEngine.Mesh, submeshIndex: number): void;
		export function DrawMesh(mesh: UnityEngine.Mesh, position: UnityEngine.Vector3, rotation: UnityEngine.Quaternion): void;
		export function DrawMesh(mesh: UnityEngine.Mesh, submeshIndex: number, position: UnityEngine.Vector3): void;
		export function DrawMesh(mesh: UnityEngine.Mesh, position: UnityEngine.Vector3, rotation: UnityEngine.Quaternion, scale: UnityEngine.Vector3): void;
		export function DrawMesh(mesh: UnityEngine.Mesh, submeshIndex: number, position: UnityEngine.Vector3, rotation: UnityEngine.Quaternion): void;
		export function DrawMesh(mesh: UnityEngine.Mesh, submeshIndex: number, position: UnityEngine.Vector3, rotation: UnityEngine.Quaternion, scale: UnityEngine.Vector3): void;
		export function DrawRay(r: UnityEngine.Ray): void;
		export function DrawRay(from: UnityEngine.Vector3, direction: UnityEngine.Vector3): void;
		export function DrawSphere(center: UnityEngine.Vector3, radius: number): void;
		export function DrawWireCube(center: UnityEngine.Vector3, size: UnityEngine.Vector3): void;
		export function DrawWireMesh(mesh: UnityEngine.Mesh): void;
		export function DrawWireMesh(mesh: UnityEngine.Mesh, position: UnityEngine.Vector3): void;
		export function DrawWireMesh(mesh: UnityEngine.Mesh, submeshIndex: number): void;
		export function DrawWireMesh(mesh: UnityEngine.Mesh, position: UnityEngine.Vector3, rotation: UnityEngine.Quaternion): void;
		export function DrawWireMesh(mesh: UnityEngine.Mesh, submeshIndex: number, position: UnityEngine.Vector3): void;
		export function DrawWireMesh(mesh: UnityEngine.Mesh, position: UnityEngine.Vector3, rotation: UnityEngine.Quaternion, scale: UnityEngine.Vector3): void;
		export function DrawWireMesh(mesh: UnityEngine.Mesh, submeshIndex: number, position: UnityEngine.Vector3, rotation: UnityEngine.Quaternion): void;
		export function DrawWireMesh(mesh: UnityEngine.Mesh, submeshIndex: number, position: UnityEngine.Vector3, rotation: UnityEngine.Quaternion, scale: UnityEngine.Vector3): void;
		export function DrawWireSphere(center: UnityEngine.Vector3, radius: number): void;
	}
	export class Gizmos
	{
		public constructor();
		static public get color(): UnityEngine.Color;
		static public set color(): UnityEngine.Color;
		static public get matrix(): UnityEngine.Matrix4x4;
		static public set matrix(): UnityEngine.Matrix4x4;
	}
}
