declare namespace UnityEngine
{
	export class ShaderVariantCollection extends UnityEngine.Object
	{
		public constructor();
		public Add(variant: UnityEngine.ShaderVariantCollection.ShaderVariant): boolean;
		public Clear(): void;
		public Contains(variant: UnityEngine.ShaderVariantCollection.ShaderVariant): boolean;
		public Remove(variant: UnityEngine.ShaderVariantCollection.ShaderVariant): boolean;
		public WarmUp(): void;
		public get shaderCount(): number;
		public get variantCount(): number;
		public get isWarmedUp(): boolean;
	}
}
