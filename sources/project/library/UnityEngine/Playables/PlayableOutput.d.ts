declare namespace UnityEngine
{
	declare namespace Playables
	{
		export class PlayableOutput extends System.ValueType
		{
			static public get Null(): UnityEngine.Playables.PlayableOutput;
			public Equals(other: UnityEngine.Playables.PlayableOutput): boolean;
			public GetHandle(): UnityEngine.Playables.PlayableOutputHandle;
			public GetPlayableOutputType(): System.Type;
		}
	}
}
