declare namespace UnityEngine
{
	export class CanvasGroup extends UnityEngine.Behaviour
	{
		public constructor();
		public IsRaycastLocationValid(sp: UnityEngine.Vector2, eventCamera: UnityEngine.Camera): boolean;
		public get alpha(): number;
		public set alpha(): number;
		public get interactable(): boolean;
		public set interactable(): boolean;
		public get blocksRaycasts(): boolean;
		public set blocksRaycasts(): boolean;
		public get ignoreParentGroups(): boolean;
		public set ignoreParentGroups(): boolean;
	}
}
