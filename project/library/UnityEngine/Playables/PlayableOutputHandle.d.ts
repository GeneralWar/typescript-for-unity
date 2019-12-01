declare namespace UnityEngine
{
	declare namespace Playables
	{
		export class PlayableOutputHandle extends System.ValueType
		{
			static public get Null(): UnityEngine.Playables.PlayableOutputHandle;
			public Equals(p: any): boolean;
			public Equals(other: UnityEngine.Playables.PlayableOutputHandle): boolean;
			public GetHashCode(): number;
		}
	}
}
