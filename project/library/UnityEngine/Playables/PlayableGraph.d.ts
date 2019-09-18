declare namespace UnityEngine
{
	declare namespace Playables
	{
		export namespace PlayableGraph
		{
			export function Create(): UnityEngine.Playables.PlayableGraph;
			export function Create(name: string): UnityEngine.Playables.PlayableGraph;
		}
		export class PlayableGraph extends System.ValueType
		{
			public Destroy(): void;
			public Evaluate(): void;
			public Evaluate(deltaTime: number): void;
			public GetOutput(index: number): UnityEngine.Playables.PlayableOutput;
			public GetOutputCount(): number;
			public GetPlayableCount(): number;
			public GetResolver(): any;
			public GetRootPlayable(index: number): UnityEngine.Playables.Playable;
			public GetRootPlayableCount(): number;
			public GetTimeUpdateMode(): UnityEngine.Playables.DirectorUpdateMode;
			public IsDone(): number;
			public IsPlaying(): number;
			public IsValid(): number;
			public Play(): void;
			public SetResolver(value: any): void;
			public SetTimeUpdateMode(value: UnityEngine.Playables.DirectorUpdateMode): void;
			public Stop(): void;
		}
	}
}
