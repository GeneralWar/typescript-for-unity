declare namespace UnityEngine
{
	declare namespace SceneManagement
	{
		export class Scene extends System.ValueType
		{
			public Equals(other: any): boolean;
			public GetHashCode(): number;
			public GetRootGameObjects(): UnityEngine.GameObject[];
			public IsValid(): boolean;
			public get handle(): number;
			public get path(): string;
			public get name(): string;
			public set name(): string;
			public get isLoaded(): boolean;
			public get buildIndex(): number;
			public get isDirty(): boolean;
			public get rootCount(): number;
		}
	}
}
