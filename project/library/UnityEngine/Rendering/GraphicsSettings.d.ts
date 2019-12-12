declare namespace UnityEngine
{
	declare namespace Rendering
	{
		export namespace GraphicsSettings
		{
			export function GetCustomShader(type: UnityEngine.Rendering.BuiltinShaderType): UnityEngine.Shader;
			export function GetShaderMode(type: UnityEngine.Rendering.BuiltinShaderType): UnityEngine.Rendering.BuiltinShaderMode;
			export function HasShaderDefine(defineHash: UnityEngine.Rendering.BuiltinShaderDefine): boolean;
			export function HasShaderDefine(tier: UnityEngine.Rendering.GraphicsTier, defineHash: UnityEngine.Rendering.BuiltinShaderDefine): boolean;
			export function SetCustomShader(type: UnityEngine.Rendering.BuiltinShaderType, shader: UnityEngine.Shader): void;
			export function SetShaderMode(type: UnityEngine.Rendering.BuiltinShaderType, mode: UnityEngine.Rendering.BuiltinShaderMode): void;
		}
		export class GraphicsSettings extends UnityEngine.Object
		{
			static public get transparencySortMode(): UnityEngine.TransparencySortMode;
			static public set transparencySortMode(): UnityEngine.TransparencySortMode;
			static public get transparencySortAxis(): UnityEngine.Vector3;
			static public set transparencySortAxis(): UnityEngine.Vector3;
			static public get lightsUseLinearIntensity(): boolean;
			static public set lightsUseLinearIntensity(): boolean;
			static public get lightsUseColorTemperature(): boolean;
			static public set lightsUseColorTemperature(): boolean;
			static public get useScriptableRenderPipelineBatching(): boolean;
			static public set useScriptableRenderPipelineBatching(): boolean;
			static public get logWhenShaderIsCompiled(): boolean;
			static public set logWhenShaderIsCompiled(): boolean;
			static public get renderPipelineAsset(): UnityEngine.Experimental.Rendering.RenderPipelineAsset;
			static public set renderPipelineAsset(): UnityEngine.Experimental.Rendering.RenderPipelineAsset;
		}
	}
}
