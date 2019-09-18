declare namespace UnityEngine
{
	declare namespace Playables
	{
		export class PlayableHandle extends System.ValueType
		{
			static public get Null(): UnityEngine.Playables.PlayableHandle;
			public Equals(p: any): number;
			public Equals(other: UnityEngine.Playables.PlayableHandle): number;
			public GetHashCode(): number;
		}
	}
}
