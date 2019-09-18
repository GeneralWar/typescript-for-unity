declare namespace UnityEngine
{
	export namespace Application
	{
		export function CanStreamedLevelBeLoaded(levelIndex: number): number;
		export function CanStreamedLevelBeLoaded(levelName: string): number;
		export function GetBuildTags(): string[];
		export function GetStackTraceLogType(logType: UnityEngine.LogType): UnityEngine.StackTraceLogType;
		export function HasProLicense(): number;
		export function HasUserAuthorization(mode: UnityEngine.UserAuthorization): number;
		export function IsPlaying(obj: UnityEngine.Object): number;
		export function OpenURL(url: string): void;
		export function Quit(): void;
		export function Quit(exitCode: number): void;
		export function RequestUserAuthorization(mode: UnityEngine.UserAuthorization): UnityEngine.AsyncOperation;
		export function SetBuildTags(buildTags: string[]): void;
		export function SetStackTraceLogType(logType: UnityEngine.LogType, stackTraceType: UnityEngine.StackTraceLogType): void;
		export function Unload(): void;
	}
	export class Application
	{
		public constructor();
		static public get isPlaying(): number;
		static public get genuine(): number;
		static public get internetReachability(): UnityEngine.NetworkReachability;
		static public get backgroundLoadingPriority(): UnityEngine.ThreadPriority;
		static public set backgroundLoadingPriority(): UnityEngine.ThreadPriority;
		static public get consoleLogPath(): string;
		static public get systemLanguage(): UnityEngine.SystemLanguage;
		static public get targetFrameRate(): number;
		static public set targetFrameRate(): number;
		static public get cloudProjectId(): string;
		static public get companyName(): string;
		static public get productName(): string;
		static public get sandboxType(): UnityEngine.ApplicationSandboxType;
		static public get installMode(): UnityEngine.ApplicationInstallMode;
		static public get identifier(): string;
		static public get installerName(): string;
		static public get version(): string;
		static public get unityVersion(): string;
		static public get absoluteURL(): string;
		static public get temporaryCachePath(): string;
		static public get persistentDataPath(): string;
		static public get streamingAssetsPath(): string;
		static public get dataPath(): string;
		static public get isBatchMode(): number;
		static public get runInBackground(): number;
		static public set runInBackground(): number;
		static public get isConsolePlatform(): number;
		static public get isMobilePlatform(): number;
		static public get buildGUID(): string;
		static public get platform(): UnityEngine.RuntimePlatform;
		static public get isFocused(): number;
		static public get genuineCheckAvailable(): number;
		static public get isEditor(): number;
	}
}
