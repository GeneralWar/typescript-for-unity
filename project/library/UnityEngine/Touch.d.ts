declare namespace UnityEngine
{
	export class Touch extends System.ValueType
	{
		public get fingerId(): number;
		public set fingerId(): number;
		public get position(): UnityEngine.Vector2;
		public set position(): UnityEngine.Vector2;
		public get rawPosition(): UnityEngine.Vector2;
		public set rawPosition(): UnityEngine.Vector2;
		public get deltaPosition(): UnityEngine.Vector2;
		public set deltaPosition(): UnityEngine.Vector2;
		public get deltaTime(): number;
		public set deltaTime(): number;
		public get tapCount(): number;
		public set tapCount(): number;
		public get phase(): UnityEngine.TouchPhase;
		public set phase(): UnityEngine.TouchPhase;
		public get pressure(): number;
		public set pressure(): number;
		public get maximumPossiblePressure(): number;
		public set maximumPossiblePressure(): number;
		public get type(): UnityEngine.TouchType;
		public set type(): UnityEngine.TouchType;
		public get altitudeAngle(): number;
		public set altitudeAngle(): number;
		public get azimuthAngle(): number;
		public set azimuthAngle(): number;
		public get radius(): number;
		public set radius(): number;
		public get radiusVariance(): number;
		public set radiusVariance(): number;
	}
}
