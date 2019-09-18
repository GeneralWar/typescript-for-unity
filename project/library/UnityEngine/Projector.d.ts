declare namespace UnityEngine
{
	export class Projector extends UnityEngine.Behaviour
	{
		public constructor();
		public get nearClipPlane(): number;
		public set nearClipPlane(): number;
		public get farClipPlane(): number;
		public set farClipPlane(): number;
		public get fieldOfView(): number;
		public set fieldOfView(): number;
		public get aspectRatio(): number;
		public set aspectRatio(): number;
		public get orthographic(): number;
		public set orthographic(): number;
		public get orthographicSize(): number;
		public set orthographicSize(): number;
		public get ignoreLayers(): number;
		public set ignoreLayers(): number;
		public get material(): UnityEngine.Material;
		public set material(): UnityEngine.Material;
	}
}
