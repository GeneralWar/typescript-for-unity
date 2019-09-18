declare namespace UnityEngine
{
	export class RaycastHit extends System.ValueType
	{
		public get collider(): UnityEngine.Collider;
		public get point(): UnityEngine.Vector3;
		public set point(): UnityEngine.Vector3;
		public get normal(): UnityEngine.Vector3;
		public set normal(): UnityEngine.Vector3;
		public get barycentricCoordinate(): UnityEngine.Vector3;
		public set barycentricCoordinate(): UnityEngine.Vector3;
		public get distance(): number;
		public set distance(): number;
		public get triangleIndex(): number;
		public get textureCoord(): UnityEngine.Vector2;
		public get textureCoord2(): UnityEngine.Vector2;
		public get transform(): UnityEngine.Transform;
		public get rigidbody(): UnityEngine.Rigidbody;
		public get lightmapCoord(): UnityEngine.Vector2;
	}
}
