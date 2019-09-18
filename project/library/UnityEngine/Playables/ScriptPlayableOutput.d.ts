declare namespace UnityEngine
{
	declare namespace Playables
	{
		export namespace ScriptPlayableOutput
		{
			export function Create(graph: UnityEngine.Playables.PlayableGraph, name: string): UnityEngine.Playables.ScriptPlayableOutput;
		}
		export class ScriptPlayableOutput extends System.ValueType
		{
			static public get Null(): UnityEngine.Playables.ScriptPlayableOutput;
			public GetHandle(): UnityEngine.Playables.PlayableOutputHandle;
		}
	}
}
