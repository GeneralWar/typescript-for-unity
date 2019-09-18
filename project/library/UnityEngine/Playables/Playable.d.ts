declare namespace UnityEngine
{
	declare namespace Playables
	{
		export namespace Playable
		{
			export function Create(graph: UnityEngine.Playables.PlayableGraph, inputCount: number): UnityEngine.Playables.Playable;
		}
		export class Playable extends System.ValueType
		{
			static public get Null(): UnityEngine.Playables.Playable;
			public Equals(other: UnityEngine.Playables.Playable): number;
			public GetHandle(): UnityEngine.Playables.PlayableHandle;
			public GetPlayableType(): System.Type;
		}
	}
}
