declare namespace UnityEngine
{
	export namespace AndroidJNIHelper
	{
		export function ConvertToJNIArray(array: System.Array): number;
		export function CreateJavaProxy(proxy: UnityEngine.AndroidJavaProxy): number;
		export function CreateJNIArgArray(args: any[]): UnityEngine.jvalue[];
		export function DeleteJNIArgArray(args: any[], jniArgs: UnityEngine.jvalue[]): void;
		export function GetConstructorID(javaClass: number): number;
		export function GetConstructorID(javaClass: number, signature: string): number;
		export function GetConstructorID(jclass: number, args: any[]): number;
		export function GetFieldID(javaClass: number, fieldName: string): number;
		export function GetFieldID(javaClass: number, fieldName: string, signature: string): number;
		export function GetFieldID(javaClass: number, fieldName: string, signature: string, isStatic: number): number;
		export function GetMethodID(javaClass: number, methodName: string): number;
		export function GetMethodID(javaClass: number, methodName: string, signature: string): number;
		export function GetMethodID(javaClass: number, methodName: string, signature: string, isStatic: number): number;
		export function GetMethodID(jclass: number, methodName: string, args: any[], isStatic: number): number;
		export function GetSignature(obj: any): string;
		export function GetSignature(args: any[]): string;
	}
	export class AndroidJNIHelper
	{
		static public get debug(): number;
		static public set debug(): number;
	}
}
