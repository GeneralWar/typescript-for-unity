declare namespace UnityEngine
{
	export class Compass
	{
		public constructor();
		public get magneticHeading(): number;
		public get trueHeading(): number;
		public get headingAccuracy(): number;
		public get rawVector(): UnityEngine.Vector3;
		public get timestamp(): number;
		public get enabled(): number;
		public set enabled(): number;
	}
}
