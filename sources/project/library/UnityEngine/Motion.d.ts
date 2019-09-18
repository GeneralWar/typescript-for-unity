declare namespace UnityEngine
{
	export class Motion extends UnityEngine.Object
	{
		public get averageDuration(): number;
		public get averageAngularSpeed(): number;
		public get averageSpeed(): UnityEngine.Vector3;
		public get apparentSpeed(): number;
		public get isLooping(): boolean;
		public get legacy(): boolean;
		public get isHumanMotion(): boolean;
	}
}
