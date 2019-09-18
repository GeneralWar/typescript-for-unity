declare namespace UnityEngine
{
	export class ComputeShader extends UnityEngine.Object
	{
		public Dispatch(kernelIndex: number, threadGroupsX: number, threadGroupsY: number, threadGroupsZ: number): void;
		public DispatchIndirect(kernelIndex: number, argsBuffer: UnityEngine.ComputeBuffer): void;
		public DispatchIndirect(kernelIndex: number, argsBuffer: UnityEngine.ComputeBuffer, argsOffset: number): void;
		public FindKernel(name: string): number;
		public HasKernel(name: string): boolean;
		public SetBool(name: string, val: boolean): void;
		public SetBool(nameID: number, val: boolean): void;
		public SetBuffer(kernelIndex: number, nameID: number, buffer: UnityEngine.ComputeBuffer): void;
		public SetBuffer(kernelIndex: number, name: string, buffer: UnityEngine.ComputeBuffer): void;
		public SetFloat(nameID: number, val: number): void;
		public SetFloat(name: string, val: number): void;
		public SetFloats(name: string, values: number[]): void;
		public SetFloats(nameID: number, values: number[]): void;
		public SetInt(nameID: number, val: number): void;
		public SetInt(name: string, val: number): void;
		public SetInts(name: string, values: number[]): void;
		public SetInts(nameID: number, values: number[]): void;
		public SetMatrix(nameID: number, val: UnityEngine.Matrix4x4): void;
		public SetMatrix(name: string, val: UnityEngine.Matrix4x4): void;
		public SetMatrixArray(nameID: number, values: UnityEngine.Matrix4x4[]): void;
		public SetMatrixArray(name: string, values: UnityEngine.Matrix4x4[]): void;
		public SetTexture(kernelIndex: number, nameID: number, texture: UnityEngine.Texture): void;
		public SetTexture(kernelIndex: number, name: string, texture: UnityEngine.Texture): void;
		public SetTexture(kernelIndex: number, nameID: number, texture: UnityEngine.Texture, mipLevel: number): void;
		public SetTexture(kernelIndex: number, name: string, texture: UnityEngine.Texture, mipLevel: number): void;
		public SetTextureFromGlobal(kernelIndex: number, nameID: number, globalTextureNameID: number): void;
		public SetTextureFromGlobal(kernelIndex: number, name: string, globalTextureName: string): void;
		public SetVector(nameID: number, val: UnityEngine.Vector4): void;
		public SetVector(name: string, val: UnityEngine.Vector4): void;
		public SetVectorArray(nameID: number, values: UnityEngine.Vector4[]): void;
		public SetVectorArray(name: string, values: UnityEngine.Vector4[]): void;
	}
}
