declare namespace UnityEngine
{
	declare namespace iOS
	{
		export class OnDemandResourcesRequest extends UnityEngine.AsyncOperation
		{
			public Dispose(): void;
			public GetResourcePath(resourceName: string): string;
			public get error(): string;
			public get loadingPriority(): number;
			public set loadingPriority(): number;
		}
	}
}
