declare namespace UnityEngine
{
	export class GUIElement extends UnityEngine.Behaviour
	{
		public constructor();
		public GetScreenRect(): UnityEngine.Rect;
		public GetScreenRect(camera: UnityEngine.Camera): UnityEngine.Rect;
		public HitTest(screenPosition: UnityEngine.Vector3): boolean;
		public HitTest(screenPosition: UnityEngine.Vector3, camera: UnityEngine.Camera): boolean;
	}
}
