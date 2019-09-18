declare namespace UnityEngine
{
	export namespace PropertyName
	{
		export function IsNullOrEmpty(prop: UnityEngine.PropertyName): number;
	}
	export class PropertyName extends System.ValueType
	{
		public constructor(name: string);
		public constructor(other: UnityEngine.PropertyName);
		public constructor(id: number);
		public Equals(other: any): number;
		public Equals(other: UnityEngine.PropertyName): number;
		public GetHashCode(): number;
		public ToString(): string;
	}
}
