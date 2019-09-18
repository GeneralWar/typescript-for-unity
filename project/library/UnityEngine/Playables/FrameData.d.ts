declare namespace UnityEngine
{
	declare namespace Playables
	{
		export class FrameData extends System.ValueType
		{
			public get frameId(): number;
			public get deltaTime(): number;
			public get weight(): number;
			public get effectiveWeight(): number;
			public get effectiveParentDelay(): number;
			public get effectiveParentSpeed(): number;
			public get effectiveSpeed(): number;
			public get seekOccurred(): number;
			public get timeLooped(): number;
			public get timeHeld(): number;
			public get output(): UnityEngine.Playables.PlayableOutput;
			public get effectivePlayState(): UnityEngine.Playables.PlayState;
		}
	}
}
