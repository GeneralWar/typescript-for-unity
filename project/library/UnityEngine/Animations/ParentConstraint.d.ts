declare namespace UnityEngine
{
	declare namespace Animations
	{
		export class ParentConstraint extends UnityEngine.Behaviour
		{
			public AddSource(source: UnityEngine.Animations.ConstraintSource): number;
			public GetRotationOffset(index: number): UnityEngine.Vector3;
			public GetSource(index: number): UnityEngine.Animations.ConstraintSource;
			public GetTranslationOffset(index: number): UnityEngine.Vector3;
			public RemoveSource(index: number): void;
			public SetRotationOffset(index: number, value: UnityEngine.Vector3): void;
			public SetSource(index: number, source: UnityEngine.Animations.ConstraintSource): void;
			public SetTranslationOffset(index: number, value: UnityEngine.Vector3): void;
			public get weight(): number;
			public set weight(): number;
			public get constraintActive(): boolean;
			public set constraintActive(): boolean;
			public get locked(): boolean;
			public set locked(): boolean;
			public get sourceCount(): number;
			public get translationAtRest(): UnityEngine.Vector3;
			public set translationAtRest(): UnityEngine.Vector3;
			public get rotationAtRest(): UnityEngine.Vector3;
			public set rotationAtRest(): UnityEngine.Vector3;
			public get translationOffsets(): UnityEngine.Vector3[];
			public set translationOffsets(): UnityEngine.Vector3[];
			public get rotationOffsets(): UnityEngine.Vector3[];
			public set rotationOffsets(): UnityEngine.Vector3[];
			public get translationAxis(): UnityEngine.Animations.Axis;
			public set translationAxis(): UnityEngine.Animations.Axis;
			public get rotationAxis(): UnityEngine.Animations.Axis;
			public set rotationAxis(): UnityEngine.Animations.Axis;
		}
	}
}
