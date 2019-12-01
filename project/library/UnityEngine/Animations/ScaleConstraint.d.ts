declare namespace UnityEngine
{
	declare namespace Animations
	{
		export class ScaleConstraint extends UnityEngine.Behaviour
		{
			public AddSource(source: UnityEngine.Animations.ConstraintSource): number;
			public GetSource(index: number): UnityEngine.Animations.ConstraintSource;
			public RemoveSource(index: number): void;
			public SetSource(index: number, source: UnityEngine.Animations.ConstraintSource): void;
			public get weight(): number;
			public set weight(): number;
			public get scaleAtRest(): UnityEngine.Vector3;
			public set scaleAtRest(): UnityEngine.Vector3;
			public get scaleOffset(): UnityEngine.Vector3;
			public set scaleOffset(): UnityEngine.Vector3;
			public get scalingAxis(): UnityEngine.Animations.Axis;
			public set scalingAxis(): UnityEngine.Animations.Axis;
			public get constraintActive(): boolean;
			public set constraintActive(): boolean;
			public get locked(): boolean;
			public set locked(): boolean;
			public get sourceCount(): number;
		}
	}
}
