declare namespace UnityEngine
{
	declare namespace Rendering
	{
		export class ShaderKeywordSet extends System.ValueType
		{
			public Disable(keyword: UnityEngine.Rendering.ShaderKeyword): void;
			public Enable(keyword: UnityEngine.Rendering.ShaderKeyword): void;
			public GetShaderKeywords(): UnityEngine.Rendering.ShaderKeyword[];
			public IsEnabled(keyword: UnityEngine.Rendering.ShaderKeyword): number;
		}
	}
}
