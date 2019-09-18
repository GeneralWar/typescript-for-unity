declare namespace UnityEngine
{
	export class TextAsset extends UnityEngine.Object
	{
		public constructor();
		public constructor(text: string);
		public ToString(): string;
		public get text(): string;
		public get bytes(): number[];
	}
}
