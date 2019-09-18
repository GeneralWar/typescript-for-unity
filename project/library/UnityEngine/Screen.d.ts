declare namespace UnityEngine
{
	export namespace Screen
	{
		export function SetResolution(width: number, height: number, fullscreenMode: UnityEngine.FullScreenMode): void;
		export function SetResolution(width: number, height: number, fullscreen: number): void;
		export function SetResolution(width: number, height: number, fullscreenMode: UnityEngine.FullScreenMode, preferredRefreshRate: number): void;
		export function SetResolution(width: number, height: number, fullscreen: number, preferredRefreshRate: number): void;
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
		static public get autorotateToPortrait(): number;
		static public set autorotateToPortrait(): number;
		static public get autorotateToPortraitUpsideDown(): number;
		static public set autorotateToPortraitUpsideDown(): number;
		static public get autorotateToLandscapeLeft(): number;
		static public set autorotateToLandscapeLeft(): number;
		static public get autorotateToLandscapeRight(): number;
		static public set autorotateToLandscapeRight(): number;
		static public get currentResolution(): UnityEngine.Resolution;
		static public get fullScreen(): number;
		static public set fullScreen(): number;
		static public get fullScreenMode(): UnityEngine.FullScreenMode;
		static public set fullScreenMode(): UnityEngine.FullScreenMode;
		static public get safeArea(): UnityEngine.Rect;
		static public get resolutions(): UnityEngine.Resolution[];
	}
}
