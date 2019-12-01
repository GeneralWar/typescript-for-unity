declare namespace UnityEngine
{
	export namespace Screen
	{
		export function SetResolution(width: number, height: number, fullscreenMode: UnityEngine.FullScreenMode): void;
		export function SetResolution(width: number, height: number, fullscreen: boolean): void;
		export function SetResolution(width: number, height: number, fullscreenMode: UnityEngine.FullScreenMode, preferredRefreshRate: number): void;
		export function SetResolution(width: number, height: number, fullscreen: boolean, preferredRefreshRate: number): void;
	}
	export class Screen
	{
		public constructor();
		static public get width(): number;
		static public get height(): number;
		static public get dpi(): number;
		static public get orientation(): UnityEngine.ScreenOrientation;
		static public set orientation(): UnityEngine.ScreenOrientation;
		static public get sleepTimeout(): number;
		static public set sleepTimeout(): number;
		static public get autorotateToPortrait(): boolean;
		static public set autorotateToPortrait(): boolean;
		static public get autorotateToPortraitUpsideDown(): boolean;
		static public set autorotateToPortraitUpsideDown(): boolean;
		static public get autorotateToLandscapeLeft(): boolean;
		static public set autorotateToLandscapeLeft(): boolean;
		static public get autorotateToLandscapeRight(): boolean;
		static public set autorotateToLandscapeRight(): boolean;
		static public get currentResolution(): UnityEngine.Resolution;
		static public get fullScreen(): boolean;
		static public set fullScreen(): boolean;
		static public get fullScreenMode(): UnityEngine.FullScreenMode;
		static public set fullScreenMode(): UnityEngine.FullScreenMode;
		static public get safeArea(): UnityEngine.Rect;
		static public get resolutions(): UnityEngine.Resolution[];
	}
}
