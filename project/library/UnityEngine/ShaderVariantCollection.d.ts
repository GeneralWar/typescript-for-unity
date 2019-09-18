declare namespace UnityEngine
{
	export class ShaderVariantCollection extends UnityEngine.Object
	{
		public constructor();
		public Add(variant: UnityEngine.ShaderVariantCollection.ShaderVariant): number;
		public Clear(): void;
		public Contains(variant: UnityEngine.ShaderVariantCollection.ShaderVariant): number;
		public Remove(variant: UnityEngine.ShaderVariantCollection.ShaderVariant): number;
		public WarmUp(): void;
		public get shaderCount(): number;
		public get variantCount(): number;
		public get isWarmedUp(): number;
	}
}
