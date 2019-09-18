declare namespace UnityEngine
{
	export class RectOffset
	{
		public constructor();
		public constructor(left: number, right: number, top: number, bottom: number);
		public Add(rect: UnityEngine.Rect): UnityEngine.Rect;
		public Remove(rect: UnityEngine.Rect): UnityEngine.Rect;
		public ToString(): string;
		public get left(): number;
		public set left(): number;
		public get right(): number;
		public set right(): number;
		public get top(): number;
		public set top(): number;
		public get bottom(): number;
		public set bottom(): number;
		public get horizontal(): number;
		public get vertical(): number;
	}
}
