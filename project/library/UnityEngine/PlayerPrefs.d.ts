declare namespace UnityEngine
{
	export namespace PlayerPrefs
	{
		export function DeleteAll(): void;
		export function DeleteKey(key: string): void;
		export function GetFloat(key: string): number;
		export function GetFloat(key: string, defaultValue: number): number;
		export function GetInt(key: string): number;
		export function GetInt(key: string, defaultValue: number): number;
		export function GetString(key: string): string;
		export function GetString(key: string, defaultValue: string): string;
		export function HasKey(key: string): number;
		export function Save(): void;
		export function SetFloat(key: string, value: number): void;
		export function SetInt(key: string, value: number): void;
		export function SetString(key: string, value: string): void;
	}
	export class PlayerPrefs
	{
		public constructor();
	}
}
