declare namespace UnityEngine
{
	export class WaitForSecondsRealtime extends UnityEngine.CustomYieldInstruction
	{
		public constructor(time: number);
		public get waitTime(): number;
		public set waitTime(): number;
		public get keepWaiting(): number;
	}
}
