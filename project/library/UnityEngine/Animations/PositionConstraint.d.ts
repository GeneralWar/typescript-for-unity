declare namespace UnityEngine
{
	declare namespace Animations
	{
		export class PositionConstraint extends UnityEngine.Behaviour
		{
			public AddSource(source: UnityEngine.Animations.ConstraintSource): number;
			public GetSource(index: number): UnityEngine.Animations.ConstraintSource;
			public RemoveSource(index: number): void;
			public SetSource(index: number, source: UnityEngine.Animations.ConstraintSource): void;
			public get weight(): number;
			public set weight(): number;
			public get translationAtRest(): UnityEngine.Vector3;
			public set translationAtRest(): UnityEngine.Vector3;
			public get translationOffset(): UnityEngine.Vector3;
			public set translationOffset(): UnityEngine.Vector3;
			public get translationAxis(): UnityEngine.Animations.Axis;
			public set translationAxis(): UnityEngine.Animations.Axis;
			public get constraintActive(): number;
			public set constraintActive(): number;
			public get locked(): number;
			public set locked(): number;
			public get sourceCount(): number;
		}
	}
}
