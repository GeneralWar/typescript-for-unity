declare namespace UnityEngine
{
	declare namespace Rendering
	{
		export class ShaderKeyword
		{
			public constructor(keywordName: string);
			public GetKeywordName(): string;
			public GetKeywordType(): UnityEngine.Rendering.ShaderKeywordType;
			public IsValid(): boolean;
		}
	}
}
