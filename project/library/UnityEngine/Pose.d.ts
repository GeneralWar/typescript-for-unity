declare namespace UnityEngine
{
	export class Pose extends System.ValueType
	{
		public constructor(position: UnityEngine.Vector3, rotation: UnityEngine.Quaternion);
		static public get identity(): UnityEngine.Pose;
		public Equals(obj: any): boolean;
		public Equals(other: UnityEngine.Pose): boolean;
		public GetHashCode(): number;
		public GetTransformedBy(lhs: UnityEngine.Pose): UnityEngine.Pose;
		public GetTransformedBy(lhs: UnityEngine.Transform): UnityEngine.Pose;
		public ToString(): string;
		public ToString(format: string): string;
		public get forward(): UnityEngine.Vector3;
		public get right(): UnityEngine.Vector3;
		public get up(): UnityEngine.Vector3;
	}
}
