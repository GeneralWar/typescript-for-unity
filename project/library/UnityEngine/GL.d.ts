declare namespace UnityEngine
{
	export namespace GL
	{
		export function Begin(mode: number): void;
		export function Clear(clearDepth: boolean, clearColor: boolean, backgroundColor: UnityEngine.Color): void;
		export function Clear(clearDepth: boolean, clearColor: boolean, backgroundColor: UnityEngine.Color, depth: number): void;
		export function ClearWithSkybox(clearDepth: boolean, camera: UnityEngine.Camera): void;
		export function Color(c: UnityEngine.Color): void;
		export function End(): void;
		export function Flush(): void;
		export function GetGPUProjectionMatrix(proj: UnityEngine.Matrix4x4, renderIntoTexture: boolean): UnityEngine.Matrix4x4;
		export function InvalidateState(): void;
		export function IssuePluginEvent(callback: number, eventID: number): void;
		export function LoadIdentity(): void;
		export function LoadOrtho(): void;
		export function LoadPixelMatrix(): void;
		export function LoadPixelMatrix(left: number, right: number, bottom: number, top: number): void;
		export function LoadProjectionMatrix(mat: UnityEngine.Matrix4x4): void;
		export function MultiTexCoord(unit: number, v: UnityEngine.Vector3): void;
		export function MultiTexCoord2(unit: number, x: number, y: number): void;
		export function MultiTexCoord3(unit: number, x: number, y: number, z: number): void;
		export function MultMatrix(m: UnityEngine.Matrix4x4): void;
		export function PopMatrix(): void;
		export function PushMatrix(): void;
		export function RenderTargetBarrier(): void;
		export function TexCoord(v: UnityEngine.Vector3): void;
		export function TexCoord2(x: number, y: number): void;
		export function TexCoord3(x: number, y: number, z: number): void;
		export function Vertex(v: UnityEngine.Vector3): void;
		export function Vertex3(x: number, y: number, z: number): void;
		export function Viewport(pixelRect: UnityEngine.Rect): void;
	}
	export class GL
	{
		public constructor();
		static public get wireframe(): boolean;
		static public set wireframe(): boolean;
		static public get sRGBWrite(): boolean;
		static public set sRGBWrite(): boolean;
		static public get invertCulling(): boolean;
		static public set invertCulling(): boolean;
		static public get modelview(): UnityEngine.Matrix4x4;
		static public set modelview(): UnityEngine.Matrix4x4;
	}
}
