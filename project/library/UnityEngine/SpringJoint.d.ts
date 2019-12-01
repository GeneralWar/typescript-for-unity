declare namespace UnityEngine
{
	export class SpringJoint extends UnityEngine.Joint
	{
		public constructor();
		public get spring(): number;
		public set spring(): number;
		public get damper(): number;
		public set damper(): number;
		public get minDistance(): number;
		public set minDistance(): number;
		public get maxDistance(): number;
		public set maxDistance(): number;
		public get tolerance(): number;
		public set tolerance(): number;
	}
}
