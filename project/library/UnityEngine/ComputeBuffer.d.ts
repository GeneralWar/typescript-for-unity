declare namespace UnityEngine
{
	export namespace ComputeBuffer
	{
		export function CopyCount(src: UnityEngine.ComputeBuffer, dst: UnityEngine.ComputeBuffer, dstOffsetBytes: number): void;
	}
	export class ComputeBuffer
	{
		public constructor(count: number, stride: number);
		public constructor(count: number, stride: number, type: UnityEngine.ComputeBufferType);
		public Dispose(): void;
		public GetData(data: System.Array): void;
		public GetData(data: System.Array, managedBufferStartIndex: number, computeBufferStartIndex: number, count: number): void;
		public GetNativeBufferPtr(): number;
		public IsValid(): number;
		public Release(): void;
		public SetCounterValue(counterValue: number): void;
		public SetData(data: System.Array): void;
		public SetData(data: System.Array, managedBufferStartIndex: number, computeBufferStartIndex: number, count: number): void;
		public get count(): number;
		public get stride(): number;
	}
}
