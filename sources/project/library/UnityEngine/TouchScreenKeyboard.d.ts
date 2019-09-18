declare namespace UnityEngine
{
	export namespace TouchScreenKeyboard
	{
		export function Open(text: string): UnityEngine.TouchScreenKeyboard;
		export function Open(text: string, keyboardType: UnityEngine.TouchScreenKeyboardType): UnityEngine.TouchScreenKeyboard;
		export function Open(text: string, keyboardType: UnityEngine.TouchScreenKeyboardType, autocorrection: boolean): UnityEngine.TouchScreenKeyboard;
		export function Open(text: string, keyboardType: UnityEngine.TouchScreenKeyboardType, autocorrection: boolean, multiline: boolean): UnityEngine.TouchScreenKeyboard;
		export function Open(text: string, keyboardType: UnityEngine.TouchScreenKeyboardType, autocorrection: boolean, multiline: boolean, secure: boolean): UnityEngine.TouchScreenKeyboard;
		export function Open(text: string, keyboardType: UnityEngine.TouchScreenKeyboardType, autocorrection: boolean, multiline: boolean, secure: boolean, alert: boolean): UnityEngine.TouchScreenKeyboard;
		export function Open(text: string, keyboardType: UnityEngine.TouchScreenKeyboardType, autocorrection: boolean, multiline: boolean, secure: boolean, alert: boolean, textPlaceholder: string): UnityEngine.TouchScreenKeyboard;
		export function Open(text: string, keyboardType: UnityEngine.TouchScreenKeyboardType, autocorrection: boolean, multiline: boolean, secure: boolean, alert: boolean, textPlaceholder: string, characterLimit: number): UnityEngine.TouchScreenKeyboard;
	}
	export class TouchScreenKeyboard
	{
		public constructor(text: string, keyboardType: UnityEngine.TouchScreenKeyboardType, autocorrection: boolean, multiline: boolean, secure: boolean, alert: boolean, textPlaceholder: string, characterLimit: number);
		static public get isSupported(): boolean;
		static public get hideInput(): boolean;
		static public set hideInput(): boolean;
		static public get area(): UnityEngine.Rect;
		static public get visible(): boolean;
		public get text(): string;
		public set text(): string;
		public get active(): boolean;
		public set active(): boolean;
		public get characterLimit(): number;
		public set characterLimit(): number;
		public get canGetSelection(): boolean;
		public get canSetSelection(): boolean;
		public get selection(): UnityEngine.RangeInt;
		public set selection(): UnityEngine.RangeInt;
		public get type(): UnityEngine.TouchScreenKeyboardType;
		public get targetDisplay(): number;
		public set targetDisplay(): number;
	}
}
