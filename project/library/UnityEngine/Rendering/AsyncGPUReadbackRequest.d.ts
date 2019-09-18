declare namespace UnityEngine
{
	declare namespace Rendering
	{
		export class AsyncGPUReadbackRequest extends System.ValueType
		{
			public Update(): void;
			public WaitForCompletion(): void;
			public get done(): number;
			public get hasError(): number;
			public get layerCount(): number;
			public get layerDataSize(): number;
			public get width(): number;
			public get height(): number;
			public get depth(): number;
		}
	}
}
