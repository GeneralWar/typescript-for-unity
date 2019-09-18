declare namespace UnityEngine
{
	declare namespace Animations
	{
		export class LookAtConstraint extends UnityEngine.Behaviour
		{
			public AddSource(source: UnityEngine.Animations.ConstraintSource): number;
			public GetSource(index: number): UnityEngine.Animations.ConstraintSource;
			public RemoveSource(index: number): void;
			public SetSource(index: number, source: UnityEngine.Animations.ConstraintSource): void;
			public get weight(): number;
			public set weight(): number;
			public get roll(): number;
			public set roll(): number;
			public get constraintActive(): number;
			public set constraintActive(): number;
			public get locked(): number;
			public set locked(): number;
			public get rotationAtRest(): UnityEngine.Vector3;
			public set rotationAtRest(): UnityEngine.Vector3;
			public get rotationOffset(): UnityEngine.Vector3;
			public set rotationOffset(): UnityEngine.Vector3;
			public get worldUpObject(): UnityEngine.Transform;
			public set worldUpObject(): UnityEngine.Transform;
			public get useUpObject(): number;
			public set useUpObject(): number;
			public get sourceCount(): number;
		}
	}
}
