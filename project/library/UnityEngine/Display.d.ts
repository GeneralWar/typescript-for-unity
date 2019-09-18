declare namespace UnityEngine
{
	export namespace Display
	{
		export function RelativeMouseAt(inputMouseCoordinates: UnityEngine.Vector3): UnityEngine.Vector3;
	}
	export class Display
	{
		static public get main(): UnityEngine.Display;
		public Activate(): void;
		public Activate(width: number, height: number, refreshRate: number): void;
		public SetParams(width: number, height: number, x: number, y: number): void;
		public SetRenderingResolution(w: number, h: number): void;
		public get renderingWidth(): number;
		public get renderingHeight(): number;
		public get systemWidth(): number;
		public get systemHeight(): number;
		public get colorBuffer(): UnityEngine.RenderBuffer;
		public get depthBuffer(): UnityEngine.RenderBuffer;
		public get active(): number;
	}
}
