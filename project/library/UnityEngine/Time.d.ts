declare namespace UnityEngine
{
	export class Time
	{
		public constructor();
		static public get time(): number;
		static public get realtimeSinceStartup(): number;
		static public get renderedFrameCount(): number;
		static public get frameCount(): number;
		static public get timeScale(): number;
		static public set timeScale(): number;
		static public get maximumParticleDeltaTime(): number;
		static public set maximumParticleDeltaTime(): number;
		static public get smoothDeltaTime(): number;
		static public get maximumDeltaTime(): number;
		static public set maximumDeltaTime(): number;
		static public get fixedDeltaTime(): number;
		static public set fixedDeltaTime(): number;
		static public get fixedUnscaledDeltaTime(): number;
		static public get unscaledDeltaTime(): number;
		static public get fixedUnscaledTime(): number;
		static public get unscaledTime(): number;
		static public get fixedTime(): number;
		static public get deltaTime(): number;
		static public get timeSinceLevelLoad(): number;
		static public get captureFramerate(): number;
		static public set captureFramerate(): number;
		static public get inFixedTimeStep(): number;
	}
}
