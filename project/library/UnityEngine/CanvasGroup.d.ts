declare namespace UnityEngine
{
	export class CanvasGroup extends UnityEngine.Behaviour
	{
		public constructor();
		public IsRaycastLocationValid(sp: UnityEngine.Vector2, eventCamera: UnityEngine.Camera): number;
		public get alpha(): number;
		public set alpha(): number;
		public get interactable(): number;
		public set interactable(): number;
		public get blocksRaycasts(): number;
		public set blocksRaycasts(): number;
		public get ignoreParentGroups(): number;
		public set ignoreParentGroups(): number;
	}
}
