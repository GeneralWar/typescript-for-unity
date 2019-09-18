declare namespace UnityEngine
{
	export class MaterialPropertyBlock
	{
		public constructor();
		public Clear(): void;
		public CopyProbeOcclusionArrayFrom(occlusionProbes: UnityEngine.Vector4[]): void;
		public CopyProbeOcclusionArrayFrom(occlusionProbes: UnityEngine.Vector4[], sourceStart: number, destStart: number, count: number): void;
		public CopySHCoefficientArraysFrom(lightProbes: UnityEngine.Rendering.SphericalHarmonicsL2[]): void;
		public CopySHCoefficientArraysFrom(lightProbes: UnityEngine.Rendering.SphericalHarmonicsL2[], sourceStart: number, destStart: number, count: number): void;
		public GetColor(name: string): UnityEngine.Color;
		public GetColor(nameID: number): UnityEngine.Color;
		public GetFloat(name: string): number;
		public GetFloat(nameID: number): number;
		public GetFloatArray(name: string): number[];
		public GetFloatArray(nameID: number): number[];
		public GetInt(name: string): number;
		public GetInt(nameID: number): number;
		public GetMatrix(name: string): UnityEngine.Matrix4x4;
		public GetMatrix(nameID: number): UnityEngine.Matrix4x4;
		public GetMatrixArray(name: string): UnityEngine.Matrix4x4[];
		public GetMatrixArray(nameID: number): UnityEngine.Matrix4x4[];
		public GetTexture(name: string): UnityEngine.Texture;
		public GetTexture(nameID: number): UnityEngine.Texture;
		public GetVector(name: string): UnityEngine.Vector4;
		public GetVector(nameID: number): UnityEngine.Vector4;
		public GetVectorArray(name: string): UnityEngine.Vector4[];
		public GetVectorArray(nameID: number): UnityEngine.Vector4[];
		public SetBuffer(name: string, value: UnityEngine.ComputeBuffer): void;
		public SetBuffer(nameID: number, value: UnityEngine.ComputeBuffer): void;
		public SetColor(name: string, value: UnityEngine.Color): void;
		public SetColor(nameID: number, value: UnityEngine.Color): void;
		public SetFloat(name: string, value: number): void;
		public SetFloat(nameID: number, value: number): void;
		public SetFloatArray(name: string, values: number[]): void;
		public SetFloatArray(nameID: number, values: number[]): void;
		public SetInt(name: string, value: number): void;
		public SetInt(nameID: number, value: number): void;
		public SetMatrix(name: string, value: UnityEngine.Matrix4x4): void;
		public SetMatrix(nameID: number, value: UnityEngine.Matrix4x4): void;
		public SetMatrixArray(name: string, values: UnityEngine.Matrix4x4[]): void;
		public SetMatrixArray(nameID: number, values: UnityEngine.Matrix4x4[]): void;
		public SetTexture(name: string, value: UnityEngine.Texture): void;
		public SetTexture(nameID: number, value: UnityEngine.Texture): void;
		public SetVector(name: string, value: UnityEngine.Vector4): void;
		public SetVector(nameID: number, value: UnityEngine.Vector4): void;
		public SetVectorArray(name: string, values: UnityEngine.Vector4[]): void;
		public SetVectorArray(nameID: number, values: UnityEngine.Vector4[]): void;
		public get isEmpty(): number;
	}
}
