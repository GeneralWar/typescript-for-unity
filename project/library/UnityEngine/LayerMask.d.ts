declare namespace UnityEngine
{
	export namespace LayerMask
	{
		export function GetMask(layerNames: string[]): number;
		export function LayerToName(layer: number): string;
		export function NameToLayer(layerName: string): number;
	}
	export class LayerMask extends System.ValueType
	{
		public get value(): number;
		public set value(): number;
	}
}
