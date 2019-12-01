declare namespace UnityEngine
{
	export class LODGroup extends UnityEngine.Component
	{
		public constructor();
		static public get crossFadeAnimationDuration(): number;
		static public set crossFadeAnimationDuration(): number;
		public ForceLOD(index: number): void;
		public GetLODs(): UnityEngine.LOD[];
		public RecalculateBounds(): void;
		public SetLODs(lods: UnityEngine.LOD[]): void;
		public get localReferencePoint(): UnityEngine.Vector3;
		public set localReferencePoint(): UnityEngine.Vector3;
		public get size(): number;
		public set size(): number;
		public get lodCount(): number;
		public get fadeMode(): UnityEngine.LODFadeMode;
		public set fadeMode(): UnityEngine.LODFadeMode;
		public get animateCrossFading(): boolean;
		public set animateCrossFading(): boolean;
		public get enabled(): boolean;
		public set enabled(): boolean;
	}
}
