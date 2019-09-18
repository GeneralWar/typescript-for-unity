declare namespace UnityEngine
{
	export class Logger
	{
		public constructor(logHandler: any);
		public IsLogTypeAllowed(logType: UnityEngine.LogType): boolean;
		public Log(message: any): void;
		public Log(logType: UnityEngine.LogType, message: any): void;
		public Log(tag: string, message: any): void;
		public Log(logType: UnityEngine.LogType, message: any, context: UnityEngine.Object): void;
		public Log(logType: UnityEngine.LogType, tag: string, message: any): void;
		public Log(tag: string, message: any, context: UnityEngine.Object): void;
		public Log(logType: UnityEngine.LogType, tag: string, message: any, context: UnityEngine.Object): void;
		public LogError(tag: string, message: any): void;
		public LogError(tag: string, message: any, context: UnityEngine.Object): void;
		public LogException(exception: System.Exception): void;
		public LogException(exception: System.Exception, context: UnityEngine.Object): void;
		public LogFormat(logType: UnityEngine.LogType, format: string, args: any[]): void;
		public LogFormat(logType: UnityEngine.LogType, context: UnityEngine.Object, format: string, args: any[]): void;
		public LogWarning(tag: string, message: any): void;
		public LogWarning(tag: string, message: any, context: UnityEngine.Object): void;
		public get logHandler(): any;
		public set logHandler(): any;
		public get logEnabled(): boolean;
		public set logEnabled(): boolean;
		public get filterLogType(): UnityEngine.LogType;
		public set filterLogType(): UnityEngine.LogType;
	}
}
