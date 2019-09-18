declare namespace UnityEngine
{
	declare namespace Animations
	{
		export class AimConstraint extends UnityEngine.Behaviour
		{
			public AddSource(source: UnityEngine.Animations.ConstraintSource): number;
			public GetSource(index: number): UnityEngine.Animations.ConstraintSource;
			public RemoveSource(index: number): void;
			public SetSource(index: number, source: UnityEngine.Animations.ConstraintSource): void;
			public get weight(): number;
			public set weight(): number;
			public get constraintActive(): boolean;
			public set constraintActive(): boolean;
			public get locked(): boolean;
			public set locked(): boolean;
			public get rotationAtRest(): UnityEngine.Vector3;
			public set rotationAtRest(): UnityEngine.Vector3;
			public get rotationOffset(): UnityEngine.Vector3;
			public set rotationOffset(): UnityEngine.Vector3;
			public get rotationAxis(): UnityEngine.Animations.Axis;
			public set rotationAxis(): UnityEngine.Animations.Axis;
			public get aimVector(): UnityEngine.Vector3;
			public set aimVector(): UnityEngine.Vector3;
			public get upVector(): UnityEngine.Vector3;
			public set upVector(): UnityEngine.Vector3;
			public get worldUpVector(): UnityEngine.Vector3;
			public set worldUpVector(): UnityEngine.Vector3;
			public get worldUpObject(): UnityEngine.Transform;
			public set worldUpObject(): UnityEngine.Transform;
			public get sourceCount(): number;
		}
	}
}
