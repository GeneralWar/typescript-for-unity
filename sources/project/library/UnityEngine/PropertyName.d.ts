declare namespace UnityEngine
{
	export namespace PropertyName
	{
		export function IsNullOrEmpty(prop: UnityEngine.PropertyName): boolean;
	}
	export class PropertyName extends System.ValueType
	{
		public constructor(name: string);
		public constructor(other: UnityEngine.PropertyName);
		public constructor(id: number);
		public Equals(other: any): boolean;
		public Equals(other: UnityEngine.PropertyName): boolean;
		public GetHashCode(): number;
		public ToString(): string;
	}
}
