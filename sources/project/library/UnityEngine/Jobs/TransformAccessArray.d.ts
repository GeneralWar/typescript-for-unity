declare namespace UnityEngine
{
	declare namespace Jobs
	{
		export class TransformAccessArray extends System.ValueType
		{
			public constructor(transforms: UnityEngine.Transform[], desiredJobCount: number);
			public constructor(capacity: number, desiredJobCount: number);
			public Add(transform: UnityEngine.Transform): void;
			public Dispose(): void;
			public RemoveAtSwapBack(index: number): void;
			public SetTransforms(transforms: UnityEngine.Transform[]): void;
			public get isCreated(): boolean;
			public get capacity(): number;
			public set capacity(): number;
			public get length(): number;
		}
	}
}
