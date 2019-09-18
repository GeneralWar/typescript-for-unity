declare namespace UnityEngine
{
	export class Cache extends System.ValueType
	{
		public ClearCache(): number;
		public ClearCache(expiration: number): number;
		public Equals(other: any): number;
		public Equals(other: UnityEngine.Cache): number;
		public GetHashCode(): number;
		public get valid(): number;
		public get ready(): number;
		public get readOnly(): number;
		public get path(): string;
		public get index(): number;
		public get spaceFree(): number;
		public get maximumAvailableStorageSpace(): number;
		public set maximumAvailableStorageSpace(): number;
		public get spaceOccupied(): number;
		public get expirationDelay(): number;
		public set expirationDelay(): number;
	}
}
