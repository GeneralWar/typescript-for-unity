declare namespace UnityEngine
{
	export class LineRenderer extends UnityEngine.Renderer
	{
		public constructor();
		public BakeMesh(mesh: UnityEngine.Mesh, useTransform: boolean): void;
		public BakeMesh(mesh: UnityEngine.Mesh, camera: UnityEngine.Camera, useTransform: boolean): void;
		public GetPosition(index: number): UnityEngine.Vector3;
		public GetPositions(positions: UnityEngine.Vector3[]): number;
		public SetPosition(index: number, position: UnityEngine.Vector3): void;
		public SetPositions(positions: UnityEngine.Vector3[]): void;
		public Simplify(tolerance: number): void;
		public get startWidth(): number;
		public set startWidth(): number;
		public get endWidth(): number;
		public set endWidth(): number;
		public get widthMultiplier(): number;
		public set widthMultiplier(): number;
		public get numCornerVertices(): number;
		public set numCornerVertices(): number;
		public get numCapVertices(): number;
		public set numCapVertices(): number;
		public get useWorldSpace(): boolean;
		public set useWorldSpace(): boolean;
		public get loop(): boolean;
		public set loop(): boolean;
		public get startColor(): UnityEngine.Color;
		public set startColor(): UnityEngine.Color;
		public get endColor(): UnityEngine.Color;
		public set endColor(): UnityEngine.Color;
		public get positionCount(): number;
		public set positionCount(): number;
		public get shadowBias(): number;
		public set shadowBias(): number;
		public get generateLightingData(): boolean;
		public set generateLightingData(): boolean;
		public get textureMode(): UnityEngine.LineTextureMode;
		public set textureMode(): UnityEngine.LineTextureMode;
		public get alignment(): UnityEngine.LineAlignment;
		public set alignment(): UnityEngine.LineAlignment;
		public get widthCurve(): UnityEngine.AnimationCurve;
		public set widthCurve(): UnityEngine.AnimationCurve;
		public get colorGradient(): UnityEngine.Gradient;
		public set colorGradient(): UnityEngine.Gradient;
	}
}
