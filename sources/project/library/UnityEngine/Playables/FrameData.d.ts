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
			public get seekOccurred(): boolean;
			public get timeLooped(): boolean;
			public get timeHeld(): boolean;
			public get output(): UnityEngine.Playables.PlayableOutput;
			public get effectivePlayState(): UnityEngine.Playables.PlayState;
		}
	}
}
