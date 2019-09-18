declare namespace UnityEngine
{
	declare namespace SceneManagement
	{
		export class Scene extends System.ValueType
		{
			public Equals(other: any): number;
			public GetHashCode(): number;
			public GetRootGameObjects(): UnityEngine.GameObject[];
			public IsValid(): number;
			public get handle(): number;
			public get path(): string;
			public get name(): string;
			public set name(): string;
			public get isLoaded(): number;
			public get buildIndex(): number;
			public get isDirty(): number;
			public get rootCount(): number;
		}
	}
}
