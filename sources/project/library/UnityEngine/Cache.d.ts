declare namespace UnityEngine
{
	export class Cache extends System.ValueType
	{
		public ClearCache(): boolean;
		public ClearCache(expiration: number): boolean;
		public Equals(other: any): boolean;
		public Equals(other: UnityEngine.Cache): boolean;
		public GetHashCode(): number;
		public get valid(): boolean;
		public get ready(): boolean;
		public get readOnly(): boolean;
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
