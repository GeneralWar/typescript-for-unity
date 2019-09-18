declare namespace UnityEngine
{
	export class CachedAssetBundle extends System.ValueType
	{
		public constructor(name: string, hash: UnityEngine.Hash128);
		public get name(): string;
		public set name(): string;
		public get hash(): UnityEngine.Hash128;
		public set hash(): UnityEngine.Hash128;
	}
}
