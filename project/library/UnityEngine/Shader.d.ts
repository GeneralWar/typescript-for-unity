declare namespace UnityEngine
{
	export namespace Shader
	{
		export function DisableKeyword(keyword: string): void;
		export function EnableKeyword(keyword: string): void;
		export function Find(name: string): UnityEngine.Shader;
		export function GetGlobalColor(name: string): UnityEngine.Color;
		export function GetGlobalColor(nameID: number): UnityEngine.Color;
		export function GetGlobalFloat(name: string): number;
		export function GetGlobalFloat(nameID: number): number;
		export function GetGlobalFloatArray(name: string): number[];
		export function GetGlobalFloatArray(nameID: number): number[];
		export function GetGlobalInt(name: string): number;
		export function GetGlobalInt(nameID: number): number;
		export function GetGlobalMatrix(name: string): UnityEngine.Matrix4x4;
		export function GetGlobalMatrix(nameID: number): UnityEngine.Matrix4x4;
		export function GetGlobalMatrixArray(name: string): UnityEngine.Matrix4x4[];
		export function GetGlobalMatrixArray(nameID: number): UnityEngine.Matrix4x4[];
		export function GetGlobalTexture(name: string): UnityEngine.Texture;
		export function GetGlobalTexture(nameID: number): UnityEngine.Texture;
		export function GetGlobalVector(name: string): UnityEngine.Vector4;
		export function GetGlobalVector(nameID: number): UnityEngine.Vector4;
		export function GetGlobalVectorArray(name: string): UnityEngine.Vector4[];
		export function GetGlobalVectorArray(nameID: number): UnityEngine.Vector4[];
		export function IsKeywordEnabled(keyword: string): number;
		export function PropertyToID(name: string): number;
		export function SetGlobalBuffer(name: string, value: UnityEngine.ComputeBuffer): void;
		export function SetGlobalBuffer(nameID: number, value: UnityEngine.ComputeBuffer): void;
		export function SetGlobalColor(name: string, value: UnityEngine.Color): void;
		export function SetGlobalColor(nameID: number, value: UnityEngine.Color): void;
		export function SetGlobalFloat(name: string, value: number): void;
		export function SetGlobalFloat(nameID: number, value: number): void;
		export function SetGlobalFloatArray(name: string, values: number[]): void;
		export function SetGlobalFloatArray(nameID: number, values: number[]): void;
		export function SetGlobalInt(name: string, value: number): void;
		export function SetGlobalInt(nameID: number, value: number): void;
		export function SetGlobalMatrix(name: string, value: UnityEngine.Matrix4x4): void;
		export function SetGlobalMatrix(nameID: number, value: UnityEngine.Matrix4x4): void;
		export function SetGlobalMatrixArray(name: string, values: UnityEngine.Matrix4x4[]): void;
		export function SetGlobalMatrixArray(nameID: number, values: UnityEngine.Matrix4x4[]): void;
		export function SetGlobalTexture(name: string, value: UnityEngine.Texture): void;
		export function SetGlobalTexture(nameID: number, value: UnityEngine.Texture): void;
		export function SetGlobalVector(name: string, value: UnityEngine.Vector4): void;
		export function SetGlobalVector(nameID: number, value: UnityEngine.Vector4): void;
		export function SetGlobalVectorArray(name: string, values: UnityEngine.Vector4[]): void;
		export function SetGlobalVectorArray(nameID: number, values: UnityEngine.Vector4[]): void;
		export function WarmupAllShaders(): void;
	}
	export class Shader extends UnityEngine.Object
	{
		static public get globalMaximumLOD(): number;
		static public set globalMaximumLOD(): number;
		static public get globalRenderPipeline(): string;
		static public set globalRenderPipeline(): string;
		public get maximumLOD(): number;
		public set maximumLOD(): number;
		public get isSupported(): number;
		public get renderQueue(): number;
	}
}
