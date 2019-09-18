declare namespace UnityEngine
{
	export namespace SortingLayer
	{
		export function GetLayerValueFromID(id: number): number;
		export function GetLayerValueFromName(name: string): number;
		export function IDToName(id: number): string;
		export function IsValid(id: number): boolean;
		export function NameToID(name: string): number;
	}
	export class SortingLayer extends System.ValueType
	{
		static public get layers(): UnityEngine.SortingLayer[];
		public get id(): number;
		public get name(): string;
		public get value(): number;
	}
}
