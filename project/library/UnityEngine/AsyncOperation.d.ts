declare namespace UnityEngine
{
	export class AsyncOperation extends UnityEngine.YieldInstruction
	{
		public constructor();
		public get isDone(): boolean;
		public get progress(): number;
		public get priority(): number;
		public set priority(): number;
		public get allowSceneActivation(): boolean;
		public set allowSceneActivation(): boolean;
	}
}
