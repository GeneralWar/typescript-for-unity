declare namespace UnityEngine
{
	export class LensFlare extends UnityEngine.Behaviour
	{
		public constructor();
		public get brightness(): number;
		public set brightness(): number;
		public get fadeSpeed(): number;
		public set fadeSpeed(): number;
		public get color(): UnityEngine.Color;
		public set color(): UnityEngine.Color;
		public get flare(): UnityEngine.Flare;
		public set flare(): UnityEngine.Flare;
	}
}
