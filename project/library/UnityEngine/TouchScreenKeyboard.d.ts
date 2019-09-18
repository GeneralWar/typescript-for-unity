declare namespace UnityEngine
{
	export namespace TouchScreenKeyboard
	{
		export function Open(text: string): UnityEngine.TouchScreenKeyboard;
		export function Open(text: string, keyboardType: UnityEngine.TouchScreenKeyboardType): UnityEngine.TouchScreenKeyboard;
		export function Open(text: string, keyboardType: UnityEngine.TouchScreenKeyboardType, autocorrection: number): UnityEngine.TouchScreenKeyboard;
		export function Open(text: string, keyboardType: UnityEngine.TouchScreenKeyboardType, autocorrection: number, multiline: number): UnityEngine.TouchScreenKeyboard;
		export function Open(text: string, keyboardType: UnityEngine.TouchScreenKeyboardType, autocorrection: number, multiline: number, secure: number): UnityEngine.TouchScreenKeyboard;
		export function Open(text: string, keyboardType: UnityEngine.TouchScreenKeyboardType, autocorrection: number, multiline: number, secure: number, alert: number): UnityEngine.TouchScreenKeyboard;
		export function Open(text: string, keyboardType: UnityEngine.TouchScreenKeyboardType, autocorrection: number, multiline: number, secure: number, alert: number, textPlaceholder: string): UnityEngine.TouchScreenKeyboard;
		export function Open(text: string, keyboardType: UnityEngine.TouchScreenKeyboardType, autocorrection: number, multiline: number, secure: number, alert: number, textPlaceholder: string, characterLimit: number): UnityEngine.TouchScreenKeyboard;
	}
	export class TouchScreenKeyboard
	{
		public constructor(text: string, keyboardType: UnityEngine.TouchScreenKeyboardType, autocorrection: number, multiline: number, secure: number, alert: number, textPlaceholder: string, characterLimit: number);
		static public get isSupported(): number;
		static public get hideInput(): number;
		static public set hideInput(): number;
		static public get area(): UnityEngine.Rect;
		static public get visible(): number;
		public get text(): string;
		public set text(): string;
		public get active(): number;
		public set active(): number;
		public get characterLimit(): number;
		public set characterLimit(): number;
		public get canGetSelection(): number;
		public get canSetSelection(): number;
		public get selection(): UnityEngine.RangeInt;
		public set selection(): UnityEngine.RangeInt;
		public get type(): UnityEngine.TouchScreenKeyboardType;
		public get targetDisplay(): number;
		public set targetDisplay(): number;
	}
}
