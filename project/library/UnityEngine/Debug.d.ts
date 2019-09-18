declare namespace UnityEngine
{
	export namespace Debug
	{
		export function Assert(condition: number): void;
		export function Assert(condition: number, context: UnityEngine.Object): void;
		export function Assert(condition: number, message: any): void;
		export function Assert(condition: number, message: string): void;
		export function Assert(condition: number, message: any, context: UnityEngine.Object): void;
		export function Assert(condition: number, message: string, context: UnityEngine.Object): void;
		export function AssertFormat(condition: number, format: string, args: any[]): void;
		export function AssertFormat(condition: number, context: UnityEngine.Object, format: string, args: any[]): void;
		export function Break(): void;
		export function ClearDeveloperConsole(): void;
		export function DebugBreak(): void;
		export function DrawLine(start: UnityEngine.Vector3, end: UnityEngine.Vector3): void;
		export function DrawLine(start: UnityEngine.Vector3, end: UnityEngine.Vector3, color: UnityEngine.Color): void;
		export function DrawLine(start: UnityEngine.Vector3, end: UnityEngine.Vector3, color: UnityEngine.Color, duration: number): void;
		export function DrawLine(start: UnityEngine.Vector3, end: UnityEngine.Vector3, color: UnityEngine.Color, duration: number, depthTest: number): void;
		export function DrawRay(start: UnityEngine.Vector3, dir: UnityEngine.Vector3): void;
		export function DrawRay(start: UnityEngine.Vector3, dir: UnityEngine.Vector3, color: UnityEngine.Color): void;
		export function DrawRay(start: UnityEngine.Vector3, dir: UnityEngine.Vector3, color: UnityEngine.Color, duration: number): void;
		export function DrawRay(start: UnityEngine.Vector3, dir: UnityEngine.Vector3, color: UnityEngine.Color, duration: number, depthTest: number): void;
		export function Log(message: any): void;
		export function Log(message: any, context: UnityEngine.Object): void;
		export function LogAssertion(message: any): void;
		export function LogAssertion(message: any, context: UnityEngine.Object): void;
		export function LogAssertionFormat(format: string, args: any[]): void;
		export function LogAssertionFormat(context: UnityEngine.Object, format: string, args: any[]): void;
		export function LogError(message: any): void;
		export function LogError(message: any, context: UnityEngine.Object): void;
		export function LogErrorFormat(format: string, args: any[]): void;
		export function LogErrorFormat(context: UnityEngine.Object, format: string, args: any[]): void;
		export function LogException(exception: System.Exception): void;
		export function LogException(exception: System.Exception, context: UnityEngine.Object): void;
		export function LogFormat(format: string, args: any[]): void;
		export function LogFormat(context: UnityEngine.Object, format: string, args: any[]): void;
		export function LogWarning(message: any): void;
		export function LogWarning(message: any, context: UnityEngine.Object): void;
		export function LogWarningFormat(format: string, args: any[]): void;
		export function LogWarningFormat(context: UnityEngine.Object, format: string, args: any[]): void;
	}
	export class Debug
	{
		public constructor();
		static public get unityLogger(): any;
		static public get developerConsoleVisible(): number;
		static public set developerConsoleVisible(): number;
		static public get isDebugBuild(): number;
	}
}
