declare namespace UnityEngine
{
	export class AsyncOperation extends UnityEngine.YieldInstruction
	{
		public constructor();
		public get isDone(): number;
		public get progress(): number;
		public get priority(): number;
		public set priority(): number;
		public get allowSceneActivation(): number;
		public set allowSceneActivation(): number;
	}
}
