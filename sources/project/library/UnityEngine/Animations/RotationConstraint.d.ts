declare namespace UnityEngine
{
	declare namespace Animations
	{
		export class RotationConstraint extends UnityEngine.Behaviour
		{
			public AddSource(source: UnityEngine.Animations.ConstraintSource): number;
			public GetSource(index: number): UnityEngine.Animations.ConstraintSource;
			public RemoveSource(index: number): void;
			public SetSource(index: number, source: UnityEngine.Animations.ConstraintSource): void;
			public get weight(): number;
			public set weight(): number;
			public get rotationAtRest(): UnityEngine.Vector3;
			public set rotationAtRest(): UnityEngine.Vector3;
			public get rotationOffset(): UnityEngine.Vector3;
			public set rotationOffset(): UnityEngine.Vector3;
			public get rotationAxis(): UnityEngine.Animations.Axis;
			public set rotationAxis(): UnityEngine.Animations.Axis;
			public get constraintActive(): boolean;
			public set constraintActive(): boolean;
			public get locked(): boolean;
			public set locked(): boolean;
			public get sourceCount(): number;
		}
	}
}
